using COA_IMS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace COA_IMS.Screens.Subscrn.EmployeeSubscreens
{
    public partial class EmployeeInfoForm : Form
    {
        string name, pos, off;
        Inventory_Manager inventory_Manager = new Inventory_Manager();
        public EmployeeInfoForm(string name, string pos, string off)
        {
            InitializeComponent();
            this.name = name;
            this.pos = pos;
            this.off = off;
            label1.Text = name;
            ActiveControl = employee_Name_Textbox;
            Populate_ComboBoxes();
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_Textbox.Text) || string.IsNullOrEmpty(contact_Number_Textbox.Text) || string.IsNullOrEmpty(address_Textbox.Text))
            {
                foreach (Control tbox in tableLayoutPanel1.Controls)
                {
                    if (tbox is GunaTextBox)
                    {
                        GunaTextBox tboxa = (GunaTextBox)tbox;
                        if (string.IsNullOrEmpty(tbox.Text))
                        {
                            tboxa.BorderColor = Color.Red;
                        }
                    }
                }
                return;
            }
            string update_employee_query = string.Format(Database_Query.insert_employee_record, employee_Name_Textbox.Text, position_ComboBox.Text, office_ComboBox.Text, email_Textbox.Text, contact_Number_Textbox.Text, address_Textbox.Text, CurrentUser.user_name);
            string insert_position_query = string.Format(Database_Query.insert_employee_office, office_ComboBox.Text, CurrentUser.user_name);
            string insert_office_query = string.Format(Database_Query.insert_employee_position, position_ComboBox.Text, CurrentUser.user_name);
            inventory_Manager.Insert_Employee_Category(insert_position_query, position_ComboBox.Text, "Employee Position", false);
            inventory_Manager.Insert_Employee_Category(insert_office_query, office_ComboBox.Text, "Employee Office", false);
            inventory_Manager.Insert_Employee_Category(update_employee_query, employee_Name_Textbox.Text, "Employee");
            clear_Textboxes();
        }

        private void Populate_ComboBoxes()
        {
            //fills different values inside comboboxes
            foreach (var items in inventory_Manager.Display_List_To_Combobox(Database_Query.select_item_list, "employee_position"))
                position_ComboBox.Items.Add(items);
            foreach (var items in inventory_Manager.Display_List_To_Combobox(Database_Query.select_item_list, "employee_office"))
                office_ComboBox.Items.Add(items);


            string query = string.Format(Database_Query.get_employee_record, name, pos, off);
            string[] employee_Details = { "employee_name", "employee_position", "employee_office", "email", "phone", "address", };
            List<string> list_of_items = inventory_Manager.Display_List_To_Combobox(query, employee_Details);
            string[] asd = list_of_items.ToArray();
            employee_Name_Textbox.Text = asd[0];
            position_ComboBox.Text = asd[1];
            office_ComboBox.Text = asd[2];
            email_Textbox.Text = asd[3];
            contact_Number_Textbox.Text = asd[4];
            address_Textbox.Text = asd[5];
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
