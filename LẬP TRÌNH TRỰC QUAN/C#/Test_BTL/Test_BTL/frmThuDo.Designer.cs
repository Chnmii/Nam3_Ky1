namespace Test_BTL
{
    partial class frmThuDo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdCT1 = new System.Windows.Forms.RadioButton();
            this.rdCT2 = new System.Windows.Forms.RadioButton();
            this.rdCT3 = new System.Windows.Forms.RadioButton();
            this.rdCT4 = new System.Windows.Forms.RadioButton();
            this.rdCT5 = new System.Windows.Forms.RadioButton();
            this.rdCT6 = new System.Windows.Forms.RadioButton();
            this.rdTD6 = new System.Windows.Forms.RadioButton();
            this.rdTD5 = new System.Windows.Forms.RadioButton();
            this.rdTD4 = new System.Windows.Forms.RadioButton();
            this.rdTD3 = new System.Windows.Forms.RadioButton();
            this.rdTD2 = new System.Windows.Forms.RadioButton();
            this.rdTD1 = new System.Windows.Forms.RadioButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCT6);
            this.groupBox1.Controls.Add(this.rdCT5);
            this.groupBox1.Controls.Add(this.rdCT4);
            this.groupBox1.Controls.Add(this.rdCT3);
            this.groupBox1.Controls.Add(this.rdCT2);
            this.groupBox1.Controls.Add(this.rdCT1);
            this.groupBox1.Location = new System.Drawing.Point(59, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTD6);
            this.groupBox2.Controls.Add(this.rdTD1);
            this.groupBox2.Controls.Add(this.rdTD5);
            this.groupBox2.Controls.Add(this.rdTD2);
            this.groupBox2.Controls.Add(this.rdTD4);
            this.groupBox2.Controls.Add(this.rdTD3);
            this.groupBox2.Location = new System.Drawing.Point(426, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 369);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capital";
            // 
            // rdCT1
            // 
            this.rdCT1.AutoSize = true;
            this.rdCT1.Location = new System.Drawing.Point(31, 40);
            this.rdCT1.Name = "rdCT1";
            this.rdCT1.Size = new System.Drawing.Size(83, 20);
            this.rdCT1.TabIndex = 0;
            this.rdCT1.TabStop = true;
            this.rdCT1.Text = "Viet Nam";
            this.rdCT1.UseVisualStyleBackColor = true;
            this.rdCT1.CheckedChanged += new System.EventHandler(this.rdCT1_CheckedChanged);
            this.rdCT1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rdCT2
            // 
            this.rdCT2.AutoSize = true;
            this.rdCT2.Location = new System.Drawing.Point(31, 93);
            this.rdCT2.Name = "rdCT2";
            this.rdCT2.Size = new System.Drawing.Size(70, 20);
            this.rdCT2.TabIndex = 1;
            this.rdCT2.TabStop = true;
            this.rdCT2.Text = "France";
            this.rdCT2.UseVisualStyleBackColor = true;
            this.rdCT2.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rdCT3
            // 
            this.rdCT3.AutoSize = true;
            this.rdCT3.Location = new System.Drawing.Point(31, 148);
            this.rdCT3.Name = "rdCT3";
            this.rdCT3.Size = new System.Drawing.Size(64, 20);
            this.rdCT3.TabIndex = 2;
            this.rdCT3.TabStop = true;
            this.rdCT3.Text = "Korea";
            this.rdCT3.UseVisualStyleBackColor = true;
            this.rdCT3.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rdCT4
            // 
            this.rdCT4.AutoSize = true;
            this.rdCT4.Location = new System.Drawing.Point(31, 202);
            this.rdCT4.Name = "rdCT4";
            this.rdCT4.Size = new System.Drawing.Size(66, 20);
            this.rdCT4.TabIndex = 3;
            this.rdCT4.TabStop = true;
            this.rdCT4.Text = "Japan";
            this.rdCT4.UseVisualStyleBackColor = true;
            this.rdCT4.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rdCT5
            // 
            this.rdCT5.AutoSize = true;
            this.rdCT5.Location = new System.Drawing.Point(31, 256);
            this.rdCT5.Name = "rdCT5";
            this.rdCT5.Size = new System.Drawing.Size(76, 20);
            this.rdCT5.TabIndex = 4;
            this.rdCT5.TabStop = true;
            this.rdCT5.Text = "Canada";
            this.rdCT5.UseVisualStyleBackColor = true;
            this.rdCT5.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rdCT6
            // 
            this.rdCT6.AutoSize = true;
            this.rdCT6.Location = new System.Drawing.Point(31, 308);
            this.rdCT6.Name = "rdCT6";
            this.rdCT6.Size = new System.Drawing.Size(87, 20);
            this.rdCT6.TabIndex = 5;
            this.rdCT6.TabStop = true;
            this.rdCT6.Text = "Indonesia";
            this.rdCT6.UseVisualStyleBackColor = true;
            this.rdCT6.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rdTD6
            // 
            this.rdTD6.AutoSize = true;
            this.rdTD6.Location = new System.Drawing.Point(40, 308);
            this.rdTD6.Name = "rdTD6";
            this.rdTD6.Size = new System.Drawing.Size(63, 20);
            this.rdTD6.TabIndex = 11;
            this.rdTD6.TabStop = true;
            this.rdTD6.Text = "Seoul";
            this.rdTD6.UseVisualStyleBackColor = true;
            // 
            // rdTD5
            // 
            this.rdTD5.AutoSize = true;
            this.rdTD5.Location = new System.Drawing.Point(40, 256);
            this.rdTD5.Name = "rdTD5";
            this.rdTD5.Size = new System.Drawing.Size(59, 20);
            this.rdTD5.TabIndex = 10;
            this.rdTD5.TabStop = true;
            this.rdTD5.Text = "Paris";
            this.rdTD5.UseVisualStyleBackColor = true;
            // 
            // rdTD4
            // 
            this.rdTD4.AutoSize = true;
            this.rdTD4.Location = new System.Drawing.Point(40, 202);
            this.rdTD4.Name = "rdTD4";
            this.rdTD4.Size = new System.Drawing.Size(69, 20);
            this.rdTD4.TabIndex = 9;
            this.rdTD4.TabStop = true;
            this.rdTD4.Text = "Ottawa";
            this.rdTD4.UseVisualStyleBackColor = true;
            // 
            // rdTD3
            // 
            this.rdTD3.AutoSize = true;
            this.rdTD3.Location = new System.Drawing.Point(40, 148);
            this.rdTD3.Name = "rdTD3";
            this.rdTD3.Size = new System.Drawing.Size(70, 20);
            this.rdTD3.TabIndex = 8;
            this.rdTD3.TabStop = true;
            this.rdTD3.Text = "Ha Noi";
            this.rdTD3.UseVisualStyleBackColor = true;
            // 
            // rdTD2
            // 
            this.rdTD2.AutoSize = true;
            this.rdTD2.Location = new System.Drawing.Point(40, 93);
            this.rdTD2.Name = "rdTD2";
            this.rdTD2.Size = new System.Drawing.Size(73, 20);
            this.rdTD2.TabIndex = 7;
            this.rdTD2.TabStop = true;
            this.rdTD2.Text = "Jakarta";
            this.rdTD2.UseVisualStyleBackColor = true;
            // 
            // rdTD1
            // 
            this.rdTD1.AutoSize = true;
            this.rdTD1.Location = new System.Drawing.Point(40, 40);
            this.rdTD1.Name = "rdTD1";
            this.rdTD1.Size = new System.Drawing.Size(67, 20);
            this.rdTD1.TabIndex = 6;
            this.rdTD1.TabStop = true;
            this.rdTD1.Text = "Tokyo";
            this.rdTD1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 10;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(597, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 52);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(56, 455);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 16);
            this.lblTitle.TabIndex = 24;
            // 
            // frmThuDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 514);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThuDo";
            this.Text = "frmThuDo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCT6;
        private System.Windows.Forms.RadioButton rdCT5;
        private System.Windows.Forms.RadioButton rdCT4;
        private System.Windows.Forms.RadioButton rdCT3;
        private System.Windows.Forms.RadioButton rdCT2;
        private System.Windows.Forms.RadioButton rdCT1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdTD6;
        private System.Windows.Forms.RadioButton rdTD1;
        private System.Windows.Forms.RadioButton rdTD5;
        private System.Windows.Forms.RadioButton rdTD2;
        private System.Windows.Forms.RadioButton rdTD4;
        private System.Windows.Forms.RadioButton rdTD3;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lblTitle;
    }
}