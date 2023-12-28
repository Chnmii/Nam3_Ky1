using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_SQL
{
    public partial class Form1 : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();

        public Form1()
        {
            InitializeComponent();
        }

        private void cbbds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbds.Text == "Hoá Đơn")
            {
                dgvds.DataSource = dtbase.DataReader("select * from tb_hoadon");
            }
            if (cbbds.Text == "Dịch Vụ")
            {
                dgvds.DataSource = dtbase.DataReader("select * from tb_dichvu");

            }
            if (cbbds.Text == "Khách Hàng")
            {
                dgvds.DataSource = dtbase.DataReader("select * from tb_khachhang");
            }
            if (cbbds.Text == "Thiết Bị")
            {
                dgvds.DataSource = dtbase.DataReader("select * from tb_tb");
            }
            if (cbbds.Text == "Phòng")
            {
                dgvds.DataSource = dtbase.DataReader("select * from tb_phong");
            }
            if (cbbds.Text == "Nhân Viên")
            {
                dgvds.DataSource = dtbase.DataReader("select * from tb_NhanVien");
            }
            if (cbbds.Text == "Đặt Phòng")
            {
                dgvds.DataSource = dtbase.DataReader("select * from tb_datphong");
            }
            if (cbbds.Text == "Chứa Thiết Bị")
            {
                dgvds.DataSource = dtbase.DataReader("select * from tb_ptb");
            }
        }
        int i;
        string a, b, c, d,  f, g, h;

        private void cbbtth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtth.Text == "Hiển thị doanh thu và tổng hoá đơn của năm")
            {
                dtntt.Enabled = false;
                txtNGT.Enabled = true;
            }
            if (cbbtth.Text == "Hiển thị 5 nhân viên có doanh thu cao nhất trong tháng")
            {
                dtntt.Enabled = false;
                txtNGT.Enabled = true;
            }
            if (cbbtth.Text == "Hiển thị Khách Hàng có nhiều hoá đơn nhất trong ngày")
            {
                dtntt.Enabled = false;
                txtNGT.Enabled = true;
            }
            if (cbbtth.Text == "Hiển thị các phòng đã đặt do Khách Hàng có tên")
            {
                dtntt.Enabled = false;
                txtNGT.Enabled = true;
            }
            if (cbbtth.Text == "Hiển thị các nhân viên sinh năm")
            {
                dtntt.Enabled = false;
                txtNGT.Enabled = true;
            }
            if (cbbtth.Text == "Hiển thị Tiền phòng mà khách hàng đã thanh toán")
            {
                dtntt.Enabled = true;
                txtNGT.Enabled = true;
            }
            if (cbbtth.Text == "Hiển thị Tên phòng có ma khách hàng")
            {
                dtntt.Enabled = false;
                txtNGT.Enabled = true;
            }
            if (cbbtth.Text == "Hiển thị tên khách hàng và ngày thanh toán của mã phòng")
            {
                dtntt.Enabled = false;
                txtNGT.Enabled = true;
            }
            if (cbbtth.Text == "Hiển thị tên dịch vụ và số lượng của hoá đơn")
            {
                dtntt.Enabled = false;
                txtNGT.Enabled = true;
            }
            if (cbbtth.Text == "Hiển thị tên khách hàng của hoá đơn")
            {
                dtntt.Enabled = false;
                txtNGT.Enabled = true;
            }
            if (cbbtth.Text == "Hiển thị Mã khách hàng và tên khách hàng đến vào ngày")
            {
                dtntt.Enabled = true;
                txtNGT.Enabled = false;
            }
            if (cbbtth.Text == "Hiển thị Tên nhân viên và ngày thanh toán của hoá đơn")
            {
                dtntt.Enabled = false;
                txtNGT.Enabled = true;
            }
            








        }
        Classes.Connectt cn = new Classes.Connectt();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        public void Loadhd()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select sohd from tb_hoadon ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbhd.DataSource = dt;
            cbbhd.ValueMember = "sohd";
        }
        public void Loaddv()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select madv from tb_dichvu ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbmdv.DataSource = dt;
            cbbmdv.ValueMember = "madv";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string sql = "insert into tb_sddv values (N'";
            sql += cbbhd.Text + "',N'" + cbbmdv.Text + "',N'" + nudsl.Value.ToString() + "',N'" + String.Format("{0:u}", dtpnm.Value.Date) + "')";
            dtbase.DataChange(sql);
            dgvsddv.DataSource = dtbase.DataReader("select * from tb_sddv where sohd = N'" + cbbhd.Text + "'");
        }

        private void cbbhd_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvsddv.DataSource = dtbase.DataReader("select * from tb_sddv where sohd = N'" + cbbhd.Text + "'");
        }

        private void btntt_Click(object sender, EventArgs e)
        {
            string sql = "update tb_hoadon set ngaythanhtoan = getdate() , tongtien = tiendv + tienphong where sohd = N'" + txtSHD.Text + "'";
            dtbase.DataChange(sql);
            dgvds.DataSource = dtbase.DataReader("select * from tb_hoadon");

        }

        private void dgvds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cbbds.Text == "Hoá Đơn")
            {
                txtSHD.Text = dgvds.CurrentRow.Cells[0].Value.ToString();
                txtMKH.Text = dgvds.CurrentRow.Cells[1].Value.ToString();
                txtMNV.Text = dgvds.CurrentRow.Cells[2].Value.ToString();
                txtSHD2.Text = dgvds.CurrentRow.Cells[0].Value.ToString();
            }if(cbbds.Text == "Phòng")
            {
                txtMP.Text = dgvds.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void dgvds_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(cbbds.Text == "Phòng")
            {
                foreach (DataGridViewRow row2 in dgvds.Rows)
                {
                    string row1 = Convert.ToString(row2.Cells[3].Value);
                    if (row1 == "Đã Sử Dụng")
                    {
                        row2.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (row1 == "Đang Bảo Trì")
                    {
                        row2.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
            
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if(cbbtth.Text == "Hiển thị doanh thu và tổng hoá đơn của năm")
            {
                dgvTTH.DataSource = dtbase.DataReader("Select * from cau1_1(N'" + txtNGT.Text + "')");
            }
            if (cbbtth.Text == "Hiển thị 5 nhân viên có doanh thu cao nhất trong tháng")
            {
                dgvTTH.DataSource = dtbase.DataReader("Select * from cau2(N'" + txtNGT.Text + "')");
            }
            if (cbbtth.Text == "Hiển thị Khách Hàng có nhiều hoá đơn nhất trong ngày")
            {
                dgvTTH.DataSource = dtbase.DataReader("Select * from cau3(N'" + txtNGT.Text + "')");
            }
            if (cbbtth.Text == "Hiển thị các phòng đã đặt do Khách Hàng có tên")
            {
                dgvTTH.DataSource = dtbase.DataReader("Select * from cau4(N'" + txtNGT.Text + "')");
            }
            if (cbbtth.Text == "Hiển thị các nhân viên sinh năm")
            {
                dgvTTH.DataSource = dtbase.DataReader("Select * from cau5(N'" + txtNGT.Text + "')");
            }
            if (cbbtth.Text == "Hiển thị Tiền phòng mà khách hàng đã thanh toán")
            {
                dgvTTH.DataSource = dtbase.DataReader("Select * from cau6(N'" + txtNGT.Text + "',N'"+ String.Format("{0:u}", dtntt.Value.Date) + "')");
            }
            if (cbbtth.Text == "Hiển thị Tên phòng có ma khách hàng")
            {
                dgvTTH.DataSource = dtbase.DataReader("exec cau1 N'" + txtNGT.Text + "'");
            }
            if (cbbtth.Text == "Hiển thị tên khách hàng và ngày thanh toán của mã phòng")
            {
                dgvTTH.DataSource = dtbase.DataReader("exec cau2proc N'" + txtNGT.Text + "'");
            }
            if (cbbtth.Text == "Hiển thị tên dịch vụ và số lượng của hoá đơn")
            {
                dgvTTH.DataSource = dtbase.DataReader("exec cau3proc N'" + txtNGT.Text + "'");
            }
            if (cbbtth.Text == "Hiển thị tên khách hàng của hoá đơn")
            {
                dgvTTH.DataSource = dtbase.DataReader("exec cau4proc N'" + txtNGT.Text + "'");
            }
            if (cbbtth.Text == "Hiển thị Mã khách hàng và tên khách hàng đến vào ngày")
            {
                dgvTTH.DataSource = dtbase.DataReader("exec cau5proc N'" + String.Format("{0:u}", dtntt.Value.Date) + "'");
            }
            if (cbbtth.Text == "Hiển thị Tên nhân viên và ngày thanh toán của hoá đơn")
            {
                dgvTTH.DataSource = dtbase.DataReader("exec cau6proc N'" + txtNGT.Text + "'");
            }
            






        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "";
            DataTable dt =  dtbase.DataReader("select *from tb_datphong where maphong = N'"+txtMP.Text+"'");
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Phòng đã được sử dụng!");
            }
            else
            {
                sql += "insert into tb_DatPhong values(N'";
                sql += txtSHD2.Text + "',N'" + txtMP.Text + "',N'" + txtSN.Text + "',N'" + String.Format("{0:u}", dtpNgayDen.Value.Date) + "',N'" + String.Format("{0:u}", DtpNgayDi.Value.Date) + "')";
                dtbase.DataChange(sql);
                cbbds.Text = "Đặt Phòng";
                 sql = "update tb_phong set tinhtrang = N'Chưa sử dụng' where maphong in (select maphong from tb_datphong join tb_hoadon on tb_hoadon.sohd = tb_datphong.sohd where ngaythanhtoan > ngaydi or getdate() > ngaydi)";
                dtbase.DataChange(sql);
            }
        }

        private void bbtnTHD_Click(object sender, EventArgs e)
        {
            string sql = "";
            DataTable dt = dtbase.DataReader("select sohd from tb_hoadon where sohd = N'" + txtSHD.Text + "'");
            if(dt.Rows.Count == 0)
            {
                sql = "insert into tb_hoadon (SoHd,makh,manv) values(N'";
                sql += txtSHD.Text + "',N'" + txtMKH.Text + "',N'" + txtMNV.Text + "')";
                dtbase.DataChange(sql);
                cbbds.Text = "Hoá Đơn";
                txtSHD.Text = "";
                txtMKH.Text = "";
                txtMNV.Text = "";
                Loadhd();
                dgvds.DataSource = dtbase.DataReader("select * from tb_hoadon");
            }
            else
            {
                MessageBox.Show("Đã trùng!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loadhd();

            Loaddv();
            cbbmdv.Text = "";
            string sql = "update tb_phong set tinhtrang = N'Chưa sử dụng' where maphong in (select maphong from tb_datphong join tb_hoadon on tb_hoadon.sohd = tb_datphong.sohd where ngaythanhtoan > ngaydi or getdate() > ngaydi)";
            dtbase.DataChange(sql);
            sql = "update tb_phong set tinhtrang = N'Đang bảo trì' where maphong in (select distinct maphong from tb_ptb where tinhtrang = N'Đã hỏng')";
            dtbase.DataChange(sql);
        }

        private void dgvds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                i = dgvds.CurrentRow.Index;
                if (cbbds.Text == "Hoá Đơn")
                {
                    if (dgvds.Rows[i].Cells[0].Value.ToString() != "")

                    {
                        a = dgvds.Rows[i].Cells[0].Value.ToString();
                        DataTable dt = dtbase.DataReader("Select sohd from tb_hoadon where sohd = N'" + a + "'");
                        if (dt.Rows.Count == 0)
                        {

                        }
                        else
                        {
                            b = dgvds.Rows[i].Cells[4].Value.ToString();
                            c = dgvds.Rows[i].Cells[5].Value.ToString();

                            string sql = "update tb_HoaDon set TienPhong = N'" + b + "',";
                            sql += "TienDV = N'" + c + "'";
                            sql += "where sohd = N'" + a + "'";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_HoaDon");
                        }

                    }
                }
                if (cbbds.Text == "Dịch Vụ")
                {
                    if (dgvds.Rows[i].Cells[0].Value.ToString() == "")
                    {
                        string sql = "delete from tb_dichvu where TenDV = N'" + dgvds.Rows[i].Cells[1].Value.ToString() + "'";
                        dtbase.DataChange(sql);
                        dgvds.DataSource = dtbase.DataReader("select * from tb_dichvu");
                    }
                    else
                    {
                        a = dgvds.Rows[i].Cells[0].Value.ToString();
                        DataTable dt = dtbase.DataReader("Select madv from tb_dichvu where madv = N'" + a + "'");
                        if (dt.Rows.Count == 0)
                        {
                            string sql = "insert into tb_dichvu values(N'" + dgvds.Rows[i].Cells[0].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[1].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[2].Value.ToString() + "')";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_dichvu");
                        }
                        else
                        {
                            b = dgvds.Rows[i].Cells[1].Value.ToString();
                            c = dgvds.Rows[i].Cells[2].Value.ToString();

                            string sql = "update tb_dichvu set Tendv = N'" + b + "',";
                            sql += "Gia = N'" + c + "'";
                            sql += "where madv = N'" + a + "'";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_dichvu");
                        }

                    }
                }
                if (cbbds.Text == "Khách Hàng")
                {
                    if (dgvds.Rows[i].Cells[0].Value.ToString() == "")
                    {
                        string sql = "delete from tb_KhachHang where Tenkh = N'" + dgvds.Rows[i].Cells[1].Value.ToString() + "'";
                        dtbase.DataChange(sql);
                        dgvds.DataSource = dtbase.DataReader("select * from tb_khachhang");
                    }
                    else
                    {
                        a = dgvds.Rows[i].Cells[0].Value.ToString();
                        DataTable dt = dtbase.DataReader("Select makh from tb_khachhang where makh = N'" + a + "'");
                        if (dt.Rows.Count == 0)
                        {
                            DateTime x = Convert.ToDateTime(dgvds.Rows[i].Cells[4].Value.ToString());
                            string sql = "";
                            sql = "insert into tb_KhachHang values(N'";
                            sql += dgvds.Rows[i].Cells[0].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[1].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[2].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[3].Value.ToString() + "',N'" + String.Format("{0:u}", x) + "',N'" + dgvds.Rows[i].Cells[5].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[6].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[7].Value.ToString() + "')";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_KhachHang");
                        }
                        else
                        {
                            b = dgvds.Rows[i].Cells[1].Value.ToString();
                            c = dgvds.Rows[i].Cells[2].Value.ToString();
                            d = dgvds.Rows[i].Cells[3].Value.ToString();
                            DateTime x = Convert.ToDateTime(dgvds.Rows[i].Cells[4].Value.ToString());
                            f = dgvds.Rows[i].Cells[5].Value.ToString();
                            g = dgvds.Rows[i].Cells[6].Value.ToString();
                            h = dgvds.Rows[i].Cells[7].Value.ToString();

                            string sql = "update tb_KhachHang set TenKH = N'" + b + "',";
                            sql += "GioiTinh = N'" + c + "',";
                            sql += "cccd = N'" + d + "',";
                            sql += "NgaySinh = N'" + String.Format("{0:u}", x) + "',";
                            sql += "DiaChi = N'" + f + "',";
                            sql += "SoDienThoai = N'" + g + "',";
                            sql += "Note = N'" + h + "'";
                            sql += " where MaKH = N'" + a + "'";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_KhachHang");
                        }
                    }
                }
                if (cbbds.Text == "Thiết Bị")
                {
                    if (dgvds.Rows[i].Cells[0].Value.ToString() == "")
                    {
                        string sql = "delete from tb_tb where Tentb = N'" + dgvds.Rows[i].Cells[1].Value.ToString() + "'";
                        dtbase.DataChange(sql);
                        dgvds.DataSource = dtbase.DataReader("select * from tb_tb");
                    }
                    else
                    {
                        a = dgvds.Rows[i].Cells[0].Value.ToString();
                        DataTable dt = dtbase.DataReader("Select matb from tb_tb where matb = N'" + a + "'");
                        if (dt.Rows.Count == 0)
                        {
                            string sql = "insert into tb_tb values(N'" + dgvds.Rows[i].Cells[0].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[1].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[2].Value.ToString() + "')";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_tb");
                        }
                        else
                        {
                            b = dgvds.Rows[i].Cells[1].Value.ToString();
                            c = dgvds.Rows[i].Cells[2].Value.ToString();

                            string sql = "update tb_tb set Tentb = N'" + b + "',";
                            sql += "Gia = N'" + c + "'";
                            sql += "where matb = N'" + a + "'";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_tb");
                        }

                    }
                }
                if (cbbds.Text == "Phòng")
                {
                    if (dgvds.Rows[i].Cells[0].Value.ToString() == "")
                    {
                        string sql = "delete from tb_Phong where TenPhong = N'" + dgvds.Rows[i].Cells[1].Value.ToString() + "'";
                        dtbase.DataChange(sql);
                        dgvds.DataSource = dtbase.DataReader("select * from tb_phong");
                    }
                    else
                    {
                        a = dgvds.Rows[i].Cells[0].Value.ToString();
                        DataTable dt = dtbase.DataReader("Select maphong from tb_phong where maphong = N'" + a + "'");
                        if (dt.Rows.Count == 0)
                        {
                            string sql = "insert into tb_phong values(N'" + dgvds.Rows[i].Cells[0].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[1].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[2].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[3].Value.ToString() + "')";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_phong");
                        }
                        else
                        {
                            b = dgvds.Rows[i].Cells[1].Value.ToString();
                            c = dgvds.Rows[i].Cells[2].Value.ToString();
                            d = dgvds.Rows[i].Cells[3].Value.ToString();
                            string sql = "update tb_phong set TenPhong = N'" + b + "',";
                            sql += "MaLP = N'" + c + "',";
                            sql += "TinhTrang = N'" + d + "'";
                            sql += "where maphong = N'" + a + "'";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_phong");

                        }
                    }
                }
                if (cbbds.Text == "Nhân Viên")
                {
                    if (dgvds.Rows[i].Cells[0].Value.ToString() == "")
                    {
                        string sql = "delete from tb_NhanVien where Tennv = N'" + dgvds.Rows[i].Cells[1].Value.ToString() + "'";
                        dtbase.DataChange(sql);
                        dgvds.DataSource = dtbase.DataReader("select * from tb_nhanvien");
                    }
                    else
                    {
                        a = dgvds.Rows[i].Cells[0].Value.ToString();
                        DataTable dt = dtbase.DataReader("Select manv from tb_NhanVIen where manv = N'" + a + "'");
                        if (dt.Rows.Count == 0)
                        {
                            DateTime x = Convert.ToDateTime(dgvds.Rows[i].Cells[4].Value.ToString());
                            string sql = "";
                            sql = "insert into tb_Nhanvien values(N'";
                            sql += dgvds.Rows[i].Cells[0].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[1].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[2].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[3].Value.ToString() + "',N'"+ String.Format("{0:u}", x) + "',N'"+ dgvds.Rows[i].Cells[5].Value.ToString() + "',N'"+ dgvds.Rows[i].Cells[6].Value.ToString() + "',N'"+ dgvds.Rows[i].Cells[7].Value.ToString() + "')";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_NhanVien");
                        }
                        else
                        {
                            b = dgvds.Rows[i].Cells[1].Value.ToString();
                            c = dgvds.Rows[i].Cells[2].Value.ToString();
                            d = dgvds.Rows[i].Cells[3].Value.ToString();
                            DateTime x = Convert.ToDateTime(dgvds.Rows[i].Cells[4].Value.ToString());
                            f = dgvds.Rows[i].Cells[5].Value.ToString();
                            g= dgvds.Rows[i].Cells[6].Value.ToString();
                            h = dgvds.Rows[i].Cells[7].Value.ToString();

                            string sql = "update tb_NhanVien set TenNV = N'" + b + "',";
                            sql += "GioiTinh = N'" + c + "',";
                            sql += "cccd = N'" + d + "',";
                            sql += "NgaySinh = N'" + String.Format("{0:u}", x) + "',";
                            sql += "DiaChi = N'" + f + "',";
                            sql += "SoDienThoai = N'" + g + "',";
                            sql += "ChucVu = N'" + h + "'";
                            sql += " where MaNv = N'" + a + "'";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_NhanVien");
                        }
                    }
                }
                if(cbbds.Text == "Chứa Thiết Bị")
                {
                    if (dgvds.Rows[i].Cells[0].Value.ToString() == "")
                    {

                    }
                    else
                    {
                        a = dgvds.Rows[i].Cells[0].Value.ToString();
                        b = dgvds.Rows[i].Cells[1].Value.ToString();
                        DataTable dt = dtbase.DataReader("Select matb from tb_ptb where matb = N'" + a + "' and maphong = N'"+b+"'");
                        if (dt.Rows.Count == 0)
                        {
                            string sql = "insert into tb_ptb values(N'" + dgvds.Rows[i].Cells[0].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[1].Value.ToString() + "',N'" + dgvds.Rows[i].Cells[2].Value.ToString() + "',N'"+ dgvds.Rows[i].Cells[3].Value.ToString() + "')";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_ptb");
                        }
                        else
                        {
                           
                            c = dgvds.Rows[i].Cells[3].Value.ToString();

                            string sql = "update tb_ptb set tinhtrang = N'" + c + "'";
                            sql += "where matb = N'" + a + "' and maphong = N'"+b+"'";
                            dtbase.DataChange(sql);
                            dgvds.DataSource = dtbase.DataReader("select * from tb_ptb");
                            sql = "update tb_phong set tinhtrang = N'Đang bảo trì' where maphong in (select distinct maphong from tb_ptb where tinhtrang = N'Đã hỏng')";
                            dtbase.DataChange(sql);
                            sql = "update tb_phong set tinhtrang = N'Chưa sử dụng' where maphong in (select distinct maphong from tb_ptb where tinhtrang = N'Đang sử dụng' and matb = N'"+a+"' and maphong = N'"+b+"') and tinhtrang = N'Đang bảo trì'";
                            dtbase.DataChange(sql);
                        }

                    }
                }
                

                
            }
        }


        private void cbbtk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbtk.Text == "Khách hàng ghé thăm nhiều nhất")
            {
                dgvthongke.DataSource = dtbase.DataReader("select * from KHNN");

            }if(cbbtk.Text == "Hoá đơn có tổng tiền lớn nhất")
            {
                dgvthongke.DataSource = dtbase.DataReader("select * from maxhd");
            }
            if (cbbtk.Text == "Nhân viên có doanh thua cao nhất")
            {
                dgvthongke.DataSource = dtbase.DataReader("select * from NVCDTCN");
            }
            if (cbbtk.Text == "Báo cáo số lượng khách theo tháng năm 2022")
            {
                dgvthongke.DataSource = dtbase.DataReader("select * from slkhachcacthang");
            }
            if (cbbtk.Text == "Tháng có nhiều khách nhất")
            {
                dgvthongke.DataSource = dtbase.DataReader("select * from TCNKN");
            }
            if(cbbtk.Text == "Thông tin nhưng nhân viên có địa chỉ ở Nam Định")
            {
                dgvthongke.DataSource = dtbase.DataReader("select * from TimDongHuong");
            }
            if (cbbtk.Text == "Thông tin thiết bị đang trong tình trạng Hỏng")
            {
                dgvthongke.DataSource = dtbase.DataReader("select * from KiemTra");
            }
            if (cbbtk.Text == "In ra tất cả các hóa đơn")
            {
                dgvthongke.DataSource = dtbase.DataReader("select * from xemhoadon");
            }

        }
        
    }
}
