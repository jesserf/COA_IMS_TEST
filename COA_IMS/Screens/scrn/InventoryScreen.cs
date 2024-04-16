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
    public partial class InventoryScreen : Form
    {
        public InventoryScreen()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            IMS_Product_Form prodForm = new IMS_Product_Form();
            prodForm.TopLevel = false;
            Prodpanel.Controls.Add(prodForm);
            prodForm.BringToFront();
            prodForm.Show();
        }
    }
}
