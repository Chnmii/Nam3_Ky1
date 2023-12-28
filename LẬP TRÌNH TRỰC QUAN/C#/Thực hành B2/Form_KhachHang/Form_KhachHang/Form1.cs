using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_KhachHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbTGian_SelectedIndexChanged()
        {
            cbTGian.Items.Add("1");
            cbTGian.Items.Add("3");
            cbTGian.Items.Add("6");
            cbTGian.Items.Add("12");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTGian_SelectedIndexChanged();
            this.KeyPreview = true;
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDC.Text = "";
            txtTien.Text = "";
            dtNgay.Text = "";
            cbTGian.Text = "";
            cbTGian.SelectedIndex = -1;
            rdThuong.Checked = false;
            rdPL.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if (txtMaKH.TextLength < 6)
            {
                MessageBox.Show("Nhập lại vì mã < 6 ký tự");
                kt = 0;
            }
            if (txtDC.TextLength == 0 || txtTenKH.TextLength == 0)
            {
                MessageBox.Show("Nhập lại vì tên hoặc địa chỉ rỗng");
                kt = 0;
            }

            double tienlai = 0;
            if (kt == 1)
            {
                if (rdThuong.Checked == true)
                {
                    if (cbTGian.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.06;

                    }
                    if (cbTGian.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.07;

                    }
                    if (cbTGian.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.08;

                    }
                    if (cbTGian.SelectedItem == "12")
                    {
                        tienlai = Convert.ToDouble(txtTien.Text) * 0.09;
                    }
                }
                else if (rdPL.Checked == true)
                {
                    if (cbTGian.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.07;

                    }
                    if (cbTGian.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.08;

                    }
                    if (cbTGian.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.09;

                    }
                    if (cbTGian.SelectedItem == "12")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.1;

                    }
                }
                lbDsKH.Items.Add(txtMaKH.Text + " | " + txtTenKH.Text + " | " + txtDC.Text + " | "
                    + dtNgay.Text + " | " + txtTien.Text + " | " + cbTGian.Text + " tháng | " + tienlai);

                
            }
        List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
        listNguoiGuis.Add(new NguoiGui(Convert.ToInt32(txtMaKH.Text), txtTenKH.Text, txtDC.Text, Convert.ToInt32(txtTien.Text),
                dtNgay.Text, cbTGian.Text, tienlai

              ));

        StaticData._NguoiGui = listNguoiGuis;
        StaticData._NguoiGui.Add(new NguoiGui(Convert.ToInt32(txtMaKH.Text), txtTenKH.Text, txtDC.Text, Convert.ToInt32(txtTien.Text),
                    dtNgay.Text, cbTGian.Text, tienlai
                ));
                
    }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

      
    }



    class NguoiGui
    {
        private int MaKH;
        private string TenKH;
        private string DiaChi;
        private int SoTienGui;
        private string NgayGui;
        private string ThoiGianGui;
        private double Tien;

        public NguoiGui(int maKH)
        {
            MaKH = maKH;
        }

        public NguoiGui(int maKH, string tenKH, string diaChi, int soTienGui, string ngayGui, string thoiGianGui, double tien)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diaChi;
            SoTienGui = soTienGui;
            NgayGui = ngayGui;
            ThoiGianGui = thoiGianGui;
            Tien = tien;
        }

        public int MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public double Tien1 { get => Tien; set => Tien = value; }

    }
    class StaticData
    {
        public static List<NguoiGui> _NguoiGui = new List<NguoiGui>();
    }

    
}
