using COA_IMS.CrystalReports;
using COA_IMS.Utilities;
using Guna.UI.Licensing;
using Guna.UI.WinForms;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/*How to use
 * Go To overload functions
 */
namespace COA_IMS.UserControlUtil.TableUtil
{
    internal class GenericTable
    {
        Activity_Manager activity_manager = new Activity_Manager();
        Database_Manager database_manager = new Database_Manager();
        Inventory_Manager inventory_Manager = new Inventory_Manager();
        Util util = new Util();
        #region Variables
        //integer
        int min_lim = 0;
        int page_cnt = 1;
        //strings
        string[] log_table_names { get; set; }
        string from_Date { get; set; }
        string to_Date { get; set; }
        public string data_Table_Type { get; set; }
        public string inventory_Table_Name { get; set; }
        public string sort_String { get; set; }
        public string employee_name { get; set; }
        public string employee_office { get; set; }
        public string employee_position { get; set; }
        public string specific_sn_item { get; set; }
        //user controls
        SearchBar searchBar1 { get; set; }
        DateFilter dateFilter1 { get; set; }
        //controls
        GunaComboBox sortComboBox { get; set; }
        GunaDataGridView data_View { get; set; }
        GunaButton next_Button { get; set; }
        GunaButton previous_Button { get; set; }
        GunaTextBox pageCountTextbox { get; set; }
        #endregion
        private readonly int max_lim = 15;
        private Image trash = Properties.Resources.error ;
        private int already_Designed = 0;
        private string Query { get; set; }

        public void FillVariables(string[] log_table_names,
            string from_Date, string to_Date, string data_Table_Type, string inventory_Table_Name,
            SearchBar searchBar1, DateFilter dateFilter1, GunaComboBox sortComboBox,
            GunaDataGridView data_View, GunaButton next_Button,
            GunaButton previous_Button, GunaTextBox pageCountTextbox)
        {
            //strings
            this.log_table_names = log_table_names;
            this.from_Date = from_Date;
            this.to_Date = to_Date;
            this.data_Table_Type = data_Table_Type;
            this.inventory_Table_Name = inventory_Table_Name;
            //user controls
            this.searchBar1 = searchBar1;
            this.dateFilter1 = dateFilter1;
            //controls
            this.sortComboBox = sortComboBox;
            this.data_View = data_View;
            this.next_Button = next_Button;
            this.previous_Button = previous_Button;
            this.pageCountTextbox = pageCountTextbox;
        }

        #region fill table with data
        public void Populate_Table(int type_of_spec, 
            DateFilter dateFilter1, SearchBar searchBar1, 
            GunaDataGridView LogsTable, GunaComboBox sortComboBox, 
            string[] log_table_names, 
            string data_Table_Type)
        {
            //instantiate a datatable to put in items to datagridview
            DataTable dt = new DataTable();
            //take datetimepicker values and format it to mysql format
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            string current_time = DateTime.Now.ToString("HH':'mm':'ss");
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);


            //add new case for every type of table to be filled
            switch (data_Table_Type)
            {
                //if data needed is for account logs
                case "acclog":
                    dt = FillAccLogsTable(type_of_spec, from_Date, to_Date, searchBar1, min_lim, sortComboBox, log_table_names);
                    break;
                //if data needed is for activity logs
                case "actlog":
                    dt = FillActLogsTable(type_of_spec, from_Date, to_Date, searchBar1, min_lim, sortComboBox, log_table_names);
                    break;
                //if data needed is for project requests
                case "project":
                    dt = FillProjectsTable(type_of_spec, from_Date, to_Date, searchBar1, min_lim, sortComboBox, log_table_names);
                    break;
                //if data needed is for inventory requests
                case "inventory":
                    dt = FillInventoryTable(type_of_spec, from_Date, to_Date, searchBar1, min_lim, sortComboBox, log_table_names);
                    break;
                default: break;
            }
            //fill in datagridview with formatted datatable with numbering
            LogsTable.DataSource = util.format_DataTableLimit(dt, min_lim);
            //add design to data grid view along with column names
            AddThemeToDGV(LogsTable, data_Table_Type);
        }
        private DataTable FillAccLogsTable(int type_of_spec, 
            string from_Date, string to_Date, 
            SearchBar searchBar1, int min_lim, 
            GunaComboBox sortComboBox, string[] log_table_names)
        {
            //instantiate a datatable to put in items from database
            DataTable dt = new DataTable();
            switch (type_of_spec)
            {
                //display all account logs within date
                case 1:
                    dt = activity_manager.Display_Specific_Date_Logs_Table(from_Date, to_Date, min_lim);
                    break;
                //display logs within specified date
                case 2:
                    dt = activity_manager.Display_Specified_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                //conditional statement
                case 3:
                    if (searchBar1.Text == null) dt = activity_manager.Display_Specific_Date_Logs_Table(from_Date, to_Date, min_lim);
                    else dt = activity_manager.Display_Specified_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                default: break;
            }
            return dt;
        }


        private DataTable FillActLogsTable(int type_of_spec, 
            string from_Date, string to_Date, 
            SearchBar searchBar1, int min_lim, 
            GunaComboBox sortComboBox, string[] log_table_names)
        {
            DataTable dt = new DataTable();
            switch (type_of_spec)
            {
                //display all activity logs within date
                case 1:
                    dt = activity_manager.Display_Activity_Logs_Table(from_Date, to_Date, min_lim);
                    break;
                //display logs within specified date
                case 2:
                    dt = activity_manager.Display_Specified_Activity_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                //conditional statement
                case 3:
                    if (searchBar1.Text == null) dt = activity_manager.Display_Activity_Logs_Table(from_Date, to_Date, min_lim);
                    else dt = activity_manager.Display_Specified_Activity_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                default: break;
            }
            return dt;
        }

        private DataTable FillProjectsTable(int type_of_spec, 
            string from_Date, string to_Date, 
            SearchBar searchBar1, int min_lim, 
            GunaComboBox sortComboBox, string[] log_table_names)
        {
            DataTable dt = new DataTable();
            string sort_by = log_table_names[sortComboBox.SelectedIndex];
            switch (type_of_spec)
            {
                case 1:
                    Query = string.Format(Database_Query.get_general_project_records_by_date, sort_by, from_Date, to_Date);
                    break;
                case 2:
                    Query = string.Format(Database_Query.get_specific_project_records_by_date2, sort_by, from_Date, to_Date, searchBar1.Text);
                    break;
                case 3:
                    if (searchBar1.Text != null) Query = string.Format(Database_Query.get_general_project_records_by_date, sort_by, from_Date, to_Date);
                    else Query = string.Format(Database_Query.get_specific_project_records_by_date2, sort_by, from_Date, to_Date, searchBar1.Text);
                    break;
                default: break;
            }
            Database_Query.last_query = Query;
            Database_Manager database_Manager = new Database_Manager();
            util = new Util();
            using (database_Manager) dt = database_Manager.ExecuteQuery(Query);
            return dt;
        }
        

        private DataTable FillInventoryTable(int type_of_spec,
            string from_Date, string to_Date,
            SearchBar searchBar1, int min_lim,
            GunaComboBox sortComboBox, string[] log_table_names)
        {
            DataTable dt = new DataTable();
            string sort_by = log_table_names[sortComboBox.SelectedIndex];

            if (searchBar1.Text != null) Query = string.Format
                    (Database_Query.get_general_project_records_by_date, 
                    sort_by, from_Date, to_Date);
            else Query = string.Format
                    (Database_Query.get_specific_project_records_by_date2, 
                    sort_by, from_Date, to_Date, searchBar1.Text);

            Database_Query.last_query = Query;
            Database_Manager database_Manager = new Database_Manager();
            using (database_Manager) dt = database_Manager.ExecuteQuery(Query);
            return dt;
        }
        #endregion
        #region add design to table
        public void AddThemeToDGV(GunaDataGridView data_View, string data_Table_Type)
        {
            //Add Theme.cs DataGridView Style
            (bool, int)[] column_Widths = null;
            (string, DataGridViewContentAlignment)[] column_Text_Align = null;
            switch (data_Table_Type)
            {
                case "actlog":
                    goto case "log";
                case "acclog":
                    goto case "log";
                case "log":
                    column_Widths = new (bool, int)[] { (true, 3), (true, 20), (true, 47), (true, 30) }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Username", DataGridViewContentAlignment.MiddleLeft),
                            ("Activity", DataGridViewContentAlignment.MiddleLeft),
                            ("Date And Time", DataGridViewContentAlignment.MiddleCenter)
                        }; ;
                    break;
                case "project":
                    column_Widths = new (bool, int)[] { (true, 3), (true, 9), (true, 9), (true, 9), (true, 10), (true, 10), (true, 10), (true, 30), (true, 10) };
                    //column_Widths = new (bool, int)[] { (true, 10), (true, 10), (true, 10), (true, 10), (true, 10), (true, 10), (true, 30), (true, 10) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Document ID", DataGridViewContentAlignment.MiddleCenter),
                            ("Document Code", DataGridViewContentAlignment.MiddleCenter),
                            ("Document #",DataGridViewContentAlignment.MiddleRight),
                            ("Amount",DataGridViewContentAlignment.MiddleRight),
                            ("Title", DataGridViewContentAlignment.MiddleLeft),
                            ("Period",DataGridViewContentAlignment.MiddleCenter),
                            ("Subject Matter",DataGridViewContentAlignment.MiddleLeft),
                            ("Receiving Date",DataGridViewContentAlignment.MiddleCenter)
                        };
                    break;
                case "items":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 10), (true, 20), (true, 20), (true, 10), (true, 5), (true, 10), (true, 10), (true, 10), }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleLeft),
                            ("Item Code", DataGridViewContentAlignment.MiddleLeft),
                            ("Item Desc.", DataGridViewContentAlignment.MiddleLeft),
                            ("SN", DataGridViewContentAlignment.MiddleLeft),
                            ("Unit", DataGridViewContentAlignment.MiddleLeft),
                            ("Qty.", DataGridViewContentAlignment.MiddleLeft),
                            ("Unit Cost", DataGridViewContentAlignment.MiddleLeft),
                            ("Total Cost", DataGridViewContentAlignment.MiddleLeft),
                            ("Est Use Life", DataGridViewContentAlignment.MiddleLeft),
                        }; ;
                    break;
                default: break;
            }

            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }
        #endregion
        #region Generate Reports
        public void GenerateReportForm(string table = null)
        {
            var temprepp = Application.OpenForms["TempReportsForms"];
            if (temprepp == null)
            {
                temprepp = new TempReportsForms();
            }
            temprepp.Show();
        }
        #endregion
        #region table paging
        public int Check_Count(GunaButton next_Button, 
            GunaButton previous_Button, DateFilter dateFilter1, 
            string data_Table_Type)
        {
            min_lim = max_lim * (page_cnt - 1);
            if ((min_lim + max_lim) >= Records_Count(dateFilter1, data_Table_Type)) next_Button.Enabled = false;
            else next_Button.Enabled = true;

            if (page_cnt <= 1) previous_Button.Enabled = false;
            else previous_Button.Enabled = true;

            return min_lim;
        }
        

        private int Records_Count(DateFilter dateFilter1, string data_Table_Type)
        {
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            string current_time = DateTime.Now.ToString("HH':'mm':'ss");
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);
            int rec_count = 0;
            switch (data_Table_Type)
            {
                case "actlog":
                    rec_count = activity_manager.Count_Activity_Logs(from_Date, to_Date);
                    break;
                case "acclog":
                    rec_count = activity_manager.Count_Account_Logs(from_Date, to_Date);
                    break;
                case "project":
                    break;
                default: break;
            }
            return rec_count;
        }

        public int UserChangePageCountInput(GunaTextBox pageCountTextbox, 
            DateFilter dateFilter1, SearchBar searchBar1, 
            GunaDataGridView LogsTable, GunaComboBox sortComboBox, 
            GunaButton next_Button, GunaButton previous_Button, 
            string[] log_table_names, string data_Table_Type)
        {
            int result;
            object b = pageCountTextbox.Text;
            //checks to see if user input is a number
            if (int.TryParse(b.ToString(), out result))
            {
                //checks maximum amount of pages
                int xd = (Records_Count(dateFilter1, data_Table_Type) / max_lim) + 1;
                //checks if user input is less than or equal to maximum amount of pages and not below 1
                if (result <= xd && result >= 1)
                {
                    page_cnt = result; //puts user input as page count
                    min_lim = Check_Count(next_Button, previous_Button, dateFilter1, data_Table_Type);
                    Populate_Table(3, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, data_Table_Type);
                }
            }
            //if wrong, puts last know page count to text box
            pageCountTextbox.Text = page_cnt.ToString();
            return page_cnt;
        }

        public int UserChangePage(GunaTextBox pageCountTextbox, 
            DateFilter dateFilter1, SearchBar searchBar1, 
            GunaDataGridView LogsTable, GunaComboBox sortComboBox, 
            GunaButton next_Button, GunaButton previous_Button, 
            string[] log_table_names, bool next, 
            string data_Table_Type)
        {
            if (next) page_cnt++;
            else page_cnt--;

            pageCountTextbox.Text = page_cnt.ToString();
            min_lim = Check_Count(next_Button, previous_Button, dateFilter1, data_Table_Type);
            Populate_Table(3, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, data_Table_Type);

            return page_cnt;
        }
        #endregion
        #region overload functions
        public void Populate_Table(int type_of_spec = 3)
        {
            //instantiate a datatable to put in items to datagridview
            DataTable dt = new DataTable();
            //take datetimepicker values and format it to mysql format
            if (dateFilter1 != null)
            {
                string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
                string current_time = DateTime.Now.ToString("HH':'mm':'ss");
                string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);
            }
            //add new case for every type of table to be filled
            switch (data_Table_Type)
            {
                //if data needed is for account logs
                case "acclog":
                    dt = FillAccountLogs();
                    //dt = FillAccLogsTable(type_of_spec, from_Date, to_Date);
                    break;
                //if data needed is for activity logs
                case "actlog":
                    dt = FillActivityLogs();
                    //dt = FillActLogsTable(type_of_spec, from_Date, to_Date);
                    break;
                //if data needed is for project requests
                case "project":
                    dt = FillProjectsTable(type_of_spec, from_Date, to_Date);
                    break;
                //if data needed is for inventory requests
                case "item_type":
                    dt = FillInventoryTable();
                    break;
                case "item_brand":
                    goto case "item_type";
                case "unit":
                    goto case "item_type";
                case "inventory":
                    dt = FillInventoryTable();
                    break;
                case "item_supplier":
                    dt = FillSupplierTable();
                    break;
                case "item":
                    dt = FillItemsTable();
                    break;
                case "fund":
                    dt = FillFundsTable();
                    break;
                case "entity":
                    dt = FillEntityTable();
                    break;
                case "employee_position":
                    dt = FillPositionTable();
                    break;
                case "employee_office":
                    dt = FillOfficeTable();
                    break;
                case "employee":
                    dt = FillEmployeeTable();
                    break;
                case "archived_employee":
                    dt = FillArchivedEmployeeTable();
                    break;
                case "items":
                    dt = FillBlankTable();
                    break;
                case "ics":
                    dt = FillICSTable();
                    break; 
                case "return":
                    dt = FillICSReturnTable();
                    break; 
                case "sn_item":
                    dt = FillSNItemTable();
                    break; 
                case "emp_hist":
                    dt = FillEmpHistoryTable();
                    break; 
                case "spec_sn":
                    dt = FillItemHistoryTable();
                    break; 
                case "archived_items":
                    dt = FillArchivedItemsTable();
                    break; 
                default: break;
            }
            //fill in datagridview with formatted datatable with numbering
            data_View.DataSource = util.format_DataTableLimit(dt, min_lim);
            //add design to data grid view along with column names
            AddThemeToDGV();
            //if (already_Designed == 0)
            //    AddThemeToDGV();
            //else AlternateTheTable();
            //already_Designed = 1;
            //add delete button
            //if (data_Table_Type.Equals("item_type"))
            //    AddDeletee();

        }
        #region account logs
        private DataTable FillAccLogsTable(int type_of_spec, string from_Date, string to_Date)
        {
            //instantiate a datatable to put in items from database
            DataTable dt = new DataTable();
            switch (type_of_spec)
            {
                //display all account logs within date
                case 1:
                    dt = activity_manager.Display_Specific_Date_Logs_Table(from_Date, to_Date, min_lim);
                    break;
                //display logs within specified date
                case 2:
                    dt = activity_manager.Display_Specified_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                //conditional statement
                case 3:
                    if (searchBar1.Text == null) dt = activity_manager.Display_Specific_Date_Logs_Table(from_Date, to_Date, min_lim);
                    else dt = activity_manager.Display_Specified_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                default: break;
            }
            return dt;
        }
        #endregion
        #region activity logs
        private DataTable FillActLogsTable(int type_of_spec, string from_Date, string to_Date)
        {
            DataTable dt = new DataTable();
            switch (type_of_spec)
            {
                //display all activity logs within date
                case 1:
                    dt = activity_manager.Display_Activity_Logs_Table(from_Date, to_Date, min_lim);
                    break;
                //display logs within specified date
                case 2:
                    dt = activity_manager.Display_Specified_Activity_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                //conditional statement
                case 3:
                    if (searchBar1.Text == null) dt = activity_manager.Display_Activity_Logs_Table(from_Date, to_Date, min_lim);
                    else dt = activity_manager.Display_Specified_Activity_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                default: break;
            }
            return dt;
        }
        #endregion
        #region project requests
        private DataTable FillProjectsTable(int type_of_spec, string from_Date, string to_Date)
        {
            DataTable dt = new DataTable();
            string sort_by = log_table_names[sortComboBox.SelectedIndex];
            switch (type_of_spec)
            {
                case 1:
                    Query = string.Format(Database_Query.get_general_project_records_by_date, sort_by, from_Date, to_Date);
                    break;
                case 2:
                    Query = string.Format(Database_Query.get_specific_project_records_by_date2, sort_by, from_Date, to_Date, searchBar1.Text);
                    break;
                case 3:
                    if (searchBar1.Text != null) Query = string.Format(Database_Query.get_general_project_records_by_date, sort_by, from_Date, to_Date);
                    else Query = string.Format(Database_Query.get_specific_project_records_by_date2, sort_by, from_Date, to_Date, searchBar1.Text);
                    break;
                default: break;
            }
            Database_Query.last_query = Query;
            Database_Manager database_Manager = new Database_Manager();
            util = new Util();
            using (database_Manager) dt = database_Manager.ExecuteQuery(Query);
            return dt;
        }
        #endregion
        private DataTable FillActivityLogs()
        {
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd 23:59:59");
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Activity_Logs(min_lim, sort_String.Replace(" ", "_"), searchBar1.Text, from_Date, to_Date);
        }
        private DataTable FillAccountLogs()
        {
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd 23:59:59");
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Account_Logs(min_lim, sort_String.Replace(" ", "_"), searchBar1.Text, from_Date, to_Date);
        }
        private DataTable FillInventoryTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Item_Records(min_lim, data_Table_Type, inventory_Table_Name, searchBar1.Text);
        }
        private DataTable FillSupplierTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Item_Supplier_Records(min_lim, sort_String, searchBar1.Text);
        }
        private DataTable FillItemsTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Item_Records(min_lim, sort_String, searchBar1.Text, 1);
        }
        private DataTable FillArchivedItemsTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Item_Records(min_lim, sort_String, searchBar1.Text, 0);
        }
        private DataTable FillFundsTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Fund_Names(min_lim, searchBar1.Text);
        }
        private DataTable FillEntityTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Entity_Names(min_lim, searchBar1.Text);
        }
        private DataTable FillPositionTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Employee_Position(min_lim, searchBar1.Text);
        }
        private DataTable FillOfficeTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Employee_Office(min_lim, searchBar1.Text);
        }
        private DataTable FillEmployeeTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Employee_Records(min_lim, 1, sort_String, searchBar1.Text);
        }
        private DataTable FillArchivedEmployeeTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Archived_Employee_Records(min_lim, 0, sort_String, searchBar1.Text);
        }
        private DataTable FillBlankTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Blank_Item_Record();
        }
        private DataTable FillICSTable()
        {
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            //string current_time = DateTime.Now.ToString("HH':'mm':'ss");
            //string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd 23:59:59");
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_ICS_Records(min_lim, 1, sort_String, searchBar1.Text, from_Date, to_Date);
        }
        private DataTable FillICSReturnTable()
        {
            //string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            //string current_time = DateTime.Now.ToString("HH':'mm':'ss");
            //string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_ICS_Return_Records(min_lim, 1, sort_String, searchBar1.Text/*, from_Date, to_Date*/);
        }
        private DataTable FillSNItemTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_SN_Item_Records(min_lim, 1, sort_String, searchBar1.Text);
        }
        private DataTable FillEmpHistoryTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Employee_History_Records(min_lim, employee_name, employee_position, employee_office, searchBar1.Text);
        }
        private DataTable FillItemHistoryTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Item_History_Records(min_lim, specific_sn_item, searchBar1.Text);
        }
        private void AddThemeToDGV()
        {
            //Add Theme.cs DataGridView Style
            (bool, int)[] column_Widths = null;
            (string, DataGridViewContentAlignment)[] column_Text_Align = null;
            switch (data_Table_Type)
            {
                case "actlog":
                    goto case "log";
                case "acclog":
                    goto case "log";
                case "log":
                    column_Widths = new (bool, int)[] { (true, 3), (true, 20), (true, 47), (true, 30) }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Username", DataGridViewContentAlignment.MiddleLeft),
                            ("Activity", DataGridViewContentAlignment.MiddleLeft),
                            ("Date And Time", DataGridViewContentAlignment.MiddleCenter)
                        }; ;
                    break;
                case "project":
                    column_Widths = new (bool, int)[] { (true, 3), (true, 9), (true, 9), (true, 9), (true, 10), (true, 10), (true, 10), (true, 30), (true, 10) };
                    //column_Widths = new (bool, int)[] { (true, 10), (true, 10), (true, 10), (true, 10), (true, 10), (true, 10), (true, 30), (true, 10) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Document ID", DataGridViewContentAlignment.MiddleCenter),
                            ("Document Code", DataGridViewContentAlignment.MiddleCenter),
                            ("Document #",DataGridViewContentAlignment.MiddleRight),
                            ("Amount",DataGridViewContentAlignment.MiddleRight),
                            ("Title", DataGridViewContentAlignment.MiddleLeft),
                            ("Period",DataGridViewContentAlignment.MiddleCenter),
                            ("Subject Matter",DataGridViewContentAlignment.MiddleLeft),
                            ("Receiving Date",DataGridViewContentAlignment.MiddleCenter)
                        };
                    break;
                case "item_type":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 95) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Item Types", DataGridViewContentAlignment.MiddleCenter),
                        };
                    break;
                case "item_brand":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 95) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Item Brands", DataGridViewContentAlignment.MiddleCenter),
                        };
                    break;
                case "unit":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 95) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Item Units", DataGridViewContentAlignment.MiddleCenter),
                        };
                    break;
                case "item_supplier":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 15), (true, 30), (true, 25), (true, 25) }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Supplier Name", DataGridViewContentAlignment.MiddleLeft),
                            ("Supplier Address", DataGridViewContentAlignment.MiddleLeft),
                            ("Contact Number", DataGridViewContentAlignment.MiddleLeft),
                            ("Contact Person", DataGridViewContentAlignment.MiddleCenter)
                        }; ;
                    break;
                case "items":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 10), (true, 20), (true, 20), (true, 10), (true, 5), (true, 10), (true, 10), (true, 10), }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleLeft),
                            ("Item Code", DataGridViewContentAlignment.MiddleLeft),
                            ("Item Desc.", DataGridViewContentAlignment.MiddleLeft),
                            ("SN", DataGridViewContentAlignment.MiddleLeft),
                            ("Unit", DataGridViewContentAlignment.MiddleLeft),
                            ("Qty.", DataGridViewContentAlignment.MiddleLeft),
                            ("Unit Cost", DataGridViewContentAlignment.MiddleLeft),
                            ("Total Cost", DataGridViewContentAlignment.MiddleLeft),
                            ("Est Use Life", DataGridViewContentAlignment.MiddleLeft),
                        }; ;
                    break;
                case "archived_items":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 10), (true, 20), (true, 20), (true, 10), (true, 5), (true, 10), (true, 10), (true, 10), }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleLeft),
                            ("Item Code", DataGridViewContentAlignment.MiddleLeft),
                            ("Item Desc.", DataGridViewContentAlignment.MiddleLeft),
                            ("SN", DataGridViewContentAlignment.MiddleLeft),
                            ("Unit", DataGridViewContentAlignment.MiddleLeft),
                            ("Qty.", DataGridViewContentAlignment.MiddleLeft),
                            ("Unit Cost", DataGridViewContentAlignment.MiddleLeft),
                            ("Total Cost", DataGridViewContentAlignment.MiddleLeft),
                            ("Est Use Life", DataGridViewContentAlignment.MiddleLeft),
                        }; ;
                    break;
                case "fund":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 95) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Fund Names", DataGridViewContentAlignment.MiddleCenter),
                        };
                    break;
                case "entity":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 95) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Entity Names", DataGridViewContentAlignment.MiddleCenter),
                        };
                    break;
                case "employee_position":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 95) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Employee Position", DataGridViewContentAlignment.MiddleCenter),
                        };
                    break;
                case "employee_office":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 95) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Employee Office", DataGridViewContentAlignment.MiddleCenter),
                        };
                    break;
                case "employee":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 45), (true, 25), (true, 25) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Employee Name", DataGridViewContentAlignment.MiddleCenter),
                            ("Employee Position", DataGridViewContentAlignment.MiddleCenter),
                            ("Office", DataGridViewContentAlignment.MiddleCenter),
                        };
                    break;
                case "archived_employee":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 20), (true, 25), (true, 25), (true, 25) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Employee Name", DataGridViewContentAlignment.MiddleCenter),
                            ("Employee Position", DataGridViewContentAlignment.MiddleCenter),
                            ("Office", DataGridViewContentAlignment.MiddleCenter),
                            ("Remarks", DataGridViewContentAlignment.MiddleCenter)
                        };
                    break;
                case "item":
                    column_Widths = new (bool, int)[] { (true, 3), (true, 10), (true, 47), (true, 10), (true, 10), (true, 10), (true, 10) }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Item Code", DataGridViewContentAlignment.MiddleLeft),
                            ("Item Description", DataGridViewContentAlignment.MiddleLeft),
                            ("Unit", DataGridViewContentAlignment.MiddleLeft),
                            ("Unit Cost", DataGridViewContentAlignment.MiddleLeft),
                            ("Est Useful Life", DataGridViewContentAlignment.MiddleLeft),
                            ("Quantity", DataGridViewContentAlignment.MiddleLeft)
                        }; ;
                    break;
                case "ics":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 25), (true, 15), (true, 15), (true, 10), (true, 15), (true, 15) }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("ICS Number", DataGridViewContentAlignment.MiddleLeft),
                            ("Entity Name", DataGridViewContentAlignment.MiddleLeft),
                            ("Received By", DataGridViewContentAlignment.MiddleLeft),
                            ("Brief Item", DataGridViewContentAlignment.MiddleLeft),
                            ("SN", DataGridViewContentAlignment.MiddleLeft),
                            ("Transfer Date", DataGridViewContentAlignment.MiddleLeft),
                        }; ;
                    break;
                case "return":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 15), (true, 15), (true, 12), (true, 8), (true, 15), (true, 15) , (true, 15) }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("ICS Number", DataGridViewContentAlignment.MiddleLeft),
                            ("Entity Name", DataGridViewContentAlignment.MiddleLeft),
                            ("Received By", DataGridViewContentAlignment.MiddleLeft),
                            ("Brief Item", DataGridViewContentAlignment.MiddleLeft),
                            ("SN", DataGridViewContentAlignment.MiddleLeft),
                            ("Transfer Date", DataGridViewContentAlignment.MiddleLeft),
                            ("Return Date", DataGridViewContentAlignment.MiddleLeft),
                        }; ;
                    break;
                case "sn_item":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 20), (true, 15), (true, 20) , (true, 20), (true, 20) }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Serial Number", DataGridViewContentAlignment.MiddleLeft),
                            ("Item Code", DataGridViewContentAlignment.MiddleLeft),
                            ("Item Description", DataGridViewContentAlignment.MiddleLeft),
                            ("Currently Held By", DataGridViewContentAlignment.MiddleLeft),
                            ("Last Held By", DataGridViewContentAlignment.MiddleLeft),
                        }; ;
                    break;
                case "emp_hist":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 20), (true, 20), (true, 20) , (true, 5), (true, 15), (true, 15) }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("ICS Number", DataGridViewContentAlignment.MiddleLeft),
                            ("Item", DataGridViewContentAlignment.MiddleLeft),
                            ("SN", DataGridViewContentAlignment.MiddleLeft),
                            ("Qty.", DataGridViewContentAlignment.MiddleLeft),
                            ("Transfer Date", DataGridViewContentAlignment.MiddleLeft),
                            ("Return Date", DataGridViewContentAlignment.MiddleLeft),
                        }; ;
                    break;
                case "spec_sn":
                    column_Widths = new (bool, int)[] { (true, 5), (true, 25), (true, 20), (true, 20), (true, 15) , (true, 15) }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("ICS Number", DataGridViewContentAlignment.MiddleLeft),
                            ("Receiver", DataGridViewContentAlignment.MiddleLeft),
                            ("Giver", DataGridViewContentAlignment.MiddleLeft),
                            ("Transfer Date", DataGridViewContentAlignment.MiddleLeft),
                            ("Return Date.", DataGridViewContentAlignment.MiddleLeft),
                        }; ;
                    break;
                default: break;
            }

            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }
        private void AlternateTheTable()
        {
            Theme.AlternateTableRows(data_View);
        }
        public void Check_Count()
        {
            min_lim = max_lim * (page_cnt - 1);

            if ((min_lim + max_lim) >= Records_Count()) next_Button.Enabled = false;
            else next_Button.Enabled = true;

            if (page_cnt <= 1) previous_Button.Enabled = false;
            else previous_Button.Enabled = true;
        }
        private int Records_Count()
        {
            if(dateFilter1 != null)
            {
                string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
                string current_time = DateTime.Now.ToString("HH':'mm':'ss");
                string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);
            }
            int rec_count = 0;
            switch (data_Table_Type)
            {
                case "actlog":
                    from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
                    to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd 23:59:59");
                    rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.display_specified_activity_logs, from_Date, to_Date, min_lim, searchBar1.Text, sort_String.Replace(" ", "_")));
                    //rec_count = activity_manager.Count_Activity_Logs(from_Date, to_Date);
                    break;
                case "acclog":
                    from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
                    to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd 23:59:59");
                    rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.display_specified_account_logs, from_Date, to_Date, min_lim, searchBar1.Text, sort_String.Replace(" ", "_")));
                    //rec_count = activity_manager.Count_Account_Logs(from_Date, to_Date);
                    break;
                case "project":
                    break;
                case "item_type":
                    rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_item_types, searchBar1.Text));
                    break;
                case "item_brand":
                    rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_item_brands, searchBar1.Text));
                    break;
                case "unit":
                    rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_item_units, searchBar1.Text));
                    break;
                case "item_supplier":
                    rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_item_suppliers, searchBar1.Text));
                    break;
                case "fund":
                    rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_funds, searchBar1.Text));
                    break;
                case "entity":
                    rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_entity, searchBar1.Text));
                    break;
                case "employee_position":
                    rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_employee_position, searchBar1.Text));
                    break;
                case "employee_office":
                    rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_employee_office, searchBar1.Text));
                    break;
                case "employee":
                    if (sort_String.Equals("All"))
                        rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.get_all_specific_employee_record, min_lim, searchBar1.Text, 1));
                    else
                        rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.get_specific_employee_record, min_lim, searchBar1.Text, sort_String.Replace(" ", "_"), 1));
                    //rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_employee, searchBar1.Text, 1));
                    break;
                case "archived_employee":
                    if (sort_String.Equals("All"))
                        rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.get_all_specific_archived_employee_record, min_lim, searchBar1.Text, 0));
                    else
                        rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.get_specific_archived_employee_record, min_lim, searchBar1.Text, sort_String.Replace(" ", "_"), 0));
                    //rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_employee, searchBar1.Text, 0));
                    break;
                case "item":
                    if (sort_String.Equals("All"))
                        rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.get_all_specific_items_record, min_lim, searchBar1.Text, 1));
                    else
                        rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.get_specific_items_record, min_lim, searchBar1.Text, sort_String.Replace(" ", "_"), 1));
                    break;
                case "archived_items":
                    if (sort_String.Equals("All"))
                        rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.get_all_specific_items_record, min_lim, searchBar1.Text, 1));
                    else
                        rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.get_specific_items_record, min_lim, searchBar1.Text, sort_String.Replace(" ", "_"), 0));
                    break;
                case "ics":
                    from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
                    to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd 23:59:59");
                    rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_ics_table, min_lim, 1, searchBar1.Text, from_Date, to_Date));
                    break;
                case "sn_item":
                    if (sort_String.Equals("All"))
                        rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.get_all_serial_num_item_table, min_lim, 1, searchBar1.Text));
                    else
                        rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.get_specific_serial_num_item_table, min_lim, 1, searchBar1.Text, sort_String.Replace(" ", "_")));
                    break;
                case "return":
                    rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.count_employee, searchBar1.Text, 0));
                    break;
                case "emp_hist":
                    rec_count = inventory_Manager.Count_Item_Categories(string.Format(Database_Query.get_employee_history_count, searchBar1.Text, employee_name,  employee_position,  employee_office));
                    break;
                case "spec_sn":
                    rec_count = inventory_Manager.Count_Total_Results(string.Format(Database_Query.get_specific_sn_item, min_lim, specific_sn_item,  searchBar1.Text));
                    break;
                default: break;
            }
            return rec_count;
        }
        public int UserChangePageCountInput()
        {
            int result;
            object b = pageCountTextbox.Text;
            //checks to see if user input is a number
            if (int.TryParse(b.ToString(), out result))
            {
                //checks maximum amount of pages
                int xd = (Records_Count() / max_lim) + 1;
                //checks if user input is less than or equal to maximum amount of pages and not below 1
                if (result <= xd && result >= 1)
                {
                    page_cnt = result; //puts user input as page count
                    Check_Count();
                    Populate_Table(3);
                }
            }
            //if wrong, puts last know page count to text box
            pageCountTextbox.Text = page_cnt.ToString();
            return page_cnt;
        }
        public void ResetPaging()
        {
            page_cnt = 1; //puts user input as page count
            Check_Count();
            Populate_Table(3);
            //if wrong, puts last know page count to text box
            pageCountTextbox.Text = page_cnt.ToString();
        }

        public void UserChangePage(bool next)
        {
            if (next) page_cnt++;
            else page_cnt--;

            pageCountTextbox.Text = page_cnt.ToString();
            Check_Count();
            Populate_Table(3);
        }

        #endregion
    }
}
