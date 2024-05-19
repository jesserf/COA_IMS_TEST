using COA_IMS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections;
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
        Inventory_Manager inventory_Manager = new Inventory_Manager();
        string active, next, back;
        public AddTrackingBaseForm()
        {
            InitializeComponent();
            add_Tracking_Info = new AddTrackingInfo(trackDTO);
            add_Tracking_Items = new AddTrackingItems(trackDTO);
            add_Confirm_Form = new AddConfirmForm(trackDTO);
            next = "info";
            next_Btn.PerformClick();
        }
        private void next_Button_Click(object sender, EventArgs e)
        {
            Form form = null;

            switch (next)
            {
                case "info":
                    form = add_Tracking_Info;
                    active = "info";
                    next = "item";
                    back = "clear";
                    break;
                case "item":
                    form = add_Tracking_Items;
                    active = "item";
                    next = "save";
                    back = "info";
                    break;
                case "save":
                    form = add_Confirm_Form;
                    //GetValues();
                    active = "save";
                    next = "confirm";
                    back = "item";
                    break;
                case "confirm":
                    ConfirmDialog();
                    return;
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

            switch (back)
            {
                case "info":
                    form = add_Tracking_Info;
                    active = "info";
                    next = "item";
                    back = "clear";
                    break;
                case "item":
                    form = add_Tracking_Items;
                    active = "item";
                    next = "save";
                    back = "info";
                    break;
                case "save":
                    form = add_Confirm_Form;
                    active = "save";
                    next = "confirm";
                    back = "item";
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


            List<string> item_list = new List<string>();
            List<string> item_pair = new List<string>();
            List<List<string>> full_item = new List<List<string>>();
            var dict = new Dictionary<string, int>();
            var item_code_and_quantity_dictionary = new Dictionary<string, int>();

            //foreach (DataRow row in items.Rows)
            //{
            //    if (item_code_and_quantity_dictionary.ContainsKey(row["item_code"].ToString()))
            //    {
            //        item_code_and_quantity_dictionary[row["item_code"].ToString()] += (int)row["quantity"]; // If book name exists, add to existing quantity
            //    }
            //    else
            //    {
            //        item_code_and_quantity_dictionary[row["item_code"].ToString()] = (int)row["quantity"]; // If book name doesn't exist, add it with the given quantity
            //    }

            //    string insert = $"ICS: {trackDTO.ics_number}\n" +
            //        $"Code: {row["item_code"].ToString()}\n" +
            //        $"SN: {row["serial_number"]}\n" +
            //        $"Qty.: {row["quantity"]}\n" +
            //        $"Total: {row["Total_Cost"]}\n" +
            //        $"Created By: {CurrentUser.user_name}";
            //    MessageBox.Show(insert);
            //}

            //all insertions
            inventory_Manager.Insert_ICS(trackDTO.ics_number, trackDTO.entity_id, trackDTO.received_by_id, trackDTO.received_from_id);
            inventory_Manager.Insert_Fund_Cluster(trackDTO.ics_number, trackDTO.fund_cluster);
            foreach (DataRow row in items.Rows)
            {
                if (item_code_and_quantity_dictionary.ContainsKey(row["item_code"].ToString()))
                {
                    item_code_and_quantity_dictionary[row["item_code"].ToString()] += (int)row["quantity"]; // If book name exists, add to existing quantity
                }
                else
                {
                    item_code_and_quantity_dictionary[row["item_code"].ToString()] = (int)row["quantity"]; // If book name doesn't exist, add it with the given quantity
                }

                //string insert = $"ICS: {trackDTO.ics_number}\n" +
                //    $"Code: {row["item_code"]}\n" +
                //    $"SN: {row["serial_number"]}\n" +
                //    $"Qty.: {row["quantity"]}\n" +
                //    $"Total: {row["Total_Cost"]}\n" +
                //    $"Created By: {CurrentUser.user_name}";
                //MessageBox.Show(insert);
                inventory_Manager.Insert_Transfer_Item(trackDTO.ics_number, row["item_code"].ToString(), row["serial_number"].ToString(), Convert.ToInt32(row["quantity"]), Convert.ToDouble(row["Total_Cost"]));
            }

            //string msg = $"ICS: {trackDTO.ics_number}\n" +
            //    $"Entity ID: {trackDTO.entity_id}\n" +
            //    $"Receiver: {trackDTO.received_by_id}\n" +
            //    $"Giver.: {trackDTO.received_from_id}\n" +
            //    $"Created By: {CurrentUser.user_name}";
            //MessageBox.Show(msg);

            foreach (var single_order in item_code_and_quantity_dictionary)
            {
                inventory_Manager.Update_Item_Quantity(single_order.Value, single_order.Key);
                //MessageBox.Show($"UPDATE items_table SET quantity = quantity - {single_order.Value} WHERE item_code = {single_order.Key}");
            }

            //foreach (DataRow dataRow in  items.Rows)
            //{
            //    item_list.Add(dataRow["item_code"].ToString());
            //    item_pair.Add(dataRow["item_code"].ToString());
            //    item_pair.Add(dataRow["serial_number"].ToString());
            //    full_item.Add(item_pair);
            //    item_pair.Clear();
            //}

            //foreach (var value in item_list)
            //{
            //    // When the key is not found, "count" will be initialized to 0
            //    dict.TryGetValue(value, out int count);
            //    dict[value] = count + 1;
            //} 



            //foreach(var value in dict)
            //{
            //    MessageBox.Show($"Item Code: {value.Key} \nQuantity: {value.Value}");
            //}

            //string msg = $"ICS: {ics_number}\nEntity:{entity_name}\nFund: {fund_cluster}\nReceiver: {received_by} \nGiver: {received_from}";
            //MessageBox.Show(msg);
        }

        private void ConfirmDialog()
        {
            DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User clicked Yes, do something
                Console.WriteLine("User clicked Yes.");
                GetValues();
                // Perform the action you want to do when the user clicks "Yes"
            }
            else
            {
                // User clicked No or closed the message box, do something else or nothing
                Console.WriteLine("User clicked No or closed the message box.");
                // Perform the action you want to do when the user clicks "No" or closes the message box
            }
        }
    }
}
