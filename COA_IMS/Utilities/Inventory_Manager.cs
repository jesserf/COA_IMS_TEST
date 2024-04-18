using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_IMS.Utilities
{
    internal class Inventory_Manager
    {
        private Database_Manager db_Manager;
        public List<string> Display_List_To_Combobox(string query)
        {
            db_Manager = new Database_Manager();
            List<string> list_Of_Items = new List<string>();
            using (db_Manager)
                list_Of_Items = db_Manager.ExecuteQueryToList(query);
            return list_Of_Items;
        }
        public int Get_Code_From_table(string query)
        {
            db_Manager = new Database_Manager();
            int code = 0;
            using (db_Manager)
                code = Convert.ToInt32(db_Manager.ExecuteScalar(query));
            return code;
        }
    }
}
