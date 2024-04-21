using COA_IMS.CrystalReports;
using COA_IMS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscreens.ActivityLogs
{
    public partial class AccountLogging : Form
    {
        Activity_Manager activity_manager;
        Util util = new Util();
        readonly string[] log_table_names = { "user_name", "activity" };
        private int min_lim = 0;
        private int page_cnt = 1;
        public AccountLogging()
        {
            InitializeComponent();

            previous_Button.Enabled = false;
            sortComboBox.SelectedText = "user_name";
            sortComboBox.SelectedIndex = 0;
            DisplayLogsTable();
            //setup user controls
            searchBar1.Ambatu(logsSearchBox_TextChanged);
            ChangeDataDates();
            dateFilter1.Ambatu(dateTimePicker_ValueChanged);
            dateFilter1.toValue = DateTime.Today;
            dateFilter1.fromValue = DateTime.Today;
            //set theme to data grid view
            AddThemeToDGV();
        }

        private void logsSearchBox_TextChanged(object sender, EventArgs e)
        {
            changeTableContent(searchBar1.Text, LogsTable, sortComboBox);
        }

        private void Populate_Table(int type_of_spec)
        {
            activity_manager = new Activity_Manager();
            //adds items to table
            DataTable dt = new DataTable();
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            string current_time = DateTime.Now.ToString("HH':'mm':'ss");
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);
            switch (type_of_spec)
            {
                //display all logs within date
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

            //populate table with number
            LogsTable.DataSource = util.format_DataTableLimit(dt, min_lim);
            //set theme to data grid view
            AddThemeToDGV();
        }

        private void DisplayLogsTable()
        {
            Populate_Table(1);
        }

        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            changeTableContent(searchBar1.Text, LogsTable, sortComboBox);
        }

        private void changeTableContent(string searchBox, GunaDataGridView sourceTable, GunaComboBox filterComboBox)
        {
            Populate_Table(2);
        }
        private void previous_Button_Click(object sender, EventArgs e)
        {
            page_cnt--;
            next_Button.Enabled = true;
            min_lim = 15 * (page_cnt - 1);
            Populate_Table(3);
            pageCountTextbox.Text = page_cnt.ToString();
            if (page_cnt <= 1) previous_Button.Enabled = false;
        }

        private void next_Button_Click(object sender, EventArgs e)
        {
            page_cnt++;
            previous_Button.Enabled = true;
            min_lim = 15 * (page_cnt - 1);
            Populate_Table(3);
            pageCountTextbox.Text = page_cnt.ToString();

            //if ((min_lim + 15) >= activity_manager.Count_Logs()) next_Button.Enabled = false;
        }

        private void pageCountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                page_cnt = Convert.ToInt32(pageCountTextbox.Text);

                if (page_cnt <= 1) previous_Button.Enabled = false;
                min_lim = 15 * (page_cnt - 1);
                Populate_Table(3);
                AddThemeToDGV();
            }
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            var temprepp = Application.OpenForms["TempReportsForms"];
            if (temprepp == null)
            {
                temprepp = new TempReportsForms();
            }
            temprepp.Show();
        }

        private void AddThemeToDGV()
        {
            //Add Theme.cs DataGridView Style
            (bool, int)[] column_Widths = new (bool, int)[] { (true, 3), (true, 20), (true, 47), (true, 30) }; ;
            (string, DataGridViewContentAlignment)[] column_Text_Align = new (string, DataGridViewContentAlignment)[]
            {
                ("#", DataGridViewContentAlignment.MiddleRight),
                ("Username", DataGridViewContentAlignment.MiddleLeft),
                ("Activity", DataGridViewContentAlignment.MiddleLeft),
                ("Date And Time", DataGridViewContentAlignment.MiddleCenter)
            }; ;

            Theme.gridView_Style(LogsTable, column_Widths, column_Text_Align);
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
            Populate_Table(3);
        }

        private void refresh_Button_Click(object sender, EventArgs e)
        {
            Populate_Table(3);
        }

        private void AccountLogging_VisibleChanged(object sender, EventArgs e)
        {
            refresh_Button.PerformClick();
        }
    }
}
