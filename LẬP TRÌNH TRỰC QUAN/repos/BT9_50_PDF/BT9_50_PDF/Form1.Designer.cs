namespace BT9_50_PDF
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
            this.txtFont = new System.Windows.Forms.TextBox();
            this.groupKieuFont = new System.Windows.Forms.GroupBox();
            this.rdoTahoma = new System.Windows.Forms.RadioButton();
            this.rdoVnVgogue = new System.Windows.Forms.RadioButton();
            this.rdoVnUaiverse = new System.Windows.Forms.RadioButton();
            this.rdoVnTime = new System.Windows.Forms.RadioButton();
            this.groupHieuUng = new System.Windows.Forms.GroupBox();
            this.checkBoxUnderline = new System.Windows.Forms.CheckBox();
            this.checkBoxstrikoot = new System.Windows.Forms.CheckBox();
            this.checkBoxitalic = new System.Windows.Forms.CheckBox();
            this.checkboxBold = new System.Windows.Forms.CheckBox();
            this.groupMauChu = new System.Windows.Forms.GroupBox();
            this.rdoTim = new System.Windows.Forms.RadioButton();
            this.rdoXanhLa = new System.Windows.Forms.RadioButton();
            this.rdoDo = new System.Windows.Forms.RadioButton();
            this.rdoXanh = new System.Windows.Forms.RadioButton();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupKieuFont.SuspendLayout();
            this.groupHieuUng.SuspendLayout();
            this.groupMauChu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFont
            // 
            this.txtFont.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFont.ForeColor = System.Drawing.Color.Red;
            this.txtFont.Location = new System.Drawing.Point(203, 59);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(350, 43);
            this.txtFont.TabIndex = 0;
            this.txtFont.Text = "Microsoft Víaual C#";
            // 
            // groupKieuFont
            // 
            this.groupKieuFont.Controls.Add(this.rdoTahoma);
            this.groupKieuFont.Controls.Add(this.rdoVnVgogue);
            this.groupKieuFont.Controls.Add(this.rdoVnUaiverse);
            this.groupKieuFont.Controls.Add(this.rdoVnTime);
            this.groupKieuFont.Location = new System.Drawing.Point(61, 140);
            this.groupKieuFont.Name = "groupKieuFont";
            this.groupKieuFont.Size = new System.Drawing.Size(163, 196);
            this.groupKieuFont.TabIndex = 1;
            this.groupKieuFont.TabStop = false;
            this.groupKieuFont.Text = "Kieu Font";
            // 
            // rdoTahoma
            // 
            this.rdoTahoma.AutoSize = true;
            this.rdoTahoma.Location = new System.Drawing.Point(24, 149);
            this.rdoTahoma.Name = "rdoTahoma";
            this.rdoTahoma.Size = new System.Drawing.Size(79, 20);
            this.rdoTahoma.TabIndex = 3;
            this.rdoTahoma.TabStop = true;
            this.rdoTahoma.Text = "Tahoma";
            this.rdoTahoma.UseVisualStyleBackColor = true;
            this.rdoTahoma.Click += new System.EventHandler(this.rdoVnTime_Click);
            // 
            // rdoVnVgogue
            // 
            this.rdoVnVgogue.AutoSize = true;
            this.rdoVnVgogue.Location = new System.Drawing.Point(24, 112);
            this.rdoVnVgogue.Name = "rdoVnVgogue";
            this.rdoVnVgogue.Size = new System.Drawing.Size(92, 20);
            this.rdoVnVgogue.TabIndex = 2;
            this.rdoVnVgogue.TabStop = true;
            this.rdoVnVgogue.Text = "VnVgogue";
            this.rdoVnVgogue.UseVisualStyleBackColor = true;
            this.rdoVnVgogue.Click += new System.EventHandler(this.rdoVnTime_Click);
            // 
            // rdoVnUaiverse
            // 
            this.rdoVnUaiverse.AutoSize = true;
            this.rdoVnUaiverse.Location = new System.Drawing.Point(24, 74);
            this.rdoVnUaiverse.Name = "rdoVnUaiverse";
            this.rdoVnUaiverse.Size = new System.Drawing.Size(99, 20);
            this.rdoVnUaiverse.TabIndex = 1;
            this.rdoVnUaiverse.TabStop = true;
            this.rdoVnUaiverse.Text = "VnUaiverse";
            this.rdoVnUaiverse.UseVisualStyleBackColor = true;
            this.rdoVnUaiverse.Click += new System.EventHandler(this.rdoVnTime_Click);
            // 
            // rdoVnTime
            // 
            this.rdoVnTime.AutoSize = true;
            this.rdoVnTime.Location = new System.Drawing.Point(24, 35);
            this.rdoVnTime.Name = "rdoVnTime";
            this.rdoVnTime.Size = new System.Drawing.Size(75, 20);
            this.rdoVnTime.TabIndex = 0;
            this.rdoVnTime.TabStop = true;
            this.rdoVnTime.Text = "VnTime";
            this.rdoVnTime.UseVisualStyleBackColor = true;
            this.rdoVnTime.Click += new System.EventHandler(this.rdoVnTime_Click);
            // 
            // groupHieuUng
            // 
            this.groupHieuUng.Controls.Add(this.checkBoxUnderline);
            this.groupHieuUng.Controls.Add(this.checkBoxstrikoot);
            this.groupHieuUng.Controls.Add(this.checkBoxitalic);
            this.groupHieuUng.Controls.Add(this.checkboxBold);
            this.groupHieuUng.Location = new System.Drawing.Point(311, 140);
            this.groupHieuUng.Name = "groupHieuUng";
            this.groupHieuUng.Size = new System.Drawing.Size(163, 196);
            this.groupHieuUng.TabIndex = 2;
            this.groupHieuUng.TabStop = false;
            this.groupHieuUng.Text = "Hiệu ứng";
            // 
            // checkBoxUnderline
            // 
            this.checkBoxUnderline.AutoSize = true;
            this.checkBoxUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUnderline.Location = new System.Drawing.Point(34, 149);
            this.checkBoxUnderline.Name = "checkBoxUnderline";
            this.checkBoxUnderline.Size = new System.Drawing.Size(96, 20);
            this.checkBoxUnderline.TabIndex = 3;
            this.checkBoxUnderline.Text = "Underline";
            this.checkBoxUnderline.UseVisualStyleBackColor = true;
            this.checkBoxUnderline.Click += new System.EventHandler(this.checkboxBold_Click);
            // 
            // checkBoxstrikoot
            // 
            this.checkBoxstrikoot.AutoSize = true;
            this.checkBoxstrikoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxstrikoot.Location = new System.Drawing.Point(34, 113);
            this.checkBoxstrikoot.Name = "checkBoxstrikoot";
            this.checkBoxstrikoot.Size = new System.Drawing.Size(90, 20);
            this.checkBoxstrikoot.TabIndex = 2;
            this.checkBoxstrikoot.Text = "Strikoout";
            this.checkBoxstrikoot.UseVisualStyleBackColor = true;
            this.checkBoxstrikoot.Click += new System.EventHandler(this.checkboxBold_Click);
            // 
            // checkBoxitalic
            // 
            this.checkBoxitalic.AutoSize = true;
            this.checkBoxitalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxitalic.Location = new System.Drawing.Point(34, 75);
            this.checkBoxitalic.Name = "checkBoxitalic";
            this.checkBoxitalic.Size = new System.Drawing.Size(56, 20);
            this.checkBoxitalic.TabIndex = 1;
            this.checkBoxitalic.Text = "Italic";
            this.checkBoxitalic.UseVisualStyleBackColor = true;
            this.checkBoxitalic.Click += new System.EventHandler(this.checkboxBold_Click);
            // 
            // checkboxBold
            // 
            this.checkboxBold.AutoSize = true;
            this.checkboxBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxBold.Location = new System.Drawing.Point(34, 35);
            this.checkboxBold.Name = "checkboxBold";
            this.checkboxBold.Size = new System.Drawing.Size(61, 20);
            this.checkboxBold.TabIndex = 0;
            this.checkboxBold.Text = "Bold";
            this.checkboxBold.UseVisualStyleBackColor = true;
            this.checkboxBold.Click += new System.EventHandler(this.checkboxBold_Click);
            // 
            // groupMauChu
            // 
            this.groupMauChu.Controls.Add(this.rdoTim);
            this.groupMauChu.Controls.Add(this.rdoXanhLa);
            this.groupMauChu.Controls.Add(this.rdoDo);
            this.groupMauChu.Controls.Add(this.rdoXanh);
            this.groupMauChu.Location = new System.Drawing.Point(553, 140);
            this.groupMauChu.Name = "groupMauChu";
            this.groupMauChu.Size = new System.Drawing.Size(163, 196);
            this.groupMauChu.TabIndex = 2;
            this.groupMauChu.TabStop = false;
            this.groupMauChu.Text = "Màu Chữ";
            // 
            // rdoTim
            // 
            this.rdoTim.AutoSize = true;
            this.rdoTim.ForeColor = System.Drawing.Color.Fuchsia;
            this.rdoTim.Location = new System.Drawing.Point(30, 148);
            this.rdoTim.Name = "rdoTim";
            this.rdoTim.Size = new System.Drawing.Size(51, 20);
            this.rdoTim.TabIndex = 3;
            this.rdoTim.TabStop = true;
            this.rdoTim.Text = "Tím";
            this.rdoTim.UseVisualStyleBackColor = true;
            this.rdoTim.Click += new System.EventHandler(this.rdoXanh_Click);
            // 
            // rdoXanhLa
            // 
            this.rdoXanhLa.AutoSize = true;
            this.rdoXanhLa.ForeColor = System.Drawing.Color.Lime;
            this.rdoXanhLa.Location = new System.Drawing.Point(30, 113);
            this.rdoXanhLa.Name = "rdoXanhLa";
            this.rdoXanhLa.Size = new System.Drawing.Size(68, 20);
            this.rdoXanhLa.TabIndex = 2;
            this.rdoXanhLa.TabStop = true;
            this.rdoXanhLa.Text = "Lá cây";
            this.rdoXanhLa.UseVisualStyleBackColor = true;
            this.rdoXanhLa.Click += new System.EventHandler(this.rdoXanh_Click);
            // 
            // rdoDo
            // 
            this.rdoDo.AutoSize = true;
            this.rdoDo.ForeColor = System.Drawing.Color.Red;
            this.rdoDo.Location = new System.Drawing.Point(30, 74);
            this.rdoDo.Name = "rdoDo";
            this.rdoDo.Size = new System.Drawing.Size(45, 20);
            this.rdoDo.TabIndex = 1;
            this.rdoDo.TabStop = true;
            this.rdoDo.Text = "Đỏ";
            this.rdoDo.UseVisualStyleBackColor = true;
            this.rdoDo.Click += new System.EventHandler(this.rdoXanh_Click);
            // 
            // rdoXanh
            // 
            this.rdoXanh.AutoSize = true;
            this.rdoXanh.ForeColor = System.Drawing.Color.Blue;
            this.rdoXanh.Location = new System.Drawing.Point(30, 34);
            this.rdoXanh.Name = "rdoXanh";
            this.rdoXanh.Size = new System.Drawing.Size(58, 20);
            this.rdoXanh.TabIndex = 0;
            this.rdoXanh.TabStop = true;
            this.rdoXanh.Text = "Xanh";
            this.rdoXanh.UseVisualStyleBackColor = true;
            this.rdoXanh.Click += new System.EventHandler(this.rdoXanh_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(173, 363);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(172, 51);
            this.btnLamLai.TabIndex = 3;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(431, 363);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 51);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.groupHieuUng);
            this.Controls.Add(this.groupMauChu);
            this.Controls.Add(this.groupKieuFont);
            this.Controls.Add(this.txtFont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupKieuFont.ResumeLayout(false);
            this.groupKieuFont.PerformLayout();
            this.groupHieuUng.ResumeLayout(false);
            this.groupHieuUng.PerformLayout();
            this.groupMauChu.ResumeLayout(false);
            this.groupMauChu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.GroupBox groupKieuFont;
        private System.Windows.Forms.RadioButton rdoTahoma;
        private System.Windows.Forms.RadioButton rdoVnVgogue;
        private System.Windows.Forms.RadioButton rdoVnUaiverse;
        private System.Windows.Forms.RadioButton rdoVnTime;
        private System.Windows.Forms.GroupBox groupHieuUng;
        private System.Windows.Forms.CheckBox checkBoxUnderline;
        private System.Windows.Forms.CheckBox checkBoxstrikoot;
        private System.Windows.Forms.CheckBox checkBoxitalic;
        private System.Windows.Forms.CheckBox checkboxBold;
        private System.Windows.Forms.GroupBox groupMauChu;
        private System.Windows.Forms.RadioButton rdoTim;
        private System.Windows.Forms.RadioButton rdoXanhLa;
        private System.Windows.Forms.RadioButton rdoDo;
        private System.Windows.Forms.RadioButton rdoXanh;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
    }
}

