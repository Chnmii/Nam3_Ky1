using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class frmMain : Form
    {
        Classes.ConnectData ConnectData = new Classes.ConnectData();
        public frmMain()
        {
            InitializeComponent();
        }
        
        private Form curentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(curentFormChild != null)
            {
                curentFormChild.Close();
            }
            curentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelOpenChilForm.Controls.Add(childForm);
            panelOpenChilForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }        

        
        private void btnDSCacBang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmCacBang());
            label_Title.Text = "DANH SÁCH CÁC BẢNG";
            panel_Title.BackColor = Color.PaleGreen;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmView());
            label_Title.Text = "CÁC CÂU VỀ VIEW";
            panel_Title.BackColor = Color.LightSkyBlue;
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHam());
            label_Title.Text = "CÁC CÂU VỀ HÀM";
            panel_Title.BackColor = Color.Pink;
        }

        private void btnThuTuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThuTuc());
            label_Title.Text = "CÁC CÂU VỀ THỦ TỤC";
            panel_Title.BackColor = Color.Violet;
        }

        private void lbTenKS_Click(object sender, EventArgs e)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close();
            }
            label_Title.Text = "QUẢN LÝ KHÁCH SẠN";
        }
    }
}
