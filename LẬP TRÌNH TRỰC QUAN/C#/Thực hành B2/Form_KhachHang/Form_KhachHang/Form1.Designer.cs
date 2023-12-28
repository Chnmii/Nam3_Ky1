namespace Form_KhachHang
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
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdPL = new System.Windows.Forms.RadioButton();
            this.rdThuong = new System.Windows.Forms.RadioButton();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.cbTGian = new System.Windows.Forms.ComboBox();
            this.lblTGian = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblTien = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbDsKH = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgay);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.cbTGian);
            this.groupBox1.Controls.Add(this.lblTGian);
            this.groupBox1.Controls.Add(this.lblNgay);
            this.groupBox1.Controls.Add(this.lblTien);
            this.groupBox1.Controls.Add(this.lblDC);
            this.groupBox1.Controls.Add(this.lblTenKH);
            this.groupBox1.Controls.Add(this.lblMaKH);
            this.groupBox1.Location = new System.Drawing.Point(30, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(142, 250);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(148, 24);
            this.dtNgay.TabIndex = 15;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNew.Location = new System.Drawing.Point(237, 455);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 37);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(85, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 37);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm vào";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdPL);
            this.groupBox2.Controls.Add(this.rdThuong);
            this.groupBox2.Location = new System.Drawing.Point(37, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 82);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại tiết kiệm : ";
            // 
            // rdPL
            // 
            this.rdPL.AutoSize = true;
            this.rdPL.Location = new System.Drawing.Point(185, 40);
            this.rdPL.Name = "rdPL";
            this.rdPL.Size = new System.Drawing.Size(83, 22);
            this.rdPL.TabIndex = 1;
            this.rdPL.TabStop = true;
            this.rdPL.Text = "Phát lộc";
            this.rdPL.UseVisualStyleBackColor = true;
            // 
            // rdThuong
            // 
            this.rdThuong.AutoSize = true;
            this.rdThuong.Location = new System.Drawing.Point(21, 40);
            this.rdThuong.Name = "rdThuong";
            this.rdThuong.Size = new System.Drawing.Size(79, 22);
            this.rdThuong.TabIndex = 0;
            this.rdThuong.TabStop = true;
            this.rdThuong.Text = "Thường";
            this.rdThuong.UseVisualStyleBackColor = true;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(142, 201);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(148, 24);
            this.txtTien.TabIndex = 10;
            this.txtTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(142, 147);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(184, 24);
            this.txtDC.TabIndex = 9;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(142, 94);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(148, 24);
            this.txtTenKH.TabIndex = 8;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(142, 40);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(148, 24);
            this.txtMaKH.TabIndex = 7;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // cbTGian
            // 
            this.cbTGian.BackColor = System.Drawing.Color.White;
            this.cbTGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTGian.FormattingEnabled = true;
            this.cbTGian.Location = new System.Drawing.Point(142, 308);
            this.cbTGian.Name = "cbTGian";
            this.cbTGian.Size = new System.Drawing.Size(114, 26);
            this.cbTGian.TabIndex = 6;
            // 
            // lblTGian
            // 
            this.lblTGian.AutoSize = true;
            this.lblTGian.Location = new System.Drawing.Point(30, 312);
            this.lblTGian.Name = "lblTGian";
            this.lblTGian.Size = new System.Drawing.Size(103, 18);
            this.lblTGian.TabIndex = 5;
            this.lblTGian.Text = "Thời gian gửi : ";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(30, 255);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(77, 18);
            this.lblNgay.TabIndex = 4;
            this.lblNgay.Text = "Ngày gửi : ";
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(30, 205);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(89, 18);
            this.lblTien.TabIndex = 3;
            this.lblTien.Text = "Số tiền gửi : ";
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(30, 151);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(65, 18);
            this.lblDC.TabIndex = 2;
            this.lblDC.Text = "Địa chỉ : ";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(30, 98);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(89, 18);
            this.lblTenKH.TabIndex = 1;
            this.lblTenKH.Text = "Họ tên KH : ";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(30, 44);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(66, 18);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã KH : ";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFind.Location = new System.Drawing.Point(843, 457);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 35);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Location = new System.Drawing.Point(989, 457);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbDsKH);
            this.groupBox3.Location = new System.Drawing.Point(488, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 393);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khách hàng";
            // 
            // lbDsKH
            // 
            this.lbDsKH.BackColor = System.Drawing.Color.White;
            this.lbDsKH.FormattingEnabled = true;
            this.lbDsKH.ItemHeight = 18;
            this.lbDsKH.Location = new System.Drawing.Point(15, 40);
            this.lbDsKH.Name = "lbDsKH";
            this.lbDsKH.Size = new System.Drawing.Size(633, 328);
            this.lbDsKH.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1181, 578);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.ComboBox cbTGian;
        private System.Windows.Forms.Label lblTGian;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdPL;
        private System.Windows.Forms.RadioButton rdThuong;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbDsKH;
        private System.Windows.Forms.DateTimePicker dtNgay;
    }
}

