using COA_IMS.Screens.Subscrn.EmployeeSubscreens;
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
    public partial class AccountLogsSubForm : Form
    {
        GenericTable generic_Table;
        readonly string[] log_table_names = { "user_name", "activity" };
        public AccountLogsSubForm()
        {
            InitializeComponent();
            //setup ordinary controls
            generic_Table = new GenericTable();
            previous_Button.Enabled = false;
            sortComboBox.SelectedText = "user_name";
            sortComboBox.SelectedIndex = 0;
            generic_Table.Populate_Table(1, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, "acclog");
            //setup user controls
            searchBar1.Ambatu(logsSearchBox_TextChanged);
            ChangeDataDates();
            dateFilter1.Ambatu(dateTimePicker_ValueChanged);
            dateFilter1.toValue = DateTime.Today;
            dateFilter1.fromValue = DateTime.Today;
            //disables next logs button
            generic_Table.Check_Count(next_Button, previous_Button, dateFilter1, "acclog");
        }
        private void logsSearchBox_TextChanged(object sender, EventArgs e)
        {
            generic_Table.Populate_Table(2, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, "acclog");
        }
        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            generic_Table.Populate_Table(3, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, "acclog");
        }

        private void previous_Button_Click(object sender, EventArgs e)
        {
            generic_Table.UserChangePage(pageCountTextbox, dateFilter1, searchBar1, LogsTable, sortComboBox, next_Button, previous_Button, log_table_names, false, "acclog");
        }
        private void next_Button_Click(object sender, EventArgs e)
        {
            generic_Table.UserChangePage(pageCountTextbox, dateFilter1, searchBar1, LogsTable, sortComboBox, next_Button, previous_Button, log_table_names, true, "acclog");
        }

        private void pageCountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                generic_Table.UserChangePageCountInput(pageCountTextbox, dateFilter1, searchBar1, LogsTable, sortComboBox, next_Button, previous_Button, log_table_names, "acclog");
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
            generic_Table.Populate_Table(3, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, "acclog");
            generic_Table.Check_Count(next_Button, previous_Button, dateFilter1, "acclog");
        }

        private void refresh_Button_Click(object sender, EventArgs e)
        {
            generic_Table.Populate_Table(3, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, "acclog");
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
            LogsInfoForm logsform = new LogsInfoForm();
            logsform.logs_Name_Textbox.Text = arg;
            logsform.logs_office_Textbox.Text = arg3;
            logsform.Action_Textbox.Text = arg2;
            logsform.ShowDialog();
        }
    }
}
