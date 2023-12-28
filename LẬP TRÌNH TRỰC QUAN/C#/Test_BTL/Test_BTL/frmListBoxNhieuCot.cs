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

namespace Test_BTL
{
    public partial class frmListBoxNhieuCot : Form
    {
        public frmListBoxNhieuCot()
        {
            InitializeComponent();
        }

        string thongbao;
        private void frmListBoxNhieuCot_Load(object sender, EventArgs e)
        {
            int i;
            listBox1.MultiColumn = true;
            listBox1.ColumnWidth = listBox1.Width / 4;
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            for (i = 1; i <= 100; i++)
            {
                listBox1.Items.Add("Item " + i.ToString());
            }

            // combobox các thư mục con có trong thư mục "D:\\Visual Studio Code\\C#"
            string[] folder;
            folder = System.IO.Directory.GetDirectories("D:\\Visual Studio Code\\C#");
            cbbThuMuc.DataSource = folder;

            // combobox các file có trong thư mục "D:\Word"
            string[] file;
            file = Directory.GetFiles("D:\\Word");
            cbbFile.DataSource = file;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.SelectedItems)
            {
                thongbao = thongbao + item + ", ";
            }
            thongbao = thongbao.Remove(thongbao.Length - 2, 2);
            MessageBox.Show("Bạn đã chọn các phần tử: " + thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
