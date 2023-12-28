namespace Form_DatTour
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdNuaNgay = new System.Windows.Forms.RadioButton();
            this.rdCaNgay = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSL = new System.Windows.Forms.ComboBox();
            this.cbDoUong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblTien = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblDoUong = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstDanhsach = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.rdNuaNgay);
            this.groupBox1.Controls.Add(this.rdCaNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbSL);
            this.groupBox1.Controls.Add(this.cbDoUong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblTien);
            this.groupBox1.Controls.Add(this.lblSL);
            this.groupBox1.Controls.Add(this.lblDoUong);
            this.groupBox1.Controls.Add(this.lblGia);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Location = new System.Drawing.Point(44, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng đặt tour";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNew.Location = new System.Drawing.Point(219, 316);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 38);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdd.Location = new System.Drawing.Point(65, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 38);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm vào DS";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rdNuaNgay
            // 
            this.rdNuaNgay.AutoSize = true;
            this.rdNuaNgay.Location = new System.Drawing.Point(231, 111);
            this.rdNuaNgay.Name = "rdNuaNgay";
            this.rdNuaNgay.Size = new System.Drawing.Size(91, 22);
            this.rdNuaNgay.TabIndex = 13;
            this.rdNuaNgay.TabStop = true;
            this.rdNuaNgay.Text = "Nửa ngày";
            this.rdNuaNgay.UseVisualStyleBackColor = true;
            this.rdNuaNgay.Click += new System.EventHandler(this.rdNuaNgay_Click);
            // 
            // rdCaNgay
            // 
            this.rdCaNgay.AutoSize = true;
            this.rdCaNgay.Location = new System.Drawing.Point(40, 111);
            this.rdCaNgay.Name = "rdCaNgay";
            this.rdCaNgay.Size = new System.Drawing.Size(83, 22);
            this.rdCaNgay.TabIndex = 12;
            this.rdCaNgay.TabStop = true;
            this.rdCaNgay.Text = "Cả ngày";
            this.rdCaNgay.UseVisualStyleBackColor = true;
            this.rdCaNgay.Click += new System.EventHandler(this.rdCaNgay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "$";
            // 
            // cbSL
            // 
            this.cbSL.FormattingEnabled = true;
            this.cbSL.Location = new System.Drawing.Point(163, 262);
            this.cbSL.Name = "cbSL";
            this.cbSL.Size = new System.Drawing.Size(68, 26);
            this.cbSL.TabIndex = 10;
            this.cbSL.SelectedIndexChanged += new System.EventHandler(this.cbDoUong_SelectedIndexChanged);
            // 
            // cbDoUong
            // 
            this.cbDoUong.FormattingEnabled = true;
            this.cbDoUong.Location = new System.Drawing.Point(16, 262);
            this.cbDoUong.Name = "cbDoUong";
            this.cbDoUong.Size = new System.Drawing.Size(115, 26);
            this.cbDoUong.TabIndex = 9;
            this.cbDoUong.SelectedIndexChanged += new System.EventHandler(this.cbDoUong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "$";
            // 
            // txtTien
            // 
            this.txtTien.Enabled = false;
            this.txtTien.Location = new System.Drawing.Point(252, 262);
            this.txtTien.Name = "txtTien";
            this.txtTien.ReadOnly = true;
            this.txtTien.Size = new System.Drawing.Size(113, 24);
            this.txtTien.TabIndex = 7;
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(150, 166);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(137, 24);
            this.txtGia.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(107, 55);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(137, 24);
            this.txtHoTen.TabIndex = 5;
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(287, 232);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(36, 18);
            this.lblTien.TabIndex = 4;
            this.lblTien.Text = "Tiền";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(164, 232);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(67, 18);
            this.lblSL.TabIndex = 3;
            this.lblSL.Text = "Số lượng";
            // 
            // lblDoUong
            // 
            this.lblDoUong.AutoSize = true;
            this.lblDoUong.Location = new System.Drawing.Point(22, 232);
            this.lblDoUong.Name = "lblDoUong";
            this.lblDoUong.Size = new System.Drawing.Size(102, 18);
            this.lblDoUong.TabIndex = 2;
            this.lblDoUong.Text = "Chọn đồ uống";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(37, 169);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(110, 18);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Giá du thuyền : ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(37, 58);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(64, 18);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(190, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(9, 9);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstDanhsach);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(449, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 367);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khách hàng đặt tour";
            // 
            // lstDanhsach
            // 
            this.lstDanhsach.FormattingEnabled = true;
            this.lstDanhsach.ItemHeight = 18;
            this.lstDanhsach.Location = new System.Drawing.Point(15, 44);
            this.lstDanhsach.Name = "lstDanhsach";
            this.lstDanhsach.Size = new System.Drawing.Size(398, 310);
            this.lstDanhsach.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThoat.Location = new System.Drawing.Point(772, 449);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(928, 516);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Công Ty Du thuyền Hồ Tây";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdNuaNgay;
        private System.Windows.Forms.RadioButton rdCaNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSL;
        private System.Windows.Forms.ComboBox cbDoUong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblDoUong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstDanhsach;
        private System.Windows.Forms.Button btnThoat;
    }
}

