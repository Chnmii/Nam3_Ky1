using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_SinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbTenMH_SelectedIndexChanged()
        {
            cbTenMH.Items.Add("Tin học đại cương");
            cbTenMH.Items.Add("Giải tích F1");
            cbTenMH.Items.Add("Tiếng anh A0");
            cbTenMH.Items.Add("Triết học Mác-Lênin");
            cbTenMH.Items.Add("Vật lý F1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTenMH_SelectedIndexChanged();
            this.KeyPreview = true;
        }

        int count = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (txtDiem.TextLength == 0)
            {
                MessageBox.Show("Điểm không được bỏ trống");
                check = 0;
            }

            lstDS.Items.Add(cbTenMH.Text + " | " + txtSoTC.Text + " | " + txtDiem.Text);
            count++;
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void cbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenMH.SelectedItem == "Tin học đại cương")
                txtSoTC.Text = 2.ToString();
            if (cbTenMH.SelectedItem == "Giải tích F1")
                txtSoTC.Text = 3.ToString();
            if (cbTenMH.SelectedItem == "Tiếng anh A0")
                txtSoTC.Text = 3.ToString();
            if (cbTenMH.SelectedItem == "Triết học Mác-Lênin")
                txtSoTC.Text = 2.ToString();
            if (cbTenMH.SelectedItem == "Vật lý F1")
                txtSoTC.Text = 3.ToString();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if (lstDS.Items.Count == 0)
            {
                MessageBox.Show("Hãy nhập thông tin môn học trước!");
                kt = 0;
            }

            double diem;
            int sTC;
            double TongD = 0;
            int TongTC = 0;

            foreach(string s in lstDS.Items)
            {
                string[] res = s.Split('|');
                diem = double.Parse(res[2]);
                sTC = int.Parse(res[1]);
                TongD += diem * sTC;
                TongTC += sTC;
            }

            txtTongDiem.Text = (TongD).ToString("0.0");
            txtTongTC.Text = (TongTC).ToString();

            double DTB = TongD / TongTC;
            txtDTB.Text = DTB.ToString("0.0");


        }
    }
}
