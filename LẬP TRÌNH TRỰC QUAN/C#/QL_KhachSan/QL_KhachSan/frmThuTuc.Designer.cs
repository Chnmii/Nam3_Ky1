namespace QL_KhachSan
{
    partial class frmThuTuc
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
            this.dgvThuTuc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaTri1 = new System.Windows.Forms.TextBox();
            this.cbbThuTuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.txtGiaTri2 = new System.Windows.Forms.TextBox();
            this.txtGiaTri3 = new System.Windows.Forms.TextBox();
            this.txtGiaTri4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuTuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThuTuc
            // 
            this.dgvThuTuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuTuc.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvThuTuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuTuc.Location = new System.Drawing.Point(42, 222);
            this.dgvThuTuc.Name = "dgvThuTuc";
            this.dgvThuTuc.RowHeadersWidth = 51;
            this.dgvThuTuc.RowTemplate.Height = 24;
            this.dgvThuTuc.Size = new System.Drawing.Size(932, 312);
            this.dgvThuTuc.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập giá trị :";
            // 
            // txtGiaTri1
            // 
            this.txtGiaTri1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri1.Location = new System.Drawing.Point(197, 111);
            this.txtGiaTri1.Name = "txtGiaTri1";
            this.txtGiaTri1.Size = new System.Drawing.Size(99, 30);
            this.txtGiaTri1.TabIndex = 16;
            // 
            // cbbThuTuc
            // 
            this.cbbThuTuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbThuTuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThuTuc.FormattingEnabled = true;
            this.cbbThuTuc.Items.AddRange(new object[] {
            "Tạo thủ tục thêm dịch vụ vào cơ sở dữ liệu",
            "Tạo thủ tục đầu vào mã khách hàng đầu ra là số lượng phòng khách đặt",
            "Tạo thủ tục cập nhật tình trạng phòng",
            "Tạo thủ tục là đầu vào là tháng, năm đầu ra là tổng tiền hóa đơn phòng của tháng " +
                "và năm đó",
            "Tạo thủ tục xóa thông tin những khách hàng không đặt phòng cũng không sử dụng dịc" +
                "h vụ nào khác",
            "Tạo thủ tục có đầu vào là năm, đầu ra là doanh thu của khách sạn trong năm đó"});
            this.cbbThuTuc.Location = new System.Drawing.Point(197, 64);
            this.cbbThuTuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbThuTuc.Name = "cbbThuTuc";
            this.cbbThuTuc.Size = new System.Drawing.Size(650, 31);
            this.cbbThuTuc.TabIndex = 15;
            this.cbbThuTuc.SelectedIndexChanged += new System.EventHandler(this.cbbThuTuc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên thủ tục :";
            // 
            // btnKetQua
            // 
            this.btnKetQua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.Location = new System.Drawing.Point(451, 156);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(99, 38);
            this.btnKetQua.TabIndex = 19;
            this.btnKetQua.Text = "Kết quả ";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // txtGiaTri2
            // 
            this.txtGiaTri2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri2.Location = new System.Drawing.Point(323, 111);
            this.txtGiaTri2.Name = "txtGiaTri2";
            this.txtGiaTri2.Size = new System.Drawing.Size(99, 30);
            this.txtGiaTri2.TabIndex = 20;
            // 
            // txtGiaTri3
            // 
            this.txtGiaTri3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri3.Location = new System.Drawing.Point(451, 111);
            this.txtGiaTri3.Name = "txtGiaTri3";
            this.txtGiaTri3.Size = new System.Drawing.Size(99, 30);
            this.txtGiaTri3.TabIndex = 21;
            // 
            // txtGiaTri4
            // 
            this.txtGiaTri4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri4.Location = new System.Drawing.Point(578, 111);
            this.txtGiaTri4.Name = "txtGiaTri4";
            this.txtGiaTri4.Size = new System.Drawing.Size(99, 30);
            this.txtGiaTri4.TabIndex = 22;
            // 
            // frmThuTuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 579);
            this.Controls.Add(this.txtGiaTri4);
            this.Controls.Add(this.txtGiaTri3);
            this.Controls.Add(this.txtGiaTri2);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGiaTri1);
            this.Controls.Add(this.cbbThuTuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThuTuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThuTuc";
            this.Text = "frmThuTuc";
            this.Load += new System.EventHandler(this.frmThuTuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuTuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvThuTuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaTri1;
        private System.Windows.Forms.ComboBox cbbThuTuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.TextBox txtGiaTri2;
        private System.Windows.Forms.TextBox txtGiaTri3;
        private System.Windows.Forms.TextBox txtGiaTri4;
    }
}