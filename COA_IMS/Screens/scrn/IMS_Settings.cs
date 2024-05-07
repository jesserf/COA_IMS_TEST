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
    public partial class IMS_Settings : Form
    {
        private Tab_Manager tab_Manager = new Tab_Manager();

        private Form current_Form = null;

        private readonly IMS_SuplierTable ims_supliertable = new IMS_SuplierTable();
        private readonly ItemCategoryForm itemCategoryForm = new ItemCategoryForm();

        private List<Control> navButtons = new List<Control>();
        public IMS_Settings()
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
                case "item_Category_Btn":
                    form = itemCategoryForm;
                    break;
                case "item_Supplier_Btn":
                    form = ims_supliertable;
                    //current_Form = tab_Manager.switch_Form(itemCategoryForm, current_Form, content_Panel);
                    break;
                default: break;
            }
            if (form != null)
            {
                current_Form = tab_Manager.switch_Form(form, current_Form, content_Panel);
            }
            tab_Manager.active_AdvButton(button, false, false);
        }

        private void IMS_Settings_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();

            tab_Manager.TakeAllAdvButtonsFromFlowLay(nav_panel);

            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_AdvButton(item_Category_Btn, false, false);

            item_Category_Btn.PerformClick();
        }
    }
}
