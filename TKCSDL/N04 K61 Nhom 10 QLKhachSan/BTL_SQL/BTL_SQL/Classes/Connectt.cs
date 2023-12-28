using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_SQL.Classes
{
    class Connectt
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public SqlConnection OpenDB()
        {
            conn = new SqlConnection("Data Source=DESKTOP-454CCL8;Initial Catalog=QL_KhachSan1;Integrated Security=True");
            return conn;
        }
        public static void OpenConnection()
        {
            string sql = "Data Source=DESKTOP-454CCL8;Initial Catalog=QL_KhachSan1;Integrated Security=True";
            try
            {
                conn = new SqlConnection(sql);
                conn.Open();
            }
            catch (Exception ex)
            {

            }
        }
        public static void DisConnection()
        {
            conn.Close();
            conn.Dispose();
            conn = null;

        }
    }
}
