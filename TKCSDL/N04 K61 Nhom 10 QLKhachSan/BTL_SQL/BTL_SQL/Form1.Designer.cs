namespace BTL_SQL
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
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbds = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.DtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.txtSHD2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntt = new System.Windows.Forms.Button();
            this.bbtnTHD = new System.Windows.Forms.Button();
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.txtMKH = new System.Windows.Forms.TextBox();
            this.txtSHD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvsddv = new System.Windows.Forms.DataGridView();
            this.dtpnm = new System.Windows.Forms.DateTimePicker();
            this.nudsl = new System.Windows.Forms.NumericUpDown();
            this.cbbmdv = new System.Windows.Forms.ComboBox();
            this.cbbhd = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvthongke = new System.Windows.Forms.DataGridView();
            this.cbbtk = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvTTH = new System.Windows.Forms.DataGridView();
            this.cbbtth = new System.Windows.Forms.ComboBox();
            this.txtNGT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.dtntt = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsddv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsl)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvds);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbds);
            this.groupBox1.Location = new System.Drawing.Point(38, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // dgvds
            // 
            this.dgvds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Location = new System.Drawing.Point(6, 59);
            this.dgvds.Name = "dgvds";
            this.dgvds.Size = new System.Drawing.Size(496, 164);
            this.dgvds.TabIndex = 2;
            this.dgvds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvds_CellClick);
            this.dgvds.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvds_CellFormatting);
            this.dgvds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvds_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách:";
            // 
            // cbbds
            // 
            this.cbbds.FormattingEnabled = true;
            this.cbbds.Items.AddRange(new object[] {
            "",
            "Dịch Vụ",
            "Đặt Phòng",
            "Hoá Đơn",
            "Khách Hàng",
            "Nhân Viên",
            "Phòng",
            "Thiết Bị",
            "Chứa Thiết Bị"});
            this.cbbds.Location = new System.Drawing.Point(101, 19);
            this.cbbds.Name = "cbbds";
            this.cbbds.Size = new System.Drawing.Size(151, 21);
            this.cbbds.TabIndex = 0;
            this.cbbds.SelectedIndexChanged += new System.EventHandler(this.cbbds_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.DtpNgayDi);
            this.groupBox2.Controls.Add(this.dtpNgayDen);
            this.groupBox2.Controls.Add(this.txtSN);
            this.groupBox2.Controls.Add(this.txtMP);
            this.groupBox2.Controls.Add(this.txtSHD2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(347, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đặt Phòng:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(100, 219);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DtpNgayDi
            // 
            this.DtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNgayDi.Location = new System.Drawing.Point(100, 165);
            this.DtpNgayDi.Name = "DtpNgayDi";
            this.DtpNgayDi.Size = new System.Drawing.Size(135, 20);
            this.DtpNgayDi.TabIndex = 11;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDen.Location = new System.Drawing.Point(100, 138);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(135, 20);
            this.dtpNgayDen.TabIndex = 10;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(100, 108);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(135, 20);
            this.txtSN.TabIndex = 9;
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(100, 82);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(135, 20);
            this.txtMP.TabIndex = 8;
            // 
            // txtSHD2
            // 
            this.txtSHD2.Location = new System.Drawing.Point(100, 53);
            this.txtSHD2.Name = "txtSHD2";
            this.txtSHD2.Size = new System.Drawing.Size(135, 20);
            this.txtSHD2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày Đi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày Đến:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số Người:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Hoá Đơn:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btntt);
            this.groupBox3.Controls.Add(this.bbtnTHD);
            this.groupBox3.Controls.Add(this.txtMNV);
            this.groupBox3.Controls.Add(this.txtMKH);
            this.groupBox3.Controls.Add(this.txtSHD);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(38, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 141);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tạo hoá đơn:";
            // 
            // btntt
            // 
            this.btntt.Location = new System.Drawing.Point(172, 115);
            this.btntt.Name = "btntt";
            this.btntt.Size = new System.Drawing.Size(75, 23);
            this.btntt.TabIndex = 7;
            this.btntt.Text = "Thanh Toán";
            this.btntt.UseVisualStyleBackColor = true;
            this.btntt.Click += new System.EventHandler(this.btntt_Click);
            // 
            // bbtnTHD
            // 
            this.bbtnTHD.Location = new System.Drawing.Point(22, 115);
            this.bbtnTHD.Name = "bbtnTHD";
            this.bbtnTHD.Size = new System.Drawing.Size(75, 23);
            this.bbtnTHD.TabIndex = 6;
            this.bbtnTHD.Text = "Tạo HD";
            this.bbtnTHD.UseVisualStyleBackColor = true;
            this.bbtnTHD.Click += new System.EventHandler(this.bbtnTHD_Click);
            // 
            // txtMNV
            // 
            this.txtMNV.Location = new System.Drawing.Point(95, 80);
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(139, 20);
            this.txtMNV.TabIndex = 5;
            // 
            // txtMKH
            // 
            this.txtMKH.Location = new System.Drawing.Point(95, 52);
            this.txtMKH.Name = "txtMKH";
            this.txtMKH.Size = new System.Drawing.Size(139, 20);
            this.txtMKH.TabIndex = 4;
            // 
            // txtSHD
            // 
            this.txtSHD.Location = new System.Drawing.Point(95, 23);
            this.txtSHD.Name = "txtSHD";
            this.txtSHD.Size = new System.Drawing.Size(139, 20);
            this.txtSHD.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã NV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã KH:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số Hoá Đơn:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnadd);
            this.groupBox4.Controls.Add(this.dgvsddv);
            this.groupBox4.Controls.Add(this.dtpnm);
            this.groupBox4.Controls.Add(this.nudsl);
            this.groupBox4.Controls.Add(this.cbbmdv);
            this.groupBox4.Controls.Add(this.cbbhd);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(651, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 278);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sử Dụng Dịch Vụ:";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(137, 249);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvsddv
            // 
            this.dgvsddv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsddv.Location = new System.Drawing.Point(0, 89);
            this.dgvsddv.Name = "dgvsddv";
            this.dgvsddv.Size = new System.Drawing.Size(325, 153);
            this.dgvsddv.TabIndex = 8;
            // 
            // dtpnm
            // 
            this.dtpnm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnm.Location = new System.Drawing.Point(221, 47);
            this.dtpnm.Name = "dtpnm";
            this.dtpnm.Size = new System.Drawing.Size(89, 20);
            this.dtpnm.TabIndex = 7;
            // 
            // nudsl
            // 
            this.nudsl.Location = new System.Drawing.Point(221, 20);
            this.nudsl.Name = "nudsl";
            this.nudsl.Size = new System.Drawing.Size(89, 20);
            this.nudsl.TabIndex = 6;
            // 
            // cbbmdv
            // 
            this.cbbmdv.FormattingEnabled = true;
            this.cbbmdv.Location = new System.Drawing.Point(69, 47);
            this.cbbmdv.Name = "cbbmdv";
            this.cbbmdv.Size = new System.Drawing.Size(81, 21);
            this.cbbmdv.TabIndex = 5;
            // 
            // cbbhd
            // 
            this.cbbhd.FormattingEnabled = true;
            this.cbbhd.Location = new System.Drawing.Point(69, 20);
            this.cbbhd.Name = "cbbhd";
            this.cbbhd.Size = new System.Drawing.Size(81, 21);
            this.cbbhd.TabIndex = 4;
            this.cbbhd.SelectedIndexChanged += new System.EventHandler(this.cbbhd_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(156, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Ngày Mua:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(156, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Số Lượng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mã DV:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số HĐ:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvthongke);
            this.groupBox5.Controls.Add(this.cbbtk);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(553, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(429, 229);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "View:";
            // 
            // dgvthongke
            // 
            this.dgvthongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongke.Location = new System.Drawing.Point(7, 59);
            this.dgvthongke.Name = "dgvthongke";
            this.dgvthongke.Size = new System.Drawing.Size(416, 164);
            this.dgvthongke.TabIndex = 2;
            // 
            // cbbtk
            // 
            this.cbbtk.FormattingEnabled = true;
            this.cbbtk.Items.AddRange(new object[] {
            "",
            "Khách hàng ghé thăm nhiều nhất",
            "Hoá đơn có tổng tiền lớn nhất",
            "Nhân viên có doanh thua cao nhất",
            "Báo cáo số lượng khách theo tháng năm 2022",
            "Tháng có nhiều khách nhất",
            "Thông tin nhưng nhân viên có địa chỉ ở Nam Định",
            "Thông tin thiết bị đang trong tình trạng Hỏng",
            "In ra tất cả các hóa đơn"});
            this.cbbtk.Location = new System.Drawing.Point(151, 18);
            this.cbbtk.Name = "cbbtk";
            this.cbbtk.Size = new System.Drawing.Size(159, 21);
            this.cbbtk.TabIndex = 1;
            this.cbbtk.SelectedIndexChanged += new System.EventHandler(this.cbbtk_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(65, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Thống kê:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtntt);
            this.groupBox6.Controls.Add(this.btnHienThi);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtNGT);
            this.groupBox6.Controls.Add(this.cbbtth);
            this.groupBox6.Controls.Add(this.dgvTTH);
            this.groupBox6.Location = new System.Drawing.Point(1, 532);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(981, 159);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hàm";
            // 
            // dgvTTH
            // 
            this.dgvTTH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTH.Location = new System.Drawing.Point(428, 9);
            this.dgvTTH.Name = "dgvTTH";
            this.dgvTTH.Size = new System.Drawing.Size(553, 150);
            this.dgvTTH.TabIndex = 0;
            // 
            // cbbtth
            // 
            this.cbbtth.FormattingEnabled = true;
            this.cbbtth.Items.AddRange(new object[] {
            "Hiển thị doanh thu và tổng hoá đơn của năm",
            "Hiển thị 5 nhân viên có doanh thu cao nhất trong tháng",
            "Hiển thị Khách Hàng có nhiều hoá đơn nhất trong ngày",
            "Hiển thị các phòng đã đặt do Khách Hàng có tên",
            "Hiển thị các nhân viên sinh năm",
            "Hiển thị Tiền phòng mà khách hàng đã thanh toán",
            "",
            "Hiển thị Tên phòng có ma khách hàng",
            "Hiển thị tên khách hàng và ngày thanh toán của mã phòng",
            "Hiển thị tên dịch vụ và số lượng của hoá đơn",
            "Hiển thị tên khách hàng của hoá đơn",
            "Hiển thị Mã khách hàng và tên khách hàng đến vào ngày",
            "Hiển thị Tên nhân viên và ngày thanh toán của hoá đơn"});
            this.cbbtth.Location = new System.Drawing.Point(70, 19);
            this.cbbtth.Name = "cbbtth";
            this.cbbtth.Size = new System.Drawing.Size(308, 21);
            this.cbbtth.TabIndex = 1;
            this.cbbtth.SelectedIndexChanged += new System.EventHandler(this.cbbtth_SelectedIndexChanged);
            // 
            // txtNGT
            // 
            this.txtNGT.Enabled = false;
            this.txtNGT.Location = new System.Drawing.Point(171, 46);
            this.txtNGT.Name = "txtNGT";
            this.txtNGT.Size = new System.Drawing.Size(100, 20);
            this.txtNGT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(101, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nhập giá trị:";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(160, 105);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 5;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // dtntt
            // 
            this.dtntt.Enabled = false;
            this.dtntt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtntt.Location = new System.Drawing.Point(171, 72);
            this.dtntt.Name = "dtntt";
            this.dtntt.Size = new System.Drawing.Size(100, 20);
            this.dtntt.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 696);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsddv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsl)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbds;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker DtpNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.TextBox txtSHD2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btntt;
        private System.Windows.Forms.Button bbtnTHD;
        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.TextBox txtMKH;
        private System.Windows.Forms.TextBox txtSHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpnm;
        private System.Windows.Forms.NumericUpDown nudsl;
        private System.Windows.Forms.ComboBox cbbmdv;
        private System.Windows.Forms.ComboBox cbbhd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvsddv;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvthongke;
        private System.Windows.Forms.ComboBox cbbtk;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNGT;
        private System.Windows.Forms.ComboBox cbbtth;
        private System.Windows.Forms.DataGridView dgvTTH;
        private System.Windows.Forms.DateTimePicker dtntt;
    }
}

