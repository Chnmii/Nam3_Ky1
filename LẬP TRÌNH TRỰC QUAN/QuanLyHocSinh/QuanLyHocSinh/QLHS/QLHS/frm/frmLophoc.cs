using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.frm
{
    public partial class frmLophoc : Form
    {
        Classes.CommonFunction functions = new Classes.CommonFunction();
        Classes.ConnectData data = new Classes.ConnectData();
        private int btn = 0;
        public frmLophoc()
        {
            InitializeComponent();
            btnAccept.Visible = false;
            btnCancel.Visible = false;
            notenable();
        }

        public void notenable()
        {
            tbMalop.Enabled = false;
            tbSiso.Enabled = false;
            tbKhoi.Enabled = false;
            tbGVCN.Enabled = false;
        }

        public void enable()
        {
            tbMalop.Enabled = true;
            tbSiso.Enabled = true;
            tbKhoi.Enabled = true;
            tbGVCN.Enabled = true;
        }

        public void clear()
        {
            tbMalop.Text = null;
            tbSiso.Text = null;
            tbKhoi.Text = null;
            tbGVCN.Text = null;
        }

        public bool notnull()
        {
            if((tbMalop.Text == "") || (tbMalop.Text == "" && tbSiso.Text == "" && tbKhoi.Text == "" && tbGVCN.Text == ""))
            {
                msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                msd.Text = "Yêu cầu nhập đầy đủ!";
                msd.Show();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmLophoc_Load(object sender, EventArgs e)
        {
            dgvLophoc.DataSource = data.ReadData("SELECT * FROM LOPHOC");
            dgvLophoc.ColumnHeadersHeight = 40;
        }

        private void dgvLophoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMalop.Text = dgvLophoc.CurrentRow.Cells[0].Value.ToString();
            tbSiso.Text = dgvLophoc.CurrentRow.Cells[1].Value.ToString();
            tbGVCN.Text = dgvLophoc.CurrentRow.Cells[2].Value.ToString();
            tbKhoi.Text = dgvLophoc.CurrentRow.Cells[3].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btn = 1;
            clear();
            enable();
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }



        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(btn == 1)
            {
                DataTable dtLop = data.ReadData("SELECT * FROM LOPHOC WHERE Malop = N'" + tbMalop.Text + "'");
                if(dtLop.Rows.Count > 0)
                {
                    msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    msd.Text = "Đã có lớp này vui lòng thêm lớp khác!";
                    msd.Show();
                }
                else
                {
                    if(notnull() == true)
                    {
                        data.UpdateData("INSERT INTO LOPHOC VALUES(N'" + tbMalop.Text + "', N'" + tbSiso.Text + "', N'" + tbGVCN.Text + "', N'"
                      + tbKhoi.Text + "')");
                        msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                        msd.Text = "Đã thêm thành công!";
                        msd.Show();
                        dgvLophoc.DataSource = data.ReadData("SELECT * FROM LOPHOC");
                        btn = 0;
                    }
                    else
                    {
                        tbMalop.Focus();
                    }
                    btnAccept.Visible = false;
                    btnCancel.Visible = false;
                    notenable();
                }
            }
            else if(btn == 2)
            {
                data.UpdateData("UPDATE LOPHOC SET Siso = N'" + tbSiso.Text + "', GVCN = N'" + tbGVCN.Text + "', KHOI = N'"
                        + tbKhoi.Text + "' WHERE Malop = '" + tbMalop.Text + "'");
                dgvLophoc.DataSource = data.ReadData("SELECT * FROM LOPHOC");
            }
            else if(btn == 3)
            {
                data.UpdateData("DELETE LOPHOC WHERE Malop = '" + tbMalop.Text + "'");
                msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                msd.Text = "Đã xóa";
                msd.Show();
                dgvLophoc.DataSource = data.ReadData("SELECT * FROM LOPHOC");
                clear();
                notenable();
                btnAccept.Visible = false;
                btnCancel.Visible = false;
            }
            else
            {
                DataTable dtlop = data.ReadData("Select * from LOPHOC where " + "Malop = N'" + tbMalop.Text + "'");
                if (dtlop.Rows.Count > 0)
                {
                    dgvLophoc.DataSource = dtlop;
                    btn = 0;
                }
                else
                {
                    msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    msd.Text = "Không có lớp này!";
                    msd.Show();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btn = 3;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btn = 2;
            enable();
            btnAccept.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            notenable();
            tbMalop.Enabled = true;
            btn = 4;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAccept.Visible = false;
            btnCancel.Visible = false;
            clear();
            notenable();
            btn = 0;
        }

        private void frmLophoc_SizeChanged(object sender, EventArgs e)
        {
            if(this.Width == this.MaximumSize.Width)
            {
                btnThem.Location = new Point(511, 452);
                btnSua.Location = new Point(647, 452);
                btnXoa.Location = new Point(789, 452);
                btnReset.Location = new Point(1060, 452);
                btnTimkiem.Location = new Point(927, 452);
                guna2GroupBox1.Location = new Point(511, 25);
                dgvLophoc.Size = new Size(479, 549);
            }
            if (this.Width == this.MinimumSize.Width)
            {
                btnThem.Location = new Point(411, 452);
                btnSua.Location = new Point(547, 452);
                btnXoa.Location = new Point(689, 452);
                btnReset.Location = new Point(960, 452);
                btnTimkiem.Location = new Point(827, 452);
                guna2GroupBox1.Location = new Point(411, 25);
                dgvLophoc.Size = new Size(379, 549);
            }
        }
    }
}
