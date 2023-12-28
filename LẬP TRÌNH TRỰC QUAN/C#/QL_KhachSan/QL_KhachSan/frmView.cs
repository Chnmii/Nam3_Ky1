using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        Classes.ConnectData dtbase = new Classes.ConnectData();

        private void picThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void SetFontAndColors()
        {
            this.dgvView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        private void cbbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvView.DataSource = dtbase.ReadData("select * from BTL_V_" + (cbbView.SelectedIndex+1).ToString() );

        }

        private void frmView_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
        }
    }
}
