using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frmCheDo
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        ConnectData data = new ConnectData();
        int i = 0;

        private void rdMaNV_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void rdHoTen_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void rdCMTND_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNhap.Text == "") || (txtNhap.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("Bạn chưa nhập từ khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        dgvTimKiem.DataSource = data.DataReader("select * from TblTTNVCoBan where MaNV=N'" + txtNhap.Text + "'");
                           
                    }
                    if (i == 2)
                    {
                        dgvTimKiem.DataSource = data.DataReader("select * from TblTTNVCoBan where HoTen=N'" + txtNhap.Text + "'");
                    }
                    if (i == 3)
                    {
                        dgvTimKiem.DataSource = data.DataReader("select * from TblTTNVCoBan where CMTND=N'" + txtNhap.Text + "'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không tìm thấy thông tin");
            }
        }

        private void txtNhap_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "Nhập vào từ khóa tìm kiếm")
            {
                txtNhap.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
