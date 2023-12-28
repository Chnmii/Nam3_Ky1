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
    public partial class frmTinhTong : Form
    {
        public frmTinhTong()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập đủ dữ liệu");
            }    
            else
            {
                int sum = 0;
                int a, b;
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);

                if (a > b)
                {
                    int c = a;
                    a = b;
                    b = c;                   
                }
                for (int i = a; i <= b; i++)
                {
                    sum += i;
                }

                label3.Text = "Tổng từ " + a + " đến " + b + " là: " + sum;
            }    
            
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            label3.Text = "";
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
