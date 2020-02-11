using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazlab
{
    public partial class ykulla : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=login1;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet d = new DataSet();

        public ykulla()
        {
            InitializeComponent();
        }

        private void ykulla_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'login1DataSet22.user1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.user1TableAdapter.Fill(this.login1DataSet22.user1);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string a;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            kus.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ksf.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            a= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cn.Open();
            SqlCommand com = new SqlCommand("Select * from kay where id='" + a + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                klok.Text = dr["Location"].ToString();
                kyas.Text = dr["Age"].ToString();


            }
            dr.Close();
            cn.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from user1 where username like '%" + skad.Text + "%' and password like '%" + sksf.Text + "%' ", cn);
            adapter.SelectCommand = cmd;
            d.Clear();
            adapter.Fill(d);

            cn.Close();

            dataGridView1.DataSource = d.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("delete from user1 where username='"+kus.Text+"' and password='"+ksf.Text+"' ", cn);
            cmd.ExecuteReader();
            cn.Close();
            cn.Open();

            SqlCommand cmd1 = new SqlCommand("delete from kay where Location='" + klok.Text + "' and Age='" + kyas.Text + "' ", cn);
            cmd1.ExecuteReader();

            cn.Close();


            MessageBox.Show("Silme işlemi tamamlandı");

        }
    }
}
