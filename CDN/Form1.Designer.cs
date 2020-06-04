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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPolynomial = new System.Windows.Forms.TextBox();
            this.btnRadomPolymial = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radomPolymialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đoThờiGianChạyHàmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rab_array = new System.Windows.Forms.RadioButton();
            this.raB_stack = new System.Windows.Forms.RadioButton();
            this.menuStrip2.SuspendLayout();
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
            this.txtPolynomial.Name = "txtPolynomial";
            this.txtPolynomial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPolynomial.Size = new System.Drawing.Size(523, 22);
            this.txtPolynomial.TabIndex = 1;
            // 
            // btnRadomPolymial
            // 
            this.btnRadomPolymial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRadomPolymial.Location = new System.Drawing.Point(656, 49);
            this.btnRadomPolymial.Name = "btnRadomPolymial";
            this.btnRadomPolymial.Size = new System.Drawing.Size(125, 22);
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
            this.menuStrip2.Size = new System.Drawing.Size(800, 30);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radomPolymialToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // radomPolymialToolStripMenuItem
            // 
            this.radomPolymialToolStripMenuItem.Name = "radomPolymialToolStripMenuItem";
            this.radomPolymialToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.radomPolymialToolStripMenuItem.Text = "Radom Đa thức";
            this.radomPolymialToolStripMenuItem.Click += new System.EventHandler(this.radomPolymialToolStripMenuItem_Click);
            // 
            // đoThờiGianChạyHàmToolStripMenuItem1
            // 
            this.đoThờiGianChạyHàmToolStripMenuItem1.Name = "đoThờiGianChạyHàmToolStripMenuItem1";
            this.đoThờiGianChạyHàmToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.đoThờiGianChạyHàmToolStripMenuItem1.Text = "Đo thời gian chạy hàm";
            this.đoThờiGianChạyHàmToolStripMenuItem1.Click += new System.EventHandler(this.đoThờiGianChạyHàmToolStripMenuItem1_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(195, 119);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(106, 23);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Thực thi";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(94, 192);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(687, 129);
            this.txtResult.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kết quả: ";
            // 
            // rab_array
            // 
            this.rab_array.AutoSize = true;
            this.rab_array.Location = new System.Drawing.Point(15, 121);
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
            this.raB_stack.Location = new System.Drawing.Point(94, 121);
            this.raB_stack.Name = "raB_stack";
            this.raB_stack.Size = new System.Drawing.Size(64, 21);
            this.raB_stack.TabIndex = 13;
            this.raB_stack.TabStop = true;
            this.raB_stack.Text = "Stack";
            this.raB_stack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.raB_stack);
            this.Controls.Add(this.rab_array);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnRadomPolymial);
            this.Controls.Add(this.txtPolynomial);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "InfixToPostfix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ToolStripMenuItem đoThờiGianChạyHàmToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rab_array;
        private System.Windows.Forms.RadioButton raB_stack;
    }
}

