using COA_IMS.Utilities;
using Guna.UI.WinForms;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace COA_IMS.Screens.Subscrn.Tracking
{
    public partial class ICSInfoForm : Form
    {
        string ics, sn;
        Inventory_Manager inventory_Manager = new Inventory_Manager();
        ICS_Info_Return_SubForm ics_Return_Form;
        public ICSInfoForm(string ics, string sn)
        {
            InitializeComponent();
            //takes information from a cell in table and puts it in variables
            this.ics = ics;
            this.sn = sn;
            ics_Number_Lbl.Text = ics;
            //ActiveControl = email_Textbox;
            //populates the comboboxes and the textboxes as well
            Populate_ComboBoxes();
        }
        private void save_Button_Click(object sender, EventArgs e)
        {
            //checks if every contact information is empty
            if (string.IsNullOrEmpty(item_Desc_Textbox.Text) && string.IsNullOrEmpty(sn_Textbox.Text) && string.IsNullOrEmpty(quantity_Textbox.Text))
            {
                foreach (Control tbox in tableLayoutPanel1.Controls)
                {
                    if (tbox is GunaTextBox gTBox)
                    {
                        if (string.IsNullOrEmpty(gTBox.Text))
                        {
                            gTBox.BorderColor = Color.IndianRed;
                        }
                    }
                }
                return;
            }

        }

        private void remove_Btn_Click(object sender, EventArgs e)
        {
            ics_Return_Form = new ICS_Info_Return_SubForm(ics, sn);
            ics_Return_Form.ShowDialog();
        }

        private void return_Btn_Click(object sender, EventArgs e)
        {
        }

        private void Populate_ComboBoxes()
        {
            string query = string.Format(Database_Query.get_ics_record, ics, sn);
            string[] employee_Details = { "receiver", "employee_position", "employee_office", "giver", "item_desc", "serial_number", "quantity", "unit_cost", "total_price", "fund_cluster", "transfer_date" };
            List<string> list_of_items = inventory_Manager.Display_List_To_Combobox(query, employee_Details);
            string[] employee_details = list_of_items.ToArray();
            employee_Name_Textbox.Text = employee_details[0];
            position_Textbox.Text = employee_details[1];
            office_Textbox.Text = employee_details[2];
            giver_Textbox.Text = employee_details[3];
            item_Desc_Textbox.Text = employee_details[4];
            sn_Textbox.Text = employee_details[5];
            quantity_Textbox.Text = employee_details[6];
            unit_Cost_Textbox.Text = Theme.Number_To_Currency( Convert.ToDouble(employee_details[7]) );
            total_Textbox.Text = Theme.Number_To_Currency(Convert.ToDouble(employee_details[8]));
            fund_Cluster_Textbox.Text = employee_details[9];
            transfer_Date_Textbox.Text = employee_details[10];

        }
    }
}
