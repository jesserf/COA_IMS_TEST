using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.UserControlUtil.PRIS_UserControl
{
    public partial class PRIS_Label_CheckBox : UserControl
    {
        public bool IsVisible
        {
            get { return this.Visible; }
            set { this.Visible = value; }
        }
        public bool Value 
        {
            get { return this.check.Checked; }
            set { this.check.Checked = value; }
        }

        public bool ReadOnly
        {
            get { return check.Enabled; }
            set { check.Enabled = !value; }
        }
        public PRIS_Label_CheckBox(string _title, bool _checked = false, bool _enabled = true)
        {
            InitializeComponent();
            this.title.Text = _title;
            this.check.Checked = _checked;
            this.check.Enabled = _enabled;
        }

        private void title_Click(object sender, EventArgs e)
        {
            if (check.Enabled)
                this.check.Checked = !this.check.Checked;
        }
    }
}
