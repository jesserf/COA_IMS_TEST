using Newtonsoft.Json.Serialization;
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
    public partial class AddSerialNumberForm : Form
    {
        public string sn { get; set; }
        public AddSerialNumberForm()
        {
            InitializeComponent();
            sn = "none";
            AcceptButton = next_Btn;
            sn_Textbox.Focus();
            
        }

        private void next_Btn_Click(object sender, EventArgs e)
        {
            sn = sn_Textbox.Text;
            this.Close();       
        }

        #region Textbox Placeholder and Press Enter to Save
        private void textbox_Enter(object sender, EventArgs e)
        {
            if (string.Equals(sn_Textbox.Text.ToString(), "none"))
            {
                sn_Textbox.ForeColor = Color.Black;
                sn_Textbox.Text = "";
            }
        }
        private void textbox_Leave(object sender, EventArgs e)
        {
            if (string.Equals(sn_Textbox.Text.ToString(), ""))
            {
                sn_Textbox.ForeColor = Color.LightGray;
                sn_Textbox.Text = "none";
            }
        }
        #endregion
    }
}
