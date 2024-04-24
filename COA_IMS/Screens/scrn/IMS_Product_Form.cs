using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COA_IMS.Utilities;
using Guna.UI.WinForms;

namespace COA_IMS.Screens.scrn
{
    public partial class IMS_Product_Form : Form
    {
        Inventory_Manager inventory_Manager = new Inventory_Manager();
        public IMS_Product_Form()
        {
            InitializeComponent();
            ActiveControl = item_Code_Textbox;
            Populate_ComboBoxes();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            string this_ItemCode, this_ItemBrand, this_estLife, this_unitType, this_unitCost, this_Quantity, this_Supplier;
            this_ItemCode = item_Code_Textbox.Text;
            this_ItemBrand = item_Code_Textbox.Text;
            this_estLife = item_Code_Textbox.Text;
            this_unitType = item_Code_Textbox.Text;
            this_unitCost = item_Code_Textbox.Text;
            this_Quantity = item_Code_Textbox.Text;
            this_Supplier = supplier_CBox.Text;
            Console.WriteLine(item_Type_CBox.Text);
            Console.WriteLine(item_Brand_CBox.Text);
            Console.WriteLine(est_Life_Textbox.Text);
            Console.WriteLine(unit_Type_CBox.Text);
            Console.WriteLine(unit_Cost_Textbox.Text);
            Console.WriteLine(quantity_Textbox.Text);
            clear_Textboxes();
        }

        private void IMS_Product_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Populate_ComboBoxes()
        {
            //fills different values inside comboboxes
            foreach (var items in inventory_Manager.Display_List_To_Combobox(Database_Query.select_item_list, "item_brand"))
                item_Brand_CBox.Items.Add(items);
            foreach (var items in inventory_Manager.Display_List_To_Combobox(Database_Query.select_item_list, "item_type"))
                item_Type_CBox.Items.Add(items);
            foreach (var items in inventory_Manager.Display_List_To_Combobox(Database_Query.select_item_units, "unit"))
                unit_Type_CBox.Items.Add(items);
        }
        private void clear_Textboxes()
        {
            //clear text inside GunaTextBox and ComboBox
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is GunaTextBox)
                    control.Controls.Clear();
                else if (control is ComboBox)
                    control.ResetText();
            }
        }

    }
}
