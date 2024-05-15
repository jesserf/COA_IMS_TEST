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

namespace COA_IMS.Screens.Subscrn.Tracking
{
    public partial class AddTrackingItems : Form
    {
        public AddTrackingItems()
        {
            InitializeComponent();
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            TableSelectorForm tableSelectorForm = new TableSelectorForm("item");
            tableSelectorForm.ShowDialog();
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            SwitchStep("info");
        }

        private void SwitchStep(string page)
        {
            this.Hide();
            Form form = null;
            switch (page)
            {
                case "confirm":
                    form = new AddConfirmForm();
                    break;
                case "item":
                    form = new AddTrackingItems();
                    break;
                case "info":
                    form = new AddTrackingInfo();
                    break;
                default:
                    break;
            }
            //Allow the from to fill the main panel.
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            this.Parent.Controls.Add(form);
            form.Show();
        }

        private void next_Btn_Click(object sender, EventArgs e)
        {
            SwitchStep("confirm");
        }
    }
}
