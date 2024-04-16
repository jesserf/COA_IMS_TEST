using Org.BouncyCastle.Crypto.Prng;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.UserControlUtil
{
    public partial class Label_Text : UserControl
    {
        public override string Text
        {
            get { return entry.Text; }
            set { entry.Text = value; }
        }

        public Label_Text(string _title)
        {
            InitializeComponent();
            this.title.Text = _title;
            this.entry.Tag = _title.Replace(":", "");
        }

        private void Label_Text_Load(object sender, EventArgs e)
        {
            
        }
        private void entry_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length == entry.MaxLength)
            {
                label_Text_Error.SetError(entry, "Maximum characters reached.");
                entry.BorderColor = Color.Red;
            }
        }

    }
}
