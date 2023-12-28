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

namespace QL_KhachSan
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        Classes.ConnectData data = new Classes.ConnectData();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)   
                this.Close();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-454CCL8;Initial Catalog=QLKhachSan;Integrated Security=True");

            string TenDN = txtTenDN.Text;
            string MK = txtMK.Text;
            string sql = "Select * from tblLogin where username=N'" + TenDN + "' and password=N'" + MK + "'";

            DataTable dtUser = data.ReadData("Select * from tblLogin");
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                frmMain frmH = new frmMain();
                frmH.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }
    }
}
