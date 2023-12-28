using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fistprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Blue;
        }

        private void txtWelcome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtWelcome.Text = "Welcome to Visual C# !";
            txtWelcome.BackColor = Color.YellowGreen;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWelcome.Text = "";
            txtWelcome.BackColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btnDisplay.Text = rnd.Next(1000).ToString(); // random tối đa 1000, chuyển từ số nguyên sang chuỗi
            btnClear.Text = rnd.Next(100).ToString();
        }
    }
}
