using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QuanLyBanRuouBTL.Classes
{

    internal class CommonFunctions
    {
        Classes.ConnectDatabase data = new ConnectDatabase();
        public void FillCombobox(ComboBox comboName, DataTable dtbase, string displayMember, string valueMember)
        {
            comboName.DataSource = dtbase;
            comboName.DisplayMember = displayMember;
            comboName.ValueMember = valueMember;
        }

        public string AutoCode(string tableName, string columnName, string startvalue)
        {

            string code;
            bool check = false;
            int id = 0;

            do
            {
                code = startvalue + id.ToString();
                DataTable dtData = data.DataReader("Select * from " + tableName + " where " + columnName + "='" + code + "'");
                if (dtData.Rows.Count == 0)
                    check = true;
                else
                    id++;
            } while (check == false);
            return code;
        }
    }
}
