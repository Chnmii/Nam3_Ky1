using QuanLyBanRuouBTL.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanRuouBTL
{
    public partial class frmMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public frmMain()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            load_form();
        }
        private void load_form()
        {
            
        }
        private Color SelectThemeColor()
        {
            random = new Random();
            int index = random.Next(ThemeColor.ColorList.Count);
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);//Phương pháp này dịch biểu diễn chuỗi của tên màu HTML, chẳng hạn như Xanh lam hoặc Đỏ, sang cấu trúc GDI + Màu .
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                }
            }
        }
        private void ActivateButton(object btnSender)
        {
            DisableButton();
            if (btnSender != null)
            {

                Color color = SelectThemeColor();
                //
                currentButton = (Button)btnSender;
                currentButton.BackColor = color;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panelLogo.BackColor = ControlPaint.Dark(color);//làm tối màu
                panelTitle.BackColor = color;

            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            
            ActivateButton(btnSender);
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;

            activeForm = childForm;
            btnCloseChildForm.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHDNhap(), sender);           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang(), sender);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhaCC(), sender);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang(), sender);
        }
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lbTitle.Text = "HOME";
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
                     
            btnCloseChildForm.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the window?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }
}
