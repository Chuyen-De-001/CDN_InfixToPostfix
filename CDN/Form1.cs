using CDN;
using CDN.Properties;
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
        bool _isInProcess = false;
        Control _preCtl, _nextCtl;
        Entity.stack stack = new Entity.stack();
        ExprHelper exprHelper = new ExprHelper();
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
            String Dathuc = functions.taoDathuc(int.Parse(textBox_Sl.Text), int.Parse(lstsetting[1]), int.Parse(lstsetting[2]));
            Debug.WriteLine(Dathuc);
            txtPolynomial.Text = Dathuc;
        }


        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đoThờiGianChạyHàmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Runtim runtim = new Runtim();
            runtim.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rab_array.Checked = true;
        }

        private void btnRun_Click_1(object sender, EventArgs e)
        {

            if (!_isInProcess)
            {
                btnReset_Click(sender, e);
                string infix = exprHelper.FormatExpression(txtPolynomial.Text);
                string[] tokens = infix.Split(' ');
                for (int i = 0; i < tokens.Count() - 1; i++)
                {

                    Label lab = new Label();
                    lab.TextAlign = ContentAlignment.MiddleCenter;
                    lab.Text = tokens[i];
                    lab.BackgroundImageLayout = ImageLayout.Stretch;
                    lab.BackgroundImage = Properties.Resources.NormalCircle;
                    lab.Width = 30;
                    lab.Height = 30;

                    flpInfix.Controls.Add(lab);
                }
                timer1.Interval = (int)numericUpDown1.Value;
                btnRun.Text = "Dừng";
            }
            else
            {
                if (_isInProcess)
                {
                    if (btnRun.Text != "Tiếp tục")
                    {
                        btnRun.Text = "Tiếp tục";
                    }
                    else
                    {
                        btnRun.Text = "Dừng";
                    }
                }
            }
            _isInProcess = true;
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StepForward();
        }
        public void StepForward()
        {
            if(flpInfix.Controls.Count > 0)
            {
                Control ctl = flpInfix.Controls[0];
                ctl.BackgroundImage = Properties.Resources.highlightCircle;
                flpInfix.Controls.Remove(ctl);
                ProcessInfixPostfix(ctl);
            }else if(flpInfix.Controls.Count == 0 && flpStack.Controls.Count > 0)
            {
                if (PeekStack().Text != "(")
                {
                    Output(PopStack());
                }
            }else if(flpInfix.Controls.Count == 0 && flpStack.Controls.Count == 0)
            {
                _isInProcess = false;
                timer1.Enabled = false;
                btnRun.Text = "Thực thi";
            }
        }

        public void ProcessInfixPostfix(Control ctl)
        {
            if (exprHelper.IsHangTu(ctl.Text))
            {
                Output(ctl);
            }else if (exprHelper.IsToanTu(ctl.Text))
            {
                if (flpStack.Controls.Count == 0)
                {
                    PushStack(ctl);
                }
                else
                {
                    if (stack.getdoUutien(char.Parse(PeekStack().Text)) < stack.getdoUutien(char.Parse(ctl.Text)) || char.Parse(PeekStack().Text) == '(')
                    {
                        PushStack(ctl);
                    }
                    else
                    {
                    while (stack.getdoUutien(char.Parse(PeekStack().Text)) >= stack.getdoUutien(char.Parse(ctl.Text)))
                    {
                        if (flpStack.Controls.Count == 1)
                        {
                            Output(PopStack());
                            PushStack(ctl);
                            break;
                        }
                        else
                        {
                            Output(PopStack());
                            if (stack.getdoUutien(char.Parse(PeekStack().Text)) < stack.getdoUutien(char.Parse(ctl.Text)))
                            {
                                PushStack(ctl);
                                break;
                            }
                        }

                    }
                    }

                }
            }
            else if (ctl.Text == "(")
            {
                PushStack(ctl);
            }
            else if (ctl.Text == ")")
            {
                while (PeekStack().Text != "(")
                {
                    Output(PopStack());

                }
                PopStack();
            }

        }
        void Output(Control ctl)
        {
            flpOutPut.Controls.Add(ctl);

            if (flpOutPut.Controls.Count > 1)
                flpOutPut.Controls[flpOutPut.Controls.Count - 2].BackgroundImage = Properties.Resources.NormalCircle;
        }
        void PushStack(Control ctl)
        {
            flpStack.Controls.Add(ctl);

            if (flpStack.Controls.Count > 1)
                flpStack.Controls[flpStack.Controls.Count - 2].BackgroundImage = Properties.Resources.NormalCircle;
        }
        Control PeekStack()
        {
            return flpStack.Controls[flpStack.Controls.Count - 1];
        }

        private void btnRun_tab1_Click(object sender, EventArgs e)
        {
            Stopwatch sp = new Stopwatch();
            if (txtPolynomial.Text == "")
            {
                MessageBox.Show("Chưa nhập đa thức", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rab_array.Checked == true)
                {
                    txtResult.Text = new Entity.Array().InfixToPostfix(txtPolynomial.Text);
                }
                else if (raB_stack.Checked == true)
                {
                    sp.Start();
                   
                    txtResult.Text = new Entity.stack().InfixToPostfix(txtPolynomial.Text);
                    sp.Stop();
                    double timeInSecondsPerN = sp.ElapsedMilliseconds;
                    txttime.Text = (timeInSecondsPerN/1000).ToString();


                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            flpInfix.Controls.Clear();
            flpOutPut.Controls.Clear();
            flpStack.Controls.Clear();
            _isInProcess = false;
            timer1.Enabled = false;
            btnRun.Text = "Thực thi";


        }

        private void btnStepbyStep_tab1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                btnRun_Click_1(sender, e);
                btnRun.Text = "Tiếp tục";
                /*timer1.Stop();*/
                timer1.Enabled = false;
                StepForward();
            }
        }

        Control PopStack()
        {
            Control ctl = flpStack.Controls[flpStack.Controls.Count - 1];
            flpStack.Controls.Remove(ctl);

            return ctl;
        }
    }
}
