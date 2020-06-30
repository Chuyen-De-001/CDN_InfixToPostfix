namespace CDN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPolynomial = new System.Windows.Forms.TextBox();
            this.btnRadomPolymial = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radomPolymialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đoThờiGianChạyHàmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rab_array = new System.Windows.Forms.RadioButton();
            this.raB_stack = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRun_tab1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStepbyStep_tab1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flpStack = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flpOutPut = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flpInfix = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_Sl = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Infix Expression:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPolynomial
            // 
            this.txtPolynomial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPolynomial.Location = new System.Drawing.Point(127, 49);
            this.txtPolynomial.Multiline = true;
            this.txtPolynomial.Name = "txtPolynomial";
            this.txtPolynomial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPolynomial.Size = new System.Drawing.Size(566, 64);
            this.txtPolynomial.TabIndex = 1;
            // 
            // btnRadomPolymial
            // 
            this.btnRadomPolymial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRadomPolymial.Location = new System.Drawing.Point(699, 49);
            this.btnRadomPolymial.Name = "btnRadomPolymial";
            this.btnRadomPolymial.Size = new System.Drawing.Size(89, 64);
            this.btnRadomPolymial.TabIndex = 2;
            this.btnRadomPolymial.Text = "Radom";
            this.btnRadomPolymial.UseVisualStyleBackColor = true;
            this.btnRadomPolymial.Click += new System.EventHandler(this.btnRadomPolymial_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.đoThờiGianChạyHàmToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radomPolymialToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // radomPolymialToolStripMenuItem
            // 
            this.radomPolymialToolStripMenuItem.Name = "radomPolymialToolStripMenuItem";
            this.radomPolymialToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.radomPolymialToolStripMenuItem.Text = "Radom Đa thức";
            this.radomPolymialToolStripMenuItem.Click += new System.EventHandler(this.radomPolymialToolStripMenuItem_Click);
            // 
            // đoThờiGianChạyHàmToolStripMenuItem1
            // 
            this.đoThờiGianChạyHàmToolStripMenuItem1.Name = "đoThờiGianChạyHàmToolStripMenuItem1";
            this.đoThờiGianChạyHàmToolStripMenuItem1.Size = new System.Drawing.Size(173, 24);
            this.đoThờiGianChạyHàmToolStripMenuItem1.Text = "Đo thời gian chạy hàm";
            this.đoThờiGianChạyHàmToolStripMenuItem1.Click += new System.EventHandler(this.đoThờiGianChạyHàmToolStripMenuItem1_Click);
            // 
            // rab_array
            // 
            this.rab_array.AutoSize = true;
            this.rab_array.Location = new System.Drawing.Point(12, 31);
            this.rab_array.Name = "rab_array";
            this.rab_array.Size = new System.Drawing.Size(63, 21);
            this.rab_array.TabIndex = 12;
            this.rab_array.TabStop = true;
            this.rab_array.Text = "Array";
            this.rab_array.UseVisualStyleBackColor = true;
            this.rab_array.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // raB_stack
            // 
            this.raB_stack.AutoSize = true;
            this.raB_stack.Location = new System.Drawing.Point(91, 31);
            this.raB_stack.Name = "raB_stack";
            this.raB_stack.Size = new System.Drawing.Size(64, 21);
            this.raB_stack.TabIndex = 13;
            this.raB_stack.TabStop = true;
            this.raB_stack.Text = "Stack";
            this.raB_stack.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 534);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txttime);
            this.tabPage1.Controls.Add(this.btnRun_tab1);
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Controls.Add(this.raB_stack);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rab_array);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(765, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kết quả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRun_tab1
            // 
            this.btnRun_tab1.Location = new System.Drawing.Point(177, 21);
            this.btnRun_tab1.Name = "btnRun_tab1";
            this.btnRun_tab1.Size = new System.Drawing.Size(95, 40);
            this.btnRun_tab1.TabIndex = 14;
            this.btnRun_tab1.Text = "Thực thi";
            this.btnRun_tab1.UseVisualStyleBackColor = true;
            this.btnRun_tab1.Click += new System.EventHandler(this.btnRun_tab1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(80, 93);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(682, 341);
            this.txtResult.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kết quả: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStepbyStep_tab1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.flpStack);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.flpOutPut);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.btnRun);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.flpInfix);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Biểu diễn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStepbyStep_tab1
            // 
            this.btnStepbyStep_tab1.Location = new System.Drawing.Point(407, 6);
            this.btnStepbyStep_tab1.Name = "btnStepbyStep_tab1";
            this.btnStepbyStep_tab1.Size = new System.Drawing.Size(106, 43);
            this.btnStepbyStep_tab1.TabIndex = 17;
            this.btnStepbyStep_tab1.Text = "Từng bước";
            this.btnStepbyStep_tab1.UseVisualStyleBackColor = true;
            this.btnStepbyStep_tab1.Click += new System.EventHandler(this.btnStepbyStep_tab1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Stack";
            // 
            // flpStack
            // 
            this.flpStack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpStack.Location = new System.Drawing.Point(3, 172);
            this.flpStack.Name = "flpStack";
            this.flpStack.Size = new System.Drawing.Size(755, 44);
            this.flpStack.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Output";
            // 
            // flpOutPut
            // 
            this.flpOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpOutPut.Location = new System.Drawing.Point(6, 242);
            this.flpOutPut.Name = "flpOutPut";
            this.flpOutPut.Size = new System.Drawing.Size(755, 44);
            this.flpOutPut.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Delay (ms):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(638, 17);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(273, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 43);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Làm lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(145, 6);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(106, 43);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Thực thi";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Infix";
            // 
            // flpInfix
            // 
            this.flpInfix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpInfix.Location = new System.Drawing.Point(4, 90);
            this.flpInfix.Name = "flpInfix";
            this.flpInfix.Size = new System.Drawing.Size(755, 44);
            this.flpInfix.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_Sl
            // 
            this.textBox_Sl.Location = new System.Drawing.Point(15, 90);
            this.textBox_Sl.Name = "textBox_Sl";
            this.textBox_Sl.Size = new System.Drawing.Size(100, 22);
            this.textBox_Sl.TabIndex = 15;
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(82, 440);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(501, 22);
            this.txttime.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Thời gian";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.textBox_Sl);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnRadomPolymial);
            this.Controls.Add(this.txtPolynomial);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "InfixToPostfix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPolynomial;
        private System.Windows.Forms.Button btnRadomPolymial;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radomPolymialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đoThờiGianChạyHàmToolStripMenuItem1;
        private System.Windows.Forms.RadioButton rab_array;
        private System.Windows.Forms.RadioButton raB_stack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpInfix;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flpOutPut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flpStack;
        private System.Windows.Forms.Button btnRun_tab1;
        private System.Windows.Forms.Button btnStepbyStep_tab1;
        private System.Windows.Forms.TextBox textBox_Sl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttime;
    }
}

