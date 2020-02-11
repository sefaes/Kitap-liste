using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlab
{
    public partial class men : Form
    {
        public men()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oylama  t = new oylama();
            t.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iyi10 a = new iyi10();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grs d = new grs();
            d.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ensonkitap ensonkitap =new ensonkitap();
            ensonkitap.Show();
            this.Hide();
        }
    }
}
