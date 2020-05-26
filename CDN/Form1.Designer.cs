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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabArray = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRun = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabArray.SuspendLayout();
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
            this.txtPolynomial.Size = new System.Drawing.Size(523, 22);
            this.txtPolynomial.TabIndex = 1;
            // 
            // btnRadomPolymial
            // 
            this.btnRadomPolymial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRadomPolymial.Location = new System.Drawing.Point(663, 49);
            this.btnRadomPolymial.Name = "btnRadomPolymial";
            this.btnRadomPolymial.Size = new System.Drawing.Size(125, 22);
            this.btnRadomPolymial.TabIndex = 2;
            this.btnRadomPolymial.Text = "Radom Đa Thức";
            this.btnRadomPolymial.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabArray);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 319);
            this.tabControl1.TabIndex = 6;
            // 
            // tabArray
            // 
            this.tabArray.Controls.Add(this.txtResult);
            this.tabArray.Controls.Add(this.label2);
            this.tabArray.Location = new System.Drawing.Point(4, 25);
            this.tabArray.Name = "tabArray";
            this.tabArray.Padding = new System.Windows.Forms.Padding(3);
            this.tabArray.Size = new System.Drawing.Size(765, 290);
            this.tabArray.TabIndex = 0;
            this.tabArray.Text = "Array";
            this.tabArray.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(108, 30);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(626, 22);
            this.txtResult.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(765, 290);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(370, 90);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(106, 23);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Thực thi";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnRadomPolymial);
            this.Controls.Add(this.txtPolynomial);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabArray.ResumeLayout(false);
            this.tabArray.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabArray;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem đoThờiGianChạyHàmToolStripMenuItem1;
    }
}

