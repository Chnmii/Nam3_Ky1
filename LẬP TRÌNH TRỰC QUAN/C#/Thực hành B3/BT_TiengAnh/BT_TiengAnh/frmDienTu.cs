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
using static BT_TiengAnh.frmMain;

namespace BT_TiengAnh
{
    public partial class frmDienTu : Form
    {
        public frmDienTu()
        {
            for (int i = 0; i < StaticData._BTDT.Count; i++)
            {
                if (i == DataClick.check)
                {
                    _baiTapDienTu = StaticData._BTDT[i];
                    break;
                }

            }
            InitializeComponent();
            
        }

        BaiTapDienTu _baiTapDienTu = new BaiTapDienTu();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void frmDienTu_Load(object sender, EventArgs e)
        {
            rtbDeBai.Text = _baiTapDienTu.Debai;
        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            rtbDeBai.Text = _baiTapDienTu.Dapan;
            btnOK.Enabled = false;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int diem = 0;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||
                textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ câu trả lời của bạn");
            }
            else
            {
                if (textBox1.Text == _baiTapDienTu.DapanTungcau[0])
                {
                    textBox1.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                }
                if (textBox2.Text == _baiTapDienTu.DapanTungcau[1])
                {
                    textBox2.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    textBox2.BackColor = Color.Red;
                }
                if (textBox3.Text == _baiTapDienTu.DapanTungcau[2])
                {
                    textBox3.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    textBox3.BackColor = Color.Red;
                }
                if (textBox4.Text == _baiTapDienTu.DapanTungcau[3])
                {
                    textBox4.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    textBox4.BackColor = Color.Red;
                }
                if (textBox5.Text == _baiTapDienTu.DapanTungcau[4])
                {
                    textBox5.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    textBox5.BackColor = Color.Red;
                }
                if (textBox6.Text == _baiTapDienTu.DapanTungcau[5])
                {
                    textBox6.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    textBox6.BackColor = Color.Red;
                }
                if (textBox7.Text == _baiTapDienTu.DapanTungcau[6])
                {
                    textBox7.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    textBox7.BackColor = Color.Red;
                }
                if (textBox8.Text == _baiTapDienTu.DapanTungcau[7])
                {
                    textBox8.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    textBox8.BackColor = Color.Red;
                }
                if (textBox9.Text == _baiTapDienTu.DapanTungcau[8])
                {
                    textBox9.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    textBox9.BackColor = Color.Red;
                }
                if (textBox10.Text == _baiTapDienTu.DapanTungcau[9])
                {
                    textBox10.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    textBox10.BackColor = Color.Red;
                }
                MessageBox.Show("Điểm của bạn: " + diem);
            }
            
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            rtbDeBai.Text = _baiTapDienTu.Debai;
            textBox1.BackColor = Color.White;
            textBox1.Text = "";
            textBox2.BackColor = Color.White;
            textBox2.Text = "";
            textBox3.BackColor = Color.White;
            textBox3.Text = "";
            textBox4.BackColor = Color.White;
            textBox4.Text = "";
            textBox5.BackColor = Color.White;
            textBox5.Text = "";
            textBox6.BackColor = Color.White;
            textBox6.Text = "";
            textBox7.BackColor = Color.White;
            textBox7.Text = "";
            textBox8.BackColor = Color.White;
            textBox8.Text = "";
            textBox9.BackColor = Color.White;
            textBox9.Text = "";
            textBox10.BackColor = Color.White;
            textBox10.Text = "";
            btnOK.Enabled = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;
            textBox9.ReadOnly = false;
            textBox10.ReadOnly = false;
            return;
        }
    }
    public class BaiTapDienTu
    {
        private string debai;
        private string dapan;
        private List<string> dapanTungcau;

        public BaiTapDienTu() { }
        public BaiTapDienTu(string debai, string dapan, List<string> dapanTungcau)
        {
            this.Debai = debai;
            this.Dapan = dapan;
            this.DapanTungcau = dapanTungcau;
        }

        public BaiTapDienTu(string debai, string dapan)
        {
            this.Debai1 = debai;
            this.Dapan1 = dapan;
        }

        public string Debai { get; set; }
        public string Dapan { get; set; }
        public string Debai1 { get; set; }
        public string Dapan1 { get; set; }
        public List<string> DapanTungcau { get; set; }

    }

    class StaticData
    {
        public static List<BaiTapDienTu> _BTDT = new List<BaiTapDienTu>();

    }

    class DataClick
    {
        public static int check;
    }
}
