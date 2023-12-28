using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyBanHang.Forms
{
    public partial class frmHDBan : Form
    {
        Classes.CommonFunctions functions=new Classes.CommonFunctions();
        Classes.ConnectData data=new Classes.ConnectData();
        public frmHDBan()
        {
            InitializeComponent();
            //Fill data in comboBoxes
            DataTable dtNhanVien = data.ReadData("Select * from tblNhanVien");
            DataTable dtKH = data.ReadData("Select * from tblKhach");
            DataTable dtHang = data.ReadData("Select * from tblHang");
            DataTable dtHDBan = data.ReadData("Select * from tblHDBan");
            functions.FillComboBox(cbomaNV, dtNhanVien, "MaNhanVien", "MaNhanVien");
            functions.FillComboBox(cboMaKhach, dtKH, "MaKhach", "MaKhach");
            functions.FillComboBox(cboMaHang, dtHang, "MaHang", "MaHang");
            functions.FillComboBox(cboMaHD, dtHDBan, "MaHDBan", "MaHDBan");
        }

        private void frmHDBan_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dtHDBan = data.ReadData("Select * from tblHDBan where MaHDBan='" + cboMaHD.Text + "'");
            DataTable dtChiTietHDBan = data.ReadData("Select tblChiTietHDBan.MaHang,"+
                "TenHang,tblChiTietHDBan.SoLuong,DonGiaBan,GiamGia,ThanhTien from tblChiTietHDBan inner "+
                "join tblHang on tblChiTietHDBan.MaHang=tblHang.MaHang where MaHDBan='"+cboMaHD.Text+"'");
            txtMaHD.Text = cboMaHD.Text;
            dateNgayBan.Text = dtHDBan.Rows[0]["NgayBan"].ToString();
            cbomaNV.SelectedValue = dtHDBan.Rows[0]["MaNhanVien"];
            cboMaKhach.SelectedValue= dtHDBan.Rows[0]["MaKhach"];
            dgvChiTietHD.DataSource = dtChiTietHDBan;
            lblTongTien.Text="Tổng tiền:"+ dtHDBan.Rows[0]["TongTien"].ToString();
        }

        private void cbomaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNV = data.ReadData("Select TenNhanVien from tblNhanVien where MaNhanVien='" + cbomaNV.SelectedValue + "'");
                txtTenNV.Text = dtNV.Rows[0]["TenNhanVien"].ToString();
            }
            catch
            {

            }
            
        }

        private void cboMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtKH = data.ReadData("Select * from tblKhach where MaKhach='" + cboMaKhach.SelectedValue + "'");
                txtTenKhach.Text = dtKH.Rows[0]["TenKhach"].ToString();
                txtDiaChi.Text = dtKH.Rows[0]["diachi"].ToString();
                txtDienThoai.Text = dtKH.Rows[0]["DienThoai"].ToString();
            }
            catch { }
            
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtHang = data.ReadData("Select * from tblHang where MaHang='" + cboMaHang.SelectedValue + "'");
                txtTenHang.Text = dtHang.Rows[0]["TenHang"].ToString();
                txtDonGia.Text = dtHang.Rows[0]["DonGiaBan"].ToString();
            }
            catch { }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaHD.Text = functions.AutoCode("tblHDBan", "MaHDBan", "HDB" + 
                DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString()+DateTime.Now.Year.ToString());
        }
        void ResetValue()
        {
            txtMaHD.Text = "";
            dateNgayBan.Text = "";
            cboMaHang.Text = "";
            cbomaNV.Text = "";
            cboMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtTenHang.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";
            lblTongTien.Text = "";
            dgvChiTietHD.DataSource = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlinsertHDBan;
            float slmua, slcon, tongtien;
            DateTime dtNgayBan;
            //Kiểm tra tính đầy đủ của dữ liệu
            if(cbomaNV.Text.Trim()=="")
            {
                MessageBox.Show("Chưa có thông tin nhân viên bán");
                return;
            }
            if (cboMaKhach.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có thông tin khách hàng");
                return;

            }    
            if(cboMaHang.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có thông sản phẩm");
                return;
            }    
            if(txtSoLuong.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập số lượng sản phẩm");
                txtSoLuong.Focus();
                return;
            }
            //Khi lưu hóa đơn xảy ra hai trường hợp. TH1: tblHDBan đã có hóa đơn với mã vừa sinh --> update lại tổng tiền
            //TH2: chưa có hóa đơn: insert hóa đơn
            dtNgayBan = Convert.ToDateTime( dateNgayBan.Value.ToLongDateString());
            DataTable dtHDBan = data.ReadData("Select * from tblHDBan where MaHDBan='" + txtMaHD.Text + "'");
            if(dtHDBan.Rows.Count==0)//chưa tồn tài hóa đơn
            {
                sqlinsertHDBan = "insert into tblHDBan values('"+txtMaHD.Text+"','"+cbomaNV.SelectedValue+
                    "','"+String.Format("{0:MM/dd/yyyy}",dtNgayBan)+"','"+cboMaKhach.SelectedValue+
                    "','"+txtThanhTien.Text+"')";
                data.UpdateData(sqlinsertHDBan);
            }
            //tblHD đã tồn tại
            //1. Kiểm tra số lượng hàng còn không
            DataTable dtHang = data.ReadData("Select * from tblhang where MaHang='" + cboMaHang.SelectedValue + "'");
            slcon = float.Parse( dtHang.Rows[0]["SoLuong"].ToString());
            slmua = float.Parse(txtSoLuong.Text);
            if(slcon < slmua)
            {
                MessageBox.Show("Không còn đủ số lượng. Sản phẩm " + txtTenHang.Text + " chỉ còn " + slcon);
                txtSoLuong.Focus();
                return;
            }
            slcon = slcon - slmua;
            //insert vào bảng tblChiTiet
            data.UpdateData("insert into tblChiTietHDBan values('"+txtMaHD.Text+"','"+cboMaHang.SelectedValue+
                "',"+(int)slmua+",'"+txtGiamGia.Text+"','"+txtThanhTien.Text+"')");
            //update lại bảng tblHang
            data.UpdateData("update tblHang set SoLuong="+(int)slcon+" where MaHang='"+cboMaHang.SelectedValue+"'");
            //update tblcHDBan cho tong tien
            DataTable dtChiTiet = data.ReadData("Select tblChiTietHDBan.MaHang," +
               "TenHang,tblChiTietHDBan.SoLuong,DonGiaBan,GiamGia,ThanhTien from tblChiTietHDBan inner " +
               "join tblHang on tblChiTietHDBan.MaHang=tblHang.MaHang where MaHDBan='" + txtMaHD.Text + "'");
            tongtien = 0;
            for(int i=0;i<dtChiTiet.Rows.Count;i++)
            {
                tongtien = tongtien + float.Parse( dtChiTiet.Rows[i]["ThanhTien"].ToString());
            }
            data.UpdateData("update tblHDBan set TongTien='" + tongtien.ToString() + "' where MaHDBan='" + txtMaHD.Text + "'");
            //Hiển thị dữ liệu lên dataGridView
            dgvChiTietHD.DataSource = dtChiTiet;
            lblTongTien.Text = "Tổng tiền:" + tongtien.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn hủy hóa đơn này không?","Messager",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)//Hủy hóa đơn
            {
                //1. Update lại số lượng hàng trong bảng tblHang
                float slcon, slmua;
                for (int i = 0; i < dgvChiTietHD.Rows.Count - 1; i++)
                {
                    DataTable dtHang = data.ReadData("Select * from tblHang where MaHang='" +
                        dgvChiTietHD.Rows[i].Cells[0].Value.ToString() + "'");
                    slcon = float.Parse(dtHang.Rows[0]["SoLuong"].ToString());
                    //slmua = float.Parse(dgvChiTietHD.Rows[i].Cells[2].Value.ToString());
                    slcon = slcon + slmua;
                    data.UpdateData("update tblHang set SoLuong=" + (int)slcon + " where MaHang='" +
                        dgvChiTietHD.Rows[i].Cells[0].Value.ToString() + "'");
                }
                //2.Xóa hóa đơn ra khỏi dataBase
                data.UpdateData("delete tblHDBan where MaHDBan='" + txtMaHD.Text + "'");
                ResetValue();
            }
              
        }

        private void dgvChiTietHD_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trả lại sản phẩm này không?", "Messager",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//Hủy SP
            {
                //1. Update lại số lượng hàng trong bảng tblHang
                float slcon, slmua;
               DataTable dtHang = data.ReadData("Select * from tblHang where MaHang='" + 
                   dgvChiTietHD.CurrentRow.Cells[0].Value.ToString() + "'");
               slcon = float.Parse(dtHang.Rows[0]["SoLuong"].ToString());
               slmua = float.Parse(dgvChiTietHD.CurrentRow.Cells[2].Value.ToString());
               slcon = slcon + slmua;
               data.UpdateData("update tblHang set SoLuong=" + (int)slcon + " where MaHang='" + 
                   dgvChiTietHD.CurrentRow.Cells[0].Value.ToString() + "'");
                
                //2.Xóa ChiTiet ra khỏi dataBase
                data.UpdateData("delete tblChiTietHDBan where MaHDBan='" + txtMaHD.Text + "' and MaHang='" + 
                    dgvChiTietHD.CurrentRow.Cells[0].Value.ToString() + "'");
                //3. Tính lại tổng tiền hóa đơn
                //update tblcHDBan cho tong tien
                DataTable dtChiTiet = data.ReadData("Select tblChiTietHDBan.MaHang," +
                   "TenHang,tblChiTietHDBan.SoLuong,DonGiaBan,GiamGia,ThanhTien from tblChiTietHDBan inner " +
                   "join tblHang on tblChiTietHDBan.MaHang=tblHang.MaHang where MaHDBan='" + txtMaHD.Text + "'");
                if(dtChiTiet.Rows.Count==0) //Khi da xoa het cac chi tiet hoa don thi xoa luon hoa don
                {
                    data.UpdateData("delete tblHDBan where MaHDBan='" + txtMaHD.Text + "'");
                    return;
                }
                float tongtien = 0;
                for (int i = 0; i < dtChiTiet.Rows.Count; i++)
                {
                    tongtien = tongtien + float.Parse(dtChiTiet.Rows[i]["ThanhTien"].ToString());
                }
                data.UpdateData("update tblHDBan set TongTien='" + tongtien.ToString() + "' where MaHDBan='" + 
                    txtMaHD.Text + "'");
                //Hiển thị dữ liệu lên dataGridView
                dgvChiTietHD.DataSource = dtChiTiet;
                lblTongTien.Text = "Tổng tiền:" + tongtien.ToString();
            }
        }

        

        private void btnIn_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1]; // dua con tro vao o A1
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "SIÊU THỊ MINI BÌNH AN";

            Excel.Range dc = (Excel.Range)exSheet.Cells[2, 1];
            dc.Font.Size = 15;
            dc.Font.Bold = true;
            dc.Font.Color = Color.Blue;
            dc.Value = "Số 156 - Hai Bà Trưng - Hà Nội";

            // In chu Hoa don ban
            exSheet.Range["D4"].Font.Size = 20;
            exSheet.Range["D4"].Font.Bold = true;
            exSheet.Range["D4"].Font.Color = Color.Red;
            exSheet.Range["D4"].Value = "HOÁ ĐƠN BÁN";

            // In cac thong tin chung
            exSheet.Range["A5:A8"].Font.Size = 12;
            exSheet.Range["A5"].Value = "Mã hoá đơn: " + txtMaHD.Text;
            exSheet.Range["A6"].Value = "Khách hàng: " + cboMaKhach.SelectedValue.ToString() + 
                " - " + txtTenKhach.Text;
            exSheet.Range["A7"].Value = "Địa chỉ: " + txtDiaChi.Text;
            exSheet.Range["A8"].Value = "Điện thoại: " + txtDienThoai.Text;

            // In dong tieu de
            exSheet.Range["A10:G10"].Font.Size = 12;
            exSheet.Range["A10:G10"].Font.Bold = true;
            exSheet.Range["A10"].Value = "STT";
            exSheet.Range["B10"].Value = "Mã hàng";
            exSheet.Range["C10"].Value = "Tên hàng";
            exSheet.Range["D10"].Value = "Số lượng";
            exSheet.Range["E10"].Value = "Đơn giá bán";
            exSheet.Range["F10"].Value = "Giảm giá";
            exSheet.Range["G10"].Value = "Thành tiền";

            // In danh sach chi tiet hoa don
            int dong = 11;

            for (int i = 0; i < dgvChiTietHD.Rows.Count-1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvChiTietHD.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvChiTietHD.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvChiTietHD.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvChiTietHD.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvChiTietHD.Rows[i].Cells[4].Value.ToString() + "%";
                exSheet.Range["G" + (dong + i).ToString()].Value = dgvChiTietHD.Rows[i].Cells[5].Value.ToString() + " VND";
            }
            dong = dong + dgvChiTietHD.Rows.Count;
            exSheet.Range["F" + dong.ToString()].Value = lblTongTien.Text + " VND";
            exSheet.Name = txtMaHD.Text;

            // Kich hoat file Excel hoat dong
            exBook.Activate();

            // Luu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx|All Files|*.*";
            saveFileDialog.FilterIndex = 2;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(saveFileDialog.FileName.ToLower());
            }
            exApp.Quit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Có hay không", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }    
        }
    }
}
