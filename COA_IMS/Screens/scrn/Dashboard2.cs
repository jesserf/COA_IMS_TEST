using COA_IMS.Utilities;
using COA_IMS.Screens.scrn;
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
    public partial class Dashboard2 : Form
    {
        private bool sidebar_Expanded = false;
        private Form current_Form = null;
        private Login_Manager login_manager;
        private Database_Manager database_manager;
        private Tab_Manager tab_Manager = new Tab_Manager();
        private Activity_Manager manager;
        private Log_Message message;
        private readonly InventoryScreen inventory_tab = new InventoryScreen();
        private readonly Homepage landing_home = new Homepage();
        private readonly IMS_Reports report_Tab = new IMS_Reports();
        /*private readonly ActivityLogs log_Tab = new ActivityLogs();*/
        private readonly IMS_Maintenance maintenance_Tab = new IMS_Maintenance();
        public Dashboard2()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            var button = (GunaButton)sender;
            Form form = null;

            switch (button.Name)
            {
                case "Homebtn":
                    form = landing_home;
                    break;
                case "Dashboard2btn":
                    // Handle Create button click
                    form = inventory_tab;
                    //current_Form = tab_Manager.switch_Form2(inventory_tab, current_Form, Main);
                    break;
                case "Reportsbtn":
                    // Handle Report button click
                    form = report_Tab;
                    break;
                case "Settingsbtn":
                    form = maintenance_Tab;
                    break;
            }
            if (form != null)
                current_Form = tab_Manager.switch_Form(form, current_Form, Main);

            tab_Manager.active_Button(button, true);
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
