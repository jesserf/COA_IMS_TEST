using COA_IMS.Screens.scrn;
using COA_IMS.Screens.Subscrn.EmployeeSubscreens;
using COA_IMS.UserControlUtil;
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

namespace COA_IMS.Screens.Subscrn.Tracking
{
    public partial class TrackingTable : Form
    {
        GenericTable generic_Table;
        readonly string[] log_table_names = { "All", "ICS Number", "Entity Name", "Employee Name", "Brief Item", "SN"};
        private Inventory_Manager inventory_Manager;
        public TrackingTable()
        {
            InitializeComponent();
            inventory_Manager = new Inventory_Manager();
            //setup GenericTable
            //setup ordinary controls
            foreach (string name in log_table_names)
                sortComboBox.Items.Add(name);
            generic_Table = new GenericTable();
            generic_Table.FillVariables(log_table_names, null, null, "ics", "ics", searchBar1, dateFilter1, sortComboBox, data_View, next_Button, previous_Button, pageCountTextbox);
            generic_Table.sort_String = "All";
            sortComboBox.SelectedText = "All";
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

            DateTime latest_date = (DateTime)inventory_Manager.Get_Code_From_table(Database_Query.get_max_transfer_date);

            string max_date = latest_date.ToString();

            dateFilter1.toValue = latest_date;
            dateFilter1.fromValue = latest_date;



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

        private void data_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
                return;
            string arg = data_View.Rows[e.RowIndex].Cells[1].Value.ToString();
            string arg2 = data_View.Rows[e.RowIndex].Cells[5].Value.ToString();
            ICSInfoForm employeeInfoForm = new ICSInfoForm(arg, arg2);
            employeeInfoForm.ShowDialog();
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

        private void add_Item_Btn_Click(object sender, EventArgs e)
        {
            AddTrackingBaseForm add_Tracking_Base_Form = new AddTrackingBaseForm();
            add_Tracking_Base_Form.ShowDialog();
            generic_Table.Populate_Table(3);
            generic_Table.Check_Count();
        }
    }
}
