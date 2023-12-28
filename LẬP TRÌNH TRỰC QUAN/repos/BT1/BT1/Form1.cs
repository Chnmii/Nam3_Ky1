using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnketqua_Click(object sender, EventArgs e)
        {
            string s = "";
            int thang, nam;
            thang = int.Parse(txtthang.Text);
            nam = int.Parse(txtnam.Text);          
/*
            int x = DateTime.DaysInMonth(thang, nam); */

            s = s + "Thang " + thang + " nam " + nam + " co ";// + x

            if (thang >=1 && thang <= 12)
            {
                if(thang == 2)
                {
                    if(nam % 4 == 0)
                    {
                        s = s + 29;
                    }
                    else
                    {
                        s = s + 28;
                    }
                }
                else if(thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
                {
                    s = s + 31;
                }
                else
                {
                    s = s + 30;
                }
            }
            lbtong.Text = s;
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txtthang.Text = "";
            txtnam.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
