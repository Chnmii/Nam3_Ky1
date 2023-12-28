namespace QL_KhachSan
{
    partial class frmCacBang
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
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.cbbCacBang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDS
            // 
            this.dgvDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDS.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Location = new System.Drawing.Point(56, 110);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.RowTemplate.Height = 24;
            this.dgvDS.Size = new System.Drawing.Size(932, 390);
            this.dgvDS.TabIndex = 14;
            // 
            // cbbCacBang
            // 
            this.cbbCacBang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCacBang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCacBang.FormattingEnabled = true;
            this.cbbCacBang.Items.AddRange(new object[] {
            "Bộ phận làm việc",
            "Chi tiết dịch vụ",
            "Chi tiết phòng đặt",
            "Chi tiết vật dụng",
            "Chức vụ",
            "Dịch vụ",
            "Dòng hoá đơn thanh toán",
            "HD dịch vụ",
            "Hoá đơn thanh toán",
            "Khách hàng",
            "Loại phòng",
            "Nhân viên",
            "Nhóm dịch vụ",
            "Phiếu đặt",
            "Phiếu thuê",
            "Phòng",
            "Vật dụng"});
            this.cbbCacBang.Location = new System.Drawing.Point(185, 58);
            this.cbbCacBang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbCacBang.Name = "cbbCacBang";
            this.cbbCacBang.Size = new System.Drawing.Size(302, 31);
            this.cbbCacBang.TabIndex = 13;
            this.cbbCacBang.SelectedIndexChanged += new System.EventHandler(this.cbbCacBang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên bảng :";
            // 
            // frmCacBang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 573);
            this.Controls.Add(this.dgvDS);
            this.Controls.Add(this.cbbCacBang);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCacBang";
            this.Text = "frmCacBang";
            this.Load += new System.EventHandler(this.frmCacBang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.ComboBox cbbCacBang;
        private System.Windows.Forms.Label label1;
    }
}