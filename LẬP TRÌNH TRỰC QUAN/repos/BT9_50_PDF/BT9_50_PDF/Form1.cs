using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT9_50_PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoVnTime_Click(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;
            txtFont.Font = new Font(rd.Text, txtFont.Font.Size, txtFont.Font.Style);
        }

        private void checkboxBold_Click(object sender, EventArgs e)
        {
            CheckBox ckb = sender as CheckBox;
            txtFont.Font = new Font(txtFont.Font.Name, txtFont.Font.Size, txtFont.Font.Style ^ ckb.Font.Style);
            // 
        }

        private void rdoXanh_Click(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;
            txtFont.ForeColor = rd.ForeColor;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtFont.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            txtFont.ForeColor = Color.Black;
           // bor di toan bo 
           foreach(Control ct in this.Controls)
            {
                if(ct is GroupBox)
                {
                    foreach(Control item in ct.Controls)
                    {
                        if(item is CheckBox)
                        {
                            CheckBox t = item as CheckBox;
                            t.Checked = false;
                        }
                        if(item is RadioButton)
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
