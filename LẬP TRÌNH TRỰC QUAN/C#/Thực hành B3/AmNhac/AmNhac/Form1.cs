using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmNhac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                cbbODia.Items.Add(drive.Name);
            }
            
        }

        private void cbbODia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cbbThuMuc.Items.Clear();
            DirectoryInfo Directory = new DirectoryInfo(cbbODia.Text);
            DirectoryInfo[] Directories = Directory.GetDirectories("*.*");
            FileInfo[] files = Directory.GetFiles();
            foreach (DirectoryInfo d in Directories)
            {
                cbbThuMuc.Items.Add(d.Name);
            }

        }

        private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbTapTin.Items.Clear();
            axWindowsMediaPlayer1.Text = "";
            string[] files = Directory.GetFiles(cbbODia.Text + cbbThuMuc.Text);
            foreach (string file in files)
            {
                lsbTapTin.Items.Add(file);
            }
        }

        private void lsbTapTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = lsbTapTin.Text;
            string[] LoiBH = lsbTapTin.Text.Split('.');
            FileStream fs = new FileStream(LoiBH[0] + ".txt", FileMode.Open);            
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            string line = rd.ReadToEnd();
            rtbLoiBH.Text = line;         
                          
        }
    }
}
