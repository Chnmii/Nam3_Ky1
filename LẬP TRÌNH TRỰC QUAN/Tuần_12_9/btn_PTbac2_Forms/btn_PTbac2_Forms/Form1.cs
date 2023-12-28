using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btn_PTbac2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapA.Text = "";
            txtNhapB.Text = "";
            txtNhapC.Text = "";
            txtKetQua.Text = "";
            txtNhapA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Có hay không?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnGiaPT_Click(object sender, EventArgs e)
        {
            

            txtNhapA.Focus();
            int a, b, c;
            a = int.Parse(txtNhapA.Text);
            b = int.Parse(txtNhapB.Text);
            c = int.Parse(txtNhapC.Text);
            double dental = b * b - 4 * a * c;
            if(dental < 0)
            {
                txtKetQua.Text = "Phương trình vô nghiệm!";
            }
            else if(dental == 0)
            {
                txtKetQua.Text = "Phương trình có nghiệm kép ; " + ((0 - b) / (2 * a)).ToString();
            }
            else
            {
                txtKetQua.Text = "Phương trình có hai nghiệm : \n" + ((0-b+Math.Sqrt(dental))/(2*a)).ToString("0.00") + " và " + ((0 - b - Math.Sqrt(dental)) / (2 * a)).ToString("0.00");
            }
        }

        /*
        private void txtNhapA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt16(e.KeyChar) < Convert.ToInt16("0") && Convert.ToInt16(e.KeyChar) > Convert.ToInt16("9") && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Bạn phải nhập số ! ");
                e.Handled = true;
            }
        }

        private void txtNhapB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < Convert.ToInt16("0") && Convert.ToInt16(e.KeyChar) > Convert.ToInt16("9") && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Bạn phải nhập số ! ");
                e.Handled = true;
            }
        }

        private void txtNhapC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < Convert.ToInt16("0") && Convert.ToInt16(e.KeyChar) > Convert.ToInt16("9") && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Bạn phải nhập số ! ");
                e.Handled = true;
            }
        }
        */
    }
}
