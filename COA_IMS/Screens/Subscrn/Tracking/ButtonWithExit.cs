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
    public partial class ButtonWithExit : UserControl
    {
        public ButtonWithExit()
        {
            InitializeComponent();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void item_Name_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
