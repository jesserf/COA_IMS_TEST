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

namespace COA_IMS.Screens.Subscrn
{
    public partial class AddEmployeeForm : Form
    {
        Inventory_Manager inventory_Manager = new Inventory_Manager();
        public AddEmployeeForm()
        {
            InitializeComponent();
            ActiveControl = employee_Name_Textbox;
            Populate_ComboBoxes();
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            string query = string.Format(Database_Query.insert_employee_record, employee_Name_Textbox.Text, position_ComboBox.Text, office_ComboBox.Text, CurrentUser.user_name);
            inventory_Manager.Insert_Employee_Category(Database_Query.insert_employee_position, position_ComboBox.Text, "Employee Position");
            inventory_Manager.Insert_Employee_Category(Database_Query.insert_employee_office, office_ComboBox.Text, "Employee Office");
            inventory_Manager.Insert_Employee_Category(query, employee_Name_Textbox.Text, "Employee");
            clear_Textboxes();
        }

        private void Populate_ComboBoxes()
        {
            //fills different values inside comboboxes
            foreach (var items in inventory_Manager.Display_List_To_Combobox(Database_Query.select_item_list, "employee_position"))
                position_ComboBox.Items.Add(items);
            foreach (var items in inventory_Manager.Display_List_To_Combobox(Database_Query.select_item_list, "employee_office"))
                office_ComboBox.Items.Add(items);
        }
        private void clear_Textboxes()
        {
            //clear text inside GunaTextBox and ComboBox
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is GunaTextBox)
                    control.Controls.Clear();
                else if (control is ComboBox)
                    control.ResetText();
            }
        }
    }
}
