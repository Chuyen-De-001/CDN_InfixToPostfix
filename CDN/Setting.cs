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
    public partial class Setting : Form
    {
        IOFile IOFile = new IOFile();
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            IOFile.docFileSetting();
            String setting = IOFile.docFileSetting();
            String[] lstSetting = setting.Split('-');
            txtMaxoperand.Text = lstSetting[0].ToString();
            txtMaxbracket.Text = lstSetting[1].ToString();
            txtMaxexponential.Text = lstSetting[2].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String setting = txtMaxoperand.Text +"-"+ txtMaxbracket.Text +"-"+ txtMaxexponential.Text;
            if (IOFile.ghiFileSetting(setting))
            {
                MessageBox.Show("Save Success","Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
