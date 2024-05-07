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

namespace COA_IMS.Screens.scrn
{
    public partial class IMS_Employee : Form
    {
        private Tab_Manager tab_Manager = new Tab_Manager();

        private Form current_Form = null;

        private readonly InventoryTable inventory_Table = new InventoryTable();
        private readonly EmployeeTable employee_Table = new EmployeeTable();
        private readonly CategoryTab category_tab = new CategoryTab();
        private readonly IMS_SuplierTable ims_supliertable = new IMS_SuplierTable();
        private readonly ItemCategoryForm itemCategoryForm = new ItemCategoryForm();

        private List<Control> navButtons = new List<Control>();
        public IMS_Employee()
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
                case "employee_Table_Btn":
                    form = employee_Table;
                    break;
                default: break;
            }
            if (form != null)
            {
                current_Form = tab_Manager.switch_Form(form, current_Form, content_Panel);
            }
            tab_Manager.active_AdvButton(button, false, false);
        }

        private void IMS_Employee_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();

            tab_Manager.TakeAllAdvButtonsFromFlowLay(nav_panel);

            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_AdvButton(employee_Table_Btn, false, false);

            employee_Table_Btn.PerformClick();
        }
    }
}
