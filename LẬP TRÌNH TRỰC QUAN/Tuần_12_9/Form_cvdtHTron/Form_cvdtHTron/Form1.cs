using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_cvdtHTron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double R = double.Parse(txtNhap.Text);
            txtCV.Text = (2 * 3.14 * R).ToString();
            txtDT.Text = (3.14 * R * R).ToString();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhap.Text = "";
            txtCV.Text = "";
            txtDT.Text = "";
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong ? ", "Co hay khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
