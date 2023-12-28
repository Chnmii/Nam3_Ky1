using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frmDangNhap : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();
        Classes.EnglishTextbox english = new Classes.EnglishTextbox();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;

            return input.ToCharArray().Any(c => c > MaxAnsiCode);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = tbuser.Text;
            string pass = tbPass.Text;
            string sqlexc = "select * from tUSER where userName = '" + user + "' and passWord = '" + pass + "'";
            //SqlCommand cmd = new SqlCommand(sqlexc, conn);
            //SqlDataReader dtreader = cmd.ExecuteReader();
            DataTable dataTable = data.ReadData(sqlexc);
            if (dataTable.Rows.Count > 0)
            {
                this.Hide();
                frm.frmMain.userName = tbuser.Text;
                frm.frmMain main = new frm.frmMain();
                main.Closed += (s, arg) => this.Close();
                main.Show();
                //main.ShowDialog();
                
            }
            else
            {
                if(tbuser.Text == "")
                {
                    lbSaiMK.Text = "Tên đăng nhập không được bỏ trống";
                    lbSaiMK.ForeColor = Color.Red;
                    tbuser.Focus();
                }
                else if(tbPass.Text == "")
                {
                    lbSaiMK.Text = "Mật khẩu không được bỏ trống";
                    lbSaiMK.ForeColor = Color.Red;
                    tbPass.Focus();
                }
                else
                {
                    lbSaiMK.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                    lbSaiMK.ForeColor = Color.Red;
                }
                
            }
            //this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        // Trang tri Form
        private void btnclose_MouseEnter(object sender, EventArgs e)
        {
            btnclose.ForeColor = Color.Red;
        }

        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            btnclose.ForeColor = Color.Black;
        }

        private void btnDangNhap_MouseEnter(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.Black;
            btnDangNhap.ForeColor = Color.White;
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.DimGray;
            btnDangNhap.ForeColor = Color.White;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void chbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chbPassword.Checked == true)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            if (chbPassword.Checked == false)
            {
                tbPass.UseSystemPasswordChar = true;
            }
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
