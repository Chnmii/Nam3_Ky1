using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frmCheDo
{
    public partial class Form1 : Form
    {
        ConnectData data = new ConnectData();
        public Form1()
        {
            InitializeComponent();
        }

        // Chế độ bảo hiểm
        void LoadData()
        {
            DataTable dtBH = data.DataReader("Select * from TblSoBaoHiem");
            dgvBH.DataSource = dtBH;
        }

        private void btnMoiBH_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        void ResetValue()
        {
            txtGhiChuBH.Text = "";
            txtMaBH.Text = "";
            txtMaNVBH.Text = "";
            txtMaLuongBH.Text = "";
            txtNoiCap.Text = "";
            txtGhiChuBH.Text = "";
            dtNgayCap.Value = DateTime.Today;
            txtMaNVBH.Focus();
            btnMoiBH.Enabled = true;
            btnLuuBH.Enabled = true;
            btnSuaBH.Enabled = false;
            btnBoQua.Enabled = false;
            btnXoaBH.Enabled = false;
            errBH.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtNgayCap.CustomFormat = " MM / dd / yyyy ";
            dtNgaySinh.CustomFormat = " MM / dd / yyyy ";
            dtNgayTroLai.CustomFormat = " MM / dd / yyyy ";
            dtNgayVeSinh.CustomFormat = " MM / dd / yyyy ";
            dtNgayVeSom.CustomFormat = " MM / dd / yyyy ";
            LoadData();
            LoadData1();
        }
        
        private void dgvBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNVBH.Text = dgvBH.CurrentRow.Cells[0].Value.ToString();
            txtMaLuongBH.Text = dgvBH.CurrentRow.Cells[1].Value.ToString();
            txtMaBH.Text = dgvBH.CurrentRow.Cells[2].Value.ToString();
            dtNgayCap.Text = dgvBH.CurrentRow.Cells[3].Value.ToString();
            txtNoiCap.Text = dgvBH.CurrentRow.Cells[4].Value.ToString();
            txtGhiChuBH.Text = dgvBH.CurrentRow.Cells[5].Value.ToString();
            btnMoiBH.Enabled = false;
            btnLuuBH.Enabled = false;
            btnSuaBH.Enabled = true;
            btnXoaBH.Enabled = true;
            btnBoQua.Enabled = true;
            btnThoatBH.Enabled = true;
        }

        private void btnLuuBH_Click(object sender, EventArgs e)
        {
            DataTable dtBH = data.DataReader("Select * from TblSoBaoHiem where MaNV='" + txtMaNVBH.Text + "'");
            if (dtBH.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã có, mời bạn nhập mã khác");
                txtMaNVBH.Focus();
                return;
            }
            //Thêm mới hàng vào DataBase 
            string sqlInsert = "insert into TblSoBaoHiem values('" + txtMaNVBH.Text + "','" + txtMaLuongBH.Text + "','" + txtMaBH.Text
                + "',N'" + dtNgayCap.Text + "',N'" + txtNoiCap.Text + "',N'" +
                txtGhiChuBH.Text + "')";
            data.DataChange(sqlInsert);
            LoadData();
            MessageBox.Show("Thêm mới thành công!");
            ResetValue();
        }


        private void btnSuaBH_Click(object sender, EventArgs e)
        {           
            data.DataChange("update TblSoBaoHiem set MaNV='" + txtMaNVBH.Text + "',MaLuong='" + txtMaLuongBH.Text 
                + "',NgayCapSo=N'" + dtNgayCap.Text + "',NoiCapSo=N'" + txtNoiCap.Text + "',GhiChu=N'" +
                txtGhiChuBH.Text + "' where MaSoBH='" + txtMaBH.Text + "'");
            LoadData();
            MessageBox.Show("Bạn đã sửa thành công!");
            ResetValue();
        }

        private void btnXoaBH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                data.DataChange("delete from TblSoBaoHiem where MaSoBH='" + txtMaBH.Text + "'");
                LoadData();
                MessageBox.Show("Bạn đã xoá thành công!");
                ResetValue();
            }
        
        }private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnThoatBH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }


        // Chế độ thai sản
        void LoadData1()
        {
            DataTable dtTS = data.DataReader("Select * from TblThaiSan");
            dgvTS.DataSource = dtTS;
        }
        void ResetValue1()
        {
            txtMaNVTS.Text = "";
            txtMaBP.Text = "";
            txtMaPhong.Text = "";
            txtHoTen.Text = "";
            txtGhiChuTS.Text = "";
            txtTroCap.Text = "";
            dtNgaySinh.Value = DateTime.Today;
            dtNgayTroLai.Value = DateTime.Today;
            dtNgayVeSinh.Value = DateTime.Today;
            dtNgayVeSom.Value = DateTime.Today;
            txtMaBP.Focus();
            btnMoiTS.Enabled = true;
            btnLuuTS.Enabled = true;
            btnSuaTS.Enabled = false;
            btnBoQuaTS.Enabled = false;
            btnXoaTS.Enabled = false;
        }


        private void btnMoiTS_Click(object sender, EventArgs e)
        {
            ResetValue1();
        }

        private void btnLuuTS_Click(object sender, EventArgs e)
        {
            DataTable dtTS = data.DataReader("Select * from TblThaiSan where MaNV='" + txtMaNVTS.Text + "'");
            if (dtTS.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã có, mời bạn nhập mã khác");
                txtMaNVTS.Focus();
                return;
            }
            //Thêm mới hàng vào DataBase 
            string sqlInsert1 = "insert into TblThaiSan values('" + txtMaBP.Text + "','" + txtMaPhong.Text + "','" + txtMaNVTS.Text 
                + "',N'" + txtHoTen.Text + "',N'" + dtNgaySinh.Text + "',N'" + dtNgayVeSom.Text + "',N'" + dtNgayVeSinh.Text
                + "',N'" + dtNgayTroLai.Text + "'," + int.Parse(txtTroCap.Text) + ",N'" + txtGhiChuTS.Text + "')";
            data.DataChange(sqlInsert1);
            LoadData1();
            MessageBox.Show("Thêm mới thành công");
            ResetValue1();
        }

        private void btnSuaTS_Click(object sender, EventArgs e)
        {
            data.DataChange("update TblThaiSan set MaBoPhan='" + txtMaBP.Text + "',MaPhong='" + txtMaPhong.Text +  
                  "',HoTen=N'" + txtHoTen.Text + "',NgaySinh=N'" + dtNgaySinh.Text + "',NgayVeSom=N'" + 
                dtNgayVeSom.Text + "',NgayNghiSinh=N'" + dtNgayVeSinh.Text + "',NgayLamTroLai=N'" + dtNgayTroLai.Text + 
                "',GhiChu=N'" + txtGhiChuBH.Text + "' where MaNV='" + txtMaNVTS.Text + "'");
            LoadData1();
            MessageBox.Show("Bạn đã sửa thành công!");
            ResetValue1();
        }

        private void btnBoQuaTS_Click(object sender, EventArgs e)
        {
            ResetValue1();
        }

        private void dgvTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBP.Text = dgvTS.CurrentRow.Cells[0].Value.ToString();
            txtMaPhong.Text = dgvTS.CurrentRow.Cells[1].Value.ToString();
            txtMaNVTS.Text = dgvTS.CurrentRow.Cells[2].Value.ToString();
            txtHoTen.Text = dgvTS.CurrentRow.Cells[3].Value.ToString();
            dtNgaySinh.Text = dgvTS.CurrentRow.Cells[4].Value.ToString();
            dtNgayVeSom.Text = dgvTS.CurrentRow.Cells[5].Value.ToString();
            dtNgayVeSinh.Text = dgvTS.CurrentRow.Cells[6].Value.ToString();
            dtNgayTroLai.Text = dgvTS.CurrentRow.Cells[7].Value.ToString();
            txtTroCap.Text = dgvTS.CurrentRow.Cells[8].Value.ToString();
            txtGhiChuTS.Text = dgvTS.CurrentRow.Cells[9].Value.ToString();
            btnMoiTS.Enabled = false;
            btnLuuTS.Enabled = false;
            btnSuaTS.Enabled = true;
            btnXoaTS.Enabled = true;
            btnBoQuaTS.Enabled = true;
            btnThoatTS.Enabled = true;
        }

        private void btnXoaTS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                data.DataChange("delete from TblThaiSan where MaNV='" + txtMaNVTS.Text + "'");
                LoadData1();
                MessageBox.Show("Bạn đã xoá thành công!");
                ResetValue1();
            }
        }

        private void btnThoatTS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
