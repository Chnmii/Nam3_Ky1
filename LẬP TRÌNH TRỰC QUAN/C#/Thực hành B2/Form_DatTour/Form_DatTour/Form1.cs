using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_DatTour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtGia.Text = "";
            txtTien.Text = "";
            rdCaNgay.Checked = false;
            rdNuaNgay.Checked = false;
            cbDoUong.Text = "";
            cbSL.Text = "";

        }

        private void cbSL_SelectedIndexChanged()
        {
            cbSL.Items.Add("1");
            cbSL.Items.Add("2");
            cbSL.Items.Add("3");
            cbSL.Items.Add("4");
            cbSL.Items.Add("5");
            cbSL.Items.Add("6");
            cbSL.Items.Add("7");
            cbSL.Items.Add("8");
            cbSL.Items.Add("9");
            cbSL.Items.Add("10");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSL_SelectedIndexChanged();
            cbDoUong_SelectedIndexChanged();
            this.KeyPreview = true;

        }

        private void cbDoUong_SelectedIndexChanged()
        {
            cbDoUong.Items.Add("Coca Cola");
            cbDoUong.Items.Add("Pepsi");
            cbDoUong.Items.Add("Seven up");
            
        }

        private void rdCaNgay_Click(object sender, EventArgs e)
        {
            txtGia.Text = 200.ToString();
        }

        private void rdNuaNgay_Click(object sender, EventArgs e)
        {
            txtGia.Text = 100.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtHoTen.Text + " | " ;
            if (rdCaNgay.Checked == true)
                item = item + "cả ngày | ";
            if (rdNuaNgay.Checked == true)
                item = item + "nửa ngày | ";
            item = item + txtGia.Text + " | " + cbDoUong.Text + " | " + cbSL.Text + " | " + txtTien.Text;

            lstDanhsach.Items.Add(item);

        }

        private void cbDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoUong.SelectedItem == "Coca Cola")
                txtTien.Text = (Convert.ToInt32(cbSL.SelectedItem) * 0.5).ToString();
            if (cbDoUong.SelectedItem == "Pepsi")
                txtTien.Text = (Convert.ToInt32(cbSL.SelectedItem) * 0.8).ToString();
            if (cbDoUong.SelectedItem == "Seven up")
                txtTien.Text = (Convert.ToInt32(cbSL.SelectedItem) * 1).ToString();
        }
    }
}
