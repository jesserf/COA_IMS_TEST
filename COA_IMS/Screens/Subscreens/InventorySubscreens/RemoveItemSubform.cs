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
using System.Xml.Linq;

namespace COA_IMS.Screens.Subscrn.InventorySubscreens
{
    public partial class RemoveItemSubform : Form
    {
        private Form parentForm;
        Inventory_Manager inventory_Manager;
        string id, button_text, remarks;
        public RemoveItemSubform(string id, Form parentForm, string button_text = null, string remarks = null)
        {
            InitializeComponent();
            this.id = id;
            this.parentForm = parentForm;
            if (button_text != null)
            {
                remove_Btn.Text = button_text;
                this.Text = button_text + " Employee";
            }
            remarks_Textbox.Text = remarks;

            remove_Btn.Click += remove_Btn_Click;
            cancel_Btn.Click += cancel_Btn_Click;
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

            if (remove_Btn.Text == "Restore")
            {
                string query = string.Format(Database_Query.alter_items_status, id, 1, remarks, CurrentUser.user_name);
                inventory_Manager.Archive_Employee_Status(query, id, "Item", true, changes, 1);
            }
            else
            {
                string query = string.Format(Database_Query.alter_items_status, id, 0, remarks, CurrentUser.user_name);
                inventory_Manager.Archive_Employee_Status(query, id, "Item", true, changes, 0);
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
