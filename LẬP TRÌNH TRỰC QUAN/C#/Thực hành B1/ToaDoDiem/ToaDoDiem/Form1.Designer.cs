namespace ToaDoDiem
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
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblY2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHSG = new System.Windows.Forms.TextBox();
            this.txtKC = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.txtY1);
            this.grb1.Controls.Add(this.txtX1);
            this.grb1.Controls.Add(this.lblY1);
            this.grb1.Controls.Add(this.lblX1);
            this.grb1.Location = new System.Drawing.Point(77, 65);
            this.grb1.Margin = new System.Windows.Forms.Padding(4);
            this.grb1.Name = "grb1";
            this.grb1.Padding = new System.Windows.Forms.Padding(4);
            this.grb1.Size = new System.Drawing.Size(278, 178);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "Điểm thứ nhất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khoảng cách";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(65, 103);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(156, 27);
            this.txtY1.TabIndex = 3;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(65, 52);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(156, 27);
            this.txtX1.TabIndex = 2;
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(26, 110);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(17, 20);
            this.lblY1.TabIndex = 1;
            this.lblY1.Text = "y";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(26, 59);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(17, 20);
            this.lblX1.TabIndex = 0;
            this.lblX1.Text = "x";
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.txtY2);
            this.grb2.Controls.Add(this.txtX2);
            this.grb2.Controls.Add(this.lblX2);
            this.grb2.Controls.Add(this.lblY2);
            this.grb2.Location = new System.Drawing.Point(402, 65);
            this.grb2.Margin = new System.Windows.Forms.Padding(4);
            this.grb2.Name = "grb2";
            this.grb2.Padding = new System.Windows.Forms.Padding(4);
            this.grb2.Size = new System.Drawing.Size(278, 178);
            this.grb2.TabIndex = 1;
            this.grb2.TabStop = false;
            this.grb2.Text = "Điểm thứ hai";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(69, 103);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(156, 27);
            this.txtY2.TabIndex = 4;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(69, 52);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(156, 27);
            this.txtX2.TabIndex = 5;
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(32, 59);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(17, 20);
            this.lblX2.TabIndex = 2;
            this.lblX2.Text = "x";
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(32, 110);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(17, 20);
            this.lblY2.TabIndex = 3;
            this.lblY2.Text = "y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hệ số góc";
            // 
            // txtHSG
            // 
            this.txtHSG.Location = new System.Drawing.Point(77, 330);
            this.txtHSG.Multiline = true;
            this.txtHSG.Name = "txtHSG";
            this.txtHSG.Size = new System.Drawing.Size(278, 73);
            this.txtHSG.TabIndex = 5;
            // 
            // txtKC
            // 
            this.txtKC.Location = new System.Drawing.Point(402, 330);
            this.txtKC.Multiline = true;
            this.txtKC.Name = "txtKC";
            this.txtKC.Size = new System.Drawing.Size(278, 73);
            this.txtKC.TabIndex = 6;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(275, 435);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(204, 50);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính toán";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 549);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKC);
            this.Controls.Add(this.txtHSG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Toạ độ các điểm";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHSG;
        private System.Windows.Forms.TextBox txtKC;
        private System.Windows.Forms.Button btnTinh;
    }
}

