using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{  
    public partial class frmCacBang : Form
    {
        Classes.ConnectData dtbase = new Classes.ConnectData();

        public frmCacBang()
        {
            InitializeComponent();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void SetFontAndColors()
        {
            this.dgvDS.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        private void cbbCacBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] TenBang = new string[] {"BOPHANLAMVIEC", "CHITIETDICHVU", "CHITIETPHONGDAT", "CHITIETVD",
            "CHUCVU", "DICHVU", "DONGHDTT", "HDDV", "HOADONTT", "KHACHHANG", "LOAIPHONG", "NHANVIEN", "NHOMDICHVU",
            "PHIEUDAT", "PHIEUTHUE", "PHONG", "VATDUNG"};

            dgvDS.DataSource = dtbase.ReadData("select * from " + TenBang[cbbCacBang.SelectedIndex+1]);

        }

        private void frmCacBang_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
        }
    }
}
