namespace NgheNhac
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
            this.cbbODia = new System.Windows.Forms.ComboBox();
            this.cbbThuMuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbTapTin = new System.Windows.Forms.ListBox();
            this.rtbLyrics = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ổ đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thư mục";
            // 
            // cbbODia
            // 
            this.cbbODia.FormattingEnabled = true;
            this.cbbODia.Location = new System.Drawing.Point(108, 42);
            this.cbbODia.Name = "cbbODia";
            this.cbbODia.Size = new System.Drawing.Size(202, 24);
            this.cbbODia.TabIndex = 2;
            this.cbbODia.SelectedIndexChanged += new System.EventHandler(this.cbbODia_SelectedIndexChanged);
            // 
            // cbbThuMuc
            // 
            this.cbbThuMuc.FormattingEnabled = true;
            this.cbbThuMuc.Location = new System.Drawing.Point(107, 84);
            this.cbbThuMuc.Name = "cbbThuMuc";
            this.cbbThuMuc.Size = new System.Drawing.Size(203, 24);
            this.cbbThuMuc.TabIndex = 3;
            this.cbbThuMuc.SelectedIndexChanged += new System.EventHandler(this.cbbThuMuc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tập tin";
            // 
            // lsbTapTin
            // 
            this.lsbTapTin.FormattingEnabled = true;
            this.lsbTapTin.ItemHeight = 16;
            this.lsbTapTin.Location = new System.Drawing.Point(22, 144);
            this.lsbTapTin.Name = "lsbTapTin";
            this.lsbTapTin.Size = new System.Drawing.Size(288, 164);
            this.lsbTapTin.TabIndex = 6;
            this.lsbTapTin.SelectedIndexChanged += new System.EventHandler(this.lsbTapTin_SelectedIndexChanged);
            // 
            // rtbLyrics
            // 
            this.rtbLyrics.Location = new System.Drawing.Point(341, 12);
            this.rtbLyrics.Name = "rtbLyrics";
            this.rtbLyrics.Size = new System.Drawing.Size(365, 573);
            this.rtbLyrics.TabIndex = 7;
            this.rtbLyrics.Text = "";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(22, 305);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(214, 170);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 597);
            this.Controls.Add(this.rtbLyrics);
            this.Controls.Add(this.lsbTapTin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.cbbThuMuc);
            this.Controls.Add(this.cbbODia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbODia;
        private System.Windows.Forms.ComboBox cbbThuMuc;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsbTapTin;
        private System.Windows.Forms.RichTextBox rtbLyrics;
    }
}

