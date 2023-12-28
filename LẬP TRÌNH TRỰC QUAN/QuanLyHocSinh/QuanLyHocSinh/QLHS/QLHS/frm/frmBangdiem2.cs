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
    public partial class frmBangdiem2 : Form
    {
        Classes.CommonFunction functions = new Classes.CommonFunction();
        Classes.ConnectData data = new Classes.ConnectData();

        private int btn = 0;
        public frmBangdiem2()
        {
            InitializeComponent();
            DataTable dthk1 = data.ReadData("Select HOCSINH.TenHS, BANGDIEMHK2.* from BANGDIEMHK2, HOCSINH WHERE HOCSINH.MaHS = BANGDIEMHK2.MaHS");
            dgvDiemky2.DataSource = dthk1;
            dgvDiemky2.ColumnHeadersHeight = 40;
            btnAccept.Visible = false;
            btnCancel.Visible = false;
            notenable();
            DataGridViewColumn column = dgvDiemky2.Columns[0];
            column.Width = 80;
            column = dgvDiemky2.Columns[1];
            column.Width = 150;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        public void clear()
        {
            tbMaBDHK2.Text = null;
            tbToan.Text = null;
            tbVan.Text = null;
            tbAnh.Text = null;
            tbLy.Text = null;
            tbHoa.Text = null;
            tbSinh.Text = null;
            tbSu.Text = null;
            tbDia.Text = null;
            tbGDCD.Text = null;
            tbCN.Text = null;
            tbtin.Text = null;
            tbTB.Text = null;
            guna2GroupBox1.Text = "Thông tin bảng điểm kỳ 2";
        }

        public void notenable()
        {
            tbMaBDHK2.Enabled = false;
            tbToan.Enabled = false;
            tbVan.Enabled = false;
            tbAnh.Enabled = false;
            tbLy.Enabled = false;
            tbHoa.Enabled = false;
            tbSinh.Enabled = false;
            tbSu.Enabled = false;
            tbDia.Enabled = false;
            tbGDCD.Enabled = false;
            tbCN.Enabled = false;
            tbtin.Enabled = false;
            tbTB.Enabled = false;
            tbMaHS.Enabled = false;
        }

        public void enable()
        {
            tbMaBDHK2.Enabled = true;
            tbToan.Enabled = true;
            tbVan.Enabled = true;
            tbAnh.Enabled = true;
            tbLy.Enabled = true;
            tbHoa.Enabled = true;
            tbSinh.Enabled = true;
            tbSu.Enabled = true;
            tbDia.Enabled = true;
            tbGDCD.Enabled = true;
            tbCN.Enabled = true;
            tbtin.Enabled = true;
            tbTB.Enabled = true;
            tbMaHS.Enabled = true;
        }
        private void frmBangdiem2_Load(object sender, EventArgs e)
        {

        }

        private void dgvDiemky2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaBDHK2.Text = dgvDiemky2.CurrentRow.Cells[1].Value.ToString();
            tbToan.Text = dgvDiemky2.CurrentRow.Cells[2].Value.ToString();
            tbVan.Text = dgvDiemky2.CurrentRow.Cells[3].Value.ToString();
            tbAnh.Text = dgvDiemky2.CurrentRow.Cells[4].Value.ToString();
            tbLy.Text = dgvDiemky2.CurrentRow.Cells[5].Value.ToString();
            tbHoa.Text = dgvDiemky2.CurrentRow.Cells[6].Value.ToString();
            tbSinh.Text = dgvDiemky2.CurrentRow.Cells[7].Value.ToString();
            tbSu.Text = dgvDiemky2.CurrentRow.Cells[13].Value.ToString();
            tbDia.Text = dgvDiemky2.CurrentRow.Cells[8].Value.ToString();
            tbGDCD.Text = dgvDiemky2.CurrentRow.Cells[9].Value.ToString();
            tbCN.Text = dgvDiemky2.CurrentRow.Cells[10].Value.ToString();
            tbtin.Text = dgvDiemky2.CurrentRow.Cells[11].Value.ToString();
            tbTB.Text = dgvDiemky2.CurrentRow.Cells[15].Value.ToString();
            tbMaHS.Text = dgvDiemky2.CurrentRow.Cells[14].Value.ToString();
            guna2GroupBox1.Text = "Thông tin bảng điểm kỳ 2 của " + dgvDiemky2.CurrentRow.Cells[0].Value.ToString();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btn = 1;
            clear();
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            enable();
            tbTB.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
            btnAccept.Visible = false;
            btnCancel.Visible = false;
            tbMaHS.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            btn = 4;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            notenable();
            tbMaBDHK2.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btn = 2;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            enable();
            tbMaBDHK2.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btn = 3;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            notenable();
            btnThem.Enabled = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (btn == 1)
            {
                if (tbMaBDHK2.Text == "" || tbMaHS.Text == "")
                {
                    msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    msd.Text = "Vui lòng nhập đầy đủ thông tin";
                    msd.Show();
                    tbMaBDHK2.Focus();
                }
                else
                {
                    DataTable dths = data.ReadData("Select * from BANGDIEMHK2 where " + "MaHS = N'" + tbMaHS.Text + "' OR MaBDHK2 = N'" + tbMaBDHK2.Text + "'");
                    if (dths.Rows.Count > 0)
                    {
                        msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                        msd.Text = "Đã có học sinh này xin vui lòng thử lại!";
                        msd.Show();
                        tbMaBDHK2.Focus();
                    }
                    else
                    {
                        data.UpdateData("INSERT INTO BANGDIEMHK2 VALUES( N'" + tbMaBDHK2.Text + "' , " + tbToan.Text + ", " + tbVan.Text + ", " +
                            tbAnh.Text + ", " + tbLy.Text + ", " + tbHoa.Text + ", " + tbSinh.Text + ", " + tbDia.Text + ", " + tbGDCD.Text +
                             ", " + tbCN.Text + ", " + tbtin.Text + ", N'Đạt' , " + tbSu.Text + ", N'" + tbMaHS.Text + "', null)");
                        msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                        msd.Text = "Đã thêm thành công!";
                        msd.Show();
                        dgvDiemky2.DataSource = data.ReadData("Select HOCSINH.TenHS, BANGDIEMHK2.* from BANGDIEMHK2, HOCSINH WHERE HOCSINH.MaHS = BANGDIEMHK2.MaHS");
                        btnAccept.Visible = false;
                        btnCancel.Visible = false;
                        notenable();
                    }
                }
                
            }
            else if (btn == 2)
            {
                data.UpdateData("UPDATE BANGDIEMHK2 SET Toan = " + tbToan.Text + ", Van = "
                        + tbVan.Text + ", Anh = " + tbAnh.Text + ", Ly = " + tbLy.Text + ", Hoa = "
                        + tbHoa.Text + ", Sinh = " + tbSinh.Text + ", Dialy = " + tbDia.Text + ", Congdan = " + tbGDCD.Text + ", Congnghe = "
                        + tbCN.Text + ", Tinhoc = " + tbtin.Text + ", Theduc = N'Đạt' , Lichsu = " + tbSu.Text + ", MaHS = N'" + tbMaHS.Text + "' "
                        + "WHERE MaBDHK2 = N'" + tbMaBDHK2.Text + "'");
                dgvDiemky2.DataSource = data.ReadData("Select HOCSINH.TenHS, BANGDIEMHK2.* from BANGDIEMHK2, HOCSINH WHERE HOCSINH.MaHS = BANGDIEMHK2.MaHS");
                btnAccept.Visible = false;
                btnCancel.Visible = false;
                notenable();
                btnThem.Enabled = true;
            }
            else if (btn == 3)
            {
                data.UpdateData("DELETE BANGDIEMHK2 WHERE MaBDHK2 = '" + tbMaBDHK2.Text + "'");
                msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                msd.Text = "Đã xóa";
                msd.Show();
                dgvDiemky2.DataSource = data.ReadData("Select HOCSINH.TenHS, BANGDIEMHK1.* from BANGDIEMHK2, HOCSINH WHERE HOCSINH.MaHS = BANGDIEMHK2.MaHS");
                clear();
                notenable();
                btnAccept.Visible = false;
                btnCancel.Visible = false;
                btnThem.Enabled = true;
            }
            else if (btn == 4)
            {
                DataTable dthk1 = data.ReadData("Select HOCSINH.TenHS, BANGDIEMHK2.* from BANGDIEMHK2, HOCSINH WHERE HOCSINH.MaHS = BANGDIEMHK2.MaHS " +
                    "and MaBDHK2 = N'" + tbMaBDHK2.Text + "'");
                if (dthk1.Rows.Count > 0)
                {
                    dgvDiemky2.DataSource = dthk1;
                    btn = 0;
                    clear();
                    notenable();
                }
                else
                {
                    msd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    msd.Text = "Không có bảng điểm này!";
                    msd.Show();
                    tbMaBDHK2.Focus();
                }
            }
            else
            {
                DataTable dt = data.ReadData("Select HOCSINH.TenHS, BANGDIEMHK2.* from BANGDIEMHK2, HOCSINH WHERE HOCSINH.MaHS = BANGDIEMHK2.MaHS");
                if(dt.Rows.Count > 0)
                {
                    Excel.Application exApp = new Excel.Application();
                    Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                    Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                    Excel.Range Tenbang = (Excel.Range)exSheet.Cells[1, 1];
                    Tenbang.Font.Size = 13;
                    Tenbang.Font.Bold = true;
                    Tenbang.Font.Color = Color.Red;
                    Tenbang.Value = "BẢNG ĐIỂM HỌC KỲ 2!";

                    exSheet.get_Range("A7:P7").Font.Bold = true;
                    exSheet.get_Range("A7:P7").HorizontalAlignment =Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    exSheet.get_Range("A7").Value = "STT";
                    exSheet.get_Range("B7").Value = "Họ tên HS";
                    exSheet.get_Range("B7").ColumnWidth = 20;
                    exSheet.get_Range("C7").Value = "Mã Bảng điểm";
                    exSheet.get_Range("C7").ColumnWidth = 40;
                    exSheet.get_Range("D7").Value = "Toán";
                    exSheet.get_Range("E7").Value = "Văn";
                    exSheet.get_Range("F7").Value = "Anh";
                    exSheet.get_Range("G7").Value = "Lý";
                    exSheet.get_Range("H7").Value = "Hóa";
                    exSheet.get_Range("I7").Value = "Sinh";
                    exSheet.get_Range("J7").Value = "Địa";
                    exSheet.get_Range("K7").Value = "Công dân";
                    exSheet.get_Range("L7").Value = "Công nghệ";
                    exSheet.get_Range("M7").Value = "Tin học";
                    exSheet.get_Range("N7").Value = "Thể dục";
                    exSheet.get_Range("O7").Value = "Lịch sử";
                    exSheet.get_Range("P7").Value = "Mã HS";

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        exSheet.get_Range("A" + (i + 8).ToString() + ":P" + (i + 8).ToString()).Font.Bold = false;
                        exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                        exSheet.get_Range("B" + (i + 8).ToString()).Value = dt.Rows[i]["TenHS"].ToString();
                        exSheet.get_Range("C" + (i + 8).ToString()).Value = dt.Rows[i]["MaBDHK2"].ToString();
                        exSheet.get_Range("D" + (i + 8).ToString()).Value = dt.Rows[i]["Toan"].ToString();
                        exSheet.get_Range("E" + (i + 8).ToString()).Value = dt.Rows[i]["Van"].ToString();
                        exSheet.get_Range("F" + (i + 8).ToString()).Value = dt.Rows[i]["Anh"].ToString();
                        exSheet.get_Range("G" + (i + 8).ToString()).Value = dt.Rows[i]["Ly"].ToString();
                        exSheet.get_Range("H" + (i + 8).ToString()).Value = dt.Rows[i]["Hoa"].ToString();
                        exSheet.get_Range("I" + (i + 8).ToString()).Value = dt.Rows[i]["Sinh"].ToString();
                        exSheet.get_Range("J" + (i + 8).ToString()).Value = dt.Rows[i]["Dialy"].ToString();
                        exSheet.get_Range("K" + (i + 8).ToString()).Value = dt.Rows[i]["Congdan"].ToString();
                        exSheet.get_Range("L" + (i + 8).ToString()).Value = dt.Rows[i]["Congnghe"].ToString();
                        exSheet.get_Range("M" + (i + 8).ToString()).Value = dt.Rows[i]["Tinhoc"].ToString();
                        exSheet.get_Range("N" + (i + 8).ToString()).Value = dt.Rows[i]["Theduc"].ToString();
                        exSheet.get_Range("O" + (i + 8).ToString()).Value = dt.Rows[i]["Lichsu"].ToString();
                        exSheet.get_Range("P" + (i + 8).ToString()).Value = dt.Rows[i]["MaHS"].ToString();
                    }

                    exSheet.Name = "Bảng điểm";
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
            DataTable dthk2 = data.ReadData("Select HOCSINH.TenHS, BANGDIEMHK2.* from BANGDIEMHK2, HOCSINH WHERE HOCSINH.MaHS = BANGDIEMHK2.MaHS");
            dgvDiemky2.DataSource = dthk2;
            btnAccept.Visible = false;
            btnCancel.Visible = false;
            clear();
            notenable();
            btn = 0;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmBangdiem2_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width == this.MaximumSize.Width)
            {
                guna2GroupBox1.Location = new Point(85, 282);
                dgvDiemky2.Size = new Size(1233, 250);
            }
            if (this.Width == this.MinimumSize.Width)
            {
                guna2GroupBox1.Location = new Point(15, 282);
                dgvDiemky2.Size = new Size(1085, 250);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            btn = 5;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
        }

        private void tbToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tbToan.Text.Length == 0 || tbToan.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }

        private void tbVan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tbVan.Text.Length == 0 || tbVan.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }

        private void tbAnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tbAnh.Text.Length == 0 || tbAnh.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }

        private void tbLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tbLy.Text.Length == 0 || tbLy.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }

        private void tbHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tbHoa.Text.Length == 0 || tbHoa.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }

        private void tbSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tbSinh.Text.Length == 0 || tbSinh.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }

        private void tbSu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tbSu.Text.Length == 0 || tbSu.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }

        private void tbDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tbDia.Text.Length == 0 || tbDia.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }

        private void tbGDCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tbGDCD.Text.Length == 0 || tbGDCD.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }

        private void tbtin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tbtin.Text.Length == 0 || tbtin.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }

        private void tbCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tbCN.Text.Length == 0 || tbCN.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }


    }
}
