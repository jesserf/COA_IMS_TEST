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
        #region Item Categories
        public List<string> Display_List_To_Combobox(string query, string item_column)
        {
            db_Manager = new Database_Manager();
            List<string> list_Of_Items = new List<string>();
            query = string.Format(query, item_column);
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
        public void Insert_Item_Category_Name(string query, string item, string table_name, string type, string name = null)
        {
            int ret;
            db_Manager = new Database_Manager();
            query = string.Format(query, item, CurrentUser.user_name, type);
            using(db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record(type, item);
                MessageBox.Show($"{name} Name: {item} is successfully added.", "Category Name Added");
            }
            else if (ret == 0)
                MessageBox.Show($"{name} Name: {item} is not added.", $"Category Name Not Added\n{name} may already exist.");

        }
        //count number of account activities
        public int Count_Item_Categories(string query)
        {
            db_Manager = new Database_Manager();
            int count;
            using (db_Manager)
            {
                count = Convert.ToInt32(db_Manager.ExecuteScalar(query));
            }
            return count;
        }
        public DataTable Get_Item_Records(int minimium, string item_spec, string item_table, string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            if (searchwords != null)
                query = string.Format(Database_Query.get_specific_item_record, item_spec, searchwords, minimium, item_table);
            else query = string.Format(Database_Query.get_general_item_record, item_spec, minimium, item_table);
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(query);
            }

            int removeLimitIndex = query.IndexOf("LIMIT");
            if (removeLimitIndex >= 0)
                Database_Query.last_query = query.Remove(removeLimitIndex);
            return dt;
        }
        #endregion
        #region Item Supplier
        public void Insert_Item_Supplier(string query, string supplier_name, string supplier_address, string supplier_contact_num, string supplier_contact_person, string name = "Item Supplier")
        {
            int ret;
            db_Manager = new Database_Manager();
            query = string.Format(query, supplier_name, supplier_address, supplier_contact_num, supplier_contact_person, CurrentUser.user_name);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record(name, supplier_name);
                MessageBox.Show($"{name} Name: {supplier_name} is successfully added.", "Category Name Added");
            }
            else if (ret == 0)
                MessageBox.Show($"{name} Name: {supplier_name} is not added.", $"Category Name Not Added\n{name} may already exist.");

        }
        public DataTable Get_Item_Supplier_Records(int minimium, string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            if (searchwords != null)
                query = string.Format(Database_Query.get_specific_item_supplier_record, minimium, searchwords);
            else query = string.Format(Database_Query.get_general_item_supplier_record, minimium);
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(query);
            }

            int removeLimitIndex = query.IndexOf("LIMIT");
            if (removeLimitIndex >= 0)
                Database_Query.last_query = query.Remove(removeLimitIndex);
            return dt;
        }
        #endregion
        #region Items
        public void Insert_Item_Description(string product_name, string brand_name, string item_type, string supplier_contact_person, string item_code, double cost, int est_use_life, int quantity, string unit_name, string name = "Item Description")
        {
            int ret;
            db_Manager = new Database_Manager();
            string query = Database_Query.insert_new_item_desc;
            RandomAlphanumericString randString = new RandomAlphanumericString();
            string desc_id = randString.Generate_RandomString(Database_Query.check_item_desc_id);
            query = string.Format(query, desc_id, product_name, brand_name, item_type);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record(name, desc_id);
                MessageBox.Show($"{name}: {desc_id} is successfully added.", $"{name} Added");
                Insert_Item(desc_id, item_code, cost, est_use_life, quantity, unit_name);
            }
            else if (ret == 0)
                MessageBox.Show($"{name}: {desc_id} is not added.", $"{name} Not Added\n{desc_id} may already exist.");

        }
        private void Insert_Item(string desc_id, string item_code, double cost, int est_use_life, int quantity, string unit_name, string name = "Item")
        {
            int ret;
            db_Manager = new Database_Manager();
            string query = Database_Query.insert_new_item;
            string user_name = CurrentUser.user_name;
            query = string.Format(query, desc_id, item_code, cost, est_use_life, quantity, user_name, unit_name);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record(name, item_code);
                MessageBox.Show($"{name} Name: {item_code} is successfully added.", "Item Added");
            }
            else if (ret == 0)
                MessageBox.Show($"{name} Name: {item_code} is not added.", $"Item Not Added\n{item_code} may already exist.");

        }
        public DataTable Get_Item_Records(int minimium, string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            if (searchwords != null)
                query = string.Format(Database_Query.get_specific_items_record, minimium, searchwords);
            else query = string.Format(Database_Query.get_general_items_record, minimium);
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(query);
            }

            int removeLimitIndex = query.IndexOf("LIMIT");
            if (removeLimitIndex >= 0)
                Database_Query.last_query = query.Remove(removeLimitIndex);
            return dt;
        }
        #endregion
    }
}
