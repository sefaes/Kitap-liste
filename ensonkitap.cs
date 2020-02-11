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
    public partial class ensonkitap : Form
    {


        SqlConnection cn = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=login1;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();


        public ensonkitap()
        {
            InitializeComponent();
        }
        Bitmap Resim(string Url)
        {
            WebRequest rs = WebRequest.Create(Url);
            return (Bitmap)Bitmap.FromStream(rs.GetResponse().GetResponseStream());
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

        private void ensonkitap_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select top 5 * from ktp order by id desc  ", cn);
            adapter.SelectCommand = cmd;
            ds.Clear();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            men men1 = new men();
            men1.Show();
            this.Hide();
        }
    }
}
