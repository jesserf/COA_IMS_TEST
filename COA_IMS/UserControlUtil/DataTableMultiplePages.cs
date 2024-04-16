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

namespace COA_IMS.UserControlUtil
{
    public partial class DataTableMultiplePages : UserControl
    {
        Activity_Manager activity_manager;
        //string[] column_names = { "User Name", "Activity", "Time" };
        string[] log_table_names = { "user_name", "activity", "activity_datetime" };
        private int min_lim = 0;
        int page_count = 1;
        public DataTableMultiplePages(string[] column_names = null, int minimum_limit = 0)
        {
            if (column_names == null) column_names = new string[] { "column 1", "column 2", "column 3" };
            InitializeComponent();
            //fix sort combobox
            changeGunaTableStyle(data_table);
            for (int i = 0; i < column_names.Length; i++)
            {
                sort_combobox.Items.Add(column_names[i]);
            }
            sort_combobox.SelectedText = column_names[0];
            sort_combobox.SelectedIndex = 0;

            SetTableHeader(column_names);

            min_lim = minimum_limit;
            DisplayLogsTable();
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            changeTableContent(search_box, data_table, sort_combobox);
        }

        private void DisplayLogsTable()
        {
            
            changeGunaTableStyle(data_table);
            //adds items to table
            activity_manager = new Activity_Manager();
            data_table.DataSource = activity_manager.Display_Three_Logs_Table(min_lim);
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            Change_Page("prev");
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            Change_Page("next");
        }

        private void page_count_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            Change_Page("skip");
        }

        private void Change_Page(string type)
        {
            switch (type)
            {
                case "prev":
                    page_count--;
                    break;
                case "next":
                    page_count++;
                    break;
                case "skip":
                    page_count = Convert.ToInt32(page_count_textbox.Text);
                    break;
                default: break;
            }
            //changes button state
            switch (page_count)
            {
                case 1:
                    next_button.Enabled = true;
                    previous_button.Enabled = false;
                    break;
                case 3:
                    next_button.Enabled = false;
                    previous_button.Enabled = true;
                    break;
                default:
                    next_button.Enabled = true;
                    previous_button.Enabled = true;
                    break;
            }
            
            page_count_textbox.Text = page_count.ToString();

            //min_lim = 7 * (page_cnt - 1);
            //activity_manager = new Activity_Manager();
            //LogsTable.DataSource = activity_manager.Display_Three_Logs_Table(min_lim);*/
        }

        private void changeGunaTableStyle(GunaDataGridView gunaTable)
        {
            //Changes column header style
            GunaDataGridViewHeaderStyle columnHeaderStyle = new GunaDataGridViewHeaderStyle(gunaTable.ColumnHeadersDefaultCellStyle, gunaTable);
            columnHeaderStyle.Font = new Font("Bahnschrift", 14.25F);
            columnHeaderStyle.Height = 40;
            columnHeaderStyle.BackColor = Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));


            //Chamges row styles
            GunaDataGridViewRowsStyle rowStyle = new GunaDataGridViewRowsStyle(gunaTable.DefaultCellStyle, gunaTable);
            rowStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(109)))), ((int)(((byte)(128)))));
            rowStyle.SelectionForeColor = Color.White;
            rowStyle.Font = new Font("Bahnschrift", 14.25F);
            rowStyle.Height = 40;
            Padding newPadding = new Padding(24, 3, 3, 3);
            foreach (DataGridViewColumn column in gunaTable.Columns)
            {
                if (column.Index == 0)
                {
                    column.DefaultCellStyle.Padding = newPadding;
                    column.HeaderCell.Style.Padding = newPadding;
                }
            }
            //alternating colors in rows
            int i = 0;
            foreach (DataGridViewRow row in gunaTable.Rows)
            {
                i++;
                if (i % 2 == 0)
                {
                    rowStyle.BackColor = Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
                }
            }
        }

        private void SetTableHeader(string[] column_names)
        {
            //Changes column name, change this later
            foreach (DataGridViewColumn column in data_table.Columns)
            {
                column.HeaderText = column_names[column.Index];
            }
        }

        

        public void changeTableContent(GunaTextBox searchBox, GunaDataGridView sourceTable, GunaComboBox filterComboBox)
        {
            if (searchBox.Text.ToString() == "") DisplayLogsTable();
            activity_manager = new Activity_Manager();
            sourceTable.DataSource = activity_manager.Display_Specific_Logs_Table(searchBox.Text.ToString(), log_table_names[filterComboBox.SelectedIndex]);

        }

        private void sort_combobox_SelectedValueChanged(object sender, EventArgs e)
        {
            changeTableContent(search_box, data_table, sort_combobox);
        }

        private void guning_button_Click(object sender, EventArgs e)
        {

        }

        private void sort_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchBar1_Load(object sender, EventArgs e)
        {
            
        }

        private void searchBar1_Load_1(object sender, EventArgs e)
        {

        }

        private void page_count_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
