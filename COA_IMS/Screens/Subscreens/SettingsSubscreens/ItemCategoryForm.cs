using COA_IMS.Screens.scrn;
using COA_IMS.UserControlUtil.TableUtil;
using COA_IMS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections;
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
    
    public partial class ItemCategoryForm : Form
    {
        GenericTable generic_Table;
        readonly string[] log_table_names = { "item_type", "item_brand", "unit", "fund" };
        readonly string[] item_table_names = { "item_type", "item_brand", "item_unit", "fund" };
        readonly string[] combobox_name = { "Item Types", "Item Brands", "Units", "Fund Names" };
        Inventory_Manager inventory_Manager = new Inventory_Manager();
        public ItemCategoryForm()
        {
            InitializeComponent();
            //setup GenericTable
            generic_Table = new GenericTable();
            generic_Table.FillVariables(log_table_names, null, null, "item_type", "item_type", searchBar1, null, sortComboBox, data_View, next_Button, previous_Button, pageCountTextbox);
            //setup ordinary controls
            sortComboBox.DataSource = combobox_name;
            sortComboBox.SelectedIndex = 0;
            generic_Table.Populate_Table(1);
            //setup user controls
            searchBar1.Ambatu(RePopulate_Table);
            //disables next logs button
            generic_Table.Check_Count();
        }
        private void add_item_Click(object sender, EventArgs e)
        {
            IMS_Product_Form prodform = new IMS_Product_Form();
            prodform.ShowDialog();
            refresh_Button.PerformClick();
        }
        private void RePopulate_Table(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
            generic_Table.Populate_Table();
            category_Name_TextBox.Text = $"{combobox_name[sortComboBox.SelectedIndex]} Name";
        }
        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            generic_Table.inventory_Table_Name = item_table_names[sortComboBox.SelectedIndex].ToString();
            generic_Table.data_Table_Type = log_table_names[sortComboBox.SelectedIndex].ToString();
            add_New_Label.Text = $"ADD NEW {combobox_name[sortComboBox.SelectedIndex].ToUpper()}";
            category_Label.Text = combobox_name[sortComboBox.SelectedIndex].ToUpper();
            category_Name_TextBox.Text = $"{combobox_name[sortComboBox.SelectedIndex]} Name";
            generic_Table.Populate_Table();
        }

        private void previous_Button_Click(object sender, EventArgs e)
        {
            generic_Table.UserChangePage(false);
        }
        private void next_Button_Click(object sender, EventArgs e)
        {
            generic_Table.UserChangePage(true);
        }

        private void add_Category_Button_Click(object sender, EventArgs e)
        {
            switch (combobox_name[sortComboBox.SelectedIndex])
            {
                case "Item Types":
                    inventory_Manager.Insert_Item_Category_Name(Database_Query.insert_item_type, category_Name_TextBox.Text, item_table_names[sortComboBox.SelectedIndex], combobox_name[sortComboBox.SelectedIndex]);
                    break;
                case "Item Brands":
                    inventory_Manager.Insert_Item_Category_Name(Database_Query.insert_item_brand, category_Name_TextBox.Text, item_table_names[sortComboBox.SelectedIndex], combobox_name[sortComboBox.SelectedIndex]);
                    break;
                case "Units":
                    inventory_Manager.Insert_Item_Category_Name(Database_Query.insert_item_unit, category_Name_TextBox.Text, item_table_names[sortComboBox.SelectedIndex], combobox_name[sortComboBox.SelectedIndex]);
                    break ;
                case "Fund Names":
                    inventory_Manager.Insert_Fund_Name(category_Name_TextBox.Text, combobox_name[sortComboBox.SelectedIndex]);
                    break;
                default: break;
            }
            
            category_Name_TextBox.Clear();
            refresh_Button.PerformClick();
        }
        #region Textbox Placeholder and Press Enter to Save
        private void textbox_Enter(object sender, EventArgs e)
        {
            if (string.Equals(category_Name_TextBox.Text.ToString(), $"{combobox_name[sortComboBox.SelectedIndex]} Name"))
            {
                category_Name_TextBox.ForeColor = Color.Black;
                category_Name_TextBox.Text = "";
            }
        }
        private void textbox_Leave(object sender, EventArgs e)
        {
            if (string.Equals(category_Name_TextBox.Text.ToString(), ""))
            {
                category_Name_TextBox.ForeColor = Color.LightGray;
                category_Name_TextBox.Text = $"{combobox_name[sortComboBox.SelectedIndex]} Name";
            }
        }
        private void textBox_PressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                add_Category_Button.PerformClick();
            }
        }
        #endregion
    }
}
