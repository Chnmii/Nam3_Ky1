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

namespace Test_BTL
{
    public partial class frmTinhToanGB : Form
    {
        public frmTinhToanGB()
        {
            InitializeComponent();
        }

        double a, b;

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void check()
        {
            if (txtA.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập a");
                txtA.Focus(); 
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập b");
                txtB.Focus(); 
                return ;
            }
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
        }

        private void rbTru_Click(object sender, EventArgs e)
        {
            check();            
            txtKetQua.Text = (a - b).ToString();
        }

        private void rbNhan_Click(object sender, EventArgs e)
        {
            check();
            txtKetQua.Text = (a * b).ToString();
        }

        private void rbChia_Click(object sender, EventArgs e)
        {
            check();
            if (b == 0)
            {
                txtKetQua.Text = "Mẫu = 0";
            }
            else
            {
                txtKetQua.Text = (a / b).ToString();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetQua.Text = "";
            rbCong.Checked = false;
            rbTru.Checked = false;
            rbNhan.Checked = false;
            rbChia.Checked = false;
            cbMax.Checked = false;
            cbMax.Text = "Max";
            cbMin.Text = "Min";
            cbMin.Checked = false;
            txtA.Focus();
        }

        private void cbMax_Click(object sender, EventArgs e)
        {
            if (a > b)
            {
                cbMax.Text = "Max = " + a;
            }
            else
            {
                cbMax.Text = "Max = " + b;
            }
        }

        private void cbMin_Click(object sender, EventArgs e)
        {
            if (a < b)
            {
                cbMin.Text = "Min = " + a;
            }
            else
            {
                cbMin.Text = "Min = " + b;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbCong_Click(object sender, EventArgs e)
        {
            check();
            txtKetQua.Text = (a + b).ToString();
        }
    }
}
