using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIME_7_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int m, s;
            m = int.Parse(txtminutes.Text);
            s = int.Parse(txtseconds.Text);
            if (s > 0 && s <= 59)
                s = s - 1;
            else
            {
                if(s == 0 && m > 0)
                {
                    s = 59;
                    m = m - 1;
                }
                if(s == 0 && m == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Da het gio!");
                }
            }
            txtminutes.Text = m.ToString();
            txtseconds.Text = s.ToString();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            txtminutes.Text = "0";
            txtseconds.Text="0";
        }
    }
}
