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
    public partial class AddTrackingBaseForm : Form
    {
        private Tab_Manager tab_Manager = new Tab_Manager();
        private Form current_Form = null;
        TrackingDTO trackDTO = new TrackingDTO();
        AddTrackingInfo add_Tracking_Info;
        AddTrackingItems add_Tracking_Items;
        AddConfirmForm add_Confirm_Form;
        string active, next, back;
        public AddTrackingBaseForm()
        {
            InitializeComponent();
            add_Tracking_Info = new AddTrackingInfo(trackDTO);
            add_Tracking_Items = new AddTrackingItems(trackDTO);
            add_Confirm_Form = new AddConfirmForm(trackDTO);
            active = "item";
            next_Btn.PerformClick();
        }
        private void next_Button_Click(object sender, EventArgs e)
        {
            Form form = null;

            switch (active)
            {
                case "info":
                    form = add_Tracking_Info;
                    active = "item";
                    break;
                case "item":
                    form = add_Tracking_Items;
                    active = "save";
                    break;
                case "save":
                    GetValues();
                    active = "save";
                    break;
                default: break;
            }
            if (form != null)
            {
                current_Form = tab_Manager.switch_Form(form, current_Form, main_Panel);
            }
        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            Form form = null;

            switch (active)
            {
                case "info":
                    form = add_Tracking_Info;
                    active = "item";
                    break;
                case "item":
                    form = add_Tracking_Info;
                    active = "info";
                    break;
                case "save":
                    form = add_Tracking_Items;
                    active = "item";
                    break;
                default: break;
            }
            if (form != null)
            {
                current_Form = tab_Manager.switch_Form(form, current_Form, main_Panel);
            }
        }

        private void GetValues()
        {
            string ics_number = trackDTO.ics_number;
            string entity_name = trackDTO.entity_name;
            string fund_cluster = trackDTO.fund_cluster;
            string received_by = trackDTO.received_by;
            string received_from = trackDTO.received_from;
            DataTable items = trackDTO.items;
            int numberOfRecords = items.Select("item_code = '456'").Length;

            string[] array = { };
            var dict = new Dictionary<string, int>();

            

            foreach (DataRow dataRow in  items.Rows)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(dataRow[i].ToString());
                }
            }
            foreach (var value in array)
            {
                // When the key is not found, "count" will be initialized to 0
                dict.TryGetValue(value, out int count);
                dict[value] = count + 1;
            }

            string msg = $"ICS: {ics_number}\nEntity:{entity_name}\nFund: {fund_cluster}\nReceiver: {received_by} \nGiver: {received_from}\nNo.:{numberOfRecords}";
            MessageBox.Show(msg);
        }
    }
}
