using COA_IMS.Screens.Subscrn.EmployeeSubscreens;
using COA_IMS.Screens.Subscrn.Tracking;
using COA_IMS.UserControlUtil.TableUtil;
using COA_IMS.Utilities;
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
        string table_type;
        public TableSelectorForm(string table_type = null, TextBox gunaTextBox = null, ComboBox comboBox = null, GunaDataGridView gunaDataGridView = null)
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

            else if (table_type == "employee" || table_type == "entity")
                comboBox.Text = arg;

            else if (table_type == "item")
            {
                DataTable dt;
                dt = gunaDataGridView.DataSource as DataTable;
                DataColumnCollection columns = dt.Columns;
                Util util = new Util();
                Inventory_Manager inventory_Manager = new Inventory_Manager();
                DebugTable(dt);

                if (columns.Contains("index"))
                {
                    dt.Columns.RemoveAt(0);
                    DebugTable(dt);
                }
                if (!columns.Contains("SN"))
                {
                    dt.Columns.Add(new DataColumn("SN"));
                }
                DebugTable(dt);
                AddSerialNumberForm form = new AddSerialNumberForm();
                form.ShowDialog();
                DataRow newRow = inventory_Manager.Get_Item_Record(arg).Rows[0];
                //newRow.Columns.Add(new DataColumn("SN"));
                
                newRow["SN"] = form.sn;
                //if(!DuplicateSerialNumber(form.sn, dt))
                dt.Rows.Add(newRow.ItemArray);
                //foreach (DataRow dataRow in dt.Rows)
                //    dataRow["SN"] = form.sn;
                DebugTable(dt);
                gunaDataGridView.DataSource = dt;
                generic_Table.AddThemeToDGV(gunaDataGridView, "items");
            }

            this.Close();
        }

        private bool DuplicateSerialNumber(string sn, DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row["SN"] == sn)
                {
                    MessageBox.Show("Duplicate Serial Number.");
                    DuplicateSerialNumber(sn, dt);
                }
                else
                {
                    return false;
                }
            }
            return false;
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
