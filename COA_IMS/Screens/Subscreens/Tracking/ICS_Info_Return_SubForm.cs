using COA_IMS.Utilities;
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
    public partial class ICS_Info_Return_SubForm : Form
    {
        string ics, sn;
        Inventory_Manager inventory_Manager = new Inventory_Manager();

        private void remove_Btn_Click(object sender, EventArgs e)
        {
            if (now_Checkbox.Checked)
            {
                inventory_Manager.Update_ICS_Record(ics, sn);
            }
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ICS_Info_Return_SubForm(string ics, string sn)
        {
            InitializeComponent();
            //takes information from a cell in table and puts it in variables
            this.ics = ics;
            this.sn = sn;
        }
    }
}
