using COA_IMS.UserControlUtil.TableUtil;
using System;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscrn
{
    public partial class IMS_SuplierTable : Form
    {
        GenericTable generic_Table;
        readonly string[] log_table_names = { "All", "Supplier Name", "Address", "Contact Num", "Contact Person" };
        public IMS_SuplierTable()
        {
            InitializeComponent();
            //setup GenericTable
            foreach (var name in log_table_names)
                sortComboBox.Items.Add(name);
            generic_Table = new GenericTable();
            generic_Table.FillVariables(log_table_names, null, null, "item_supplier", "item_supplier", searchBar1, null, sortComboBox, data_View, next_Button, previous_Button, pageCountTextbox);
            //setup ordinary controls
            generic_Table.sort_String = "All";
            sortComboBox.SelectedIndex = 0;
            generic_Table.Populate_Table(1);
            //setup user controls
            searchBar1.Ambatu(RePopulate_Table);
            //disables next logs button
            generic_Table.Check_Count();
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            Add_SupplierForm supform = new Add_SupplierForm();
            supform.ShowDialog();
            refresh_Button.PerformClick();
        }
        private void RePopulate_Table(object sender, EventArgs e)
        {
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

        private void pageCountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                generic_Table.UserChangePageCountInput();
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            generic_Table.sort_String = log_table_names[sortComboBox.SelectedIndex];
            generic_Table.Populate_Table();
        }
    }
}
