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

namespace COA_IMS.Screens.Subscrn
{
    public partial class Add_SupplierForm : Form
    {
        Inventory_Manager inventory_Manager = new Inventory_Manager();

        public Add_SupplierForm()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SAVING");

            inventory_Manager.Insert_Item_Supplier(Database_Query.insert_item_supplier, supplier_Name_Textbox.Text, address_Textbox.Text, contact_Number_Textbox.Text, contact_Person_Textbox.Text);
            ClearAllFields();
            //supplier_info.Insert_Item_Supplier_Info(Database_Query.insert_item_type, gunaTextBox1.Text, gunaTextBox2.Text, gunaTextBox3.Text, gunaTextBox4.Text);
        }

        private void ClearAllFields()
        {
            supplier_Name_Textbox.Clear();
            address_Textbox.Clear();
            contact_Number_Textbox.Clear();
            contact_Person_Textbox.Clear();
        }
    }
}
