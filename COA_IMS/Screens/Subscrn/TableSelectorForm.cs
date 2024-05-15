using COA_IMS.Screens.Subscrn.EmployeeSubscreens;
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
    public partial class TableSelectorForm : Form
    {
        GenericTable generic_Table;
        TextBox gunaTextBox;
        ComboBox comboBox;
        public TableSelectorForm(string table_type = null, TextBox gunaTextBox = null, ComboBox comboBox = null)
        {
            InitializeComponent();
            generic_Table = new GenericTable();
            generic_Table.FillVariables(null, null, null, table_type, table_type, searchBar1, null, null, data_View, next_Button, previous_Button, pageCountTextbox);
            generic_Table.sort_String = "All";
            generic_Table.Populate_Table(1);
            //setup user controls
            searchBar1.Ambatu(RePopulate_Table);
            //disables next logs button
            generic_Table.Check_Count();

            this.comboBox = comboBox;
            this.gunaTextBox = gunaTextBox;
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

        private void data_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string arg = data_View.Rows[e.RowIndex].Cells[1].Value.ToString();
            if(gunaTextBox != null)
            {
                if(gunaTextBox.Text.Contains(arg + " - "))
                {
                    gunaTextBox.Text = gunaTextBox.Text.Replace(arg + " - ", "").Trim();
                    this.Close();
                    return;
                }
                else if (gunaTextBox.Text.Contains(" - " + arg))
                {
                    gunaTextBox.Text = gunaTextBox.Text.Replace(" - " + arg, "").Trim();
                    this.Close();
                    return;
                } else if (gunaTextBox.Text.Contains(arg))
                {
                    gunaTextBox.Text = gunaTextBox.Text.Replace(arg, "").Trim();
                    this.Close();
                    return;
                }
                if (string.IsNullOrEmpty(gunaTextBox.Text.Trim()))
                {
                    gunaTextBox.Text = arg;
                }
                else
                {
                    gunaTextBox.Text += " - " + arg.Trim();
                }
            }

            if (comboBox != null)
            {
                comboBox.Text = arg;
            }

            this.Close();
        }
    }
}
