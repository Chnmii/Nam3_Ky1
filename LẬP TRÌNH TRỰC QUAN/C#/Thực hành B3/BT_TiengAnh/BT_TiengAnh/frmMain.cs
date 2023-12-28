using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_TiengAnh
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        

        private void dienTu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDienTu frm = new frmDienTu();
            frm.ShowDialog();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BaiTapDienTu bt1 = new BaiTapDienTu();
            bt1.Debai = "Many people say that schooldays (1) _______ the best days of their life, and they often feel that this " +
                "should be a period of enjoyment. (2) _______, exams often make them unhappy, and many " +
                "students prefer having no exams at all. They say the exams (3) _______ they have to take" +
                "noften make them worried, and they (4) _______ no time to relax. Others, on the other hand, say that " +
                "exams help students study better. They will (5) _______ to study throughout the year, and if they do " +
                "well, they will become more (6) _______ in studying. There are (7) _______ students who prefer " +
                "only final exams. They say that they have to work hard for two months a year and so they have (8) _______ " +
                "time for their leisure activities. They think that this is a better way of (9) _______ students’ " +
                "knowledge and ability (10) _______ the subjectsthey are studying.";

            bt1.Dapan = "Many people say that schooldays (1) are the best days of their life, and they often feel that this " +
                "should be a period of enjoyment. (2) However, exams often make them unhappy, and many " +
                "students prefer having no exams at all. They say the exams (3) which they have to take" +
                "noften make them worried, and they (4) have no time to relax. Others, on the other hand, say that " +
                "exams help students study better. They will (5) have to study throughout the year, and if they do " +
                "well, they will become more (6) interested in studying. There are (7) some students who prefer " +
                "only final exams. They say that they have to work hard for two months a year and so they have (8) more " +
                "time for their leisure activities. They think that this is a better way of (9) assessing students’ " +
                "knowledge and ability (10) in the subjectsthey are studying.";

            List<string> lists = new List<string>();
            lists.Add("are");
            lists.Add("However");
            lists.Add("which");
            lists.Add("have");
            lists.Add("have");
            lists.Add("interested");
            lists.Add("some");
            lists.Add("more");
            lists.Add("assessing");
            lists.Add("in");

            bt1.DapanTungcau = lists;
            StaticData._BTDT.Add(bt1);
           

            BaiTapDienTu bt2 = new BaiTapDienTu();
            bt2.Debai = "Many people say that schooldays (1) _______ the best days of their life, and they often feel that this " +
                "should be a period of enjoyment. (2) _______, exams often make them unhappy, and many " +
                "students prefer having no exams at all. They say the exams (3) _______ they have to take" +
                "noften make them worried, and they (4) _______ no time to relax. Others, on the other hand, say that " +
                "exams help students study better. They will (5) _______ to study throughout the year, and if they do " +
                "well, they will become more (6) _______ in studying. There are (7) _______ students who prefer " +
                "only final exams. They say that they have to work hard for two months a year and so they have (8) _______ " +
                "time for their leisure activities. They think that this is a better way of (9) _______ students’ " +
                "knowledge and ability (10) _______ the subjectsthey are studying.";

            bt2.Dapan = "Many people say that schooldays (1) are the best days of their life, and they often feel that this " +
                "should be a period of enjoyment. (2) However, exams often make them unhappy, and many " +
                "students prefer having no exams at all. They say the exams (3) which they have to take" +
                "noften make them worried, and they (4) have no time to relax. Others, on the other hand, say that " +
                "exams help students study better. They will (5) have to study throughout the year, and if they do " +
                "well, they will become more (6) interested in studying. There are (7) some students who prefer " +
                "only final exams. They say that they have to work hard for two months a year and so they have (8) more " +
                "time for their leisure activities. They think that this is a better way of (9) assessing students’ " +
                "knowledge and ability (10) in the subjectsthey are studying.";

            List<string> lists2 = new List<string>();
            lists2.Add("are");
            lists2.Add("However");
            lists2.Add("which");
            lists2.Add("have");
            lists2.Add("have");
            lists2.Add("interested");
            lists2.Add("some");
            lists2.Add("more");
            lists2.Add("assessing");
            lists2.Add("in");

            bt2.DapanTungcau = lists2;
            StaticData._BTDT.Add(bt2);

            BaiTapDienTu bt3 = new BaiTapDienTu();
            bt3.Debai = "Many people say that schooldays (1) _______ the best days of their life, and they often feel that this " +
                "should be a period of enjoyment. (2) _______, exams often make them unhappy, and many " +
                "students prefer having no exams at all. They say the exams (3) _______ they have to take" +
                "noften make them worried, and they (4) _______ no time to relax. Others, on the other hand, say that " +
                "exams help students study better. They will (5) _______ to study throughout the year, and if they do " +
                "well, they will become more (6) _______ in studying. There are (7) _______ students who prefer " +
                "only final exams. They say that they have to work hard for two months a year and so they have (8) _______ " +
                "time for their leisure activities. They think that this is a better way of (9) _______ students’ " +
                "knowledge and ability (10) _______ the subjectsthey are studying.";

            bt3.Dapan = "Many people say that schooldays (1) are the best days of their life, and they often feel that this " +
                "should be a period of enjoyment. (2) However, exams often make them unhappy, and many " +
                "students prefer having no exams at all. They say the exams (3) which they have to take" +
                "noften make them worried, and they (4) have no time to relax. Others, on the other hand, say that " +
                "exams help students study better. They will (5) have to study throughout the year, and if they do " +
                "well, they will become more (6) interested in studying. There are (7) some students who prefer " +
                "only final exams. They say that they have to work hard for two months a year and so they have (8) more " +
                "time for their leisure activities. They think that this is a better way of (9) assessing students’ " +
                "knowledge and ability (10) in the subjectsthey are studying.";

            List<string> lists3 = new List<string>();
            lists3.Add("are");
            lists3.Add("However");
            lists3.Add("which");
            lists3.Add("have");
            lists3.Add("have");
            lists3.Add("interested");
            lists3.Add("some");
            lists3.Add("more");
            lists3.Add("assessing");
            lists3.Add("in");

            bt3.DapanTungcau = lists3;
            StaticData._BTDT.Add(bt3);


        }
    }
}
