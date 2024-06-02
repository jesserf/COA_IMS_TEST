using COA_IMS.Screens.Subscreens.Users;
using COA_IMS.Screens.Subscrn;
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

namespace COA_IMS.Screens
{
    public partial class UserMaintenancetab : Form
    {
        private Form current_Form = null;
        private Tab_Manager tab_Manager = new Tab_Manager();

        private readonly Users_Lists users_Lists = new Users_Lists();
        private readonly Users_Roles users_Roles = new Users_Roles();
        private readonly Users_Create users_Create = new Users_Create();

        private readonly IMS_AccountManagement ims_accmanagement = new IMS_AccountManagement();

        public UserMaintenancetab()
        {
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            foreach (Control control in nav_panel.Controls)
                if (control is GunaAdvenceButton)
                    tab_Manager.Nav_buttons.Add(control);

            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_AdvButton(user_Btn, false);

            user_Btn.PerformClick();

        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = (GunaAdvenceButton)sender;
            Form form = null;

            switch (button.Name)
            {
                case "user_Btn":
                    form = users_Lists;
                    break;
                case "roles_Btn":
                    form = users_Roles;
                    break;
            }
            if (form != null)
                current_Form = tab_Manager.switch_Form(form, current_Form, content_Panel);

            tab_Manager.active_AdvButton(button, false);

        }
    }
}
