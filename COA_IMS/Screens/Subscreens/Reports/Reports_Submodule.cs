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

namespace COA_IMS.Screens.Subscreens.Reports
{
    public partial class Reports_Submodule : Form
    {
        private Database_Manager database_Manager;
        private Util util;
        readonly string[] date_types = { "period", "receiveing_date" };
        private string Query { get; set; }
        public Reports_Submodule()
        {
            InitializeComponent();

            sortComboBox.SelectedIndex = 0;

            searchBar1.Ambatu(logsSearchBox_TextChanged);
            ChangeDataDates();
            dateFilter1.Ambatu(dateTimePicker_ValueChanged);
            dateFilter1.toValue = DateTime.Today;
            dateFilter1.fromValue = DateTime.Today;

            PopulateTable(1);
        }

        private void PopulateTable(int i)
        {
            string sort_by = date_types[sortComboBox.SelectedIndex];
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            string current_time = DateTime.Now.ToString("HH':'mm':'ss");
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);
            switch (4)
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
            show_Table(Query);
            SetTableTheme();
        }
        //change data grid view content according to search box
        private void logsSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateTable(2);
        }
        //change data grid view design
        private void SetTableTheme()
        {
            (bool, int)[] column_Widths = null;
            (string, DataGridViewContentAlignment)[] column_Text_Align = null;

            column_Widths = new (bool, int)[] { (true, 10), (true, 10), (true, 10), (true, 10), (true, 10), (true, 10), (true, 30), (true, 10) };
            column_Text_Align = new (string, DataGridViewContentAlignment)[]
                {
                    ("Document ID", DataGridViewContentAlignment.MiddleCenter),
                    ("Document Code", DataGridViewContentAlignment.MiddleCenter),
                    ("Document #",DataGridViewContentAlignment.MiddleRight),
                    ("Amount",DataGridViewContentAlignment.MiddleRight),
                    ("Title", DataGridViewContentAlignment.MiddleLeft),
                    ("Period",DataGridViewContentAlignment.MiddleCenter),
                    ("Subject Matter",DataGridViewContentAlignment.MiddleLeft),
                    ("Receiving Date",DataGridViewContentAlignment.MiddleCenter)
                };

            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }

        private void show_Table(string query)
        {
            DataTable dt = new DataTable();
            database_Manager = new Database_Manager();
            util = new Util();
            using (database_Manager) dt = database_Manager.ExecuteQuery(query);

            data_View.DataSource = dt;
        }

        private void previous_Button_Click(object sender, EventArgs e)
        {

        }

        private void next_Button_Click(object sender, EventArgs e)
        {

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
        //change logs page 
        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            PopulateTable(3);
        }
        //add events to date time picker
        private void ChangeDataDates()
        {
            dateFilter1.ToValueChanged += dateTimePicker_ValueChanged;
            dateFilter1.FromValueChanged += dateTimePicker_ValueChanged;
        }
        //if date time picker change values
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateFilter1.toValue < dateFilter1.fromValue)
                dateFilter1.fromValue = dateFilter1.toValue;
            PopulateTable(3);
        }

        private void refresh_Button_Click(object sender, EventArgs e)
        {
            PopulateTable(3);
        }
    }
}
