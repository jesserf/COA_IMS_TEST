using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Utilities
{
    internal class Inventory_Manager
    {
        private Database_Manager db_Manager;
        public List<string> Display_List_To_Combobox(string query, string item_column)
        {
            db_Manager = new Database_Manager();
            List<string> list_Of_Items = new List<string>();
            using (db_Manager)
                list_Of_Items = db_Manager.ExecuteQueryToList(query, item_column);
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
        public void Insert_Item_Category_Name(string query, string item)
        {
            int ret;
            db_Manager = new Database_Manager();
            query = string.Format(query, item);
            using(db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
                MessageBox.Show($"Category Name: {item} is successfully added.", "Category Name Added");
            else if (ret == 0)
                MessageBox.Show($"Category Name: {item} is not added.", "Category Name Not Added");

        }
        public void Insert_Item_Supplier_Info(string sn, string address, string cn, string cp, string item)
        {
            int ret;
            db_Manager = new Database_Manager();
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_supplier, sn, address, cn, cp));
            /*if(ret == 1)
            MessageBox.Show($"Category Name: {item} is successfully added.", "Category Name Added");
            else if (ret == 0)
                MessageBox.Show($"Category Name: {item} is not added.", "Category Name Not Added");*/
        }
    }
}
