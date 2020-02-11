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
    public partial class oku : Form
    {
        
       
       
       
        public oku()
        {
            InitializeComponent();
        }

        private void oku_Load(object sender, EventArgs e)
        {

            

            axAcroPDF1.LoadFile(grs.h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grs grs1 = new grs();
            grs1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
