namespace AmNhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbODia = new System.Windows.Forms.ComboBox();
            this.cbbThuMuc = new System.Windows.Forms.ComboBox();
            this.rtbLoiBH = new System.Windows.Forms.RichTextBox();
            this.lsbTapTin = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ổ đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thư mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tập tin";
            // 
            // cbbODia
            // 
            this.cbbODia.FormattingEnabled = true;
            this.cbbODia.Location = new System.Drawing.Point(140, 35);
            this.cbbODia.Name = "cbbODia";
            this.cbbODia.Size = new System.Drawing.Size(172, 24);
            this.cbbODia.TabIndex = 3;
            this.cbbODia.SelectedIndexChanged += new System.EventHandler(this.cbbODia_SelectedIndexChanged);
            // 
            // cbbThuMuc
            // 
            this.cbbThuMuc.FormattingEnabled = true;
            this.cbbThuMuc.Location = new System.Drawing.Point(140, 100);
            this.cbbThuMuc.Name = "cbbThuMuc";
            this.cbbThuMuc.Size = new System.Drawing.Size(172, 24);
            this.cbbThuMuc.TabIndex = 4;
            this.cbbThuMuc.SelectedIndexChanged += new System.EventHandler(this.cbbThuMuc_SelectedIndexChanged);
            // 
            // rtbLoiBH
            // 
            this.rtbLoiBH.Location = new System.Drawing.Point(373, 12);
            this.rtbLoiBH.Name = "rtbLoiBH";
            this.rtbLoiBH.Size = new System.Drawing.Size(468, 574);
            this.rtbLoiBH.TabIndex = 5;
            this.rtbLoiBH.Text = "";
            // 
            // lsbTapTin
            // 
            this.lsbTapTin.FormattingEnabled = true;
            this.lsbTapTin.ItemHeight = 16;
            this.lsbTapTin.Location = new System.Drawing.Point(44, 209);
            this.lsbTapTin.Name = "lsbTapTin";
            this.lsbTapTin.Size = new System.Drawing.Size(279, 148);
            this.lsbTapTin.TabIndex = 6;
            this.lsbTapTin.SelectedIndexChanged += new System.EventHandler(this.lsbTapTin_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(35, 353);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(220, 121);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 616);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lsbTapTin);
            this.Controls.Add(this.rtbLoiBH);
            this.Controls.Add(this.cbbThuMuc);
            this.Controls.Add(this.cbbODia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ví dụ ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbODia;
        private System.Windows.Forms.ComboBox cbbThuMuc;
        private System.Windows.Forms.RichTextBox rtbLoiBH;
        private System.Windows.Forms.ListBox lsbTapTin;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

