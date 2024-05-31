using COA_IMS.Screens.Subscreens.ActivityLogs;
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
using COA_IMS.Screens.Subscrn;

namespace COA_IMS.Screens.scrn
{
    public partial class InventoryMain : Form
    {
        private Tab_Manager tab_Manager = new Tab_Manager();

        private Form current_Form = null;

        private readonly InventoryTable inventory_Table = new InventoryTable();
        private readonly ArchiveInventoryTable archived_Inventory_Table = new ArchiveInventoryTable();

        private List<Control> navButtons = new List<Control>();
        public InventoryMain()
        {
            InitializeComponent();
            foreach (GunaAdvenceButton buttoan in nav_panel.Controls)
                navButtons.Add(buttoan);
        }
        private void button_Click(object sender, EventArgs e)
        {
            var button = (GunaAdvenceButton)sender;
            Form form = null;

            switch (button.Name)
            {
                case "inventory_Table_Btn":
                    form = inventory_Table;
                    break;

                case "archived_Table_Btn":
                    form = archived_Inventory_Table;
                    break;
                default: break;
                }
            if (form != null)
            {
                current_Form = tab_Manager.switch_Form(form, current_Form, content_Panel);
            }
            tab_Manager.active_AdvButton(button, false, false);
        }

        private void InventoryMain_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();

            //foreach (Control control in nav_panel.Controls)
            //    if (control is GunaAdvenceButton)
            //        tab_Manager.Nav_buttons.Add(control);
            tab_Manager.TakeAllAdvButtonsFromFlowLay(nav_panel);

            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_AdvButton(inventory_Table_Btn, false, false);

            inventory_Table_Btn.PerformClick();
        }

    }
}