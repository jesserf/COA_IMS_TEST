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

namespace COA_IMS.Screens.Subscrn.EmployeeSubscreens
{
    public partial class EmployeeRemoveRemarksSubForm : Form
    {
        private Form parentForm;
        Inventory_Manager inventory_Manager;
        string id, name, button_text;
        public EmployeeRemoveRemarksSubForm(string id, string name, Form parentForm, string button_text = null)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.parentForm = parentForm;
            if (button_text != null ) remove_Btn.Text = button_text;
        }

        private void remove_Btn_Click(object sender, EventArgs e)
        {
            
            string remarks = remarks_Textbox.Text.ToString().Trim();
            string changes = "";
            if (!string.IsNullOrEmpty(remarks))
            {
                changes = $": Remarks: {remarks}";
                remarks = $", remarks = '{remarks}'";
            }
            inventory_Manager = new Inventory_Manager();

            if(remove_Btn.Text == "Restore")
            {
                string query = string.Format(Database_Query.alter_employee_status, id, 1, remarks, CurrentUser.user_name);
                inventory_Manager.Archive_Employee_Status(query, name, "Employee", true, changes, 1);
            }
            else
            {
                string query = string.Format(Database_Query.alter_employee_status, id, 0, remarks, CurrentUser.user_name);
                inventory_Manager.Archive_Employee_Status(query, name, "Employee", true, changes, 0);
            }

            if (parentForm != null)
            {
                parentForm.Close();
            }
            this.Close();
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
