using COA_IMS.Screens.Subscrn;
using COA_IMS.Screens.Subscrn.EmployeeSubscreens;
using COA_IMS.Screens.Subscrn.Tracking;
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

namespace COA_IMS.Screens.scrn
{
    public partial class IMS_Tracking : Form
    {
        private Tab_Manager tab_Manager = new Tab_Manager();

        private Form current_Form = null;

        private readonly AddTrackingBaseForm add_Tracking_Base_Form = new AddTrackingBaseForm();
        private readonly TrackingTable tracking_Table = new TrackingTable();
        private readonly EmployeeHistoryTable history_Table = new EmployeeHistoryTable();
        private readonly ICS_Return_Table iCS_Return_Table = new ICS_Return_Table();
        private readonly Tracking_Serial_Num_Table tracking_Serial_Num_Table = new Tracking_Serial_Num_Table();

        private List<Control> navButtons = new List<Control>();

        public IMS_Tracking()
        {
            InitializeComponent();
            foreach (GunaAdvenceButton button in nav_panel.Controls)
                navButtons.Add(button);
        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = (GunaAdvenceButton)sender;
            Form form = null;

            switch (button.Name)
            {
                case "add_Btn":
                    form = add_Tracking_Base_Form;
                    break;
                case "tracking_Table_Btn":
                    form = tracking_Table;
                    break;
                case "returned_Btn":
                    form = iCS_Return_Table;
                    break;
                case "emp_History_Btn":
                    form = history_Table;
                    break;
                case "item_History_Btn":
                    form = tracking_Serial_Num_Table;
                    break;
                default: break;
            }
            if (form != null)
            {
                current_Form = tab_Manager.switch_Form(form, current_Form, content_Panel);
            }
            tab_Manager.active_AdvButton(button, false, false);
        }

        private void IMS_Tracking_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();

            tab_Manager.TakeAllAdvButtonsFromFlowLay(nav_panel);

            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_AdvButton(tracking_Table_Btn, false, false);

            tracking_Table_Btn.PerformClick();
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
           CreateOrder trackform = new CreateOrder();
            trackform.ShowDialog();
        }
    }
}
