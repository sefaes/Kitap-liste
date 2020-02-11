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
    public partial class yenpuan : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=login1;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet d = new DataSet();
        string m = uye.n;
       static int p = 0;
        int u = 0;



        public yenpuan()
        {
            InitializeComponent();
         
            loaddata();
        }
        private void loaddata()
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from ktp ", cn);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
           
            cn.Close();


        }
        private void yenpuan_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'login1DataSet4.ktp' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ktpTableAdapter2.Fill(this.login1DataSet4.ktp);
          
          



        }







        private void ara_Click(object sender, EventArgs e)
        {

            

                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from ktp where ISBN like '%" + serno.Text + "%' and k_ad like '%" + kıadı.Text + "%' and Book_Author like  '%" + kıyz.Text + "%' and Year_Of_Publication like '%" + kıyl.Text + "%'  and Publisher like '%" + kıyyn.Text + "%'  ", cn);
                adapter.SelectCommand = cmd;
            d.Clear();
            adapter.Fill(d);

            cn.Close();

            dataGridView1.DataSource = d.Tables[0];
           

                     
            
           





        }





      

      

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string deger = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into puan(ID,ISBN,puan) values('" + m+ "','" + deger + "','1') ", cn);
            cmd.ExecuteReader();
            cn.Close();
            MessageBox.Show("Puanınız alındı");
            u++;
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string deger = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into puan(ID,ISBN,puan) values('" + m + "','" + deger + "','2') ", cn);
            cmd.ExecuteReader();
            cn.Close();
            MessageBox.Show("Puanınız alındı");
            u++;
           
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string deger = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into puan(ID,ISBN,puan) values('" + m + "','" + deger + "','3') ", cn);
            cmd.ExecuteReader();
            cn.Close();
            MessageBox.Show("Puanınız alındı");
            u++;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string deger = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into puan(ID,ISBN,puan) values('" + m + "','" + deger + "','4') ", cn);
            cmd.ExecuteReader();
            cn.Close();
            MessageBox.Show("Puanınız alındı");
            u++;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string deger = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into puan(ID,ISBN,puan) values('" + m + "','" + deger + "','5') ", cn);
            cmd.ExecuteReader();
            cn.Close();
            MessageBox.Show("Puanınız alındı");
            u++;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string deger = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into puan(ID,ISBN,puan) values('" + m + "','" + deger + "','6') ", cn);
            cmd.ExecuteReader();
            cn.Close();
            MessageBox.Show("Puanınız alındı");
            u++;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string deger = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into puan(ID,ISBN,puan) values('" + m + "','" + deger + "','7') ", cn);
            cmd.ExecuteReader();
            cn.Close();
            MessageBox.Show("Puanınız alındı");
            u++;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string deger = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into puan(ID,ISBN,puan) values('" + m + "','" + deger + "','8') ", cn);
            cmd.ExecuteReader();
            cn.Close();
            MessageBox.Show("Puanınız alındı");
            u++;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string deger = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into puan(ID,ISBN,puan) values('" + m + "','" + deger + "','9') ", cn);
            cmd.ExecuteReader();
            cn.Close();
            MessageBox.Show("Puanınız alındı");
            u++;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string deger = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into puan(ID,ISBN,puan) values('" + m + "','" + deger + "','10') ", cn);
            cmd.ExecuteReader();
            cn.Close();
            MessageBox.Show("Puanınız alındı");
            u++;
        }

        private void gec_Click(object sender, EventArgs e)
        {
            if (u >= 10)
            {
                grs d = new grs();
                d.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("10 tane kitap oylamalısınız,oyaldığınız kitap sayısı = '"+u+"'");

            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
