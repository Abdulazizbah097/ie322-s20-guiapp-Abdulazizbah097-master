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
    public partial class FormMain : Form
    {

        int f = 0;
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPW_TextChanged(object sender, EventArgs e)
        {

        }


        private void Btnlogin_Click(object sender, EventArgs e) {



            while (f < 3) {

             
                    if (Txtuser.Text == "abdulaziz" && TxtPW.Text == "123456")
                    {

                        MessageBox.Show("login Succsessful");
                        break;
                    }
                    else if (Txtuser.Text != "abdulaziz")

                    {

                        MessageBox.Show("Incorrect Username");
                        f++;
                        return;

                    }
                    else if (TxtPW.Text != "123456")
                    {
                   
                    MessageBox.Show("Incorrect Password");
                        f++;
                        return;
                    

                }



            }
            if (f == 3)
                MessageBox.Show("3 failre tries");
            f++;
        }
        
        
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCheck check = new FrmCheck();
            check.ShowDialog();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmCombo combo = new frmCombo();
            combo.ShowDialog() ;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom random = new frmRandom();
            random.ShowDialog();
        }

        private void BtnRandomCompo_Click(object sender, EventArgs e)
        {
            frmRandomCombo fr = new frmRandomCombo();
            fr.ShowDialog();
        }

        private void BtnPB1_Click(object sender, EventArgs e)
        {
            frmpic01 pic = new frmpic01();
            pic.ShowDialog();

        }

        

        private void BtnTalk_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            frmArray array = new frmArray();
            array.ShowDialog();
        }
    }
}
