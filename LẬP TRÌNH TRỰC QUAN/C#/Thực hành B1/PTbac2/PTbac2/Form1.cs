using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTbac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            if (txtNhapA.Text == "" || txtNhapB.Text == "" || txtNhapC.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ cả a, b, c");
                if (txtNhapC.Text == "") txtNhapC.Focus();
                if (txtNhapB.Text == "") txtNhapB.Focus();
                if (txtNhapA.Text == "") txtNhapA.Focus();
                return;
            }

            double a, b, c, temp;
            if (Double.TryParse(txtNhapA.Text, out temp) == false)
            {
                MessageBox.Show("a phải là số thực");
                txtNhapA.Focus();
                return;
            }
            if (Double.TryParse(txtNhapB.Text, out temp) == false)
            {
                MessageBox.Show("b phải là số thực");
                txtNhapB.Focus();
                return;
            }
            if (Double.TryParse(txtNhapC.Text, out temp) == false)
            {
                MessageBox.Show("c phải là số thực");
                txtNhapC.Focus();
                return;
            }
            
            a = int.Parse(txtNhapA.Text);
            b = int.Parse(txtNhapB.Text);
            c = int.Parse(txtNhapC.Text);
            double dental = b * b - 4 * a * c;
            if (dental < 0)
            {
                txtKetQua.Text = "Phương trình vô nghiệm!";
            }
            else if (dental == 0)
            {
                txtKetQua.Text = "Phương trình có nghiệm kép ; " + ((0 - b) / (2 * a)).ToString();
            }
            else
            {
                txtKetQua.Text = "Phương trình có hai nghiệm : \n" + ((0 - b + Math.Sqrt(dental)) / (2 * a)).ToString("0.00") + " và " + ((0 - b - Math.Sqrt(dental)) / (2 * a)).ToString("0.00");
            }
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
    }
}
