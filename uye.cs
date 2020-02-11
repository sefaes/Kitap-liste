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
    public partial class uye : Form
    {

        public static string n;
        
       

        public uye()
        {
            InitializeComponent();
        }

        private void yol_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=login1;Integrated Security=True");
           

            if (kad.Text == "" || sfr.Text == "" || yer.Text == "" || ys.Text == "")
            {

                MessageBox.Show("alanları eksizsiz doldurunuz");
            }
            else
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into user1 values('" + kad.Text + "','" + sfr.Text + "') ", cn);
                cmd.ExecuteReader();
                cn.Close();
                cn.Open();
                SqlCommand cmd1 = new SqlCommand("insert into kay values('" + yer.Text + "','" + ys.Text + "') ", cn);
                cmd1.ExecuteReader();
                cn.Close();
                n = kad.Text;
                yenpuan b = new yenpuan();
                b.Show();
                this.Hide();




            }




        }
    }
}
