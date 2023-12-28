using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLHS.frm
{
    public partial class frmGiaoVien : Form
    {
        Classes.CommonFunction functions = new Classes.CommonFunction();
        Classes.ConnectData data = new Classes.ConnectData();
        private int btn = 0;
        public frmGiaoVien()
        {
            InitializeComponent();
            btnAccept.Visible = false;
            btnCancel.Visible = false;
            
        }

        public void Xoahet()
        {
            tbMaGV.Text = null;
            tbHoTen.Text = null;
            cbbMalop.Text = null;
            tbDiachi.Text = null;
            tbSDT.Text = null;
            tbMonhoc.Text = null;
            dtpNgaysinh.Text = null;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }

        public void Notenable()
        {
            tbMaGV.Enabled = false;
            tbHoTen.Enabled = false;
            cbbMalop.Enabled = false;
            tbDiachi.Enabled = false;
            tbSDT.Enabled = false;
            tbMonhoc.Enabled = false;
            dtpNgaysinh.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;
        }

        public void En()
        {
            tbMaGV.Enabled = true;
            tbHoTen.Enabled = true;
            cbbMalop.Enabled = true;
            tbDiachi.Enabled = true;
            tbSDT.Enabled = true;
            tbMonhoc.Enabled = true;
            dtpNgaysinh.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            DataTable dtGV = data.ReadData("Select * from GIAOVIEN");
            dgvGiaoVien.DataSource = dtGV;
            dgvGiaoVien.ColumnHeadersHeight = 40;
            DataTable dtML = data.ReadData("Select * from LOPHOC");
            functions.FillComboBox(cbbMalop, dtML, "Malop", "Malop");
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void guna2Panel1_SizeChanged(object sender, EventArgs e)
        {
            //btnThem.Location = new Point(959, 6);
        }

        private void guna2DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbMaGV.Text = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            tbHoTen.Text = dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
            cbbMalop.Text = dgvGiaoVien.CurrentRow.Cells[2].Value.ToString();
            tbDiachi.Text = dgvGiaoVien.CurrentRow.Cells[3].Value.ToString();
            tbSDT.Text = dgvGiaoVien.CurrentRow.Cells[4].Value.ToString();
            tbMonhoc.Text = dgvGiaoVien.CurrentRow.Cells[5].Value.ToString();
            dtpNgaysinh.Text = dgvGiaoVien.CurrentRow.Cells[6].Value.ToString();
            if(dgvGiaoVien.CurrentRow.Cells[7].Value.ToString() == "Nam")
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNu.Checked = true;
                rdoNam.Checked = false;
            }
            Notenable();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Xoahet();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btn = 1;
            Xoahet();
            En();
            btnAccept.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(btn == 1)
            {
                if (tbMaGV.Text == "")
                {
                    msdError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    msdError.Text = "Vui lòng nhập đầy đủ thông tin";
                    msdError.Show();
                    tbMaGV.Focus();
                }
                else
                {
                    DataTable dtgv = data.ReadData("Select * from GIAOVIEN where " + "MaGV = N'" + tbMaGV.Text + "'");
                    if (dtgv.Rows.Count > 0)
                    {
                        msdError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                        msdError.Text = "Đã có Giáo viên này xin vui lòng thử lại!";
                        msdError.Show();
                        tbMaGV.Focus();
                    }
                    else
                    {
                        if (rdoNam.Checked == true)
                        {
                            data.UpdateData("INSERT INTO GIAOVIEN VALUES(N'" + tbMaGV.Text + "', N'" + tbHoTen.Text + "', N'" + cbbMalop.Text + "', N'"
                          + tbDiachi.Text + "', N'" + tbSDT.Text + "', N'" + tbMonhoc.Text + "', '" + dtpNgaysinh.Text + "', N'" + "Nam')");
                        }
                        else
                        {
                            data.UpdateData("INSERT INTO GIAOVIEN VALUES(N'" + tbMaGV.Text + "', N'" + tbHoTen.Text + "', N'" + cbbMalop.Text + "', N'"
                          + tbDiachi.Text + "', N'" + tbSDT.Text + "', N'" + tbMonhoc.Text + "', '" + dtpNgaysinh.Text + "', N'" + "Nữ')");
                        }
                        msdError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                        msdError.Text = "Đã thêm thành công!";
                        msdError.Show();
                        dgvGiaoVien.DataSource = data.ReadData("SELECT * FROM GIAOVIEN");
                        btnAccept.Visible = false;
                        btnCancel.Visible = false;
                    }
                }
            }
            else if(btn == 2)
            {
                if (rdoNam.Checked == true)
                {
                    data.UpdateData("UPDATE GIAOVIEN SET TenGV = N'" + tbHoTen.Text + "', Malop = N'" + cbbMalop.Text + "', Diachi = N'"
                        + tbDiachi.Text + "', SDT = N'" + tbSDT.Text + "', MonDay = N'" + tbMonhoc.Text + "', Ngaysinh = '"
                        + dtpNgaysinh.Text + "', Gioitinh = N'Nam' WHERE MaGV = N'" + tbMaGV.Text + "'");
                    dgvGiaoVien.DataSource = data.ReadData("SELECT * FROM GIAOVIEN");
                    btnThem.Enabled = true;
                }
                if (rdoNu.Checked == true)
                {
                    data.UpdateData("UPDATE GIAOVIEN SET TenGV = N'" + tbHoTen.Text + "', Malop = N'" + cbbMalop.Text + "', Diachi = N'"
                        + tbDiachi.Text + "', SDT = N'" + tbSDT.Text + "', MonDay = N'" + tbMonhoc.Text + "', Ngaysinh = '"
                        + dtpNgaysinh.Text + "', Gioitinh = N'Nữ' WHERE MaGV = N'" + tbMaGV.Text + "'");
                    dgvGiaoVien.DataSource = data.ReadData("SELECT * FROM GIAOVIEN");
                    btnThem.Enabled = true;
                    
                }
                
            }
            else if(btn == 3)
            {
                data.UpdateData("DELETE GIAOVIEN WHERE MaGV = '" + tbMaGV.Text + "'");
                msdError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                msdError.Text = "Đã xóa";
                msdError.Show();
                dgvGiaoVien.DataSource = data.ReadData("SELECT * FROM GIAOVIEN");
                Xoahet();
                Notenable();
                btnAccept.Visible = false;
                btnCancel.Visible = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else if(btn == 4)
            {
                DataTable dtgv = data.ReadData("Select * from GIAOVIEN where " + "MaGV = N'" + tbMaGV.Text + "' or TenGV = '" + tbHoTen.Text +"'");
                if(dtgv.Rows.Count > 0)
                {
                    dgvGiaoVien.DataSource = dtgv;
                    btnThem.Enabled = true;
                    btn = 0;
                }
                else
                {
                    msdError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    msdError.Text = "Không có giáo viên này!";
                    msdError.Show();

                }
            }
            else
            {
                DataTable dt = data.ReadData("SELECT * FROM GIAOVIEN");
                if (dt.Rows.Count > 0)
                {
                    Excel.Application exApp = new Excel.Application();
                    Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                    Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                    Excel.Range Tenbang = (Excel.Range)exSheet.Cells[1, 1];
                    Tenbang.Font.Size = 13;
                    Tenbang.Font.Bold = true;
                    Tenbang.Font.Color = Color.Red;
                    Tenbang.Value = "Danh sách giáo viên";

                    exSheet.get_Range("A7:I7").Font.Bold = true;
                    exSheet.get_Range("A7:I7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    exSheet.get_Range("A7").Value = "STT";
                    exSheet.get_Range("B7").Value = "Mã GV";
                    exSheet.get_Range("B7:K7").ColumnWidth = 30;
                    exSheet.get_Range("C7").Value = "Tên GV";
                    exSheet.get_Range("D7").Value = "Mã lớp";
                    exSheet.get_Range("E7").Value = "Địa chỉ";
                    exSheet.get_Range("F7").Value = "SDT";
                    exSheet.get_Range("G7").Value = "Môn dạy";
                    exSheet.get_Range("H7").Value = "Ngày sinh";
                    exSheet.get_Range("I7").Value = "Giới tính";

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        exSheet.get_Range("A" + (i + 8).ToString() + ":I" + (i + 8).ToString()).Font.Bold = false;
                        exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                        exSheet.get_Range("B" + (i + 8).ToString()).Value = dt.Rows[i]["MaGV"].ToString();
                        exSheet.get_Range("C" + (i + 8).ToString()).Value = dt.Rows[i]["TenGV"].ToString();
                        exSheet.get_Range("D" + (i + 8).ToString()).Value = dt.Rows[i]["Malop"].ToString();
                        exSheet.get_Range("E" + (i + 8).ToString()).Value = dt.Rows[i]["Diachi"].ToString();
                        exSheet.get_Range("F" + (i + 8).ToString()).Value = dt.Rows[i]["SDT"].ToString();
                        exSheet.get_Range("G" + (i + 8).ToString()).Value = dt.Rows[i]["MonDay"].ToString();
                        exSheet.get_Range("H" + (i + 8).ToString()).Value = dt.Rows[i]["Ngaysinh"].ToString();
                        exSheet.get_Range("I" + (i + 8).ToString()).Value = dt.Rows[i]["Gioitinh"].ToString();
                    }

                    exSheet.Name = "Danh sách";
                    exBook.Activate();
                    saveFileDialog1.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
                    saveFileDialog1.FilterIndex = 1;
                    saveFileDialog1.AddExtension = true;
                    saveFileDialog1.DefaultExt = ".xls";
                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        exBook.SaveAs(saveFileDialog1.FileName.ToString());
                    exApp.Quit();
                }
                else
                    MessageBox.Show("Không có danh sách hàng để in");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            btn = 3;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            tbMaGV.Enabled = false;
            btn = 2;
            En();
            tbMaGV.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(btn == 1)
            {
                btnAccept.Visible = false;
                btnCancel.Visible = false;
                Xoahet();
                Notenable();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btn = 0;
            }
            else if(btn == 2)
            {
                btnAccept.Visible = false;
                btnCancel.Visible = false;
                Xoahet();
                Notenable();
                btnThem.Enabled = true;
                
                btn = 0;
            }
            else if(btn == 3)
            {
                btnAccept.Visible = false;
                btnCancel.Visible = false;
                Xoahet();
                Notenable();
                btnThem.Enabled = true;
                btn = 0;
            }
            else if(btn == 4)
            {
                btnAccept.Visible = false;
                btnCancel.Visible = false;
                Xoahet();
                Notenable();
                btn = 0;
                DataTable dtGV = data.ReadData("Select * from GIAOVIEN");
                dgvGiaoVien.DataSource = dtGV;
            }
            else
            {
                btnAccept.Visible = false;
                btnCancel.Visible = false;
                DataTable dtGV = data.ReadData("Select * from GIAOVIEN");
                dgvGiaoVien.DataSource = dtGV;
                Xoahet();
                Notenable();
                btn = 0;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Notenable();
            tbMaGV.Enabled = true;
            tbHoTen.Enabled = true;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            btn = 4;
        }

        private void frmGiaoVien_SizeChanged(object sender, EventArgs e)
        {
            if(this.Width == this.MaximumSize.Width)
            {
                btnThem.Location = new Point(168, 9 );
                btnSua.Location = new Point(327, 9);
                btnXoa.Location = new Point(487, 9);
                btnReset.Location = new Point(647, 9);
                btnTimkiem.Location = new Point(814, 9);
                guna2Button4.Location = new Point(979, 9);
                guna2GroupBox2.Size = new Size(872, 498);
            }
            if(this.Width == this.MinimumSize.Width)
            {
                btnThem.Location = new Point(70, 9);
                btnSua.Location = new Point(229, 9);
                btnXoa.Location = new Point(389, 9);
                btnReset.Location = new Point(549, 9);
                btnTimkiem.Location = new Point(716, 9);
                guna2Button4.Location = new Point(881, 9);
                guna2GroupBox2.Size = new Size(724, 498);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            btn = 5;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
        }
    }
}
