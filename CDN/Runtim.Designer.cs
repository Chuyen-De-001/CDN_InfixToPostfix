namespace CDN
{
    partial class Runtim
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtDathuc = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.textRuntime1 = new System.Windows.Forms.TextBox();
            this.textRuntime2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐO THỜI CHẠY HÀM";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Array",
            "Stack"});
            this.comboBox1.Location = new System.Drawing.Point(46, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Array",
            "Stack"});
            this.comboBox2.Location = new System.Drawing.Point(432, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(321, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // txtDathuc
            // 
            this.txtDathuc.Location = new System.Drawing.Point(46, 50);
            this.txtDathuc.Multiline = true;
            this.txtDathuc.Name = "txtDathuc";
            this.txtDathuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDathuc.Size = new System.Drawing.Size(558, 47);
            this.txtDathuc.TabIndex = 3;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(619, 49);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(134, 48);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Thực thi";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // textRuntime1
            // 
            this.textRuntime1.Location = new System.Drawing.Point(46, 169);
            this.textRuntime1.Multiline = true;
            this.textRuntime1.Name = "textRuntime1";
            this.textRuntime1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRuntime1.Size = new System.Drawing.Size(321, 225);
            this.textRuntime1.TabIndex = 5;
            // 
            // textRuntime2
            // 
            this.textRuntime2.Location = new System.Drawing.Point(432, 169);
            this.textRuntime2.Multiline = true;
            this.textRuntime2.Name = "textRuntime2";
            this.textRuntime2.Size = new System.Drawing.Size(321, 225);
            this.textRuntime2.TabIndex = 6;
            // 
            // Runtim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textRuntime2);
            this.Controls.Add(this.textRuntime1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtDathuc);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Runtim";
            this.Text = "Runtim";
            this.Load += new System.EventHandler(this.Runtim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtDathuc;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox textRuntime1;
        private System.Windows.Forms.TextBox textRuntime2;
    }
}