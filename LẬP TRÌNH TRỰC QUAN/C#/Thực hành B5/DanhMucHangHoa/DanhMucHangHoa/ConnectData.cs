using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhMucHangHoa.Classes
{
    internal class ConnectData
    {
        public static string strConnect = "Data Source=DESKTOP-454CCL8;Initial Catalog=QLSanPham;Integrated Security=True";
        SqlConnection sqlConn = null;
        //PT OpenConnect de mo ket noi
        public void OpenConnect()
        {
            sqlConn = new SqlConnection(strConnect);
            if (sqlConn.State != ConnectionState.Open)
                sqlConn.Open();
        }
        //PT CloseConnect để đóng kết nối
        void CloseConnect()
        {
            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }
        //PT thực hiện truy vấn dữ liệu trả về DataTable su dung DataAdapter
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConn);
            sqlData.Fill(dt);
            CloseConnect();
            sqlData.Dispose();
            return dt;
        }
        //PT thực hiện thay đổi dữ liệu insert, update, delete dung SqlCommand
        public void UpdateData(string sql)
        {
            OpenConnect();
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = sql;
            sqlComm.ExecuteNonQuery();
            CloseConnect();
            sqlComm.Dispose();
        }
    }
}
