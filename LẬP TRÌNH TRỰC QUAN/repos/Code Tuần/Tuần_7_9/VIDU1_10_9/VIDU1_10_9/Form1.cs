using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIDU1_10_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpen = new OpenFile=();
            odlgOpen.Filter = "JPEG Images|*.jpg|Bitmap Images|*.bmp|All Files|*.*";
            odlgOpen.FilterIndex = 1;
            odlgOpen.Title = "Select a image File to open";
            if(odlgOpen.ShowDialog() == DialogResult.OK) // Khi nguoi dung kick nut open
                picture.Image = Image.FromFile(odlgOpen.FileName);
        }
    }
}
