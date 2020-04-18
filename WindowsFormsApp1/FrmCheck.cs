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
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (CBCofee.Checked == true)
                msg = CBCofee.Text;


            if (CBDonut.Checked == true)
                msg = msg +" "+"and"+" "+ CBDonut.Text;
      
            if (CBBrowni.Checked == true)
               

                msg = msg +" "+"and"+" "+ CBBrowni.Text;
            if (msg.Length > 0)

                MessageBox.Show(msg + " " + "selected");
            else
                MessageBox.Show("no selection");
                    }

        private void FrmCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
