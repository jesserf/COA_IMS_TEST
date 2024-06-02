using COA_IMS.Screens.Subscrn.EmployeeSubscreens;
using COA_IMS.Screens.Subscrn.Tracking;
using COA_IMS.UserControlUtil.TableUtil;
using COA_IMS.Utilities;
using Google.Protobuf.WellKnownTypes;
using Guna.UI.WinForms;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        GunaDataGridView gunaDataGridView;
        TrackingDTO trackDTO;
        string table_type;
        public string pos { get; set; }
        public string off { get; set; }
        public TableSelectorForm(string table_type = null, TextBox gunaTextBox = null, ComboBox comboBox = null, GunaDataGridView gunaDataGridView = null, TrackingDTO trackDTO = null)
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
            this.table_type = table_type;
            this.comboBox = comboBox;
            this.gunaTextBox = gunaTextBox;
            this.gunaDataGridView = gunaDataGridView;
            if(trackDTO != null)
                this.trackDTO = trackDTO;
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
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                return;
            }
            string arg = data_View.Rows[e.RowIndex].Cells[1].Value.ToString();
            if(table_type == "fund")
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

            else if (table_type == "entity")
                comboBox.Text = arg;

            else if (table_type == "employee")
            {
                pos = data_View.Rows[e.RowIndex].Cells[2].Value.ToString();
                off = data_View.Rows[e.RowIndex].Cells[3].Value.ToString();
                trackDTO.emp_position = data_View.Rows[e.RowIndex].Cells[2].Value.ToString();
                trackDTO.emp_office = data_View.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBox.Text = arg;
            }

            //if table selector is for items
            else if (table_type == "item")
            {
                Inventory_Manager inventory_Manager = new Inventory_Manager();
                DataTable dt;
                //get datatable based on the current data grid view
                dt = gunaDataGridView.DataSource as DataTable;
                //get index
                int dtRows = dt.Rows.Count + 1;

                //DataColumnCollection columns = dt.Columns;
                //Util util = new Util();
                //DebugTable(dt);

                //if (columns.Contains("index"))
                //{
                //    dt.Columns.RemoveAt(0);
                //    DebugTable(dt);
                //}
                //if (!columns.Contains("SN"))
                //{
                //    dt.Columns.Add(new DataColumn("SN"));
                //}
                //if (!columns.Contains("Qty."))
                //{
                //    dt.Columns.Add(new DataColumn("Qty."));
                //}
                //DebugTable(dt);

                //get the quantity for a the chosen item
                int item_quantity = inventory_Manager.Get_Item_Quantity(arg);


                //count quantity
                Dictionary<string, int> itemQuantities = new Dictionary<string, int>();

                // Populate dictionary from DataTable
                foreach (DataRow row in dt.Rows)
                {
                    string itemCode = row["item_code"].ToString();
                    int quantity = (int)row["quantity"];

                    if (itemQuantities.ContainsKey(itemCode))
                    {
                        itemQuantities[itemCode] += quantity; // Add to existing quantity
                    }
                    else
                    {
                        itemQuantities[itemCode] = quantity; // Add new item code
                    }
                }
                //checks if item count is empty and returns it
                if(itemQuantities.ContainsKey(arg))
                    if ((item_quantity - itemQuantities[arg]) == 0)
                    {
                        MessageBox.Show("Empty");
                        return;
                    }

                //gets serial number for a specific item
                AddSerialNumberForm sn_form = new AddSerialNumberForm();
                sn_form.ShowDialog();


                //gets the data of an item
                DataRow newRow = inventory_Manager.Get_Item_Record(arg).Rows[0];

                //foreach (DataColumn column in newRow.Table.Columns)
                //{
                //    // Print the column name and value
                //    Console.WriteLine($"{column.ColumnName}: {newRow[column]}");
                //}


                //newRow.Columns.Add(new DataColumn("SN"));

                //puts the serial number from the form to item data
                newRow["SN"] = sn_form.sn;
                //defaults the quantity to 1
                newRow["Qty."] = "1";

                if (string.IsNullOrEmpty(newRow["SN"].ToString()) || newRow["SN"].ToString().ToLower() == "none")
                {
                    // Handle the case where the string is null, empty, or "none"
                    int quantity_on_table = 0;
                    if (itemQuantities.ContainsKey(arg))
                        quantity_on_table = itemQuantities[arg];
                    AddItemQuantity qty_form = new AddItemQuantity(item_quantity - quantity_on_table);
                    qty_form.ShowDialog();
                    newRow["Qty."] = qty_form.qty;
                }


                //newRow["Total Price"] = qty_form.qty * Convert.ToDouble(newRow["unit_cost"]);
                newRow["Total Price"] = Convert.ToInt32(newRow["Qty."]) * Convert.ToDouble(newRow["unit_cost"]);

                //concatenates the item data to the index of the item
                object[] rowData = new object[] { dtRows }.Concat(newRow.ItemArray).ToArray();
                //adds the new data to the data table
                dt.Rows.Add(rowData);

                //if(!DuplicateSerialNumber(form.sn, dt))
                //foreach (DataRow dataRow in dt.Rows)
                //    dataRow["SN"] = form.sn;
                DebugTable(dt);
                //gunaDataGridView.DataSource = dt;
                //generic_Table.AddThemeToDGV(gunaDataGridView, "items");
            }

            this.Close();
        }


        public void DebugTable(DataTable table)
        {
            Debug.WriteLine("--- DebugTable(" + table.TableName + ") ---");
            int zeilen = table.Rows.Count;
            int spalten = table.Columns.Count;

            // Header
            for (int i = 0; i < table.Columns.Count; i++)
            {
                string s = table.Columns[i].ToString();
                Debug.Write(String.Format("{0,-20} | ", s));
            }
            Debug.Write(Environment.NewLine);
            for (int i = 0; i < table.Columns.Count; i++)
            {
                Debug.Write("---------------------|-");
            }
            Debug.Write(Environment.NewLine);

            // Data
            for (int i = 0; i < zeilen; i++)
            {
                DataRow row = table.Rows[i];
                //Debug.WriteLine("{0} {1} ", row[0], row[1]);
                for (int j = 0; j < spalten; j++)
                {
                    string s = row[j].ToString();
                    if (s.Length > 20) s = s.Substring(0, 17) + "...";
                    Debug.Write(String.Format("{0,-20} | ", s));
                }
                Debug.Write(Environment.NewLine);
            }
            for (int i = 0; i < table.Columns.Count; i++)
            {
                Debug.Write("---------------------|-");
            }
            Debug.Write(Environment.NewLine);
        }
    }
}
