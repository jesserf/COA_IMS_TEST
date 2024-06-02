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
        string name, pos, off, email, number, address, id, left_button_text, remarks;
        private Dictionary<GunaTextBox, string> initialTexts = new Dictionary<GunaTextBox, string>();
        private Dictionary<ComboBox, string> initialChoices = new Dictionary<ComboBox, string>();
        Inventory_Manager inventory_Manager = new Inventory_Manager();
        public EmployeeInfoForm(string name, string pos, string off, string left_button_text = null, string remarks = null)
        {
            InitializeComponent();
            //takes information from a cell in table and puts it in variables
            this.name = name;
            this.pos = pos;
            this.off = off;
            if(remarks != null)
                this.remarks = remarks;
            if (left_button_text != null)
                switch (left_button_text)
                {
                    case "Restore":
                        remove_Btn.Text = "Restore";
                        break;
                    default: break;
                }
            //puts the passed name information and sets it into title
            label1.Text = name;
            //tab is transferred to email
            ActiveControl = email_Textbox;
            //populates the comboboxes and the textboxes as well
            Populate_ComboBoxes();
            //takes information from the textboxes and stores it in the dictionary
            foreach (Control control in tableLayoutPanel1.Controls)
                if (control is GunaTextBox gunaTextBox)
                    initialTexts.Add(gunaTextBox, gunaTextBox.Text);
            //takes information from comboboxes and stores it in dictionary
            foreach (Control control in tableLayoutPanel1.Controls)
                if (control is ComboBox gunaComboBox)
                    initialChoices.Add(gunaComboBox, gunaComboBox.Text);


        }
        //checks if current text in gunatextbox matches info stored from dictionary
        private List<GunaTextBox> GetChangedTextboxes()
        {
            List<GunaTextBox> changedTextboxes = new List<GunaTextBox>();
            foreach (var pair in initialTexts)
                if (pair.Key.Text.Trim() != pair.Value)
                    changedTextboxes.Add(pair.Key);
            return changedTextboxes;
        }
        //checks if current text in gunacombobox matches info stored from dictionary
        private List<ComboBox> GetChangedComboboxes()
        {
            List<ComboBox> changedComboboxes = new List<ComboBox>();
            foreach (var pair in initialChoices)
                if (pair.Key.Text.Trim() != pair.Value)
                    changedComboboxes.Add(pair.Key);
            return changedComboboxes;
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            //checks if every contact information is empty
            if (string.IsNullOrEmpty(email_Textbox.Text) && string.IsNullOrEmpty(contact_Number_Textbox.Text) && string.IsNullOrEmpty(address_Textbox.Text))
            {
                foreach (Control tbox in tableLayoutPanel1.Controls)
                {
                    if (tbox is GunaTextBox gTBox)
                    {
                        if (string.IsNullOrEmpty(gTBox.Text))
                        {
                            gTBox.BorderColor = Color.IndianRed;
                        }
                    }
                }
                return;
            }
            //create a list for gunatextboxes using function to see if there is atleast 1 that has changed
            List<GunaTextBox> changedTextboxes = GetChangedTextboxes();
            //create a list for comboboxes using function to see if there is atleast 1 that has changed
            List<ComboBox> changedComboboxes = GetChangedComboboxes();
            if (changedTextboxes.Count > 0 || changedComboboxes.Count > 0)
            {
                inventory_Manager = new Inventory_Manager();
                string changes = ": Changed ";

                string update_query = "";
                foreach (GunaTextBox textBox in changedTextboxes)
                {
                    update_query += $" {textBox.Tag.ToString().Replace(" ", "_")} = '{textBox.Text}',";
                    changes += $"{textBox.Tag} from {initialTexts[textBox]} to {textBox.Text}, ";
                }

                update_query = update_query.Substring(0, update_query.Length - 1);
                UpdateEmployeeRecord();
                foreach (ComboBox comboBox in changedComboboxes)
                {
                    update_query += $", {comboBox.Tag.ToString().Replace(" ", "_")}_id = (SELECT pos.{comboBox.Tag.ToString().Replace(" ", "_")}_id FROM {comboBox.Tag.ToString().Replace(" ", "_")}_table pos WHERE pos.{comboBox.Tag.ToString().Replace(" ", "_")} = '{comboBox.Text}')";
                    changes += $"{comboBox.Tag} from {initialChoices[comboBox]} to {comboBox.Text}, ";
                }

                changes = changes.Substring(0, changes.Length - 1);

                string query = string.Format(Database_Query.update_employee_record, id, update_query, CurrentUser.user_name);

                inventory_Manager.Update_Employee_Record(query, name, "Employee", true, changes);
                MessageBox.Show(query);
            }
            else MessageBox.Show("No textboxes have changed their texts.");

            //MessageBox.Show(id);

        }

        private void UpdateEmployeeRecord()
        {
            string insert_position_query = string.Format(Database_Query.insert_employee_office, office_ComboBox.Text, CurrentUser.user_name);
            string insert_office_query = string.Format(Database_Query.insert_employee_position, position_ComboBox.Text, CurrentUser.user_name);
            inventory_Manager.Insert_Employee_Category(insert_position_query, position_ComboBox.Text, "Employee Position", false);
            inventory_Manager.Insert_Employee_Category(insert_office_query, office_ComboBox.Text, "Employee Office", false);
        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            save_Button.Enabled = true;
        }

        private void Populate_ComboBoxes()
        {
            //fills different values inside comboboxes
            foreach (var items in inventory_Manager.Display_List_To_Combobox(Database_Query.select_item_list, "employee_position"))
                position_ComboBox.Items.Add(items);
            foreach (var items in inventory_Manager.Display_List_To_Combobox(Database_Query.select_item_list, "employee_office"))
                office_ComboBox.Items.Add(items);


            string query = string.Format(Database_Query.get_employee_record, name, pos, off);
            string[] employee_Details = { "employee_name", "employee_position", "employee_office", "email", "phone", "address", "employee_id" };
            List<string> list_of_items = inventory_Manager.Display_List_To_Combobox(query, employee_Details);
            string[] employee_details = list_of_items.ToArray();
             employee_Name_Textbox.Text = employee_details[0];
            position_ComboBox.Text = employee_details[1];
            office_ComboBox.Text = employee_details[2];
            email_Textbox.Text = employee_details[3];
            contact_Number_Textbox.Text = employee_details[4];
            address_Textbox.Text = employee_details[5];
            email = employee_details[3];
            number = employee_details[4];
            address = employee_details[5];
            id = employee_details[6];
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

        private void comboBox_TextUpdate(object sender, EventArgs e)
        {
            save_Button.Enabled = true;
            if (sender is ComboBox comboBox)
                if (string.IsNullOrEmpty(comboBox.Text.ToString().Trim()))
                    save_Button.Enabled = false; else save_Button.Enabled = true;
        }

        private void remove_Btn_Click(object sender, EventArgs e)
        {
            //if still has unreturned items, show yes and no messagebox showing that  they still are in possession of items, if yes, remove all items today, if no dont show form
            EmployeeRemoveRemarksSubForm removalForm = new EmployeeRemoveRemarksSubForm(id, name, this, remove_Btn.Text, remarks);
            removalForm.ShowDialog();
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
                tBox.BorderColor = Color.IndianRed;
            }
            else
            {
                tBox.BorderColor = Color.Gainsboro;
            }
        }
    }
}
