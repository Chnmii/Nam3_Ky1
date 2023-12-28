namespace BT3
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
            this.lbnhap = new System.Windows.Forms.Label();
            this.lbinput = new System.Windows.Forms.Label();
            this.lbtong = new System.Windows.Forms.Label();
            this.lbsapxep = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnSapxep = new System.Windows.Forms.Button();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbnhap
            // 
            this.lbnhap.AutoSize = true;
            this.lbnhap.Location = new System.Drawing.Point(132, 77);
            this.lbnhap.Name = "lbnhap";
            this.lbnhap.Size = new System.Drawing.Size(56, 16);
            this.lbnhap.TabIndex = 0;
            this.lbnhap.Text = "Nhập n :";
            // 
            // lbinput
            // 
            this.lbinput.AutoSize = true;
            this.lbinput.Location = new System.Drawing.Point(132, 134);
            this.lbinput.Name = "lbinput";
            this.lbinput.Size = new System.Drawing.Size(59, 16);
            this.lbinput.TabIndex = 1;
            this.lbinput.Text = "Dãy số : ";
            // 
            // lbtong
            // 
            this.lbtong.AutoSize = true;
            this.lbtong.Location = new System.Drawing.Point(132, 193);
            this.lbtong.Name = "lbtong";
            this.lbtong.Size = new System.Drawing.Size(55, 16);
            this.lbtong.TabIndex = 2;
            this.lbtong.Text = "Tổng  = ";
            // 
            // lbsapxep
            // 
            this.lbsapxep.AutoSize = true;
            this.lbsapxep.Location = new System.Drawing.Point(132, 257);
            this.lbsapxep.Name = "lbsapxep";
            this.lbsapxep.Size = new System.Drawing.Size(230, 16);
            this.lbsapxep.TabIndex = 3;
            this.lbsapxep.Text = "Dãy sau khi sắp xếp từ bé đến lớn là : ";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(234, 75);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(200, 22);
            this.txtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtn, "Nhập số nguyên");
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(30, 352);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(129, 41);
            this.btnNhap.TabIndex = 5;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(182, 352);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(129, 41);
            this.btnTong.TabIndex = 6;
            this.btnTong.Text = "Tính tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnSapxep
            // 
            this.btnSapxep.Location = new System.Drawing.Point(333, 352);
            this.btnSapxep.Name = "btnSapxep";
            this.btnSapxep.Size = new System.Drawing.Size(129, 41);
            this.btnSapxep.TabIndex = 7;
            this.btnSapxep.Text = "Sắp xếp";
            this.btnSapxep.UseVisualStyleBackColor = true;
            this.btnSapxep.Click += new System.EventHandler(this.btnSapxep_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Location = new System.Drawing.Point(486, 352);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(129, 41);
            this.btnLamlai.TabIndex = 8;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(637, 352);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 41);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btnSapxep);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.lbsapxep);
            this.Controls.Add(this.lbtong);
            this.Controls.Add(this.lbinput);
            this.Controls.Add(this.lbnhap);
            this.Name = "Form1";
            this.Text = "Tính toán trên day số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnhap;
        private System.Windows.Forms.Label lbinput;
        private System.Windows.Forms.Label lbtong;
        private System.Windows.Forms.Label lbsapxep;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnSapxep;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

