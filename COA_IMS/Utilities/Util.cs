using Guna.UI.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using COA_IMS.Utilities;

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
        public string GenarateUID(string _table)
        {
            db_Manager = new Database_Manager();
            Random random = new Random();
            string code;
            int length = 0;

            string date = DateTime.Now.ToString("yyMMdd");
            const string digits = "0123456789";

            using (db_Manager)
            {
                code = (string)db_Manager.ExecuteScalar(string.Format(Database_Query.get_code, _table));
                length = Convert.ToInt32(db_Manager.ExecuteScalar(string.Format(Database_Query.get_length, _table)));
            }

            int fixedPartLength = code.Length + date.Length + 1; // 1 for the underscore
            int randomLength = length - fixedPartLength;

            if (randomLength < 1)
            {
                throw new ArgumentException("Total length is too short to accommodate the fixed parts and at least one random character.");
            }

            string randomNumbers = new string(Enumerable.Repeat(digits, randomLength)
                                                       .Select(s => s[random.Next(s.Length)])
                                                       .ToArray());

            return $"{code}{date}_{randomNumbers}";
        }
        public string GenerateID(string _table)
        {
            db_Manager = new Database_Manager();
            string ret;

            using (db_Manager)
            {
                ret = (string)db_Manager.ExecuteScalar(string.Format(Database_Query.get_recent_code, _table));
            }

            if (ret is null)
            {
                DataTable code_info = new DataTable();

                string prefix = null;
                int number = 0;
                int initial = 0;

                using (db_Manager)
                {
                    code_info = db_Manager.ExecuteQuery(string.Format(Database_Query.get_code_info, _table));
                }

                foreach (DataRow row in code_info.Rows)
                {
                    prefix = (string)row["code"];
                    number = Convert.ToInt32(row["num_length"]);
                    initial = Convert.ToInt32(row["initial_num"]);
                }

                return $"{prefix}{initial.ToString($"D{number}")}";
            }
            else
            {
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

        public string GenerateRandomID(Random random, string _table)
        {
            DataTable code_info;
            db_Manager = new Database_Manager();

            using (db_Manager)
                code_info = db_Manager.ExecuteQuery(string.Format(Database_Query.get_code_info, _table));


            string prefix = (string)code_info.Rows[0]["code"] + '_';
            int number = Convert.ToInt32(code_info.Rows[0]["num_length"]) - 4;

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            //Random random = new Random();

            char[] id = new char[number];
            for (int i = 0; i < number; i++)
                id[i] = chars[random.Next(chars.Length)];


            return prefix + new string(id);


        }
        public string GenerateUserName(Random random, string _name)
        {
            //Random random = new Random();
            int randomNumber = random.Next(100000, 1000000);
            // Split the full name into parts
            string[] parts = _name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Initialize a variable to store the short name
            string userName = "";

            // If there's only one part, return it directly
            if (parts.Length == 1)
            {
                return parts[0] += "_" + randomNumber.ToString(); ;
            }

            // Take the first character of each part (except the last part) and convert it to uppercase
            for (int i = 0; i < parts.Length - 1; i++)
            {
                userName += parts[i][0].ToString().ToUpper();
            }

            // Append an underscore and the last part of the name
            userName += "_" + parts[parts.Length - 1];



            // Append the random number to the shortened name
            userName += "_" + randomNumber.ToString();

            return userName;
        }

        public string GeneratePassword(Random random, string _name)
        {
            // Split the full name into parts
            string[] parts = _name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Get the last name
            string lastName = parts.Length > 0 ? parts[parts.Length - 1] : "";

            // Generate a random 6-digit number
            //Random random = new Random();
            int randomNumber = random.Next(100000, 1000000); // Generates a number between 100000 and 999999

            // Combine the last name and the random number
            string password = lastName + "_" + randomNumber.ToString();

            return password;
        }

        public string GenerateQuery(List<List<string>> entries, string insertionQuery)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var entry in entries)
            {
                string query = string.Format(insertionQuery, entry.ToArray());
                stringBuilder.AppendLine(query);
            }

            return stringBuilder.ToString();
        }

        public DataTable FormatDataTable(DataTable existing_Table)
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

        public DataTable FormatDataTableLimit(DataTable existing_Table, int minLim)
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

        public void SetControls(List<UserControl[]> controls, Control parent)
        {

            var panel = new TableLayoutPanel();
            panel.Dock = DockStyle.Fill;

            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            for (int col = 0; col < controls.Count; col++)
            {
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / controls.Count));

                var sub = new TableLayoutPanel();
                sub.Dock = DockStyle.Fill;

                sub.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));

                for (int row = 0; row < controls[col].Length; row++)
                {
                    sub.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                panel.Controls.Add(sub, col, 0);

            }

            for (int conCol = 0; conCol < controls.Count; conCol++)
            {
                var sub = (TableLayoutPanel)panel.Controls[conCol];
                sub.SuspendLayout();

                sub.AutoScroll = true;

                for (int conRow = 0; conRow < controls[conCol].Length; conRow++)
                {
                    var pris = controls[conCol][conRow];

                    pris.Dock = DockStyle.Top; // Set the docking property of the control

                    sub.Controls.Add(pris, 0, conRow);
                }

                sub.ResumeLayout(); // Resume layout logic after adding controls

            }

            parent.Controls.Add(panel);
        }

        public List<T> SearchControls<T>(Control parent, List<Type> types) where T : Control
        {
            List<T> ret_Controls = new List<T>();
            Queue<Control> q_control = new Queue<Control>();

            q_control.Enqueue(parent);

            while (q_control.Count > 0)
            {
                Control con = q_control.Dequeue();
                foreach (Type type in types)
                {
                    if (type.IsAssignableFrom(con.GetType()))
                    {
                        ret_Controls.Add((T)con);
                        break;
                    }
                }

                if (con.HasChildren)
                {
                    foreach (Control child_Control in con.Controls)
                        q_control.Enqueue(child_Control);
                }
            }

            return ret_Controls;
        }

        public bool SearchString(DataTable dataTable, string searchString)
        {
            var ret = false;
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    if (item.ToString().Contains(searchString))
                        ret = true;
                }
            }
            return ret;
        }

        public ConnectionInfo ReadJsonFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<ConnectionInfo>(jsonString);
            }
            else
            {
                Console.WriteLine($"File '{filePath}' not found.");
                return null;
            }
        }

        public void WriteJsonFile(string filePath, ConnectionInfo connectionInfo)
        {
            string jsonString = JsonConvert.SerializeObject(connectionInfo, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
