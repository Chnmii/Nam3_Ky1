using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_7_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string sv=lstSinhVien.SelectedItem.ToString();
            string[] detailSinhVien = sv.Split('|');
            txtMa.Text = detailSinhVien[0];
            txtTen.Text = detailSinhVien[1]; 
            if (detailSinhVien[2] == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string student, gt;
            if (rdoNu.Checked == true)
                gt = "Nữ";
            else
                gt = "Nam";
            student = txtMa.Text + "|" + txtTen.Text + "|" + gt;
            lstSinhVien.Items.Add(student);


            txtMa.Text = "";
            txtTen.Text = "";
            if (rdoNam.Checked == true)
                rdoNam.Checked = false;
            else
                rdoNu.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = lstSinhVien.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử để Sửa1");
                return;
            }
            string student, gt;
            if (rdoNu.Checked == true)
                gt = "Nữ";
            else
                gt = "Nam";
            student = txtMa.Text + "|" + txtTen.Text + "|" + gt;
            // cập nhật lại vị trí index bằng student
            lstSinhVien.Items[index] = student;

            txtMa.Text = "";
            txtTen.Text = "";
            if (rdoNam.Checked == true)
                rdoNam.Checked = false;
            else
                rdoNu.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = lstSinhVien.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử để Xoá");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                lstSinhVien.Items.Remove(index);

            // lỗi remove 

            //if(MessageBox.Show("Ban co muon thoat khong ? ", "Co hay khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        }
    }
}
