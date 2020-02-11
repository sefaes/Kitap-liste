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
    public partial class iyi10 : Form
    {


        SqlConnection cn = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=login1;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet s = new DataSet();
        public iyi10()
        {
            InitializeComponent();
        }

        private void iyi10_Load(object sender, EventArgs e)
        {

            cn.Open();
           
            
           
                SqlCommand cmd = new SqlCommand("SELECT top 10 ISBN,SUM(puan) as 'puanlar' FROM puan group by ISBN order by puanlar desc ", cn);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];




            cn.Close();


            cn.Open();



            SqlCommand cmd2 = new SqlCommand("SELECT top 10 ISBN,COUNT(ISBN) as 'oylama' FROM puan group by ISBN order by oylama desc ", cn);
            adapter.SelectCommand = cmd2;
            adapter.Fill(s);
            dataGridView2.DataSource = s.Tables[0];




            cn.Close();







        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            men g = new men();
            g.Show();
            this.Hide();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string a;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ısbn.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            a= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cn.Open();
            SqlCommand com = new SqlCommand("Select * from ktp where ISBN='"+a+"'", cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                kadi.Text = dr["k_ad"].ToString();
                kyazar.Text = dr["Book_Author"].ToString();
                kyil.Text = dr["Year_Of_Publication"].ToString();
                kyayin.Text = dr["Publisher"].ToString();
               
            }
            dr.Close();
            cn.Close();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string a;
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            ısbn.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            a = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            cn.Open();
            SqlCommand com = new SqlCommand("Select * from ktp where ISBN='" + a + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                kadi.Text = dr["k_ad"].ToString();
                kyazar.Text = dr["Book_Author"].ToString();
                kyil.Text = dr["Year_Of_Publication"].ToString();
                kyayin.Text = dr["Publisher"].ToString();

            }
            dr.Close();
            cn.Close();
        }
    }




    

           
        
    
}
