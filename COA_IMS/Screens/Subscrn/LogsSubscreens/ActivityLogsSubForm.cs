using COA_IMS.Screens.Subscrn.EmployeeSubscreens;
using COA_IMS.Screens.Subscrn.Tracking;
using COA_IMS.UserControlUtil.TableUtil;
using COA_IMS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscrn.LogsSubscreens
{
    public partial class ActivityLogsSubForm : Form
    {
        GenericTable generic_Table;
        readonly string[] log_table_names = { "User Name", "Activity" };
        private Inventory_Manager inventory_Manager;
        public ActivityLogsSubForm()
        {
            InitializeComponent();
            inventory_Manager = new Inventory_Manager();
            //setup GenericTable
            //setup ordinary controls
            sortComboBox.Items.Clear();
            foreach (string name in log_table_names)
                sortComboBox.Items.Add(name);
            generic_Table = new GenericTable();
            generic_Table.FillVariables(log_table_names, null, null, "actlog", "actlog", searchBar1, dateFilter1, sortComboBox, LogsTable, next_Button, previous_Button, pageCountTextbox);
            generic_Table.sort_String = "User Name";
            sortComboBox.SelectedText = "User Name";
            sortComboBox.SelectedIndex = 0;
            generic_Table.Populate_Table(1);
            //setup user controls
            searchBar1.Ambatu(RePopulate_Table);
            //disables next logs button
            generic_Table.Check_Count();
            //setup date filter
            ChangeDataDates();
            dateFilter1.Ambatu(dateTimePicker_ValueChanged);
            //dateFilter1.toValue = DateTime.Today;
            //dateFilter1.fromValue = DateTime.Today;

            DateTime latest_date = (DateTime)inventory_Manager.Get_Code_From_table(Database_Query.get_max_transfer_date_actlogs);

            string max_date = latest_date.ToString("dd/MM/yyyy 00:00:00");

            dateFilter1.toValue = Convert.ToDateTime(max_date);
            dateFilter1.fromValue = Convert.ToDateTime(max_date);



            next_Button.Click += next_Button_Click;
            previous_Button.Click += previous_Button_Click;
            pageCountTextbox.KeyDown += pageCountTextbox_KeyDown;
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            refresh_Button.Click += RePopulate_Table;
            this.VisibleChanged += RePopulate_Table;
        }
        private void RePopulate_Table(object sender, EventArgs e)
        {
            generic_Table.Populate_Table();
            generic_Table.Check_Count();
            generic_Table.ResetPaging();
        }

        private void previous_Button_Click(object sender, EventArgs e)
        {
            generic_Table.UserChangePage(false);
        }
        private void next_Button_Click(object sender, EventArgs e)
        {
            generic_Table.UserChangePage(true);
        }

        private void pageCountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                generic_Table.UserChangePageCountInput();
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            generic_Table.sort_String = log_table_names[sortComboBox.SelectedIndex];
            generic_Table.Populate_Table();
            generic_Table.Check_Count();
        }

        #region More Plates More Dates
        public void ChangeDataDates()
        {
            dateFilter1.ToValueChanged += dateTimePicker_ValueChanged;
            dateFilter1.FromValueChanged += dateTimePicker_ValueChanged;
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateFilter1.toValue < dateFilter1.fromValue)
                dateFilter1.fromValue = dateFilter1.toValue;
            generic_Table.Populate_Table(3);
            generic_Table.Check_Count();
        }
        #endregion

        private void LogsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
                return;
            string arg = LogsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            string arg2 = LogsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            string arg3 = LogsTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            //MessageBox.Show(arg.ToString());
            LogsInfoForm logsform = new LogsInfoForm();
            logsform.logs_Name_Textbox.Text = arg;
            logsform.logs_office_Textbox.Text = arg3;
            logsform.Action_Textbox.Text = arg2;
            logsform.ShowDialog();
        }
    }
}

//backup
/*
 * using COA_IMS.Screens.Subscrn.EmployeeSubscreens;
using COA_IMS.UserControlUtil.TableUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscrn.LogsSubscreens
{
    public partial class ActivityLogsSubForm : Form
    {
        GenericTable generic_Table;
        readonly string[] log_table_names = { "user_name", "activity" };
        public ActivityLogsSubForm()
        {
            InitializeComponent();


            //setup ordinary controls
            generic_Table = new GenericTable();
            previous_Button.Enabled = false;
            sortComboBox.SelectedText = "user_name";
            sortComboBox.SelectedIndex = 0;
            generic_Table.Populate_Table(1, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, "actlog");
            //setup user controls
            searchBar1.Ambatu(logsSearchBox_TextChanged);
            ChangeDataDates();
            dateFilter1.Ambatu(dateTimePicker_ValueChanged);
            dateFilter1.toValue = DateTime.Today;
            dateFilter1.fromValue = DateTime.Today;
            //disables next logs button
            generic_Table.Check_Count(next_Button, previous_Button, dateFilter1, "actlog");
        }
        private void logsSearchBox_TextChanged(object sender, EventArgs e)
        {
            generic_Table.Populate_Table(2, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, "actlog");
        }
        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            generic_Table.Populate_Table(3, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, "actlog");
        }

        private void previous_Button_Click(object sender, EventArgs e)
        {
            generic_Table.UserChangePage(pageCountTextbox, dateFilter1, searchBar1, LogsTable, sortComboBox, next_Button, previous_Button, log_table_names, false, "actlog");
        }
        private void next_Button_Click(object sender, EventArgs e)
        {
            generic_Table.UserChangePage(pageCountTextbox, dateFilter1, searchBar1, LogsTable, sortComboBox, next_Button, previous_Button, log_table_names, true, "actlog");
        }

        private void pageCountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                generic_Table.UserChangePageCountInput(pageCountTextbox, dateFilter1, searchBar1, LogsTable, sortComboBox, next_Button, previous_Button, log_table_names, "actlog");
            }
        }
        private void ChangeDataDates()
        {
            dateFilter1.ToValueChanged += dateTimePicker_ValueChanged;
            dateFilter1.FromValueChanged += dateTimePicker_ValueChanged;
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateFilter1.toValue < dateFilter1.fromValue)
                dateFilter1.fromValue = dateFilter1.toValue;
            generic_Table.Populate_Table(3, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, "actlog");
        }

        private void refresh_Button_Click(object sender, EventArgs e)
        {
            generic_Table.Populate_Table(3, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, "actlog");
        }

        private void AccountLogging_VisibleChanged(object sender, EventArgs e)
        {
            refresh_Button.PerformClick();
        }

        private void LogsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
                return;
            string arg = LogsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            string arg2 = LogsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            string arg3 = LogsTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            //MessageBox.Show(arg.ToString());
            EmployeeInfoForm employeeInfoForm = new EmployeeInfoForm(arg, arg2, arg3);
            employeeInfoForm.ShowDialog();
            generic_Table.Populate_Table();
        }
    }
}
*/