namespace PTbac2
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
            this.lblNhapA = new System.Windows.Forms.Label();
            this.lblNhapB = new System.Windows.Forms.Label();
            this.lblNhapC = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.txtNhapC = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // lblNhapA
            // 
            this.lblNhapA.AutoSize = true;
            this.lblNhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapA.Location = new System.Drawing.Point(82, 109);
            this.lblNhapA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapA.Name = "lblNhapA";
            this.lblNhapA.Size = new System.Drawing.Size(77, 20);
            this.lblNhapA.TabIndex = 1;
            this.lblNhapA.Text = "Nhập a : ";
            // 
            // lblNhapB
            // 
            this.lblNhapB.AutoSize = true;
            this.lblNhapB.Location = new System.Drawing.Point(82, 164);
            this.lblNhapB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapB.Name = "lblNhapB";
            this.lblNhapB.Size = new System.Drawing.Size(77, 20);
            this.lblNhapB.TabIndex = 2;
            this.lblNhapB.Text = "Nhập b : ";
            // 
            // lblNhapC
            // 
            this.lblNhapC.AutoSize = true;
            this.lblNhapC.Location = new System.Drawing.Point(82, 218);
            this.lblNhapC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapC.Name = "lblNhapC";
            this.lblNhapC.Size = new System.Drawing.Size(77, 20);
            this.lblNhapC.TabIndex = 3;
            this.lblNhapC.Text = "Nhập c : ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(82, 288);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(81, 20);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết quả : ";
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(191, 102);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(337, 27);
            this.txtNhapA.TabIndex = 5;
            // 
            // txtNhapB
            // 
            this.txtNhapB.Location = new System.Drawing.Point(191, 157);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(337, 27);
            this.txtNhapB.TabIndex = 6;
            // 
            // txtNhapC
            // 
            this.txtNhapC.Location = new System.Drawing.Point(191, 211);
            this.txtNhapC.Name = "txtNhapC";
            this.txtNhapC.Size = new System.Drawing.Size(337, 27);
            this.txtNhapC.TabIndex = 7;
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKetQua.Location = new System.Drawing.Point(191, 285);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(337, 67);
            this.txtKetQua.TabIndex = 8;
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.Location = new System.Drawing.Point(62, 402);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(122, 52);
            this.btnGiaiPT.TabIndex = 9;
            this.btnGiaiPT.Text = "&Giải PT";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.btnGiaiPT_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(288, 402);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(122, 52);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "&Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(512, 402);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 52);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 494);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNhapC);
            this.Controls.Add(this.txtNhapB);
            this.Controls.Add(this.txtNhapA);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblNhapC);
            this.Controls.Add(this.lblNhapB);
            this.Controls.Add(this.lblNhapA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNhapA;
        private System.Windows.Forms.Label lblNhapB;
        private System.Windows.Forms.Label lblNhapC;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.TextBox txtNhapB;
        private System.Windows.Forms.TextBox txtNhapC;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnGiaiPT;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
    }
}

