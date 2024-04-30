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
using MySqlX.XDevAPI.Common;

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
            string this_ItemCode, this_ItemBrand, this_estLife, this_unitType, this_unitCost, this_Quantity, this_Supplier, this_Product_Name, this_ItemType;
            int est_life = 0, quantity = 0, result_int;
            object b;
            float cost = 0, result_fl;
            this_ItemCode = item_Code_Textbox.Text;
            this_ItemType = item_Type_CBox.Text;
            this_ItemBrand = item_Brand_CBox.Text;
            this_estLife = est_Life_Textbox.Text;
            this_unitType = unit_Type_CBox.Text;
            this_unitCost = unit_Cost_Textbox.Text;
            this_Quantity = quantity_Textbox.Text;
            this_Supplier = supplier_CBox.Text;
            this_Product_Name = product_Name_TextBox.Text;

            b = this_estLife;
            //checks to see if user input is a number
            if (int.TryParse(b.ToString(), out result_int))
            {
                est_life = result_int;
            }
            b = this_Quantity;
            //checks to see if user input is a number
            if (int.TryParse(b.ToString(), out result_int))
            {
                quantity = result_int;
            }
            b = this_unitCost;
            //checks to see if user input is a number
            if (float.TryParse(b.ToString(), out result_fl))
            {
                cost = result_fl;
            }

            Console.WriteLine(this_ItemCode);
            Console.WriteLine(this_ItemType);
            Console.WriteLine(this_ItemBrand);
            Console.WriteLine(est_life);
            Console.WriteLine(this_unitType);
            Console.WriteLine(cost);
            Console.WriteLine(quantity);
            Console.WriteLine(this_Supplier);
            Console.WriteLine(this_Product_Name);
            inventory_Manager.Insert_Item_Description(this_Product_Name, this_ItemBrand, this_ItemType, this_Supplier, this_ItemCode, cost, est_life, quantity, this_unitType);
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
            foreach (var items in inventory_Manager.Display_List_To_Combobox(Database_Query.select_item_supplier_list, "supplier_name"))
                supplier_CBox.Items.Add(items);
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
