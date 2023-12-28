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
    public partial class frmDaySo : Form
    {
        public frmDaySo()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int[] a;
        int n;

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập n");
                txtNhap.Focus();
            }    

            n = int.Parse(txtNhap.Text);
            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(100);
                label2.Text = label2.Text + "  " + a[i].ToString();
            }    
            
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            label3.Text = label3.Text + "  " + sum;
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }    
                }    
            } 
            for (int i = 0; i < n; i++)
            {
                label4.Text = label4.Text + "  " + a[i].ToString();
            }    
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhap.Text = "";
            txtNhap.Focus();
            label2.Text = "Dãy số: ";
            label3.Text = "Tổng dãy số là: ";
            label4.Text = "Dãy số sắp xếp giảm dần là: ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
