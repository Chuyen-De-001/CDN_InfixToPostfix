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
    public partial class Runtim : Form
    {
        Functions functions = new Functions();
        IOFile IOFile = new IOFile();
        public Runtim()
        {
            InitializeComponent();
        }

        private void Runtim_Load(object sender, EventArgs e)
        {
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Stopwatch sp = new Stopwatch();
            if (txtDathuc.Text.Length  < 2)
            {
                MessageBox.Show("Chưa nhập đa thức.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<double> lstTime = new List<double>();
                String result = "";
                int n = 50;
                for (int i = 0; i < n; i++)
                {
                    sp.Restart();
                    sp.Start();
                    result = new Entity.Array().InfixToPostfix(txtDathuc.Text);
                    sp.Stop();
                    double timeInSecondsPerN = sp.ElapsedMilliseconds;
                    lstTime.Add(timeInSecondsPerN / 1000);
                }
                double tong = 0;
                for (int i = 0; i < n; i++)
                {
                    textRuntime1.Text += "Lần " + i + ": " + lstTime[i] + "s" + Environment.NewLine;
                    tong += lstTime[i];
                }
                textRuntime1.Text += "Trung bình thời gian là: " + (tong / 50);


                List<double> lstTime1 = new List<double>();
                double tong1 = 0;
                String result1 = "";
                for (int i = 0; i < n; i++)
                {

                    sp.Restart();
                    sp.Start();
                    result1 = new Entity.stack().InfixToPostfix(txtDathuc.Text);
                    sp.Stop();
                    double timeInSecondsPerN = sp.ElapsedMilliseconds;
                    Debug.WriteLine(i);
                    lstTime1.Add(timeInSecondsPerN / 1000);
                }
                for (int i = 0; i < n; i++)
                {
                    textRuntime2.Text += "Lần " + i + ": " + lstTime1[i] + "s" + Environment.NewLine;
                    tong1 += lstTime1[i];
                }
                textRuntime2.Text += "Trung bình thời gian là: " + (tong1 / 50);
            }
        }

        private void btnRadom_Click(object sender, EventArgs e)
        {
            string setting = IOFile.docFileSetting();
            string[] lstsetting = setting.Split('-');
            String Dathuc = functions.taoDathuc(int.Parse(lstsetting[0]), int.Parse(lstsetting[1]), int.Parse(lstsetting[2]));
            Debug.WriteLine(Dathuc);
            txtDathuc.Text = Dathuc;
        }
    }
}
