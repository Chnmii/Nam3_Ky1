using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_BTL
{
    public partial class frmMonAnCLB : Form
    {
        public frmMonAnCLB()
        {
            InitializeComponent();
        }

        private void frmMonAnCLB_Load(object sender, EventArgs e)
        {
            clbMonAn.MultiColumn = true;
            clbMonAn.ColumnWidth = clbMonAn.Width / 2;
            clbMonAn.Items.Add("Gà nướng");
            clbMonAn.Items.Add("Bún ốc");
            clbMonAn.Items.Add("Bún chả");
            clbMonAn.Items.Add("Phở Hà Nội");
            clbMonAn.Items.Add("Bánh đa cua");
            clbMonAn.Items.Add("Xôi khúc");
            clbMonAn.Items.Add("Phở cuốn");
            clbMonAn.Items.Add("Bánh mì sốt vang");
            clbMonAn.Items.Add("Bánh cuốn");
            clbMonAn.Items.Add("Bún đậu mắm tôm");
            clbMonAn.Items.Add("Gà nướng");
            clbMonAn.Items.Add("Bún ốc");
            clbMonAn.Items.Add("Bún chả");
            clbMonAn.Items.Add("Phở Hà Nội");
            clbMonAn.Items.Add("Bánh đa cua");
            clbMonAn.Items.Add("Xôi khúc");
            clbMonAn.Items.Add("Phở cuốn");
            clbMonAn.Items.Add("Bánh mì sốt vang");
            clbMonAn.Items.Add("Bánh cuốn");
            clbMonAn.Items.Add("Bún đậu mắm tôm");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbMonAn_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                MessageBox.Show("Bạn vừa chọn thêm món: " + clbMonAn.SelectedItem,
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (string item in clbMonAn.CheckedItems)
                str = str + item + ", ";
            //Xóa dấu phẩy và dấu cách thừa cuối chuỗi
            str = str.Remove(str.Length - 2, 2);
            MessageBox.Show("Bạn đã chọn các món sau: " + str);

        }
    }
}
