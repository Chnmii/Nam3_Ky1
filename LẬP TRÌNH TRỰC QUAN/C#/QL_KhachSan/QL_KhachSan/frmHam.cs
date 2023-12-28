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
    public partial class frmHam : Form
    {
        public frmHam()
        {
            InitializeComponent();
        }

        Classes.ConnectData dtbase = new Classes.ConnectData();

        private void picThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void SetFontAndColors()
        {
            this.dgvHam.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        private void ResetTextBox(bool txt1, bool txt2, bool dt)
        {
            txtGiaTri.Enabled = txt1;
            txtGiaTri2.Enabled = txt2;
            dtNgay.Enabled = dt;
            dgvHam.DataSource = null;
            txtGiaTri.Text = txtGiaTri2.Text = "";
        }

        private void cbbHam_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool[,] txtArr = new bool[6, 3]
            { {false, false, true },
              {true, false, false },
              {true, true, false },
              {true, false, false },
              {true, false, false},
              {true, false, false},

            };

            ResetTextBox(txtArr[cbbHam.SelectedIndex, 0], txtArr[cbbHam.SelectedIndex, 1], txtArr[cbbHam.SelectedIndex, 2]);

        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if (cbbHam.Text == "Danh sách khách hàng sẽ đến khách sạn vào ngày: ...")
            {
                dgvHam.DataSource = dtbase.ReadData("Select * from BTL_F_C1(N'" + String.Format("{0:u}", dtNgay.Value.Date) + "')");
            }
            if (cbbHam.Text == "Các mã hóa đơn dịch vụ hoặc mã hóa đơn thanh toán có bao gồm mã dịch vụ : ...")
            {
                dgvHam.DataSource = dtbase.ReadData("Select * from BTL_F_C2(N'" + txtGiaTri.Text + "')");
            }
            if (cbbHam.Text == "Bảng thống kê tiền thu được từ các loại phòng của khách sạn trong tháng: ...")
            {
                dgvHam.DataSource = dtbase.ReadData("Select * from BTL_F_C3(N'" + txtGiaTri.Text + "', N'" + txtGiaTri2.Text + "')" );
            }
            if (cbbHam.Text == "Các hóa đơn dịch vụ do nhân viên nam lập và tổng tiền của các hóa đơn dịch vụ đó trong năm: ...")
            {
                dgvHam.DataSource = dtbase.ReadData("Select * from BTL_F_C4(N'" + txtGiaTri.Text + "')");
            }
            if (cbbHam.Text == "Top 2 phòng của khách sạn có số lượt thuê cao nhất có diện tích lớn hơn diện tích: ...")
            {
                dgvHam.DataSource = dtbase.ReadData("Select * from BTL_F_C5(N'" + txtGiaTri.Text + "')");
            }
            if (cbbHam.Text == "Danh sách các hóa đơn, thời gian xuất hóa đơn và tổng trị giá các hóa đơn đã thanh toán của khách hàng có mã: ...")
            {
                dgvHam.DataSource = dtbase.ReadData("Select * from BTL_F_C6(N'" + txtGiaTri.Text + "')");
            }
            
        }

        private void frmHam_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
        }
    }
}
