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

namespace COA_IMS.Screens.Subscrn.LogsSubscreens
{
    public partial class UnitForm : Form
    {
        Inventory_Manager inventory_Manager = new Inventory_Manager();
        public UnitForm()
        {
            InitializeComponent();
        }
        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            add_Category_TextBox.Clear();
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            inventory_Manager.Insert_Item_Category_Name(Database_Query.insert_item_unit, add_Category_TextBox.Text, "Unit", "item_unit");
        }

        private void textbox_Enter(object sender, EventArgs e)
        {
            if (string.Equals(add_Category_TextBox.Text.ToString(), "Unit Name"))
            {
                add_Category_TextBox.ForeColor = Color.Black;
                add_Category_TextBox.Text = "";
            }
        }


        private void textbox_Leave(object sender, EventArgs e)
        {
            if (string.Equals(add_Category_TextBox.Text.ToString().Trim(), ""))
            {
                add_Category_TextBox.ForeColor = Color.LightGray;
                add_Category_TextBox.Text = "Unit Name";
            }
        }
    }
}
