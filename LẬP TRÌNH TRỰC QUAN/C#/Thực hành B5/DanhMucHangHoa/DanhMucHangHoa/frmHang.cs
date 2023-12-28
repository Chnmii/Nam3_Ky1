using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DanhMucHangHoa
{
    public partial class frmHang : Form
    {
        public frmHang(string userName)
        {
            InitializeComponent();
            DataTable dtChatLieu = data.ReadData("Select * from tblChatLieu");
            functions.FillCombobox(cbbChatLieu, dtChatLieu, "TenChatLieu", "MaChatLieu");
            lblDangNhap.Text = userName;
        }

        public frmHang()
        {
            InitializeComponent();
        }

        Classes.CommonFunctions functions = new Classes.CommonFunctions();
        Classes.ConnectData data = new Classes.ConnectData();
        string fileAnh;

        private void frmHang_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Chất liệu";
            dgvHang.Columns[3].HeaderText = "Số lượng";
            dgvHang.Columns[4].HeaderText = "Đơn giá nhập";
            dgvHang.Columns[5].HeaderText = "Đơn giá bán";
            dgvHang.Columns[6].HeaderText = "Ảnh";
            dgvHang.Columns[7].HeaderText = "Ghi chú";
            ResetValue();
        }
        void LoadData()
        {
            DataTable dtHang = data.ReadData("Select * from tblHang");
            dgvHang.DataSource = dtHang;

        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvHang.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvHang.CurrentRow.Cells[1].Value.ToString();
            cbbChatLieu.SelectedValue = dgvHang.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvHang.CurrentRow.Cells[3].Value.ToString();
            txtDonGiaB.Text = dgvHang.CurrentRow.Cells[4].Value.ToString();
            txtDonGiaN.Text = dgvHang.CurrentRow.Cells[5].Value.ToString();
            fileAnh = dgvHang.CurrentRow.Cells[6].Value.ToString();
            try
            {
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\Images\\Products\\" + fileAnh);
            }
            catch
            {
                picAnh = null;
            }
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            string[] image;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPEG Images|*.jpg|PNG Images|*.png|All files|*.*";
            openFile.FilterIndex = 1;
            openFile.InitialDirectory = Application.StartupPath;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(openFile.FileName);
                image = openFile.FileName.ToString().Split('\\');
                fileAnh = image[image.Length - 1];
                //MessageBox.Show(fileAnh);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // kiem tra tinh hop le va day du du lieu
            // kiem tra co trung ma hang ko

            DataTable dtCheckHang = data.ReadData("Select * from tblHang where MaHang ='" + txtMa.Text + "'");
            if (dtCheckHang.Rows.Count > 0)
            {
                MessageBox.Show("Mã hàng đã có, mời bạn nhập mã khác");
                txtMa.Focus();
                return;
            }

            // them moi hang vao database
            string sqlInsert = "Insert into tblHang values('" + txtMa.Text + "',N'" + txtTen.Text + "','" + cbbChatLieu.SelectedValue + "'," + int.Parse(txtSoLuong.Text) + "," + float.Parse(txtDonGiaN.Text) + "," + float.Parse(txtDonGiaB.Text) + ",'" + fileAnh + "',N'" + txtGhiChu.Text + "')";

            data.UpdateData(sqlInsert);
            LoadData();
            MessageBox.Show("Thêm mới thành công!");
            ResetValue();
        }
        void ResetValue()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            cbbChatLieu.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaN.Text = "";
            txtDonGiaB.Text = "";
            picAnh.Image = null;
            fileAnh = "";
            txtGhiChu.Text = "";
            txtMa.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn phần tử để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá mặt hàng này không?", "Có hay không", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    data.UpdateData("Delete tblHang where MaHang='" + txtMa.Text + "'");
                    LoadData();
                    ResetValue();
                }
                catch
                {
                    MessageBox.Show("Bạn không thể xoá vì chúng liên quan đến các hoá đơn");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiem tra tinh day du va chinh xac cua du lieu
            // sua du lieu
            data.UpdateData("Update tblHang set TenHang = N'" + txtTen.Text + "', MaChatLieu = '" + cbbChatLieu.SelectedValue + "'," +
                " SoLuong = " + int.Parse(txtSoLuong.Text) + ", DonGiaNhap = " + float.Parse(txtDonGiaN.Text) + ", " +
                "DonGiaBan = " + float.Parse(txtDonGiaB.Text) + ", Anh = '" + fileAnh + "', GhiChu = N'" + txtGhiChu.Text + "'" +
                "where MaHang='" + txtMa.Text + "'");
            LoadData();
            ResetValue();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Có hay không", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
