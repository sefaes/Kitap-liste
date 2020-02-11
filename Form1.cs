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
    public partial class Form1 : Form
    {

        public static string f;

        public Form1()
        {
            InitializeComponent();
        }

        private void grs_Click(object sender, EventArgs e)
        {

            
            
             SqlConnection cn = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=login1;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from user1 where username='" + kad.Text + "' and password='" + sfr.Text + "' ",cn);
            SqlDataReader dr;
            dr=cmd.ExecuteReader();
            int count = 0;

            while (dr.Read())
            {

                count += 1;


            }
            if (count == 1)
            {
                if (kad.Text.Equals("sefa") && sfr.Text.Equals("1996"))
                {
                    ypanel p = new ypanel();
                    p.Show();
                    this.Hide();



                }

                else
                {
                    men a = new men();
                    a.Show();
                    this.Hide();
                    f = kad.Text;

                } }

            else if (count > 0){

                MessageBox.Show("yanlış bir giriş yaptınız");

            }

            else
            {
                MessageBox.Show("yanlış bir giriş yaptınız");

            }
            kad.Clear();
            sfr.Clear();
            cn.Close();


          




        }

        private void button1_Click(object sender, EventArgs e)
        {
            uye a = new uye();
            a.Show();
            this.Hide();
        }
    }
}
