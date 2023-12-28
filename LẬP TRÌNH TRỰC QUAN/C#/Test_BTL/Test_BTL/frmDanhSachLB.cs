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
    public partial class frmDanhSachLB : Form
    {
        public frmDanhSachLB()
        {
            InitializeComponent();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            lbDanhSach.Items.Add(txtNhap.Text);
            txtNhap.Text = "";
            txtNhap.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lbDanhSach.Items.RemoveAt(lbDanhSach.SelectedIndex);
        }

        
        private void btnTim_Click(object sender, EventArgs e)
        {            
            if (lbDanhSach.Items.Contains(txtNhap.Text))
            {
                lbDanhSach.Text = txtNhap.Text;
            }
            else
            {
                MessageBox.Show("Không tìm thấy ngoại ngữ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
