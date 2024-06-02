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

namespace COA_IMS.Screens.Subscrn.Tracking
{
    public partial class AddConfirmForm : Form
    {
        GenericTable genericTable;
        TrackingDTO trackDTO;
        public AddConfirmForm(TrackingDTO trackDTO)
        {
            InitializeComponent();

            genericTable = new GenericTable();
            genericTable.FillVariables(null, null, null, "items", "items", null, null, null, data_View, null, null, null);
            genericTable.sort_String = "All";
            this.trackDTO = trackDTO;
            genericTable.Populate_Table(1);
            //genericTable = new GenericTable();
            //genericTable.FillVariables(null, null, null, "items", "items", null, null, null, data_View, null, null, null);
            //genericTable.sort_String = "All";
            //genericTable.Populate_Table(1);
            //this.trackDTO = trackDTO;
            //ics_Textbox.Text = trackDTO.ics_number;
        }
        

        private void back_Btn_Click(object sender, EventArgs e)
        {
            SwitchStep("item");
        }

        private void next_Btn_Click(object sender, EventArgs e)
        {

        }

        private void SwitchStep(string page)
        {
            this.Hide();
            Form form = null;

            //Allow the from to fill the main panel.
            //form.TopLevel = false;
            //form.Dock = DockStyle.Fill;

            this.Parent.Controls.Add(form);
            //form.Show();
        }

        private void AddConfirmForm_VisibleChanged(object sender, EventArgs e)
        {
            ics_Textbox.Text = trackDTO.ics_number;
            entity_Name_Textbox.Text = trackDTO.entity_name;
            fund_Cluster_Textbox.Text = trackDTO.fund_cluster;
            received_From_Combobox.Text = trackDTO.received_from;
            received_By_Combobox.Text = trackDTO.received_by;
            data_View.DataSource = trackDTO.items;
            genericTable.AddThemeToDGV(data_View, "items");
        }
    }
}
