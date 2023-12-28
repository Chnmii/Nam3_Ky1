namespace QL_KhachSan
{
    partial class frmHam
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
            this.dgvHam = new System.Windows.Forms.DataGridView();
            this.cbbHam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaTri2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHam
            // 
            this.dgvHam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHam.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvHam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHam.Location = new System.Drawing.Point(50, 207);
            this.dgvHam.Name = "dgvHam";
            this.dgvHam.RowHeadersWidth = 51;
            this.dgvHam.RowTemplate.Height = 24;
            this.dgvHam.Size = new System.Drawing.Size(932, 327);
            this.dgvHam.TabIndex = 10;
            // 
            // cbbHam
            // 
            this.cbbHam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbHam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHam.FormattingEnabled = true;
            this.cbbHam.Items.AddRange(new object[] {
            "Danh sách khách hàng sẽ đến khách sạn vào ngày: ...",
            "Các mã hóa đơn dịch vụ hoặc mã hóa đơn thanh toán có bao gồm mã dịch vụ : ...",
            "Bảng thống kê tiền thu được từ các loại phòng của khách sạn trong tháng: ...",
            "Các hóa đơn dịch vụ do nhân viên nam lập và tổng tiền của các hóa đơn dịch vụ đó " +
                "trong năm: ...",
            "Top 2 phòng của khách sạn có số lượt thuê cao nhất có diện tích lớn hơn diện tích" +
                ": ...",
            "Danh sách các hóa đơn, thời gian xuất hóa đơn và tổng trị giá các hóa đơn đã than" +
                "h toán của khách hàng có mã: ..."});
            this.cbbHam.Location = new System.Drawing.Point(179, 61);
            this.cbbHam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbHam.Name = "cbbHam";
            this.cbbHam.Size = new System.Drawing.Size(763, 31);
            this.cbbHam.TabIndex = 9;
            this.cbbHam.SelectedIndexChanged += new System.EventHandler(this.cbbHam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên hàm :";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri.Location = new System.Drawing.Point(179, 108);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(99, 30);
            this.txtGiaTri.TabIndex = 11;
            // 
            // dtNgay
            // 
            this.dtNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(179, 153);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(160, 30);
            this.dtNgay.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nhập giá trị :";
            // 
            // btnKetQua
            // 
            this.btnKetQua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.Location = new System.Drawing.Point(443, 135);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(120, 45);
            this.btnKetQua.TabIndex = 14;
            this.btnKetQua.Text = "Kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày :";
            // 
            // txtGiaTri2
            // 
            this.txtGiaTri2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri2.Location = new System.Drawing.Point(304, 108);
            this.txtGiaTri2.Name = "txtGiaTri2";
            this.txtGiaTri2.Size = new System.Drawing.Size(98, 30);
            this.txtGiaTri2.TabIndex = 16;
            // 
            // frmHam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 575);
            this.Controls.Add(this.txtGiaTri2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.dgvHam);
            this.Controls.Add(this.cbbHam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHam";
            this.Text = "frmHam";
            this.Load += new System.EventHandler(this.frmHam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHam;
        private System.Windows.Forms.ComboBox cbbHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaTri2;
    }
}