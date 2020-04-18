using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322ABahaidrah
{
    public partial class frmRandom : Form
    {
        Random r = new Random();
        public frmRandom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int red = r.Next(0, 255);
            int green = r.Next(0, 255);
            int blue = r.Next(0, 255);
           labelRan.Text = Convert.ToString(red) + "-" + Convert.ToString(green) + "-" + Convert.ToString(blue);
            btnGRC.BackColor = Color.FromArgb(red, green, blue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnRN.Text = Convert.ToString(r.Next(1, 100));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmRandom_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
