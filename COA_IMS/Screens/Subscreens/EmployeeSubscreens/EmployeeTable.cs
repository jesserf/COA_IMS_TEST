using COA_IMS.Screens.Subscrn.EmployeeSubscreens;
using COA_IMS.UserControlUtil.TableUtil;
using System;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscrn
{
    public partial class EmployeeTable : Form
    {
        GenericTable generic_Table;
        readonly string[] log_table_names = {"All", "Employee Name", "Employee Position", "Employee Office" };
        public EmployeeTable()
        {
            InitializeComponent();
            //setup GenericTable
            //setup ordinary controls
            foreach (string name in log_table_names)
                sortComboBox.Items.Add(name);
            generic_Table = new GenericTable();
            generic_Table.FillVariables(log_table_names, null, null, "employee", "employee", searchBar1, null, sortComboBox, data_View, next_Button, previous_Button, pageCountTextbox);
            generic_Table.sort_String = "All";
            sortComboBox.SelectedText = "All";
            sortComboBox.SelectedIndex = 0;
            generic_Table.Populate_Table(1);
            //setup user controls
            searchBar1.Ambatu(RePopulate_Table);
            //disables next logs button
            generic_Table.Check_Count();
        }
        private void add_Employee_Button_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
            refresh_Button.PerformClick();
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
            string arg2 = data_View.Rows[e.RowIndex].Cells[2].Value.ToString();
            string arg3 = data_View.Rows[e.RowIndex].Cells[3].Value.ToString();
            //MessageBox.Show(arg.ToString());
            EmployeeInfoForm employeeInfoForm = new EmployeeInfoForm(arg, arg2, arg3);
            employeeInfoForm.ShowDialog();
            generic_Table.Populate_Table();
            generic_Table.Check_Count();
        }
    }
}
