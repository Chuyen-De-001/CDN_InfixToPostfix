using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDN
{
    public partial class Form1 : Form
    {
        Functions functions = new Functions();
        IOFile IOFile = new IOFile();
        public Form1()
        {
            InitializeComponent();
        }

        private void radomPolymialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void btnRadomPolymial_Click(object sender, EventArgs e)
        {
            string setting = IOFile.docFileSetting();
            string[] lstsetting = setting.Split('-');
            Debug.WriteLine(lstsetting[0] + "-" + lstsetting[1] + "-" + lstsetting[2]);
            String Dathuc = functions.taoDathuc(int.Parse(lstsetting[0]), int.Parse(lstsetting[1]), int.Parse(lstsetting[2]));
            txtPolynomial.Text = Dathuc;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(txtPolynomial.Text == "")
            {
                MessageBox.Show("Chưa nhập đa thức", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtResult.Text = new Entity.Array().InfixToPostfix(txtPolynomial.Text);
            }
        }
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đoThờiGianChạyHàmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Runtim runtim = new Runtim();
            runtim.Show();
        }
    }
}
