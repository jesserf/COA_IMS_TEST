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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace COA_IMS.Screens.scrn
{
    public partial class Dashboard2 : Form
    {
        private Form current_Form = null;
        private Login_Manager login_manager;
        private Database_Manager database_manager;
        private Tab_Manager tab_Manager;
        private Activity_Manager activity_manager;
        private Log_Message message;
        //all forms
        /*private readonly InventoryScreen inventory_tab = new InventoryScreen();*/
        private readonly InventoryMain inventory_tab = new InventoryMain();
        private readonly Homepage landing_home = new Homepage();
        private readonly IMS_Reports report_Tab = new IMS_Reports();
        /*private readonly ActivityLogs log_Tab = new ActivityLogs();*/
        private readonly IMS_Maintenance maintenance_Tab = new IMS_Maintenance();

        private bool dontRunClosingEventHandler = false;

        private readonly UserMaintenancetab usermaintenance_tab = new UserMaintenancetab();

        public Dashboard2()
        {
            InitializeComponent();
        }

        private void Dashboard2_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();
            login_manager = new Login_Manager();
            activity_manager = new Activity_Manager();
            foreach (GunaButton btn in tabPanel.Controls)
            {
                tab_Manager.Nav_buttons.Add(btn);
                btn.OnHoverBaseColor = Theme.Hex_To_RGB(tab_Manager.select_hover_color);
            }

            Login_Manager.active_Account = "admin";
            activity_manager.Log_Activity("admin", "Logged In");

            tab_Manager.Header_Title = title_Label;
            tab_Manager.active_Button(Homebtn, true);
            Inventorybtn.PerformClick();
        }
        private void tab_Button_Click(object sender, EventArgs e)
        {
            var button = (GunaButton)sender;
            Form form = null;

            switch (button.Name)
            {
                case "Homebtn":
                    form = landing_home;
                    break;
                case "Inventorybtn":
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
                case "UserMaintenance":
                    form = usermaintenance_tab;
                    break;
            }
            if (form != null)
                current_Form = tab_Manager.switch_Form(form, current_Form, main_Panel);

            tab_Manager.active_Button(button, true);
        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (dontRunClosingEventHandler) return;
                Console.WriteLine(1);
                Activity_Manager activityManager = new Activity_Manager();
                if (MessageBox.Show("Are you sure you want to logout", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    activityManager.Log_Activity("admin", Log_Message.logout_message);
                    Application.Exit();
                }
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Activity_Manager activityManager = new Activity_Manager();
            if (MessageBox.Show("Are you sure you want to logout", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
            }
            else
            {
                dontRunClosingEventHandler = true;
                activityManager.Log_Activity("admin", Log_Message.logout_message);
                this.Hide();
                login login_ = new login();
                login_.ShowDialog();
                this.Close();
            }

        private void main_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserMaintenance_Click(object sender, EventArgs e)
        {

        }
    }
}
