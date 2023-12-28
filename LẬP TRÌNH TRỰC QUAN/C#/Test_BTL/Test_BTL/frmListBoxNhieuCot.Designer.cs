namespace Test_BTL
{
    partial class frmListBoxNhieuCot
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.cbbThuMuc = new System.Windows.Forms.ComboBox();
            this.cbbFile = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(96, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(604, 196);
            this.listBox1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.BorderRadius = 10;
            this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(346, 429);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 52);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbbThuMuc
            // 
            this.cbbThuMuc.FormattingEnabled = true;
            this.cbbThuMuc.Location = new System.Drawing.Point(137, 297);
            this.cbbThuMuc.Name = "cbbThuMuc";
            this.cbbThuMuc.Size = new System.Drawing.Size(512, 24);
            this.cbbThuMuc.TabIndex = 24;
            // 
            // cbbFile
            // 
            this.cbbFile.FormattingEnabled = true;
            this.cbbFile.Location = new System.Drawing.Point(137, 350);
            this.cbbFile.Name = "cbbFile";
            this.cbbFile.Size = new System.Drawing.Size(512, 24);
            this.cbbFile.TabIndex = 25;
            // 
            // frmListBoxNhieuCot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.cbbFile);
            this.Controls.Add(this.cbbThuMuc);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.listBox1);
            this.Name = "frmListBoxNhieuCot";
            this.Text = "frmListBoxNhieuCot";
            this.Load += new System.EventHandler(this.frmListBoxNhieuCot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private System.Windows.Forms.ComboBox cbbThuMuc;
        private System.Windows.Forms.ComboBox cbbFile;
    }
}