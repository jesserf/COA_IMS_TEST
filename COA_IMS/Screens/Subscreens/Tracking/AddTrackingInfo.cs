using COA_IMS.Utilities;
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

namespace COA_IMS.Screens.Subscrn.Tracking
{
    public partial class AddTrackingInfo : Form
    {
        TrackingDTO trackDTO;
        TextBox trackingTextBox;
        ComboBox trackingComboBox;
        Inventory_Manager inventory_Manager = new Inventory_Manager();
        public AddTrackingInfo(TrackingDTO trackDTO)
        {
            InitializeComponent();
            this.trackDTO = trackDTO;
            Add_ICS_Number();
        }

        private void next_Btn_Click(object sender, EventArgs e)
        {

        }
        #region Controls
        private void Add_ICS_Number()
        {
            string ics_Num = "ICS-";
            ics_Num += DateTime.Now.ToString("yyyy-MM-ddHHmmssfff");
            ics_Textbox.Text = ics_Num;
            trackDTO.ics_number = ics_Num;
        }
        private void Enable_Next_Btn(bool enable)
        {
            if (enable)
            {
                //next_Btn.Enabled = true;
            }
            else
            {
                //next_Btn.Enabled = false;
            }
        }
        private bool Check_Text_Boxes_Comboboxes()
        {
            foreach(Control control in content_Panel.Controls)
            {
                if (control is TextBox gTextBox)
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
            TableSelectorForm tableSelectorForm = new TableSelectorForm(GetDataTableType(((GunaButton)sender).Name), trackingTextBox, trackingComboBox, null, trackDTO);
            tableSelectorForm.ShowDialog();

            //if (tableSelectorForm.off != null)
            //{
                trackDTO.emp_office = tableSelectorForm.off;
                trackDTO.emp_position = tableSelectorForm.pos;
            //}

            trackDTO.entity_name = entity_Name_Textbox.Text;
            trackDTO.fund_cluster = fund_Cluster_Textbox.Text;
            trackDTO.received_by = received_By_Combobox.Text;
            trackDTO.received_from = received_From_Combobox.Text;


            Enable_Next_Btn(Check_Text_Boxes_Comboboxes());
        }

        private void GetAllValues()
        {
            List<string> values = new List<string>();
            foreach (Control control in content_Panel.Controls)
            {
                if (control is TextBox gTextBox)
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
                    trackingTextBox = null;
                    trackingComboBox = entity_Name_Textbox;
                    return "entity";
                case "add_Funds_Btn":
                    trackingComboBox = null;
                    trackingTextBox = fund_Cluster_Textbox;
                    return "fund";
                case "add_Received_Btn":
                    trackingTextBox = null;
                    trackingComboBox = received_By_Combobox;
                    return "employee";
                case "add_Giver_Btn":
                    trackingTextBox = null;
                    trackingComboBox = received_From_Combobox;
                    return "employee";
                default: break;
            }
            return "none";
        }

        private void received_By_Combobox_TextChanged(object sender, EventArgs e)
        {
            if(received_By_Combobox.Text == received_From_Combobox.Text)
            {
                received_From_Combobox.Text = "";
            }
            trackDTO.received_by_id = inventory_Manager.Get_Employee_ID(received_By_Combobox.Text, trackDTO.emp_position, trackDTO.emp_office);
        }

        private void received_From_Combobox_TextChanged(object sender, EventArgs e)
        {
            if (received_From_Combobox.Text == received_By_Combobox.Text)
            {
                received_By_Combobox.Text = "";
            }
            trackDTO.received_from_id = inventory_Manager.Get_Employee_ID(received_From_Combobox.Text, trackDTO.emp_position, trackDTO.emp_office);
        }

        private void entity_Name_Textbox_TextChanged(object sender, EventArgs e)
        {
            trackDTO.entity_id = inventory_Manager.Get_Entity_ID(entity_Name_Textbox.Text);
        }

        private void entity_Name_Textbox_TextUpdate(object sender, EventArgs e)
        {
            trackDTO.entity_id = inventory_Manager.Get_Entity_ID(entity_Name_Textbox.Text);
            MessageBox.Show(trackDTO.entity_id.ToString());
        }

        private void received_By_Combobox_TextUpdate(object sender, EventArgs e)
        {
            //trackDTO.received_by_id = inventory_Manager.Get_Employee_ID(received_By_Combobox.Text, trackDTO.emp_position, trackDTO.emp_office);
        }

        private void received_From_Combobox_TextUpdate(object sender, EventArgs e)
        {
            //trackDTO.received_from_id = inventory_Manager.Get_Employee_ID(received_From_Combobox.Text, trackDTO.emp_position, trackDTO.emp_office);
        }
    }
}
