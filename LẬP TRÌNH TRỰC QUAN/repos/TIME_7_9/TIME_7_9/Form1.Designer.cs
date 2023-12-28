namespace TIME_7_9
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
            this.lalmin = new System.Windows.Forms.Label();
            this.lblsec = new System.Windows.Forms.Label();
            this.txtminutes = new System.Windows.Forms.TextBox();
            this.txtseconds = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lalmin
            // 
            this.lalmin.AutoSize = true;
            this.lalmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalmin.ForeColor = System.Drawing.Color.Red;
            this.lalmin.Location = new System.Drawing.Point(225, 95);
            this.lalmin.Name = "lalmin";
            this.lalmin.Size = new System.Drawing.Size(132, 32);
            this.lalmin.TabIndex = 0;
            this.lalmin.Text = "(Minutes)";
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.ForeColor = System.Drawing.Color.Red;
            this.lblsec.Location = new System.Drawing.Point(392, 95);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(143, 32);
            this.lblsec.TabIndex = 1;
            this.lblsec.Text = "(Seconds)";
            // 
            // txtminutes
            // 
            this.txtminutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtminutes.Location = new System.Drawing.Point(242, 151);
            this.txtminutes.Multiline = true;
            this.txtminutes.Name = "txtminutes";
            this.txtminutes.Size = new System.Drawing.Size(95, 56);
            this.txtminutes.TabIndex = 2;
            this.txtminutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtseconds
            // 
            this.txtseconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtseconds.Location = new System.Drawing.Point(419, 151);
            this.txtseconds.Multiline = true;
            this.txtseconds.Name = "txtseconds";
            this.txtseconds.Size = new System.Drawing.Size(95, 56);
            this.txtseconds.TabIndex = 3;
            this.txtseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(112, 290);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(145, 55);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(312, 290);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(145, 55);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(507, 290);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(145, 55);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 69);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtseconds);
            this.Controls.Add(this.txtminutes);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.lalmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalmin;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.TextBox txtminutes;
        private System.Windows.Forms.TextBox txtseconds;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

