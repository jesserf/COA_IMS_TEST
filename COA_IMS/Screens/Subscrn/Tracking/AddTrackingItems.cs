using COA_IMS.UserControlUtil;
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
    public partial class AddTrackingItems : Form
    {
        GenericTable genericTable;
        TrackingDTO trackDTO;
        public AddTrackingItems(TrackingDTO trackDTO)
        {
            InitializeComponent();

            genericTable = new GenericTable();
            genericTable.FillVariables(null, null, null, "items", "items", null, null, null, data_View, null, null, null);
            genericTable.sort_String = "All";
            this.trackDTO = trackDTO;
            genericTable.Populate_Table(1);
            //setup user controls
            //disables next logs button
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            TableSelectorForm tableSelectorForm = new TableSelectorForm("item", null, null, data_View);
            tableSelectorForm.ShowDialog();
            trackDTO.items = data_View.DataSource as DataTable;
            tableSelectorForm.DebugTable(trackDTO.items);
        }

        private void data_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
