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


namespace DanhMucHangHoa
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        Classes.ConnectData data = new Classes.ConnectData();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-454CCL8;Initial Catalog=QLSanPham;Integrated Security=True");

            string TenDN = txtTenDN.Text;
            string MK = txtMK.Text;
            string sql = "Select * from tblUser where userName=N'" + TenDN + "' and passWord=N'" + MK+ "'";

            DataTable dtUser = data.ReadData("Select * from tblUser");
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dt = cmd.ExecuteReader();
            if(dt.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                frmHang frmH = new frmHang(TenDN);
                frmH.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = "";
            txtMK.Text = "";
            
        }

        private void rbMK_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMK.Checked)
            {
                txtMK.PasswordChar = (char)0;
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
