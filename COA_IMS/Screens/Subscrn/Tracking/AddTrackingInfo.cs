﻿using Guna.UI.WinForms;
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
    public partial class AddTrackingInfo : Form
    {
        GunaTextBox trackingTextBox;
        ComboBox trackingComboBox;
        public AddTrackingInfo()
        {
            InitializeComponent();
            Add_ICS_Number();
        }

        private void next_Btn_Click(object sender, EventArgs e)
        {

        }
        #region Controls
        private void Add_ICS_Number()
        {
            string ics_Num = "ICS-";
            ics_Num += DateTime.Now.ToString("yyyy-MM-HHmmdd");
            ics_Textbox.Text = ics_Num;
        }
        private void Enable_Next_Btn(bool enable)
        {
            if (enable)
            {
                next_Btn.Enabled = true;
            }
            else
            {
                next_Btn.Enabled = false;
            }
        }
        private bool Check_Text_Boxes_Comboboxes()
        {
            foreach(Control control in content_Panel.Controls)
            {
                if (control is GunaTextBox gTextBox)
                    if (string.IsNullOrEmpty(gTextBox.Text.Trim()))
                        return false;
                if(control is ComboBox comboBox)
                    if(string.IsNullOrEmpty(comboBox.Text.Trim())) 
                        return false;
            }
            return true;
        }
        private void text_TextUpdate(object sender, EventArgs e)
        {
            Enable_Next_Btn(Check_Text_Boxes_Comboboxes());
        }

        #endregion

        private void add_Btn_Click(object sender, EventArgs e)
        {
            TableSelectorForm tableSelectorForm = new TableSelectorForm(GetDataTableType(((GunaButton)sender).Name), trackingTextBox, trackingComboBox);
            tableSelectorForm.ShowDialog();
            string xd = ((GunaButton)sender).Name;
        }

        private void next_Btn_Click_1(object sender, EventArgs e)
        {
            GetAllValues();
            AddTrackingItems addTrackingItems = new AddTrackingItems();
            this.Hide();
            addTrackingItems.Show();
        }

        private void GetAllValues()
        {
            List<string> values = new List<string>();
            foreach (Control control in content_Panel.Controls)
            {
                if (control is GunaTextBox gTextBox)
                {
                    values.Add(gTextBox.Text.Trim());
                }
                else if (control is ComboBox comboBox)
                {
                    values.Add(comboBox.Text.Trim());
                }
            }
            foreach (string  value in values)
            {
                Console.WriteLine(value);
            }
        }

        private string GetDataTableType(string buttonName)
        {
            switch(buttonName)
            {
                case "add_Entity_Btn":
                    trackingComboBox = entity_Name_Textbox;
                    return "entity";
                case "add_Funds_Btn":
                    trackingTextBox = gunaTextBox2;
                    return "fund";
                case "add_Received_Btn":
                    trackingComboBox = received_By_Combobox;
                    return "employee";
                case "add_Giver_Btn":
                    trackingComboBox = received_From_Combobox;
                    return "employee";
                default: break;
            }
            return "none";
        }
    }
}
