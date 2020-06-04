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
            String option = "";
            try
            {
                option = comboBox1.SelectedItem.ToString();
            }
            catch
            {
                option = "";
            }
            if(option == "")
            {
                MessageBox.Show("error");
            }
            else
            {
                if(option == "Array")
                {
                    List<double> lstTime = new List<double>();
                    String result1 = "";
                    int n = 50;
                    for (int i = 0; i < n; i++)
                    {
                        Stopwatch sp = new Stopwatch();
                        sp.Start();
                        result1 = new Entity.Array().InfixToPostfix(txtDathuc.Text);
                        sp.Stop();
                        double timeInSecondsPerN = sp.ElapsedMilliseconds;
                        lstTime.Add(timeInSecondsPerN / 1000); 
                    }
                    for(int i = 1; i <= n; i++)
                    {
                        textRuntime1.Text += "Lần " + i + ": " + lstTime[i-1] + "s"+Environment.NewLine;
                    }
                    
                }
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
