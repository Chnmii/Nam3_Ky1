using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmCheDo
{
    internal class ConnectData
    {
        //Khai báo biến tàn cục
        string strConnect = @"Data Source=DESKTOP-454CCL8;Initial Catalog=QLNhanSu;Integrated Security=True";
        SqlConnection sqlConnect = null;
        //phương thức mở kết nối
        void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
            {
                sqlConnect.Open();
            }
        }
        //phương thức đóng kết nối 
        void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }
        //phường thức thực thi câu lệnh select trả về một Datatable 
        public DataTable DataReader(string sqlSeclct)
        {
            DataTable tblData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSeclct, sqlConnect);
            sqlData.Fill(tblData);
            return tblData;
        }

        //phương thức thực hiện câu lệnh dạng insert, update, delate
        public void DataChange(string sql)
        {
            OpenConnect();
            SqlCommand sqlcoma = new SqlCommand();
            sqlcoma.Connection = sqlConnect;
            sqlcoma.CommandText = sql;
            sqlcoma.ExecuteNonQuery();
            CloseConnect();

        }
    }
}
