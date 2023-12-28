using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu20_8
{
    public partial class Form1 : Form
    {   
        int n;
        int[] a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "Day so la : ";
            // lay gia tri n
            n = int.Parse(txtbox.Text);
            // cap phat bo nho cho mang
            a = new int[n];
            //sinh day so
            Random rd = new Random();
            for(int i=0; i<n; i++)
            {
                a[i] = rd.Next(100);
                s = s + " " +a[i];
            }
            input.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int S = 0;
            for(int i=0; i<n; i++)
            {
                S += a[i];
            }
            string s = "Tong la : ";
            s = s + " " + S;
            inputTong.Text = s;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co muon thoat khong ? ", "Co hay khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.Close();
        }
    }
}
