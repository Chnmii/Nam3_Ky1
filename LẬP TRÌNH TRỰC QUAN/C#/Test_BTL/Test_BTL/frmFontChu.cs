using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_BTL
{
    public partial class frmFontChu : Form
    {
        public frmFontChu()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            txtTieuDe.Font = new Font(rd.Text, txtTieuDe.Font.Size, txtTieuDe.Font.Style);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            txtTieuDe.Font = new Font(txtTieuDe.Font.Name, txtTieuDe.Font.Size, txtTieuDe.Font.Style ^ cb.Font.Style);
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            txtTieuDe.ForeColor = rb.ForeColor;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtTieuDe.Font = new Font("Segoe Print", 10, FontStyle.Regular);
            txtTieuDe.ForeColor = Color.Black;
            // bor di toan bo 
            foreach (Control ct in this.Controls)
            {
                if (ct is GroupBox)
                {
                    foreach (Control item in ct.Controls)
                    {
                        if (item is CheckBox)
                        {
                            CheckBox t = item as CheckBox;
                            t.Checked = false;
                        }
                        if (item is RadioButton)
                        {
                            RadioButton t = item as RadioButton;
                            t.Checked = false;
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong ? ", "Co hay khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
