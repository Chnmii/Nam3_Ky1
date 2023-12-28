using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.frm
{
    public partial class frmMain : Form
    {
        //Form movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        //sidebar
        bool sidebarExpand;
        bool bangdiemcolapse;
        
        //formmain
        public static string userName;

        public void loadform(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        public frmMain()
        {
            InitializeComponent();
            lbXinchao.Text = "Xin chào, " + userName;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Sidebartimer.Start();
            loadform(new frm.frmTrangchu());
        }

        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                if(Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    Sidebartimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if(Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    Sidebartimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Sidebartimer.Start();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadform(new frm.frmTrangchu());
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            loadform(new frm.frmGiaoVien());
        }

        private void btnThongtinhocsinh_Click(object sender, EventArgs e)
        {
            loadform(new frm.frmHocSinh());
        }

        // Cho form movable
        private void mainpanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Sidebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLophoc_Click(object sender, EventArgs e)
        {
            loadform(new frmLophoc());
        }

        private void btnHK1_Click(object sender, EventArgs e)
        {
            loadform(new frmBangDiem());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new frmBangdiem2());
        }
    }
}
