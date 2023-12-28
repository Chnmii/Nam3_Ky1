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
    public partial class frmTrangchu : Form
    {
        Classes.CommonFunction functions = new Classes.CommonFunction();
        Classes.ConnectData data = new Classes.ConnectData();
        private int imageNumber = 1;
        public frmTrangchu()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void frmTrangchu_Load(object sender, EventArgs e)
        {
            chart1.DataSource = data.ReadData("select * from view_chart2");
            chart1.Series["Số lượng"].XValueMember = "MonDay";
            chart1.Series["Số lượng"].YValueMembers = "SL";
            chart1.Titles.Add("Số lượng giáo viên chia theo môn");
            chart2.DataSource = data.ReadData("select * from Chart");
            chart2.Series["Số lượng"].XValueMember = "X";
            chart2.Series["Số lượng"].YValueMembers = "Y";
            chart2.Titles.Add("Biểu đồ điểm của học sinh trong trường");
            chart3.DataSource = data.ReadData("select D.Malop, Max(A.DiemTB) as DiemMax1, Max(B.DiemTB) as DiemMax2 from BANGDIEMHK1 A, BANGDIEMHK2 B, HOCSINH C, LOPHOC D where A.MaHS = C.MaHS and B.MaHS = C.MaHS and C.Malop = D.Malop group by D.Malop");
            chart3.Series["Kỳ 1"].XValueMember = "Malop";
            chart3.Series["Kỳ 1"].YValueMembers = "DiemMax1";
            chart3.Series["Kỳ 2"].XValueMember = "Malop";
            chart3.Series["Kỳ 2"].YValueMembers = "DiemMax2";
            chart3.Titles.Add("Điểm cao nhất trong từng lớp");
        }

        private void LoadnextImage()
        {
            if(imageNumber == 10)
            {
                imageNumber = 1;
            }
            ptbslideshow.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadnextImage();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void frmTrangchu_SizeChanged(object sender, EventArgs e)
        {
            
            if(this.Width == this.MaximumSize.Width)
            {
                ptbslideshow.Location = new Point(490, 12);
                guna2Button1.Location = new Point(476, 252);
                chart1.Location = new Point(483, 330);
                chart2.Location = new Point(127, 12);
                chart3.Location = new Point(821, 252);
                guna2GroupBox1.Location = new Point(104, 356);

            }
            if (this.Width == this.MinimumSize.Width)
            {
                
                ptbslideshow.Location = new Point(370, 12);
                guna2Button1.Location = new Point(396, 252);
                chart1.Location = new Point(413, 330);
                chart2.Location = new Point(47, 12);
                chart3.Location = new Point(761, 252);
                guna2GroupBox1.Location = new Point(24, 356);
                
            }
           
        }
    }
}
