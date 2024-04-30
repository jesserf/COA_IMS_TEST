using COA_IMS.CrystalReports;
using COA_IMS.Utilities;
using Guna.UI.WinForms;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void AddThemeToDGV(GunaDataGridView data_View, string data_Table_Type)
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
            if(dateFilter1 != null)
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
                    dt = FillAccLogsTable(type_of_spec, from_Date, to_Date);
                    break;
                //if data needed is for activity logs
                case "actlog":
                    dt = FillActLogsTable(type_of_spec, from_Date, to_Date);
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
        private DataTable FillInventoryTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Item_Records(min_lim, data_Table_Type, inventory_Table_Name, searchBar1.Text);
        }
        private DataTable FillSupplierTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Item_Supplier_Records(min_lim, searchBar1.Text);
        }
        private DataTable FillItemsTable()
        {
            inventory_Manager = new Inventory_Manager();
            return inventory_Manager.Get_Item_Records(min_lim, searchBar1.Text);
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
                case "item":
                    column_Widths = new (bool, int)[] { (true, 3), (true, 10), (true, 47), (true, 10), (true, 10), (true, 10), (true, 10) }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Item Code", DataGridViewContentAlignment.MiddleLeft),
                            ("Item Desc", DataGridViewContentAlignment.MiddleLeft),
                            ("Unit", DataGridViewContentAlignment.MiddleLeft),
                            ("Unit Cost", DataGridViewContentAlignment.MiddleLeft),
                            ("Est Useful Life", DataGridViewContentAlignment.MiddleLeft),
                            ("Quantity", DataGridViewContentAlignment.MiddleLeft)
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
        //add button
        //private void AddDeletee()
        //{
        //    DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
        //    int columnIndex = 2;
        //    if (data_View.Columns["uninstall_column"] == null)
        //    {
        //        data_View.Columns.Insert(columnIndex, uninstallButtonColumn);
        //    }
        //    data_View.CellPainting += grid_CellPainting;
        //}

        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = trash.Width;
                var h = trash.Height;
                var x = e.CellBounds.Right + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(trash, new Rectangle(x, y, w, h));
            }
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
                    rec_count = activity_manager.Count_Activity_Logs(from_Date, to_Date);
                    break;
                case "acclog":
                    rec_count = activity_manager.Count_Account_Logs(from_Date, to_Date);
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
