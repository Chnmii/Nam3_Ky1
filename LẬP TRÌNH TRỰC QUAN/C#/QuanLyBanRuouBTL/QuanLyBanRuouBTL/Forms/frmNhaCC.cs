using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanRuouBTL.Forms
{
    public partial class frmNhaCC : Form
    {
        Classes.ConnectDatabase data = new Classes.ConnectDatabase();
        public frmNhaCC()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            dgvNhaCC.DataSource = data.DataReader("select * from tblNhaCungCap");
        }

        void ResetValue()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtMa.Focus();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            btnTimKiem.Enabled = true;

        }
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvNhaCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNhaCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvNhaCC.Columns[2].HeaderText = "Địa chỉ";
            dgvNhaCC.Columns[3].HeaderText = "Số điện thoại";

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // viet cau lẹnh tim kiem
            string sql = "select * from tblNhaCungCap where MaNCC is not null ";
            // tim theo mancc khac rong

            if(txtTKMa.Text.Trim() != "")
            {
                sql += " and MaNCC like '%" + txtTKMa.Text + "%'";
            }    
            // ktra ten nha cc
            if(txtTKTen.Text.Trim() != "")
            {
                sql += " And TenNCC like N'%" + txtTKTen.Text + "%'";
            }

            dgvNhaCC.DataSource = data.DataReader(sql);

           
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvNhaCC.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvNhaCC.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaCC.CurrentRow.Cells[2].Value.ToString();
            txtSoDienThoai.Text = dgvNhaCC.CurrentRow.Cells[3].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnTimKiem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp");
                txtMa.Focus();
            }    
            if(txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp");
                txtTen.Focus();
            }    

            if(txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                txtDiaChi.Focus();
            }
            if (txtSoDienThoai.Text == "") ;
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                txtSoDienThoai.Focus();
            }

            DataTable dtCheck = data.DataReader("select * from tblNhaCungCap where MaNCC ='" + txtMa.Text + "'");
            if(dtCheck.Rows.Count > 0)
            {
                MessageBox.Show("Đã có mã này mời bạn nhập lại ");
                txtMa.Focus();
                return;
            }

            // them moi vao database
            string sql = "insert into tblNhaCungCap values('" + txtMa.Text + "', N'" + txtTen.Text + "',N'" + txtDiaChi.Text + "','" + txtSoDienThoai.Text + "')";
            data.DataChange(sql);
            LoadData();
            MessageBox.Show("Thêm mới thành công!");
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Có hay Không", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    data.DataChange("delete tblNhaCungCap where MaNCC ='" + txtMa.Text + "'");
                    LoadData();
                    ResetValue();

                }

                catch
                {
                    MessageBox.Show("Không thể xóa vì liên quan đến các kết nối khác");
                }
                
               
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            data.DataChange("update tblNhaCungCap set  TenNCC = N'" + txtTen.Text + "', DiaChiNCC = N'" 
                            + txtDiaChi.Text + "', SDT = '" + txtSoDienThoai.Text + "' where MaNCC = '" + 
                                txtMa.Text + "'");
            LoadData();
            ResetValue();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Có hay Không", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }
    }
}
