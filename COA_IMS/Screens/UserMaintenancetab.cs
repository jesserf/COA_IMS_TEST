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
        private Tab_Manager tab_Manager = new Tab_Manager();

        private Form current_Form = null;

        private readonly IMS_AccountManagement ims_accmanagement = new IMS_AccountManagement();

        public UserMaintenancetab()
        {
            InitializeComponent();
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            var btn = (GunaButton)sender;
            Form usermanagementform = null;

            switch (btn.Name)
            {
                case "accountbtn":
                    usermanagementform = ims_accmanagement;
                    break;
            }
            if (usermanagementform != null)
            {
                current_Form = tab_Manager.switch_Form(usermanagementform, current_Form, gunaElipsePanel1);
            }
            tab_Manager.active_Button(btn, false, false);
        }
    }
}
