using COA_IMS.Screens.scrn;
using COA_IMS.Screens.Subscrn.EmployeeSubscreens;
using COA_IMS.Screens.Subscrn.InventorySubscreens;
using COA_IMS.UserControlUtil;
using COA_IMS.UserControlUtil.TableUtil;
using Guna.UI.WinForms;
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
    public partial class InventoryTable : Form
    {
        GenericTable generic_Table;
        readonly string[] log_table_names = { "All", "Item Code", "Item Description", "Unit" };
        public InventoryTable()
        {
            InitializeComponent();
            //setup GenericTable
            foreach (var name in log_table_names)
                sortComboBox.Items.Add(name);
            generic_Table = new GenericTable();
            generic_Table.FillVariables(log_table_names, null, null, "item", "item", searchBar1, null, sortComboBox, data_View, next_Button, previous_Button, pageCountTextbox);
            //setup ordinary controls
            sortComboBox.SelectedText = "All";
            sortComboBox.SelectedIndex = 0;
            generic_Table.sort_String = log_table_names[sortComboBox.SelectedIndex];
            generic_Table.Populate_Table(1);
            //setup user controls
            searchBar1.Ambatu(RePopulate_Table);
            //disables next logs button
            generic_Table.Check_Count();

            data_View.CellDoubleClick += data_View_CellDoubleClick;
        }
        private void add_item_Click(object sender, EventArgs e)
        {
            IMS_Product_Form prodform = new IMS_Product_Form();
            prodform.ShowDialog();
            generic_Table.Populate_Table();
            generic_Table.Check_Count();
        }
        private void RePopulate_Table(object sender, EventArgs e)
        {
            generic_Table.Populate_Table();
            generic_Table.Check_Count();
            generic_Table.ResetPaging();
        }
        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            generic_Table.sort_String = log_table_names[sortComboBox.SelectedIndex];
            generic_Table.Populate_Table();
            generic_Table.Check_Count();
        }

        private void previous_Button_Click(object sender, EventArgs e)
        {
            generic_Table.UserChangePage(false);
        }
        private void next_Button_Click(object sender, EventArgs e)
        {
            generic_Table.UserChangePage(true);
        }

        private void pageCountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                generic_Table.UserChangePageCountInput();
            }
        }
        private void data_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
                return;
            string arg_code = data_View.Rows[e.RowIndex].Cells[1].Value.ToString();
            string arg_desc = data_View.Rows[e.RowIndex].Cells[2].Value.ToString();
            string arg_unit = data_View.Rows[e.RowIndex].Cells[3].Value.ToString();
            string arg_cost = data_View.Rows[e.RowIndex].Cells[4].Value.ToString();
            string arg_life = data_View.Rows[e.RowIndex].Cells[5].Value.ToString();
            string arg_qty = data_View.Rows[e.RowIndex].Cells[6].Value.ToString();
            //MessageBox.Show(arg.ToString());
            ItemInfo itemInfo = new ItemInfo();
            itemInfo.item_Code_Textbox.Text = arg_code;
            itemInfo.item_Desc_Textbox.Text = arg_desc; 
            itemInfo.unit_Type_CBox.Text = arg_unit;
            itemInfo.unit_Cost_Textbox.Text = arg_cost;
            itemInfo.quantity_Textbox.Text = arg_qty;
            itemInfo.ShowDialog();
            generic_Table.Populate_Table();
            generic_Table.Check_Count();
        }

    }
}
