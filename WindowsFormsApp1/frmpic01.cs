using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
namespace IE322ABahaidrah
{
    public partial class frmpic01 : Form
    {

        Assembly  _assembly;
        Stream  _imagesStream;
        public frmpic01()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {

            try
            {
                pic01.Image = Image.FromFile("C:\\photo\\mountain.jpg");
            }
            catch (Exception)
            {

                MessageBox.Show("File not found");
            }
        }

       

        private void frmpic01_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imagesStream = _assembly.GetManifestResourceStream("IE322ABahaidrah.res.mountain.jpg");
        }
    }
}
