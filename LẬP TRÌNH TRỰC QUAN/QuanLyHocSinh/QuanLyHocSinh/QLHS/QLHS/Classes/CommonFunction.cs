using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.Classes
{
    class CommonFunction
    {
        Classes.ConnectData data = new Classes.ConnectData();
        public void FillComboBox(ComboBox comboName, DataTable data, string displayMember, string valueMember)
        {
            comboName.DataSource = data;
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
                DataTable dtData = data.ReadData("Select * from " + tableName + " where " + columnName + "='" + code + "'");
                if (dtData.Rows.Count == 0)
                    check = true;
                else
                    id++;
            } while (check == false);
            return code;
        }
    }
}
