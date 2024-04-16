using COA_IMS.Screens.Subscreens.Employees;
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
    public partial class Employee : Form
    {
        private Tab_Manager tab_Manager;

        private Form current_Form = null;

        private readonly Employee_Submodule employee_Submodule = new Employee_Submodule();
        private readonly Inactive_Submodule inactive_Submodule = new Inactive_Submodule();

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();

            foreach (Control control in nav_panel.Controls) 
                if (control is GunaButton)
                    tab_Manager.Nav_buttons.Add(control);

            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_Button(employee_Btn, false);
        
            employee_Btn.PerformClick();
        }




        private void button_Click(object sender, EventArgs e) 
        { 
            var button = (GunaButton)sender;
            switch (button.Name)
            {
                case "employee_Btn":
                    current_Form = tab_Manager.switch_Form(employee_Submodule, current_Form, container_Panel);
                    break;

                case "inactive_Btn":
                    current_Form = tab_Manager.switch_Form(inactive_Submodule, current_Form, container_Panel);
                    break;
                
            }
            tab_Manager.active_Button(button, false);        
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
