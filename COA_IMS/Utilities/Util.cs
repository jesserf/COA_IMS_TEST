using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace COA_IMS.Utilities
{
    internal class Util
    {
        private Database_Manager db_Manager;
        public string generate_ID(string table)
        {
            db_Manager = new Database_Manager();
            string ret;

            using (db_Manager) 
            {
                ret = (string)db_Manager.ExecuteScalar(string.Format(Database_Query.get_recent_code, table));
            }

            if (ret is null)
            {
                DataTable code_info = new DataTable();

                string prefix = null;
                int number = 0;
                int initial = 0;

                using (db_Manager)
                {
                    code_info = db_Manager.ExecuteQuery(string.Format(Database_Query.get_code_info, table));
                }

                foreach (DataRow row in code_info.Rows)
                {
                    prefix = (string)row["code"];
                    number = Convert.ToInt32(row["num_length"]);
                    initial = Convert.ToInt32(row["initial_num"]);
                }

                return $"{prefix}{initial.ToString($"D{number}")}";
            }
            else {
                int numeric_Index = ret.IndexOfAny("0123456789".ToCharArray());

                if (numeric_Index != -1)
                {
                    string prefix = ret.Substring(0, numeric_Index);
                    string numeric = ret.Substring(numeric_Index);
                    int numeric_Value = int.Parse(numeric) + 1;

                    return $"{prefix}{numeric_Value.ToString("D" + numeric.Length)}";
                }
                else
                    return "err";

            }
        }

        

        public string generate_Query(List<List<string>> entries, string insertionQuery)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var entry in entries)
            {
                string query = string.Format(insertionQuery, entry.ToArray());
                stringBuilder.AppendLine(query);
            }
            
            return stringBuilder.ToString();
        }

        public DataTable format_DataTable(DataTable existing_Table) 
        { 
            DataTable modified_Table = new DataTable();
            modified_Table.Columns.Add("index", typeof(int));


            foreach (DataColumn column in existing_Table.Columns) 
            {
                modified_Table.Columns.Add(column.ColumnName, column.DataType);
            }

            for (int i = 0; i < existing_Table.Rows.Count; i++)
            {
                DataRow row = modified_Table.NewRow();
                row["index"] = i + 1;

                foreach (DataColumn column in existing_Table.Columns)
                {
                    row[column.ColumnName] = existing_Table.Rows[i][column.ColumnName];
                }

                modified_Table.Rows.Add(row);
            }
            return modified_Table;
        }

        public DataTable format_DataTableLimit(DataTable existing_Table, int minLim)
        {
            DataTable modified_Table = new DataTable();
            modified_Table.Columns.Add("index", typeof(int));


            foreach (DataColumn column in existing_Table.Columns)
            {
                modified_Table.Columns.Add(column.ColumnName, column.DataType);
            }

            for (int i = 0; i < existing_Table.Rows.Count; i++)
            {
                DataRow row = modified_Table.NewRow();
                row["index"] = i + 1 + minLim;

                foreach (DataColumn column in existing_Table.Columns)
                {
                    row[column.ColumnName] = existing_Table.Rows[i][column.ColumnName];
                }

                modified_Table.Rows.Add(row);
            }
            return modified_Table;
        }

        public int get_ChildIndex(Control parent, Control child)
        {
            for (int i = 0; i < parent.Controls.Count; i++)
            {
                if (parent.Controls[i] == child)
                    return i;
                
            }
            return -1;
        }
    }
}
