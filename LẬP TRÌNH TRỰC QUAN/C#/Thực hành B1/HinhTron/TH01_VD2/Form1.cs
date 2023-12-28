using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH01_VD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double r = double.Parse(txtNhap.Text);
            txtChuVi.Text = (2 * 3.14 * r).ToString();
            txtDienTich.Text = (3.14 * r * r).ToString();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhap.Text = "";
            txtChuVi.Text = "";
            txtDienTich.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Có hay không?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
