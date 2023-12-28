using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_KhachHang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            listNguoiGuis = StaticData._NguoiGui;

        }

        List<NguoiGui> listNguoiGuis = new List<NguoiGui>();


        private void btnFind_Click(object sender, EventArgs e)
        {
            int timthay = 0;
            foreach (NguoiGui i in listNguoiGuis)
            {
                if (i.MaKH1 == Convert.ToInt32(txtMaKH.Text))
                {
                    timthay = 1;
                    lblResult.Text = "Ngân hàng phải trả cho khách hàng " + i.TenKH1 + " "
                        + i.Tien1 + " nghìn đồng";

                }
            } 

            if (timthay == 0)
            {
                lblResult.Text = "Khách hàng " + txtMaKH.Text + " không có trong danh sách";

            }

        }
    }
}
