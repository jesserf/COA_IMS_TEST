using COA_IMS.Screens.Subscrn;
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
    public partial class IMS_Tracking : Form
    {
        
        public IMS_Tracking()
        {
            InitializeComponent();
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
           CreateOrder trackform = new CreateOrder();
            trackform.ShowDialog();
        }
    }
}
