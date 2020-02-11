using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

using System.Data.SqlClient;

namespace yazlab
{
    public partial class kitapsil : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=login1;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public kitapsil()
        {
            InitializeComponent();
        }

        Bitmap Resim(string Url)
        {
            WebRequest rs = WebRequest.Create(Url);
            return (Bitmap)Bitmap.FromStream(rs.GetResponse().GetResponseStream());
        }

        private void kitapsil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'login1DataSet3.ktp' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ktpTableAdapter1.Fill(this.login1DataSet3.ktp);
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ısbn.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            kadi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            kyazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kyil.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            kyayin.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            kres.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Resim(kres.Text);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("delete from ktp where ISBN='" + ısbn.Text + "' and k_ad='" + kadi.Text + "' and Book_Author='" + kyazar.Text + "'and Year_Of_Publication='" + kyil.Text + "'and Publisher='" + kyayin.Text + "'", cn);
            cmd.ExecuteReader();
            cn.Close();
           


            MessageBox.Show("Silme işlemi tamamlandı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from ktp where ISBN like '%" + ısbn.Text + "%' and k_ad like '%" + kadi.Text + "%' and Book_Author like  '%" + kyazar.Text + "%' and Year_Of_Publication like '%" + kyil.Text + "%'  and Publisher like '%" + kyayin.Text + "%'  ", cn);
            adapter.SelectCommand = cmd;
            ds.Clear();
            adapter.Fill(ds);

            cn.Close();

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ykitap p = new ykitap();
            p.Show();
            this.Hide();
        }
    }
}
