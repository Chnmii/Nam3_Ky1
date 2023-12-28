using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraGiuaKy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            txtPhut.Text = "00";
            txtGiay.Text = "00";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int m, s;
            m = int.Parse(txtPhut.Text);
            s = int.Parse(txtGiay.Text);
            if (s > 0 && s <= 59)
                s = s - 1;
            else
            {
                if (s == 0 && m > 0)
                {
                    s = 59;
                    m = m - 1;
                }
                if (s == 0 && m == 0)
                {
                    timer1.Stop();
                    
                }
            }
            txtPhut.Text = m.ToString();
            txtGiay.Text = s.ToString();
        }

        private void btnChay_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnTamDung_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void txtPhut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Có hay không?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }  
        }
    }
}
