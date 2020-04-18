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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBY.Checked == true)
                RBY.ForeColor = Color.FromName("yellow");
            else RBY.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void frmRadio_Load(object sender, EventArgs e)
        {

        }

        private void RBRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RBRed.Checked == true)
                RBRed.ForeColor = Color.FromArgb(255, 0, 0);
            else
                RBRed.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void RBGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RBGreen.Checked == true)
                RBGreen.ForeColor = Color.FromArgb(0, 255, 0);
            else
                RBGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RBBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RBBlue.Checked == true)
                RBBlue.ForeColor = Color.FromName("blue");
            else
                RBBlue.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void RBYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RBYellow.Checked == true)
                RBYellow.ForeColor = Color.FromName("yellow");
            else
                RBYellow.ForeColor = Color.FromArgb(0, 0, 0);

            {

            }
        }

        private void RBR_CheckedChanged(object sender, EventArgs e)
        {
            if (RBR.Checked == true)
                RBR.ForeColor = Color.FromName("red");
            else RBR.ForeColor = Color.FromArgb(0,0,0);
        }

        private void RBG_CheckedChanged(object sender, EventArgs e)
        {
            if (RBG.Checked == true)
                RBG.ForeColor = Color.FromName("green");
            else RBG.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RBB_CheckedChanged(object sender, EventArgs e)
        {
            if (RBB.Checked == true)
                RBB.ForeColor = Color.FromName("blue");
            else RBB.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RBB.ForeColor = Color.FromArgb(0, 0, 0);
            RBG.ForeColor = Color.FromArgb(0, 0, 0);
            RBR.ForeColor = Color.FromArgb(0, 0, 0);
            RBY.ForeColor = Color.FromArgb(0, 0, 0);
            RBYellow.ForeColor = Color.FromArgb(0, 0, 0);
            RBRed.ForeColor = Color.FromArgb(0, 0, 0);
            RBBlue.ForeColor = Color.FromArgb(0, 0, 0);
            RBGreen.ForeColor = Color.FromArgb(0, 0, 0);

        }
    }
}
