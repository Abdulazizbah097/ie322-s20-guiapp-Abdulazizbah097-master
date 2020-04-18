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
    public partial class frmRandomCombo : Form
    {
        
        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void frmRandomCombo_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            comboNumbers.ResetText();
            comboNumbers.Items.Clear();
            Random r = new Random();

            for (int i = 0; i<r.Next(1,51); i++)
            {

                comboNumbers.Items.Add(r.Next(100,999));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboNumbers.ResetText();
            comboNumbers.Items.Clear();
            radioless500.Checked = false;
            radioGreater500.Checked = false;

        }

        private void comboNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboNumbers.Text) > 499)
            {
                radioGreater500.Checked = true;
            }
            else
            {
                radioless500.Checked = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ComboNumber2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ComboNumber2.Text) > 49)
            {
                radioGreater50.Checked = true;
            }
            else
            {
                radioless50.Checked = true;
            }
        }

        private void btnGenerate2_Click(object sender, EventArgs e)
        {
            ComboNumber2.ResetText();
            ComboNumber2.Items.Clear();
            Random r = new Random();

            for (int i = 0; i < r.Next(2,9)-1; i++)
            {

               ComboNumber2.Items.Add(r.Next(10, 99));
            }
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            ComboNumber2.ResetText();
            ComboNumber2.Items.Clear();
            radioless50.Checked = false;
            radioGreater50.Checked = false;

        }
    }
}
