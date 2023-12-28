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

namespace BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        // chưa hoàn thiện!
        private void btnTong_Click(object sender, EventArgs e)
        {
            int a, b;
            int s = 0;
            String s1 = "";
            a = int.Parse(txtsoa.Text);
            b = int.Parse(txtsob.Text);
            if(a > b)
            {
                int c = a;
                a = b;
                b = c;
            }
            for(int i = a; i <= b; i++)
            {
                s += i;
            }
            s1 = s1 + "Tong tu " + a + " den " + b +" la : " + s;

            lbketqua.Text = s1;
            //lbketqua.BackColor = Color.Red;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtsoa.Text = "";
            txtsob.Text = "";
            txtsoa.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
