﻿using COA_IMS.UserControlUtil.TableUtil;
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
    public partial class SNHistorySubform : Form
    {
        GenericTable generic_Table;
        public SNHistorySubform(string item_desc, string item_sn)
        {
            InitializeComponent();
            generic_Table = new GenericTable();
            generic_Table.FillVariables(null, null, null, "spec_sn", "spec_sn", searchBar1, null, null, data_View, next_Button, previous_Button, pageCountTextbox);
            label1.Text = item_desc + " SN: " + item_sn;
            generic_Table.specific_sn_item = item_sn;
            generic_Table.Populate_Table(1);
            //setup user controls
            searchBar1.Ambatu(RePopulate_Table);
            //disables next logs button
            generic_Table.Check_Count();

            next_Button.Click += next_Button_Click;
            previous_Button.Click += previous_Button_Click;
            pageCountTextbox.KeyDown += pageCountTextbox_KeyDown;
            refresh_Button.Click += RePopulate_Table;
            close_Btn.Click += close_Btn_Click;
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

        private void close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
