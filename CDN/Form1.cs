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
            String Dathuc = functions.taoDathuc(int.Parse(lstsetting[0]), int.Parse(lstsetting[1]), int.Parse(lstsetting[2]));
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
            string infix = exprHelper.FormatExpression(txtPolynomial.Text);
            string[] tokens = infix.Split(' ');
            if (!_isInProcess)
            {
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
                    btnRun.Text = "Resume";
                else
                    btnRun.Text = "Start";
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
                            //postfix += stack.Pop();
                            Output(PopStack());
                            if (stack.getdoUutien(char.Parse(PeekStack().Text)) >= stack.getdoUutien(char.Parse(ctl.Text)))
                            {
                                PushStack(ctl);
                                break;
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

/*            if (flpOutPut.Controls.Count > 1)
                flpOutPut.Controls[flpOutPut.Controls.Count - 2].BackgroundImage = Properties.Resources.NormalCircle;*/
        }
        void PushStack(Control ctl)
        {
            flpStack.Controls.Add(ctl);
/*
            if (flpStack.Controls.Count > 1)
                flpStack.Controls[flpStack.Controls.Count - 2].BackgroundImage = Properties.Resources.NormalCircle;*/
        }
        Control PeekStack()
        {
            return flpStack.Controls[flpStack.Controls.Count - 1];
        }

        private void btnRun_tab1_Click(object sender, EventArgs e)
        {
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
                    txtResult.Text = new Entity.stack().InfixToPostfix(txtPolynomial.Text);
                }
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
