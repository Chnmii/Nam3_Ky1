namespace Bai2_7_9
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
            this.txtColor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.HSBblue = new System.Windows.Forms.HScrollBar();
            this.HSBgreen = new System.Windows.Forms.HScrollBar();
            this.HSBred = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtColor.ForeColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(18, 19);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(735, 182);
            this.txtColor.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBlue);
            this.groupBox1.Controls.Add(this.lblGreen);
            this.groupBox1.Controls.Add(this.lblRed);
            this.groupBox1.Controls.Add(this.HSBblue);
            this.groupBox1.Controls.Add(this.HSBgreen);
            this.groupBox1.Controls.Add(this.HSBred);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(628, 142);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(13, 16);
            this.lblBlue.TabIndex = 8;
            this.lblBlue.Text = "  ";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblGreen.Location = new System.Drawing.Point(628, 87);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(13, 16);
            this.lblGreen.TabIndex = 7;
            this.lblGreen.Text = "  ";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(628, 32);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(13, 16);
            this.lblRed.TabIndex = 6;
            this.lblRed.Text = "  ";
            // 
            // HSBblue
            // 
            this.HSBblue.Location = new System.Drawing.Point(93, 142);
            this.HSBblue.Name = "HSBblue";
            this.HSBblue.Size = new System.Drawing.Size(513, 20);
            this.HSBblue.TabIndex = 5;
            this.HSBblue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSBred_Scroll);
            this.HSBblue.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // HSBgreen
            // 
            this.HSBgreen.Location = new System.Drawing.Point(93, 87);
            this.HSBgreen.Name = "HSBgreen";
            this.HSBgreen.Size = new System.Drawing.Size(513, 20);
            this.HSBgreen.TabIndex = 4;
            this.HSBgreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSBred_Scroll);
            this.HSBgreen.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // HSBred
            // 
            this.HSBred.Location = new System.Drawing.Point(93, 32);
            this.HSBred.Name = "HSBred";
            this.HSBred.Size = new System.Drawing.Size(513, 20);
            this.HSBred.TabIndex = 3;
            this.HSBred.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSBred_Scroll);
            this.HSBred.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(18, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtColor);
            this.Name = "Form1";
            this.Text = "Đổi màu nền cho textBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar HSBblue;
        private System.Windows.Forms.HScrollBar HSBgreen;
        private System.Windows.Forms.HScrollBar HSBred;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
    }
}

