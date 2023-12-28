using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_BTL
{
    public partial class frmThangNam : Form
    {
        public frmThangNam()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if (txtThang.Text == "" || txtNam.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập đủ dữ liệu");
                return;
            }    

            string s = "";
            int m, y;
            m = int.Parse(txtThang.Text);
            y = int.Parse(txtNam.Text);

            s = "Tháng " + m + " năm " + y + " có ";

            if (m < 1 || m > 12)
            {
                MessageBox.Show("Tháng chỉ từ 1 đến 12");
                return ;
            }  
            
            if (y < 1000)
            {
                MessageBox.Show("Năm gồm 4 chữ số");
                return;
            }    

            if (txtThang.Text != "" && txtNam.Text != "")
            {
                if (m >= 1 && m <= 12)
                {
                    if (m == 2)
                    {
                        if (m % 4 == 0)
                        {
                            s += 29;
                        }
                        else
                        {
                            s += 28;
                        }
                    }  
                    else if (m == 4 || m == 6 || m == 9 || m == 11)
                    {
                        s += 30;
                    }
                    else
                    {
                        s += 31;
                    }
                }
                label3.Text = s + " ngày";
            }    
            
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtThang.Text = "";
            txtNam.Text = "";
            label3.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
