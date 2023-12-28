using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btn_ToaDoCacDiem_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTona_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;
            x1 = double.Parse(txtX1.Text);
            x2 = double.Parse(txtX2.Text);
            y1 = double.Parse(txtY1.Text);
            y2 = double.Parse(txtY2.Text);
            txtHSG.Text = ((y2 - y1) / (x2 - x1)).ToString();
            txtKC.Text = (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))).ToString();
        }
    }
}
