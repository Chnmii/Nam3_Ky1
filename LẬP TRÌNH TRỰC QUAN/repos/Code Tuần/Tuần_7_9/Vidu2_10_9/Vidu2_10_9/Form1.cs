using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidu2_10_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Word Ducument|*.doc|Rich Text Format|*.rtf|All files|*.*";
            ofd.FilterIndex = 2;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rtfDocument.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error : "+ex.Message);
                }
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                rtfDocument.SelectionFont = fd.Font;
                rtfDocument.SelectionColor = fd.Color;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
                rtfDocument.BackColor = cd.Color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SaveFileDialog  trong slide
        }
    }
}
