using COA_IMS.Screens.Subscreens.Maintenance;
using COA_IMS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscreens.Projects
{
    public partial class ProjectLists : Form
    {
        private Database_Manager database_Manager;
        private Util util;
        readonly string[] date_types = { "period", "receiveing_date" };
        private string Query { get; set; }
        public ProjectLists()
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
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd 23:59:59");
            switch (i)
            {
                case 1:
                    Query = string.Format(Database_Query.get_general_project_records_by_date, sort_by, from_Date, to_Date);
                    break;
                case 2:
                    Query = string.Format(Database_Query.get_specific_project_records_by_date, sort_by, from_Date, to_Date, searchBar1.Text);
                    break;
                case 3:
                    if (searchBar1.Text != null) Query = string.Format(Database_Query.get_all_project_records, sort_by, from_Date, to_Date);
                    else Query = string.Format(Database_Query.get_specific_project_records_by_date, sort_by, from_Date, to_Date, searchBar1.Text);
                    break;
                default: break;
            }
            /*show_Table(Query);*/
            SetTableTheme();
        }

        private void logsSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateTable(2);
        }

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

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void nextLogsBtn_Click(object sender, EventArgs e)
        {

        }

        private void reportsButton_Click(object sender, EventArgs e)
        {

        }

        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            PopulateTable(3);
        }

        private void ChangeDataDates()
        {
            dateFilter1.ToValueChanged += dateTimePicker_ValueChanged;
            dateFilter1.FromValueChanged += dateTimePicker_ValueChanged;
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateTable(3);
        }
    }
}
