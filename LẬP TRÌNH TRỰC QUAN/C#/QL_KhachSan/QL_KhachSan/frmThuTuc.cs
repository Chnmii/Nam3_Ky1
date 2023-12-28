using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class frmThuTuc : Form
    {
        public frmThuTuc()
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
            this.dgvThuTuc.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if (cbbThuTuc.Text == "Tạo thủ tục thêm dịch vụ vào cơ sở dữ liệu")
            {
                dgvThuTuc.DataSource = dtbase.ReadData("EXEC BTL_P_1 '" + txtGiaTri1.Text + "',N'" + txtGiaTri2.Text + "',N'" + txtGiaTri3.Text + "','" + txtGiaTri4.Text + "' SELECT * from DICHVU");
            }
            if (cbbThuTuc.Text == "Tạo thủ tục đầu vào mã khách hàng đầu ra là số lượng phòng khách đặt")
            {
                dgvThuTuc.DataSource = dtbase.ReadData("Declare	@SoPhong int Exec BTL_P_2 '" + txtGiaTri1.Text + "', @SoPhong out Select @SoPhong as SoPhongDaDat");
            }
            if (cbbThuTuc.Text == "Tạo thủ tục cập nhật tình trạng phòng")
            {
                dgvThuTuc.DataSource = dtbase.ReadData("exec BTL_P_3_ N'" + txtGiaTri1.Text + "', N'" + txtGiaTri2.Text + "' \nselect * from PHONG");
            }          
            if (cbbThuTuc.Text == "Tạo thủ tục là đầu vào là tháng, năm đầu ra là tổng tiền hóa đơn phòng của tháng và năm đó")
            {
                dgvThuTuc.DataSource = dtbase.ReadData("declare @Tong int exec BTL_P_4 '" + txtGiaTri1.Text + "','" + txtGiaTri2.Text + "', @Tong out select @Tong as TongTienHD");
            }
            if (cbbThuTuc.Text == "Tạo thủ tục xóa thông tin những khách hàng không đặt phòng cũng không sử dụng dịch vụ nào khác")
            {
                dgvThuTuc.DataSource = dtbase.ReadData("EXEC BTL_P_5 SELECT * FROM KHACHHANG");
            }
            if (cbbThuTuc.Text == "Tạo thủ tục có đầu vào là năm, đầu ra là doanh thu của khách sạn trong năm đó")
            {
                dgvThuTuc.DataSource = dtbase.ReadData("DECLARE @DoanhThu Money EXEC BTL_P_6 '" + txtGiaTri1.Text + "', @DoanhThu OUTPUT SELECT @DoanhThu AS DoanhThu");
            }
            
        }

        private void ResetTextBox(bool txt1, bool txt2, bool txt3, bool txt4)
        {
            txtGiaTri1.Enabled = txt1;
            txtGiaTri2.Enabled = txt2;
            txtGiaTri3.Enabled = txt3;
            txtGiaTri4.Enabled = txt4;
            dgvThuTuc.DataSource = null;
            txtGiaTri1.Text = txtGiaTri2.Text = txtGiaTri3.Text = txtGiaTri4.Text = "";
        }


        private void cbbThuTuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool[,] txtArr = new bool[6, 4] 
            { {true, true, true, true },
              {true, false, false, false },
              {true, true, false, false }, 
              {true, true, false, false },
              {false, false, false, false },
              {true, false, false, false },
              
            };

            ResetTextBox(txtArr[cbbThuTuc.SelectedIndex, 0], txtArr[cbbThuTuc.SelectedIndex, 1],
                        txtArr[cbbThuTuc.SelectedIndex, 2], txtArr[cbbThuTuc.SelectedIndex, 3]);

            switch (cbbThuTuc.SelectedIndex)
            {
                case 0:                   
                    dgvThuTuc.DataSource = dtbase.ReadData("Select * from DICHVU");
                    break;
                case 2:
                    dgvThuTuc.DataSource = dtbase.ReadData("Select * from PHONG");
                    break;
                case 4:
                    dgvThuTuc.DataSource = dtbase.ReadData("Select * from KHACHHANG");
                    break;
                default:
                    break;
            }

        }

        private void frmThuTuc_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
        }
    }
}
