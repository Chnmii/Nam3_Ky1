namespace BT1
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
            this.lbthang = new System.Windows.Forms.Label();
            this.lbnam = new System.Windows.Forms.Label();
            this.lbtong = new System.Windows.Forms.Label();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.btnketqua = new System.Windows.Forms.Button();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbthang
            // 
            this.lbthang.AutoSize = true;
            this.lbthang.Location = new System.Drawing.Point(214, 63);
            this.lbthang.Name = "lbthang";
            this.lbthang.Size = new System.Drawing.Size(88, 16);
            this.lbthang.TabIndex = 0;
            this.lbthang.Text = "Nhập Tháng :";
            // 
            // lbnam
            // 
            this.lbnam.AutoSize = true;
            this.lbnam.Location = new System.Drawing.Point(215, 120);
            this.lbnam.Name = "lbnam";
            this.lbnam.Size = new System.Drawing.Size(78, 16);
            this.lbnam.TabIndex = 1;
            this.lbnam.Text = "Nhập Năm :";
            // 
            // lbtong
            // 
            this.lbtong.AutoSize = true;
            this.lbtong.Location = new System.Drawing.Point(216, 177);
            this.lbtong.Name = "lbtong";
            this.lbtong.Size = new System.Drawing.Size(54, 16);
            this.lbtong.TabIndex = 2;
            this.lbtong.Text = "Ket Qua";
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(339, 60);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(141, 22);
            this.txtthang.TabIndex = 3;
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(339, 114);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(141, 22);
            this.txtnam.TabIndex = 4;
            // 
            // btnketqua
            // 
            this.btnketqua.Location = new System.Drawing.Point(68, 330);
            this.btnketqua.Name = "btnketqua";
            this.btnketqua.Size = new System.Drawing.Size(131, 45);
            this.btnketqua.TabIndex = 5;
            this.btnketqua.Text = "Kết Quả";
            this.btnketqua.UseVisualStyleBackColor = true;
            this.btnketqua.Click += new System.EventHandler(this.btnketqua_Click);
            // 
            // btnlamlai
            // 
            this.btnlamlai.Location = new System.Drawing.Point(310, 330);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(131, 45);
            this.btnlamlai.TabIndex = 6;
            this.btnlamlai.Text = "Làm Lại";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(559, 330);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(131, 45);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlamlai);
            this.Controls.Add(this.btnketqua);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.lbtong);
            this.Controls.Add(this.lbnam);
            this.Controls.Add(this.lbthang);
            this.Name = "Form1";
            this.Text = "Chuong trinh tinh so ngay trong thang";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbthang;
        private System.Windows.Forms.Label lbnam;
        private System.Windows.Forms.Label lbtong;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Button btnketqua;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.Button btnthoat;
    }
}

