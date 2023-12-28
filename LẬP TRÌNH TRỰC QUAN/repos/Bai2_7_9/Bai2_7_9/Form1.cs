using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_7_9
{
    public partial class Form1 : Form
    {
        int  red, green, blue;

        private void HSBred_Scroll(object sender, ScrollEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            red = HSBred.Value;
            green = HSBgreen.Value;
            blue = HSBblue.Value;
            lblRed.Text = red.ToString();
            lblGreen.Text = green.ToString();
            lblBlue.Text = blue.ToString();
            txtColor.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
