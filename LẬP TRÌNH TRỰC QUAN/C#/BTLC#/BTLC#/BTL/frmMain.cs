using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        
        private void OpenChildForm(Form childForm)
        {       
            Form frm = childForm;
            panel_show.Show();
            panel_show.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel_show.Controls.Add(frm);
            frm.Show();
        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDangNhap());
        }

        private void menuQLTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDangKy());
        }

        private void menuDoiMK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDoiMatKhau());
        }

        private void menuNhanSu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCoBan());
        }

        private void menuThongTinCN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongTinCaNhan());
        }

        private void menuCheDo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCheDo());
        }

        private void menuHSTV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoSoThuViec());
        }

        private void menuTraCuu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimKiem());
        }

        private void menuBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void menuTroGiup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTroGiup());
        }

        private void menuPhongBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhongBan());
        }

        private void menuBoPhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBoPhan());
        }

        private void menuLuongNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLuong());
        }

        private void menuBangLuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBangCong());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
