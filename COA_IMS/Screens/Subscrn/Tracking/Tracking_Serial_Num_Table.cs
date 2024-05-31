﻿using COA_IMS.Screens.Subscrn.EmployeeSubscreens;
using COA_IMS.UserControlUtil.TableUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscrn.Tracking
{
    public partial class Tracking_Serial_Num_Table : Form
    {
        GenericTable generic_Table;
        readonly string[] log_table_names = { "All", "Serial Number", "Item Code", "Item Description" , "Currently Held By", "Last Held By" };
        public Tracking_Serial_Num_Table()
        {
            InitializeComponent();
            //setup GenericTable
            //setup ordinary controls
            foreach (string name in log_table_names)
                sortComboBox.Items.Add(name);
            generic_Table = new GenericTable();
            generic_Table.FillVariables(log_table_names, null, null, "sn_item", "sn_item", searchBar1, null, sortComboBox, data_View, next_Button, previous_Button, pageCountTextbox);
            generic_Table.sort_String = "All";
            sortComboBox.SelectedText = "All";
            sortComboBox.SelectedIndex = 0;
            generic_Table.Populate_Table(1);
            //setup user controls
            searchBar1.Ambatu(RePopulate_Table);
            //disables next logs button
            generic_Table.Check_Count();

            next_Button.Click += next_Button_Click;
            previous_Button.Click += previous_Button_Click;
            pageCountTextbox.KeyDown += pageCountTextbox_KeyDown;
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            data_View.CellDoubleClick += data_View_CellDoubleClick;
            refresh_Button.Click += RePopulate_Table;
            this.VisibleChanged += RePopulate_Table;
        }
        private void RePopulate_Table(object sender, EventArgs e)
        {
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

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            generic_Table.sort_String = log_table_names[sortComboBox.SelectedIndex];
            generic_Table.Populate_Table();
            generic_Table.Check_Count();
        }

        private void data_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
                return;
            string arg_sn = data_View.Rows[e.RowIndex].Cells[1].Value.ToString();
            string arg_item_desc = data_View.Rows[e.RowIndex].Cells[3].Value.ToString();
            SNHistorySubform snHistorySubform = new SNHistorySubform(arg_item_desc, arg_sn);
            snHistorySubform.ShowDialog();
            generic_Table.Populate_Table();
            generic_Table.Check_Count();
        }
    }
}
