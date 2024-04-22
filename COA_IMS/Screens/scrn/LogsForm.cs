using COA_IMS.Screens.Subscrn;
using COA_IMS.Screens.Subscrn.LogsSubscreens;
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
    public partial class LogsForm : Form
    {
        private Tab_Manager tab_Manager;

        private Form current_Form = null;

        private readonly AccountLogsSubForm account_Logs = new AccountLogsSubForm();
        private readonly ActivityLogsSubForm activity_Logs = new ActivityLogsSubForm();
        private readonly ReportLogsSubForm report_Logs = new ReportLogsSubForm();

        private List<Control> navButtons = new List<Control>();
        public LogsForm()
        {
            InitializeComponent();
        }
        private void LogsForm_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();

            tab_Manager.TakeAllAdvButtonsFromFlowLay(nav_panel);

            //tab_Manager.set_Colors("#1B303B", "#C7C8CC");

            account_Logs_Button.PerformClick();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = (GunaAdvenceButton)sender;
            switch (button.Name)
            {
                case "account_Logs_Button":
                    current_Form = tab_Manager.switch_Form(account_Logs, current_Form, container_Panel);
                    break;

                case "activity_Logs_Button":
                    current_Form = tab_Manager.switch_Form(activity_Logs, current_Form, container_Panel);
                    break;

                case "reports_Button":
                    current_Form = tab_Manager.switch_Form(report_Logs, current_Form, container_Panel);
                    break;
                default: break;
            }
            tab_Manager.active_AdvButton(button, false, false);
        }
    }
}
