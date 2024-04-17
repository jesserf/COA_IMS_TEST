using COA_IMS.Screens.scrn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscrn
{
    public partial class InventoryTable : Form
    {
        public InventoryTable()
        {
            InitializeComponent();
        }
        private void add_item_Click(object sender, EventArgs e)
        {
            IMS_Product_Form prodform = new IMS_Product_Form();
            prodform.ShowDialog();
        }
    }
}
