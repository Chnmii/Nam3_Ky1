using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmCheDo : Form
    {
        Classes.ConnectDataB data = new Classes.ConnectDataB();
        public frmCheDo()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            DataTable dtBH = data.DataReader("Select * from TblSoBH");
            dgvBH.DataSource = dtBH;
        }

        private void btnMoiBH_Click(object sender, EventArgs e)
        {
            DataTable dtBH = data.DataReader("Select * from TblSoBH where MaNV='" + txtMaNVBH.Text + "'");
            if (dtBH.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã có, mời bạn nhập mã khác");
                txtMaNVBH.Focus();
                return;
            }
            //Thêm mới hàng vào DataBase 
            string sqlInsert = "insert into TblSoBH values('" + txtMaNVBH.Text + "','" + txtMaLuongBH.Text + "','" + txtMaBH.Text
                + "',N'" + String.Format("{0:u}", dtNgayCap.Value.Date) + "',N'" + txtNoiCap.Text + "',N'" +
                txtGhiChuBH.Text + "')";
            data.DataChange(sqlInsert);
            LoadData();
            MessageBox.Show("Thêm mới thành công");
            ResetValue();
        }

        void ResetValue()
        {
            txtGhiChuBH.Text = "";
            txtMaBH.Text = "";
            txtMaNVBH.Text = "";
            txtMaLuongBH.Text = "";
            txtNoiCap.Text = "";
            txtGhiChuBH.Text = "";
            txtMaNVBH.Focus();
            btnMoiBH.Enabled = true;
            btnLuuBH.Enabled = false;
            btnSuaBH.Enabled = false;
            btnXoaBH.Enabled = false;
        }
    }
}
