using COA_IMS.Utilities;
using Guna.UI.WinForms;
using Org.BouncyCastle.Asn1.Crmf;
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

        private void save_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(employee_Name_Textbox.Text) || (
                string.IsNullOrEmpty(email_Textbox.Text) || string.IsNullOrEmpty(contact_Number_Textbox.Text) || string.IsNullOrEmpty(address_Textbox.Text)))
            {
                foreach (Control tbox in tableLayoutPanel1.Controls)
                {
                    if(tbox is GunaTextBox)
                    {
                        GunaTextBox tboxa = (GunaTextBox)tbox;
                        if (string.IsNullOrEmpty(tbox.Text))
                        {
                            Console.WriteLine("asdasda");
                            tboxa.BorderColor = Color.Red;
                        }
                    }
                }
                return;
            }
            string insert_employee_query = string.Format(Database_Query.insert_employee_record, employee_Name_Textbox.Text, position_ComboBox.Text, office_ComboBox.Text, email_Textbox.Text, contact_Number_Textbox.Text, address_Textbox.Text, CurrentUser.user_name);
            string insert_position_query = string.Format(Database_Query.insert_employee_office, office_ComboBox.Text, CurrentUser.user_name);
            string insert_office_query = string.Format(Database_Query.insert_employee_position, position_ComboBox.Text, CurrentUser.user_name);
            inventory_Manager.Insert_Employee_Category(insert_position_query, position_ComboBox.Text, "Employee Position", false);
            inventory_Manager.Insert_Employee_Category(insert_office_query, office_ComboBox.Text, "Employee Office", false);
            inventory_Manager.Insert_Employee_Category(insert_employee_query, employee_Name_Textbox.Text, "Employee");
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

        private void textbox_Enter(object sender, EventArgs e)
        {
            GunaTextBox tBox = (GunaTextBox)sender;
            tBox.BorderColor = Color.Gainsboro;
        }

        private void textbox_Leave(object sender, EventArgs e)
        {
            GunaTextBox tBox = (GunaTextBox)sender;
            if (string.Equals(tBox.Text.ToString().Trim(), ""))
            {
                tBox.BorderColor = Color.Red;
            }
            else
            {
                tBox.BorderColor = Color.Gainsboro;
            }
        }
    }
}
