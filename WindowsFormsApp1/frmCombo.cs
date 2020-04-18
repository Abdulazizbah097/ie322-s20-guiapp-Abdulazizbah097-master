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
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
            CmbDays.Items.Add("Sunday"); 
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");
        }

        private void frmCombo_Load(object sender, EventArgs e)
        {

        }

        private void btnSSM1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);

        }

        private void brnSSM2_Click(object sender, EventArgs e)
        {
            var item = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(item);
        }

        private void btnRBN_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
        }

        private void btnRBI_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }

        private void btnRLI_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }else
            {
                MessageBox.Show("can't remove last item");

            }
        }

        private void btnRLSI_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("can't remove this item");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
