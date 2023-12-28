using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLHS.frm
{
    public partial class frmHocSinh : Form
    {
        Classes.CommonFunction functions = new Classes.CommonFunction();
        Classes.ConnectData data = new Classes.ConnectData();
        private int btn = 0;
        public frmHocSinh()
        {
            InitializeComponent();
            btnAccept.Visible = false;
            btnCancel.Visible = false;
        }
        
        public void notenable()
        {
            tbMaHS.Enabled = false;
            tbTenHS.Enabled = false;
            dtpNgaysinh.Enabled = false;
            tbDiachi.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;
            cbbLop.Enabled = false;
            tbNamhoc.Enabled = false;
            tbHanhkiem.Enabled = false;
            tbGhichu.Enabled = false;
        }

        public void enable()
        {
            tbMaHS.Enabled = true;
            tbTenHS.Enabled = true;
            dtpNgaysinh.Enabled = true;
            tbDiachi.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
            cbbLop.Enabled = true;
            tbNamhoc.Enabled = true;
            tbHanhkiem.Enabled = true;
            tbGhichu.Enabled = true;
        }

        public void clear()
        {
            tbMaHS.Text = null;
            tbTenHS.Text = null;
            dtpNgaysinh.Value = DateTime.Today;
            tbDiachi.Text = null;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            cbbLop.SelectedIndex = -1;
            tbNamhoc.Text = null;
            tbHanhkiem.Text = null;
            tbGhichu.Text = null;
        }
        
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            dgvHocsinh.DataSource = data.ReadData("SELECT * FROM HOCSINH");
            dgvHocsinh.ColumnHeadersHeight = 40;
            DataTable dtml = data.ReadData("Select * from LOPHOC");
            functions.FillComboBox(cbbLop, dtml, "Malop", "Malop");
            notenable();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvHocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaHS.Text = dgvHocsinh.CurrentRow.Cells[0].Value.ToString();
            tbTenHS.Text = dgvHocsinh.CurrentRow.Cells[1].Value.ToString();
            dtpNgaysinh.Text = dgvHocsinh.CurrentRow.Cells[2].Value.ToString();
            tbDiachi.Text = dgvHocsinh.CurrentRow.Cells[3].Value.ToString();
            if (dgvHocsinh.CurrentRow.Cells[4].Value.ToString() == "Nam")
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNu.Checked = true;
                rdoNam.Checked = false;
            }
            cbbLop.Text = dgvHocsinh.CurrentRow.Cells[5].Value.ToString();
            tbNamhoc.Text = dgvHocsinh.CurrentRow.Cells[6].Value.ToString();
            tbHanhkiem.Text = dgvHocsinh.CurrentRow.Cells[7].Value.ToString();
            tbGhichu.Text = dgvHocsinh.CurrentRow.Cells[8].Value.ToString();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            btn = 2;
            enable();
            tbMaHS.Enabled = false;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            btnThem.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btn = 3;
            enable();
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            btnThem.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            btn = 4;
            clear();
            notenable();
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            tbMaHS.Enabled = true;
            tbTenHS.Enabled = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(btn == 1)
            {
                if (tbMaHS.Text == "")
                {
                    msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    msd.Text = "Vui lòng nhập đầy đủ thông tin";
                    msd.Show();
                    tbMaHS.Focus();
                }
                else
                {
                    DataTable dths = data.ReadData("Select * from HOCSINH where " + "MaHS = N'" + tbMaHS.Text + "'");
                    if (dths.Rows.Count > 0)
                    {
                        msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                        msd.Text = "Đã có học sinh này xin vui lòng thử lại!";
                        msd.Show();
                        tbMaHS.Focus();
                    }
                    else
                    {
                        if (rdoNam.Checked == true)
                        {
                            data.UpdateData("INSERT INTO HOCSINH VALUES(N'" + tbMaHS.Text + "', N'" + tbTenHS.Text + "', N'" + dtpNgaysinh.Text + "', N'"
                          + tbDiachi.Text + "', N'" + "Nam" + "', N'" + cbbLop.Text + "', '" + tbNamhoc.Text + "', N'" + tbHanhkiem.Text + "', N'" + tbGhichu.Text + "', null)");
                        }
                        else
                        {
                            data.UpdateData("INSERT INTO HOCSINH VALUES(N'" + tbMaHS.Text + "', N'" + tbTenHS.Text + "', N'" + dtpNgaysinh.Text + "', N'"
                          + tbDiachi.Text + "', N'" + "Nữ" + "', N'" + cbbLop.Text + "', '" + tbNamhoc.Text + "', N'" + tbHanhkiem.Text + "', N'" + tbGhichu.Text + "', null)");
                        }
                        msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                        msd.Text = "Đã thêm thành công!";
                        msd.Show();
                        dgvHocsinh.DataSource = data.ReadData("SELECT * FROM HOCSINH");
                        btnAccept.Visible = false;
                        btnCancel.Visible = false;
                        clear();
                    }
                }
                
            }
            else if(btn == 2)
            {
                if (rdoNam.Checked == true)
                {
                    data.UpdateData("UPDATE HOCSINH SET TenHS = N'" + tbTenHS.Text + "', Ngaysinh = N'" + dtpNgaysinh.Text + "', Diachi = N'"
                        + tbDiachi.Text + "', Ghichu = N'" + tbGhichu.Text + "', Malop = N'" + cbbLop.Text + "', Namhoc = '" + tbNamhoc.Text + "', Hanhkiem = N'"
                        + tbHanhkiem.Text + "', Gioitinh = N'Nam' WHERE MaHS = N'" + tbMaHS.Text + "'");
                    dgvHocsinh.DataSource = data.ReadData("SELECT * FROM HOCSINH");
                }
                if (rdoNu.Checked == true)
                {
                    data.UpdateData("UPDATE HOCSINH SET TenHS = N'" + tbTenHS.Text + "', Ngaysinh = N'" + dtpNgaysinh.Text + "', Diachi = N'"
                        + tbDiachi.Text + "', Ghichu = N'" + tbGhichu.Text + "', Malop = N'" + cbbLop.Text + "', Namhoc = '" + tbNamhoc.Text + "', Hanhkiem = N'"
                        + tbHanhkiem.Text + "', Gioitinh = N'Nữ' WHERE MaHS = N'" + tbMaHS.Text + "'");
                    dgvHocsinh.DataSource = data.ReadData("SELECT * FROM HOCSINH");
                }
            }
            else if(btn == 3)
            {
                data.UpdateData("DELETE HOCSINH WHERE MaHS = '" + tbMaHS.Text + "'");
                msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                msd.Text = "Đã xóa";
                msd.Show();
                dgvHocsinh.DataSource = data.ReadData("SELECT * FROM HOCSINH");
                clear();
                notenable();
                btnAccept.Visible = false;
                btnCancel.Visible = false;
            }
            else if(btn == 4)
            {
                DataTable dtgv = data.ReadData("Select * from HOCSINH where " + "MaHS = N'" + tbMaHS.Text + "' or TenHS = '" + tbTenHS.Text + "'");
                if (dtgv.Rows.Count > 0)
                {
                    dgvHocsinh.DataSource = dtgv;
                    btn = 0;
                }
                else
                {
                    msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    msd.Text = "Không có học sinh này!";
                    msd.Show();
                }
            }
            else
            {
                DataTable dt = data.ReadData("SELECT * FROM HOCSINH");
                if (dt.Rows.Count > 0)
                {
                    Excel.Application exApp = new Excel.Application();
                    Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                    Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                    Excel.Range Tenbang = (Excel.Range)exSheet.Cells[1, 1];
                    Tenbang.Font.Size = 13;
                    Tenbang.Font.Bold = true;
                    Tenbang.Font.Color = Color.Red;
                    Tenbang.Value = "Danh sách học sinh";

                    exSheet.get_Range("A7:K7").Font.Bold = true;
                    exSheet.get_Range("A7:K7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    exSheet.get_Range("A7").Value = "STT";
                    exSheet.get_Range("B7").Value = "Mã HS";
                    exSheet.get_Range("B7:K7").ColumnWidth = 30;
                    exSheet.get_Range("C7").Value = "Tên HS";
                    exSheet.get_Range("D7").Value = "Ngày sinh";
                    exSheet.get_Range("E7").Value = "Địa chỉ";
                    exSheet.get_Range("F7").Value = "Giới tính";
                    exSheet.get_Range("G7").Value = "Mã lớp";
                    exSheet.get_Range("H7").Value = "Năm học";
                    exSheet.get_Range("I7").Value = "Hạnh kiểm";
                    exSheet.get_Range("J7").Value = "Ghi chú";
                    exSheet.get_Range("K7").Value = "Điểm TB";

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        exSheet.get_Range("A" + (i + 8).ToString() + ":K" + (i + 8).ToString()).Font.Bold = false;
                        exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                        exSheet.get_Range("B" + (i + 8).ToString()).Value = dt.Rows[i]["MaHS"].ToString();
                        exSheet.get_Range("C" + (i + 8).ToString()).Value = dt.Rows[i]["TenHS"].ToString();
                        exSheet.get_Range("D" + (i + 8).ToString()).Value = dt.Rows[i]["Ngaysinh"].ToString();
                        exSheet.get_Range("E" + (i + 8).ToString()).Value = dt.Rows[i]["Diachi"].ToString();
                        exSheet.get_Range("F" + (i + 8).ToString()).Value = dt.Rows[i]["Gioitinh"].ToString();
                        exSheet.get_Range("G" + (i + 8).ToString()).Value = dt.Rows[i]["Malop"].ToString();
                        exSheet.get_Range("H" + (i + 8).ToString()).Value = dt.Rows[i]["Namhoc"].ToString();
                        exSheet.get_Range("I" + (i + 8).ToString()).Value = dt.Rows[i]["Hanhkiem"].ToString();
                        exSheet.get_Range("J" + (i + 8).ToString()).Value = dt.Rows[i]["Ghichu"].ToString();
                        exSheet.get_Range("K" + (i + 8).ToString()).Value = dt.Rows[i]["DiemTB"].ToString();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAccept.Visible = false;
            btnCancel.Visible = false;
            clear();
            notenable();
            btn = 0;
            DataTable dths = data.ReadData("Select * from HOCSINH");
            dgvHocsinh.DataSource = dths;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            btn = 5;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
        }

        private void frmHocSinh_SizeChanged(object sender, EventArgs e)
        {
            if(this.Width == this.MaximumSize.Width)
            {
                guna2GroupBox1.Location = new Point(717, 12);
                dgvHocsinh.Size = new Size(699, 425);
                btnXoa.Location = new Point(563, 12);
                btnSua.Location = new Point(310, 12);
                btnIn.Location = new Point(563, 493);
                btnReset.Location = new Point(215, 493);
                btnUpdate.Location = new Point(395, 493);
            }
            if(this.Width == this.MinimumSize.Width)
            {
                guna2GroupBox1.Location = new Point(607, 12);
                dgvHocsinh.Size = new Size(589, 425);
                btnXoa.Location = new Point(453, 12);
                btnSua.Location = new Point(255, 12);
                btnIn.Location = new Point(453, 493);
                btnReset.Location = new Point(185, 493);
                btnUpdate.Location = new Point(325, 493);
            }
        }

        public void addchart()
        {
            DataTable dt = data.ReadData("SELECT isnull(DiemTB, -1) from HOCSINH");
            data.UpdateData("update Chart set Y = 0 where X = '0-1' or X = '1-2' or X = '2-3' or X = '3-4' or X = '4-5' or X = '5-6' or X = '6-7' or X = '7-8' or X = '8-9' or X = '9-10' or X = N'Chưa sắp'");

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= dt.Columns.Count - 1; j++)
                {
                    double otherNumber = dt.Rows[i].Field<double>("DiemTB");
                    if (otherNumber >= 0 && otherNumber < 1)
                    {
                        data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '0-1'");
                    }
                    else if (otherNumber >= 1 && otherNumber < 2)
                    {
                        data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '1-2'");
                    }
                    else if (otherNumber >= 2 && otherNumber < 3)
                    {
                        data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '2-3'");
                    }
                    else if (otherNumber >= 3 && otherNumber < 4)
                    {
                        data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '3-4'");
                    }
                    else if (otherNumber >= 4 && otherNumber < 5)
                    {
                        data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '4-5'");
                    }
                    else if (otherNumber >= 5 && otherNumber < 6)
                    {
                        data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '5-6'");
                    }
                    else if (otherNumber >= 6 && otherNumber < 7)
                    {
                        data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '6-7'");
                    }
                    else if (otherNumber >= 7 && otherNumber < 8)
                    {
                        data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '7-8'");
                    }
                    else if (otherNumber >= 8 && otherNumber < 9)
                    {
                        data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '8-9'");
                    }
                    else if (otherNumber >= 9 && otherNumber <= 10)
                    {
                        data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '9-10'");
                    }
                    else
                    {
                        data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = N'Chưa sắp'");
                    }
                }
            }
            
            /*
            foreach (DataRow row in dt.Rows)
            {
                var number = row["DiemTB"].ToString();
                if (float.Parse(number) >= 7 && float.Parse(number) <= 8)
                {
                    data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '7-8'");
                }
            }
            */
            /*
            float num;
            foreach (DataRow dr in dt.Rows)
            {
                num = float.Parse(dr["DiemTB"].ToString(), CultureInfo.InvariantCulture.NumberFormat);// bạn duyệt qua table bằng foreach, columnName là tên cột cần lấy  
                if (num >= 7 && num <= 8)
                {
                    data.UpdateData("UPDATE Chart set Y = isnull(Y, 0) + 1 where X = '7-8'");
                }
            }
            */
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            addchart();
            msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            msd.Text = "Đã được cập nhật lên biểu đồ trên trang chủ!";
            msd.Show();
        }
    }
}
