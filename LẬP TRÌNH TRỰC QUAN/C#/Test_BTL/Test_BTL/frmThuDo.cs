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
    public partial class frmThuDo : Form
    {
        public frmThuDo()
        {
            InitializeComponent();
        }
        private void EmptyOption(EventArgs e)
        {
            rdTD1.Checked = false;
            rdTD2.Checked = false;
            rdTD3.Checked = false;
            rdTD4.Checked = false;
            rdTD5.Checked = false;
            rdTD6.Checked = false;

        }


        private void radioButton1_Click(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            lblTitle.Text = "Hãy chọn thành phố cho " + rd.Text;

            
        }

        private void rdCT1_CheckedChanged(object sender, EventArgs e)
        {
            EmptyOption(e);
            RadioButton rd1 = (RadioButton)sender;
            /*if (rdTD3.Checked == true)
            {
                MessageBox.Show("Chúc mừng bạn, thủ đô của France là Paris", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn sai rồi, thủ đô của France không phải là London", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  */  
        }
    }
}
