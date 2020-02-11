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
using System.IO;
namespace yazlab
{
    public partial class ykullakekle : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=login1;Integrated Security=True");
        public ykullakekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string g = ısbn.Text;
            int h = 0;
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("select ISBN from ktp where ISBN='"+g+"'", cn);
            SqlDataReader dr;
            dr = cmd1.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {

                count += 1;


            }

            cn.Close();


            if (count == 1)
            {

                h = 100;
               
            }


            if (h == 0)
            {
                if (kad.Text == "" || ısbn.Text == "" || kyayin.Text == "" || kyazar.Text == "" || kres.Text == "" || kyil.Text == ""||pdf.Text=="")
                {

                    MessageBox.Show("alanları eksizsiz doldurunuz");
                }



                else
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("insert into  ktp (ISBN,k_ad,Book_Author,Year_Of_Publication,Publisher,URL1,pdf) values('" + ısbn.Text + "','" + kad.Text + "','" + kyazar.Text + "','" + kyil.Text + "','" + kyayin.Text + "','" + kres.Text + "','"+pdf.Text+"') ", cn);
                    cmd.ExecuteReader();
                    cn.Close();

                    MessageBox.Show("Ekleme İşlemi Tamamlandı");
                    kad.Text = "";
                    ısbn.Text = "";
                    kyayin.Text = "";
                    kyazar.Text = "";
                    kres.Text = "";
                    kyil.Text = "";
                    pdf.Text = "";

                }


           
            }
            else
            {

                MessageBox.Show("ISBN Aynı Değiştiriniz");


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ykitap r = new ykitap();
            r.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdfac = new OpenFileDialog();
            pdfac.Title = "pdf ac";
           
            if (pdfac.ShowDialog() == DialogResult.OK)
            {
                pdf.Text = pdfac.FileName;

 }
        }
    }
}
