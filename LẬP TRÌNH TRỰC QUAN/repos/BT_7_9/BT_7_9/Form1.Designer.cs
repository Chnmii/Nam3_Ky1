namespace BT_7_9
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lab_GT = new System.Windows.Forms.Label();
            this.lab_TenSV = new System.Windows.Forms.Label();
            this.lab_MaSV = new System.Windows.Forms.Label();
            this.grbutton = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lstSinhVien = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.grbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.lab_GT);
            this.groupBox1.Controls.Add(this.lab_TenSV);
            this.groupBox1.Controls.Add(this.lab_MaSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(282, 91);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(45, 20);
            this.rdoNu.TabIndex = 13;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(174, 91);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(57, 20);
            this.rdoNam.TabIndex = 12;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(499, 24);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(199, 22);
            this.txtTen.TabIndex = 11;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(150, 24);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(199, 22);
            this.txtMa.TabIndex = 10;
            // 
            // lab_GT
            // 
            this.lab_GT.AutoSize = true;
            this.lab_GT.Location = new System.Drawing.Point(79, 95);
            this.lab_GT.Name = "lab_GT";
            this.lab_GT.Size = new System.Drawing.Size(60, 16);
            this.lab_GT.TabIndex = 9;
            this.lab_GT.Text = "Giới Tính";
            // 
            // lab_TenSV
            // 
            this.lab_TenSV.AutoSize = true;
            this.lab_TenSV.Location = new System.Drawing.Point(433, 30);
            this.lab_TenSV.Name = "lab_TenSV";
            this.lab_TenSV.Size = new System.Drawing.Size(52, 16);
            this.lab_TenSV.TabIndex = 8;
            this.lab_TenSV.Text = "Tên SV";
            // 
            // lab_MaSV
            // 
            this.lab_MaSV.AutoSize = true;
            this.lab_MaSV.Location = new System.Drawing.Point(79, 30);
            this.lab_MaSV.Name = "lab_MaSV";
            this.lab_MaSV.Size = new System.Drawing.Size(47, 16);
            this.lab_MaSV.TabIndex = 7;
            this.lab_MaSV.Text = "Ma SV";
            // 
            // grbutton
            // 
            this.grbutton.Controls.Add(this.btnTimKiem);
            this.grbutton.Controls.Add(this.btnXoa);
            this.grbutton.Controls.Add(this.btnSua);
            this.grbutton.Controls.Add(this.btnThem);
            this.grbutton.Location = new System.Drawing.Point(631, 154);
            this.grbutton.Name = "grbutton";
            this.grbutton.Size = new System.Drawing.Size(157, 276);
            this.grbutton.TabIndex = 8;
            this.grbutton.TabStop = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(31, 183);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 33);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(31, 138);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(31, 88);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 33);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 33);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lstSinhVien
            // 
            this.lstSinhVien.FormattingEnabled = true;
            this.lstSinhVien.ItemHeight = 16;
            this.lstSinhVien.Items.AddRange(new object[] {
            "201200409|Nguyễn Thị Tuyết|Nữ",
            "201437657|Ngô Thị Trang|Nữ",
            "290001329|Phùng Khánh Ly|Nam"});
            this.lstSinhVien.Location = new System.Drawing.Point(12, 162);
            this.lstSinhVien.Name = "lstSinhVien";
            this.lstSinhVien.Size = new System.Drawing.Size(607, 276);
            this.lstSinhVien.TabIndex = 9;
            this.lstSinhVien.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSinhVien);
            this.Controls.Add(this.grbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lab_GT;
        private System.Windows.Forms.Label lab_TenSV;
        private System.Windows.Forms.Label lab_MaSV;
        private System.Windows.Forms.GroupBox grbutton;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox lstSinhVien;
    }
}

