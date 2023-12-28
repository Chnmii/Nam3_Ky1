using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{

    public partial class Form1 : Form
    {
        int n, tong = 0;
        string day = "Day so : ";
        string tongds = "Tong day so = ";
        string sapxep = "Day sau khi sap xep la : ";
        Random rd = new Random();
        int[] a;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            
            n = int.Parse(txtn.Text);
            
            a = new int[n];
            for(int i=0; i<n; i++)
            {     
                a[i] = rd.Next(100);
                day = day + " " + a[i];
            }
            
            lbinput.Text = day;   
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(100);
                day = day + " " + a[i];
                tong += a[i];
            }
            tongds += tong;
            lbtong.Text = tongds;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtn.Text = "";
            lbinput.Text = "Dãy số : ";
            lbtong.Text = "Tổng : ";
            lbsapxep.Text = "Dãy sau khi sắp xếp từ bé đến lớn : ";
        }

        private void btnSapxep_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
                sapxep += " " + a[i];
            }
            sapxep += " " + a[n - 1];
            lbsapxep.Text = sapxep;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
