using COA_IMS.Screens;
using COA_IMS.Screens.Subscrn.Tracking;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public List<string> Display_List_To_Combobox(string query, string[] item_columns)
        {
            db_Manager = new Database_Manager();
            List<string> list_Of_Items = new List<string>();
            query = string.Format(query);
            using (db_Manager)
                list_Of_Items = db_Manager.ExecuteQueryToList(query, item_columns);
            return list_Of_Items;
        }
        public object Get_Code_From_table(string query)
        {
            db_Manager = new Database_Manager();
            object ret;
            using (db_Manager)
                ret = (db_Manager.ExecuteScalar(query));
            return ret;
        }
        public void Insert_Item_Category_Name(string query, string item, string type, string name = null)
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
        public int Count_Total_Results(string query)
        {
            db_Manager = new Database_Manager();
            int count;

            int removeLimitIndex = query.IndexOf("LIMIT");
            if (removeLimitIndex >= 0)
                query = query.Remove(removeLimitIndex);

            query = string.Format(Database_Query.count_total_result, query);

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
        public DataTable Get_Item_Supplier_Records(int minimium, string sortString, string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            switch (sortString)
            {
                case "All":
                    query = string.Format(Database_Query.get_all_specific_item_supplier_record, minimium, searchwords);
                    break;
                default:
                    if (searchwords != null)
                        query = string.Format(Database_Query.get_specific_item_supplier_record, minimium, searchwords, sortString.Replace(" ", "_"));
                    else query = string.Format(Database_Query.get_general_item_supplier_record, minimium);
                    break;
            }
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
        public DataTable Get_Item_Records(int minimium, string sortString, string searchwords = null, int status = 1)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            switch (sortString)
            {
                case "All":
                    query = string.Format(Database_Query.get_all_specific_items_record, minimium, searchwords, status);
                    break;
                default:
                    if (searchwords != null)
                        query = string.Format(Database_Query.get_specific_items_record, minimium, searchwords, sortString.Replace(" ", "_"), status);
                    else query = string.Format(Database_Query.get_general_items_record, minimium);
                    break;
            }
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(query);
            }

            int removeLimitIndex = query.IndexOf("LIMIT");
            if (removeLimitIndex >= 0)
                Database_Query.last_query = query.Remove(removeLimitIndex);
            return dt;
        }
        #region For Tracking
        public DataTable Get_Item_Record(string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            query = string.Format(Database_Query.get_item_record, 0, searchwords, "item_code");
            using (db_Manager)
                dt = db_Manager.ExecuteQuery(query);
            if(searchwords != "nowords")
            {
                dt.Columns.Add(new DataColumn("SN"));
                dt.Columns.Add(new DataColumn("Qty."));
                dt.Columns.Add(new DataColumn("Total Price"));
            }


            DataTable rearrangedDataTable = new DataTable();

            // Specify the desired column order
            string[] columnNames = { "item_code", "Item_Description", "SN", "unit" , "Qty.", "unit_cost" , "Total Price", "est_useful_life" }; // Example: rearrange columns 3, 1, 2, and 4

            // Add columns to the rearranged DataTable in the specified order
            foreach (string columnName in columnNames)
            {
                DataColumn column = dt.Columns[columnName];
                rearrangedDataTable.Columns.Add(column.ColumnName, column.DataType);
            }

            // Copy data from the original DataTable to the rearranged DataTable
            foreach (DataRow originalRow in dt.Rows)
            {
                DataRow newRow = rearrangedDataTable.NewRow();

                // Copy data from original row to the new row in the rearranged DataTable
                foreach (string columnName in columnNames)
                {
                    newRow[columnName] = originalRow[columnName];
                }

                rearrangedDataTable.Rows.Add(newRow);
            }

            return rearrangedDataTable;
        }
        public DataTable Get_Blank_Item_Record()
        {
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            using (db_Manager)
                dt = db_Manager.ExecuteQuery(Database_Query.get_blank_tracking_table);
            return dt;
        }
        public DataTable Get_ICS_Records(int minimium, int status, string sortString, string searchwords = null, string from_date = null, string to_date = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();

            switch (sortString)
            {
                case "All":
                    query = string.Format(Database_Query.get_ics_table, minimium, status, searchwords, from_date, to_date);
                    break;
                default:
                    if (searchwords != null)
                        query = string.Format(Database_Query.get_specific_ics_table, minimium, status, searchwords, sortString.Replace(" ", "_"), from_date, to_date);
                    else query = string.Format(Database_Query.get_general_ics_table, minimium, status, from_date, to_date);
                    break;
            }
            using (db_Manager)
                dt = db_Manager.ExecuteQuery(query);

            int removeLimitIndex = query.IndexOf("LIMIT");
            if (removeLimitIndex >= 0)
                Database_Query.last_query = query.Remove(removeLimitIndex);
            return dt;
        }
        public void Update_ICS_Record(string ics, string sn, string date = null)
        {
            int ret;
            db_Manager = new Database_Manager();
            string query = Database_Query.update_ics_record;
            if (date == null) date = "CURRENT_TIMESTAMP";
            query = string.Format(query, date, CurrentUser.user_name, ics, sn);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Update_Item_Return(ics, sn, date);
                //MessageBox.Show($"{item_code} is successfully updated.", "Quantity Updated");
            }
            else if (ret == 0)
                MessageBox.Show($"{sn} is not updated.");
        }
        public DataTable Get_ICS_Return_Records(int minimium, int status, string sortString, string searchwords = null, string end_date = "", string from_date = null, string to_date = null)
        {
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            // 0 - transfer return date | 1 - transfer date | 2 - ics number | 3 - entity name | 4 - employee name | 5 - minimum limit
            string query = Database_Query.get_return_ics_table;
            query = string.Format(query, minimium, status, searchwords, from_date, to_date);
            using (db_Manager)
                dt = db_Manager.ExecuteQuery(query);
            return dt;
        }
        public DataTable Get_SN_Item_Records(int minimium, int status, string sortString, string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            switch (sortString)
            {
                case "All":
                    query = string.Format(Database_Query.get_all_serial_num_item_table, minimium, status, searchwords);
                    break;
                default:
                    query = string.Format(Database_Query.get_specific_serial_num_item_table, minimium, status, searchwords, sortString.Replace(" ", "_"));
                    //else query = string.Format(Database_Query.get_general_serial_num_item_table, minimium, status);
                    //if (searchwords != null)
                    //    query = string.Format(Database_Query.get_specific_serial_num_item_table, minimium, status, searchwords, sortString.Replace(" ", "_"));
                    //else query = string.Format(Database_Query.get_general_serial_num_item_table, minimium, status);
                    break;
            }
            using (db_Manager)
                dt = db_Manager.ExecuteQuery(query);

            Console.WriteLine(query);
            int removeLimitIndex = query.IndexOf("LIMIT");
            if (removeLimitIndex >= 0)
                Database_Query.last_query = query.Remove(removeLimitIndex);

            return dt;
        }
        public DataTable Get_Employee_History_Records(int minimium, string employee_name, string employee_position, string employee_office, string searchwords)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();

            query = string.Format(Database_Query.get_employee_history_item, minimium, employee_name, employee_position, employee_office, searchwords);

            using (db_Manager)
                dt = db_Manager.ExecuteQuery(query);

            int removeLimitIndex = query.IndexOf("LIMIT");
            if (removeLimitIndex >= 0)
                Database_Query.last_query = query.Remove(removeLimitIndex);
            return dt;
        }
        public DataTable Get_Item_History_Records(int minimium, string spec_sn, string searchword)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();

            query = string.Format(Database_Query.get_specific_sn_item, minimium, spec_sn, searchword);

            using (db_Manager)
                dt = db_Manager.ExecuteQuery(query);

            int removeLimitIndex = query.IndexOf("LIMIT");
            if (removeLimitIndex >= 0)
                Database_Query.last_query = query.Remove(removeLimitIndex);
            return dt;
        }
        public int Get_Item_Quantity(string column, string table, string conditional_column, string conditional_var)
        {
            string query = Database_Query.get_quantity_general;
            query = string.Format(query, column, table, conditional_column, conditional_var);
            db_Manager = new Database_Manager();
            using (db_Manager)
                return Convert.ToInt32(db_Manager.ExecuteScalar(query));
        }
        public int Get_Item_Quantity(string conditional_var)
        {
            string query = Database_Query.get_quantity_item;
            query = string.Format(query, conditional_var);
            db_Manager = new Database_Manager();
            using (db_Manager)
                return Convert.ToInt32(db_Manager.ExecuteScalar(query));
        }
        public int Get_Entity_ID(string conditional_var)
        {
            string query = Database_Query.get_entity_id;
            query = string.Format(query, conditional_var);
            db_Manager = new Database_Manager();
            using (db_Manager)
                return Convert.ToInt32(db_Manager.ExecuteScalar(query));
        }
        public int Get_Employee_ID(string emp_name, string emp_pos, string emp_off)
        {
            string query = Database_Query.get_employee_id;
            query = string.Format(query, emp_name, emp_pos, emp_off);
            db_Manager = new Database_Manager();
            using (db_Manager)
                return Convert.ToInt32(db_Manager.ExecuteScalar(query));
        }
        #region Inserts
        public void Insert_ICS(string ics_num, int entity_id, int receiver, int giver)
        {
            int ret;
            db_Manager = new Database_Manager();
            string query = Database_Query.insert_ics;
            string user_name = CurrentUser.user_name;
            query = string.Format(query, ics_num, entity_id, receiver, giver, user_name);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record("ICS", ics_num);
                MessageBox.Show($"ICS Number: {ics_num} is successfully added.", "ICS Added");
            }
            else if (ret == 0)
                MessageBox.Show($"ICS Number: {ics_num} is not added.", $"ICS Number Not Added\n{ics_num} may already exist.");
        }
        public void Insert_Transfer_Item(string ics_num, string item_code, string serial_number, int quantity, double total)
        {
            int ret;
            db_Manager = new Database_Manager();
            string query = Database_Query.insert_transferred_item;
            string user_name = CurrentUser.user_name;
            query = string.Format(query, ics_num, item_code, serial_number, quantity, total, user_name);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record("Item", item_code);
                //MessageBox.Show($"Item: {item_code} is successfully added.", "Item Added");
            }
            else if (ret == 0)
                MessageBox.Show($"Item: {item_code} is not added.", $"Item Not Added\n{item_code} may already exist.");
        }
        public void Insert_Fund_Cluster(string ics_num, string fund_cluster)
        {
            int ret;
            db_Manager = new Database_Manager();
            string query = Database_Query.insert_fund_cluster;
            query = string.Format(query, ics_num, fund_cluster);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record("Fund Cluster", ics_num);
                //MessageBox.Show($"Fund Cluster in {ics_num} is successfully added.", "Fund Cluster Added");
            }
            else if (ret == 0)
                MessageBox.Show($"Fund Cluster in {ics_num} is not added.", $"Fund Cluster Not Added\n{ics_num} may already exist.");
        }
        public void Update_Item_Quantity(int quantity, string item_code)
        {
            int ret;
            db_Manager = new Database_Manager();
            string query = Database_Query.update_item_quantity;
            query = string.Format(query, quantity, item_code);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Update_Item_Quantity(quantity.ToString(), item_code);
                //MessageBox.Show($"{item_code} is successfully updated.", "Quantity Updated");
            }
            else if (ret == 0)
                MessageBox.Show($"{item_code} is not updated.", $"Quantity not Updated");
        }
        #endregion
        #endregion
        #endregion
        #region Funds
        public void Insert_Fund_Name(string fund_name, string type)
        {
            int ret;
            db_Manager = new Database_Manager();
            string query = string.Format(Database_Query.insert_fund_name, fund_name, CurrentUser.user_name);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record(type, fund_name);
                MessageBox.Show($"Fund Name: {fund_name} is successfully added.", "Fund Name Added");
            }
            else if (ret == 0)
                MessageBox.Show($"Fund Name: {fund_name} is not added.", $"Fund Name Not Added\n{fund_name} may already exist.");

        }
        public DataTable Get_Fund_Names(int minimium, string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            if (searchwords != null)
                query = string.Format(Database_Query.select_specific_funds, searchwords, minimium);
            else query = string.Format(Database_Query.select_fund, minimium);
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
        #region Entity
        public void Insert_Entity_Name(string entity_name, string type)
        {
            int ret;
            db_Manager = new Database_Manager();
            string query = string.Format(Database_Query.insert_entity_name, entity_name, CurrentUser.user_name);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record(type, entity_name);
                MessageBox.Show($"Entity Name: {entity_name} is successfully added.", "Entity Name Added");
            }
            else if (ret == 0)
                MessageBox.Show($"Entity Name: {entity_name} is not added.", $"Entity Name Not Added\n{entity_name} may already exist.");

        }
        public DataTable Get_Entity_Names(int minimium, string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            if (searchwords != null)
                query = string.Format(Database_Query.select_specific_entity, searchwords, minimium);
            else query = string.Format(Database_Query.select_entity, minimium);
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
        #region Employee Position
        public void Insert_Employee_Position(string employee_position, string type)
        {
            int ret;
            db_Manager = new Database_Manager();
            string query = string.Format(Database_Query.insert_employee_position, employee_position, CurrentUser.user_name);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record(type, employee_position);
                MessageBox.Show($"Employee Position: {employee_position} is successfully added.", "Employee Position Added");
            }
            else if (ret == 0)
                MessageBox.Show($"Employee Position: {employee_position} is not added.", $"Employee Position Not Added\n{employee_position} may already exist.");

        }
        public DataTable Get_Employee_Position(int minimium, string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            if (searchwords != null)
                query = string.Format(Database_Query.select_specific_employee_position, searchwords, minimium);
            else query = string.Format(Database_Query.select_employee_position, minimium);
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
        #region Employee Office
        public void Insert_Employee_Office(string employee_office, string type)
        {
            int ret;
            db_Manager = new Database_Manager();
            string query = string.Format(Database_Query.insert_employee_office, employee_office, CurrentUser.user_name);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record(type, employee_office);
                MessageBox.Show($"Employee Office: {employee_office} is successfully added.", "Employee Office Added");
            }
            else if (ret == 0)
                MessageBox.Show($"Employee Office: {employee_office} is not added.", $"Employee Office Not Added\n{employee_office} may already exist.");

        }
        public DataTable Get_Employee_Office(int minimium, string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            if (searchwords != null)
                query = string.Format(Database_Query.select_specific_employee_office, searchwords, minimium);
            else query = string.Format(Database_Query.select_employee_office, minimium);
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
        #region Employee
        public void Insert_Employee_Category(string query, string item, string type, bool zero_feedback = true)
        {
            int ret;
            db_Manager = new Database_Manager();
            query = string.Format(query, item);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Add_New_Item_Record(type, item);
                MessageBox.Show($"{type}: {item} is successfully added.", $"{type} Added");
            }
            else if (ret == 0)
                if(zero_feedback)
                    MessageBox.Show($"{type}: {item} is not added.", $"{type} Not Added\n{item} may already exist.");
        }
        public DataTable Get_Employee_Records(int minimium, int status, string sortString, string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            switch (sortString)
            {
                case "All":
                    query = string.Format(Database_Query.get_all_specific_employee_record, minimium, searchwords, status);
                    break;
                default:
                    if (searchwords != null)
                        query = string.Format(Database_Query.get_specific_employee_record, minimium, searchwords, sortString.Replace(" ", "_"), status);
                    else query = string.Format(Database_Query.get_general_employee_record, minimium, status);
                    break;
            }
            using (db_Manager)
                dt = db_Manager.ExecuteQuery(query);

            int removeLimitIndex = query.IndexOf("LIMIT");
            if (removeLimitIndex >= 0)
                Database_Query.last_query = query.Remove(removeLimitIndex);
            return dt;
        }
        public DataTable Get_Archived_Employee_Records(int minimium, int status, string sortString, string searchwords = null)
        {
            string query;
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            switch (sortString)
            {
                case "All":
                    query = string.Format(Database_Query.get_all_specific_archived_employee_record, minimium, searchwords, status);
                    break;
                default:
                    if (searchwords != null)
                        query = string.Format(Database_Query.get_specific_archived_employee_record, minimium, searchwords, sortString.Replace(" ", "_"), status);
                    else query = string.Format(Database_Query.get_general_archived_employee_record, minimium, status);
                    break;
            }
            using (db_Manager)
                dt = db_Manager.ExecuteQuery(query);

            int removeLimitIndex = query.IndexOf("LIMIT");
            if (removeLimitIndex >= 0)
                Database_Query.last_query = query.Remove(removeLimitIndex);
            return dt;
        }
        public void Update_Employee_Record(string query, string item, string type, bool zero_feedback = true, string changes = null)
        {
            int ret;
            db_Manager = new Database_Manager();
            query = string.Format(query, item);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            if (ret == 1)
            {
                Activity_Manager activity_Manager = new Activity_Manager();
                activity_Manager.Alter_Item_Record(type, item, changes);
                MessageBox.Show($"{type}: {item} is successfully updated.", $"{type} updated");
            }
            else if (ret == 0)
                if (zero_feedback)
                    MessageBox.Show($"{type}: {item} is not updated.", $"{type} Not updated.");
        }
        public void Archive_Employee_Status(string query, string item, string type, bool zero_feedback = true, string remarks = null, int status = 0)
        {
            int ret;
            db_Manager = new Database_Manager();
            query = string.Format(query, item);
            using (db_Manager)
                ret = db_Manager.ExecuteNonQuery(query);
            switch (status)
            {
                case 0:
                    if (ret == 1)
                    {
                        Activity_Manager activity_Manager = new Activity_Manager();
                        activity_Manager.Archive_Item_Record(type, item, remarks);
                        MessageBox.Show($"{type}: {item} is successfully archived.", $"{type} Archived");
                    }
                    else if (ret == 0)
                        if (zero_feedback)
                            MessageBox.Show($"{type}: {item} is not archived.", $"{type} Not Archived\n{item} may already archived.");
                    break;
                case 1:
                    if (ret == 1)
                    {
                        Activity_Manager activity_Manager = new Activity_Manager();
                        activity_Manager.Archive_Item_Record(type, item, remarks);
                        MessageBox.Show($"{type}: {item} is successfully restored.", $"{type} Restored");
                    }
                    else if (ret == 0)
                        if (zero_feedback)
                            MessageBox.Show($"{type}: {item} is not restored.", $"{type} Not Restored\n{item} may already restored.");
                    break;
                default: break;
            }
            
        }
        #endregion
    }
}
