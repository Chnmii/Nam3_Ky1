using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanRuouBTL.Forms
{
    public partial class frmHDNhap : Form
    {
        Classes.CommonFunctions function = new Classes.CommonFunctions();
        Classes.ConnectDatabase data = new Classes.ConnectDatabase();
        public frmHDNhap()
        {
            InitializeComponent();
            DataTable dtNhanVien = data.DataReader("select * from tblNhanVien");
            DataTable dtNhaCC = data.DataReader("select * from tblNhaCungCap");
            DataTable dtHDNhap = data.DataReader("select * from tblHoaDonNhap");
            DataTable dtHang = data.DataReader("select * from tblHangHoa");
            function.FillCombobox(cbbMaNV, dtNhanVien, "MaNhanVien", "MaNhanVien");
            function.FillCombobox(cbbMaNCC, dtNhaCC, "MaNCC", "MaNCC");
            function.FillCombobox(cbbMaHang, dtHang, "MaHang", "MaHang");
            function.FillCombobox(cbbTKSoHDN, dtHDNhap, "SoHDN", "SoHDN");

        }

        private void frmHDNhap_Load(object sender, EventArgs e)
        {

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dtHDN = data.DataReader("select * from tblHoaDonNhap where SoHDN = '" + cbbTKSoHDN.Text + "'");
            DataTable dtChiTietHDN = data.DataReader("select tblCtHDN.MaHang," +
                "TenHang, tblCtHDN.SoLuong,GiaNhap,GiamGia,ThanhTien from tblCtHDN inner " +
                   "join tblHangHoa on tblCtHDN.MaHang = tblHangHoa.MaHang where SoHDN ='" + cbbTKSoHDN.Text + "'");
            txtMaHDN.Text = cbbTKSoHDN.Text;
            dtpNgayNhap.Text = dtHDN.Rows[0]["NgayNhap"].ToString();
            cbbMaNV.SelectedValue = dtHDN.Rows[0]["MaNhanVien"];
            cbbMaNCC.SelectedValue = dtHDN.Rows[0]["MaNCC"];
            dgvRuou.DataSource = dtChiTietHDN;
            lblTongTien.Text = "Tổng tiền : " + dtHDN.Rows[0]["TongTien"].ToString();
            
         
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNV = data.DataReader("select * from tblNhanVien where MaNhanVien = '" + cbbMaNV.SelectedValue + "'");
                txtTenNV.Text = dtNV.Rows[0]["TenNhanVien"].ToString();

            }
            catch
            {

            }
        }

        private void cbbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtncc = data.DataReader("select * from tblNhaCungCap where MaNCC = '" + cbbMaNCC.SelectedValue + "'");
                txtTenNCC.Text = dtncc.Rows[0]["TenNCC"].ToString();
                txtDiachi.Text = dtncc.Rows[0]["DiaChiNCC"].ToString();
                txtSDT.Text = dtncc.Rows[0]["SDT"].ToString();
            }
            catch
            {

            }
        }

        private void cbbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dthang = data.DataReader("select * from tblHangHoa where MaHang = '" + cbbMaHang.SelectedValue + "'");
                txtTenHang.Text = dthang.Rows[0]["TenHang"].ToString();
                txtDonGia.Text = dthang.Rows[0]["DonGiaNhap"].ToString();
            }
            catch
            {

            }

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn chỉ nhập số nguyên");
                e.Handled = true;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float sl, dg, gg, tt;
                if (txtGiamGia.Text.Trim() == "")
                    gg = 0;
                else
                    gg = float.Parse(txtGiamGia.Text);
                if (txtSoLuong.Text.Trim() == "")
                    sl = 0;
                else
                    sl = float.Parse(txtSoLuong.Text);
                dg = float.Parse(txtDonGia.Text);
                tt = dg * sl * (1 - gg / 100);
                txtThanhTien.Text = tt.ToString();
            }
            catch { }
                                                                                           
        }

        void ResetValue()
        {
            txtMaHDN.Text = "";
            txtTenHang.Text = "";
            dtpNgayNhap.Text = "";
            cbbMaHang.Text = "";
            cbbMaNCC.Text = "";
            cbbMaNV.Text = "";
            txtTenNCC.Text = "";
            txtTenNV.Text = "";
            txtThanhTien.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "";
            txtDonGia.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
            lblTongTien.Text = "";
            dgvRuou.DataSource = null;
              
        }    
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaHDN.Text = function.AutoCode("tblHoaDonNhap", "SoHDN", "HDN" +
                DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlinsertHDNhap;
            float slnhap, slco, tongtien;
            DateTime dtNgayNhap;
            //Kiểm tra tính đầy đủ của dữ liệu
            if (cbbMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có thông tin nhân viên bán");
                return;
            }
            if (cbbMaNCC.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có thông tin nhà cc");
                return;

            }
            if (cbbMaHang.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có thông sản phẩm");
                return;
            }
            if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng sản phẩm");
                txtSoLuong.Focus();
                return;
            }
            //Khi lưu hóa đơn xảy ra hai trường hợp. TH1: tblHDBan đã có hóa đơn với mã vừa sinh --> update lại tổng tiền
            //TH2: chưa có hóa đơn: insert hóa đơn
            dtNgayNhap = Convert.ToDateTime(dtpNgayNhap.Value.ToLongDateString());
            DataTable dtHDNhap = data.DataReader("Select * from tblHoaDonNhap where SoHDN='" + txtMaHDN.Text + "'");
            if (dtHDNhap.Rows.Count == 0)//chưa tồn tài hóa đơn
            {
                sqlinsertHDNhap = "insert into tblHoaDonNhap values('" + txtMaHDN.Text + "','" + cbbMaNCC.SelectedValue +
                    "','" + String.Format("{0:dd/MM/yyyy}", dtNgayNhap) + "','" + cbbMaNV.SelectedValue +
                    "','" + txtThanhTien.Text + "')";
                data.DataChange(sqlinsertHDNhap);
            }
            //tblHD đã tồn tại
            //1. Kiểm tra số lượng hàng 
            DataTable dtHang = data.DataReader("Select * from tblHangHoa where MaHang='" + cbbMaHang.SelectedValue + "'");
            slco = float.Parse(dtHang.Rows[0]["SoLuong"].ToString());
            slnhap = float.Parse(txtSoLuong.Text);
            
            slco = slco + slnhap;
            //insert vào bảng tblChiTiet
            data.DataReader("insert into tblCtHDN values('" + txtMaHDN.Text + "','" + cbbMaHang.SelectedValue +
                "'," + (int)slnhap + ",'" + txtGiamGia.Text + "','" + txtThanhTien.Text + "')");
            //update lại bảng tblHang
            data.DataReader("update tblHang set SoLuong=" + (int)slco + " where MaHang='" + cbbMaHang.SelectedValue + "'");
            //update tblcHDBan cho tong tien
            DataTable dtChiTiet = data.DataReader("Select tblCtHDN.MaHang," +
               "TenHang,tblCtHDN.SoLuong,DonGiaNhap,GiamGia,ThanhTien from tblCtHDN inner " +
               "join tblHangHoa on tblCtHDN.MaHang=tblHangHoa.MaHang where SoHDN='" + txtMaHDN.Text + "'");
            tongtien = 0;
            for (int i = 0; i < dtChiTiet.Rows.Count; i++)
            {
                tongtien = tongtien + float.Parse(dtChiTiet.Rows[i]["ThanhTien"].ToString());
            }
            data.DataReader("update tblHoaDonNhap set TongTien='" + tongtien.ToString() + "' where SoHDN='" + txtMaHDN.Text + "'");
            //Hiển thị dữ liệu lên dataGridView
            dgvRuou.DataSource = dtChiTiet;
            lblTongTien.Text = "Tổng tiền:" + tongtien.ToString();
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn hủy hóa đơn này không? ", "Messager",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                // hủy hóa đơn
                // 1. update lại so lượng hàng trong bảng tblHangHoa
                float slco, slnhap;
                for(int i=0;i< dgvRuou.Rows.Count -1; i++)
                {
                    DataTable dthang = data.DataReader("select * from tblHangHoa where MaHang = ' " + dgvRuou.Rows[i].Cells[0].Value.ToString() + "'");
                    slco = int.Parse(dthang.Rows[0]["SoLuong"].ToString());
                    slnhap = int.Parse(dgvRuou.Rows[i].Cells[2].Value.ToString());
                    slco = slco - slnhap;
                    data.DataChange("update tblHangHoa set SoLuong=" + (int)slco + "where MaHang='" + dgvRuou.Rows[i].Cells[0].Value.ToString() + "'");

                }
                // 2 Xóa hóa đơn ra khỏi database
                data.DataChange("delete tblHoaDonNhap where SoHDN ='" + txtMaHDN.Text + "'");
                ResetValue();
            }    

        }



        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chăn muốn thoát không?", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgvRuou_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn trả lại sản phẩm này không?", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //1 update lại số lượng hàng trong bảng tblHangHoa
                float slco, slnhap;
                DataTable dthang = data.DataReader("select * from tblHangHoa where MaHang ='" + dgvRuou.CurrentRow.Cells[0].Value.ToString());
                slco = int.Parse(dthang.Rows[0]["SoLuong"].ToString());
                slnhap = int.Parse(dgvRuou.CurrentRow.Cells[2].Value.ToString());
                slco = slco - slnhap;
                data.DataChange("update tblHangHoa set SoLuong=" + (int)slco + "where MaHang='" + dgvRuou.CurrentRow.Cells[0].Value.ToString() + "'");

                // 2 Xóa hóa đơn ra khỏi database
                data.DataChange("delete tblCtHDN where SoHDN ='" + txtMaHDN.Text + "' and MaHang ='" + dgvRuou.CurrentRow.Cells[0].Value.ToString()+ "'");

                // 3 tính lại tổng tiền hóa đơn
                // update lại tblHoaDonNhap cho tongtien
                DataTable dtchitiet = data.DataReader("select * from tblCtHDN.MaHang," + "TenHang, tblCtHDN.SoLuong, DonGiaNhap, GiamGia, ThanhTien from tblCtHDN inner join tblHangHoa on tblCtHDN.MaHang = tblHangHoa.MaHang where SoHDN ='" + txtMaHDN.Text + "'");
                if(dtchitiet.Rows.Count == 0) // khi đã xoa het các chi tiet hoa dơn thi xoa luon hoa don
                {
                    data.DataChange("delete tblHoaDonNhap where SoHDN ='" + txtMaHDN.Text + "'");
                    return;
                }
                float tongtien = 0;
                for(int i=0;i<dtchitiet.Rows.Count; i++)
                {
                    tongtien = tongtien + float.Parse(dtchitiet.Rows[i]["ThanhTien"].ToString());

                }

                data.DataChange("update tblHoaDonNhap set TongTien = '" + tongtien.ToString() + "' where SoHDN ='" + txtMaHDN.Text + "'");

                // hiển thị dữ liệu lên dataGridView
                dgvRuou.DataSource = dtchitiet;
                lblTongTien.Text = "Tổng tiền: " + tongtien.ToString();

            }

        }

      /*  private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
         
            //Thêm
           
                    //trùng
                    sql = "select * from tblHoaDonNhap where SoHDN = '" + txtMaHDN.Text + "'";
                    DataTable dtsp = data.DataReader(sql);
                    if (dtsp.Rows.Count > 0)
                    {
                        
                      
                        return;
                    }
                   
                
                //Insert vao CSDL                
                sql = "INSERT  INTO  tblHoaDonNhap VALUES(N'"
                    + txtMaHDN.Text + "',N'" + txt.Text + "',N'" + rbtn + "','" +
                        dtpNgaySinh.Value.Date + "',N'" + txtDiachi.Text + "','" + int.Parse(txtSdt.Text) + "')";
            
        }*/
    }
}
