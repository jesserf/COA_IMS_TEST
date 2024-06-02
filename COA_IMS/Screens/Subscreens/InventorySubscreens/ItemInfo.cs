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
    public partial class ItemInfo : Form
    {
        private string default_quantity, default_price, log_changes, update_query;
        Inventory_Manager inventory_Manager;
        public ItemInfo()
        {
            InitializeComponent();
        }

        private void remove_Btn_Click(object sender, EventArgs e)
        {
            RemoveItemSubform removeForm = new RemoveItemSubform(item_Code_Textbox.Text, this);
            removeForm.ShowDialog();
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            inventory_Manager = new Inventory_Manager();
            string query = string.Format(Database_Query.update_item, item_Code_Textbox.Text, update_query, CurrentUser.user_name);

            inventory_Manager.Update_Employee_Record(query, item_Code_Textbox.Text, "Item", true, log_changes);
            //MessageBox.Show(query + "\n" + log_changes);
        }

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            default_quantity = quantity_Textbox.Text;
            default_price = unit_Cost_Textbox.Text;
        }

        private bool CheckTextUpdate()
        {
            string q = "", p = "", q2 = "", p2 = "";

            if (default_quantity != quantity_Textbox.Text || default_price != unit_Cost_Textbox.Text)
            {
                if (default_quantity != quantity_Textbox.Text)
                {
                    q = $" quantity = {quantity_Textbox.Text}";
                    q2 = $"Item Code: {item_Code_Textbox.Text} quantity changed from {default_quantity} to {quantity_Textbox.Text},";
                }
                if (default_price != unit_Cost_Textbox.Text)
                {
                    p = $"unit_cost = {unit_Cost_Textbox.Text}";
                    p2 = $"Item Code: {item_Code_Textbox.Text} price changed from {default_price} to {unit_Cost_Textbox.Text}";
                }
                update_query = q + ", " + p;
                log_changes = q2 + ", " + p2;
                return true;
            }
            
            return false;
        }

        private void unit_Cost_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (CheckTextUpdate()) save_Button.Enabled = true; else save_Button.Enabled = false;
        }

        private void quantity_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (CheckTextUpdate()) save_Button.Enabled = true; else save_Button.Enabled = false;
        }
    }
}
