namespace BT2
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
            this.lba = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.lbketqua = new System.Windows.Forms.Label();
            this.txtsoa = new System.Windows.Forms.TextBox();
            this.txtsob = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Location = new System.Drawing.Point(169, 71);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(91, 16);
            this.lba.TabIndex = 0;
            this.lba.Text = "Số nguyên a : ";
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Location = new System.Drawing.Point(169, 133);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(88, 16);
            this.lbb.TabIndex = 1;
            this.lbb.Text = "Số nguyên b :";
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.ForeColor = System.Drawing.Color.Red;
            this.lbketqua.Location = new System.Drawing.Point(169, 203);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(61, 16);
            this.lbketqua.TabIndex = 2;
            this.lbketqua.Text = "Kết quả : ";
            // 
            // txtsoa
            // 
            this.txtsoa.Location = new System.Drawing.Point(264, 69);
            this.txtsoa.Name = "txtsoa";
            this.txtsoa.Size = new System.Drawing.Size(175, 22);
            this.txtsoa.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtsoa, "Nhập số nguyên");
            // 
            // txtsob
            // 
            this.txtsob.Location = new System.Drawing.Point(264, 130);
            this.txtsob.Name = "txtsob";
            this.txtsob.Size = new System.Drawing.Size(175, 22);
            this.txtsob.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtsob, "Nhập số nguyên");
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(70, 322);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(154, 49);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "Tính Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(313, 322);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(154, 49);
            this.btnLamLai.TabIndex = 6;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(551, 322);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(154, 49);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.txtsob);
            this.Controls.Add(this.txtsoa);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lba);
            this.Name = "Form1";
            this.Text = "Chương trình tính tổng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.Label lbketqua;
        private System.Windows.Forms.TextBox txtsoa;
        private System.Windows.Forms.TextBox txtsob;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

