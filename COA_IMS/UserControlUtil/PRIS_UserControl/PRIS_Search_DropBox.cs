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
    public partial class PRIS_Search_DropBox : UserControl
    {
        public EventHandler Search_Typed;
        public List<string> DropboxValues 
        {
            //get {return  (List<string>)dropbox.DataSource; }
            set 
            { 
                if (value != null) 
                {
                    dropbox.DataSource = value;
                    dropbox.Visible = true;
                }
                else
                { 
                    dropbox.DataSource = null; 
                    dropbox.Visible = false;
                }
            }
        }

        public string Dropbox_Text 
        {
            get { return dropbox.SelectedValue.ToString(); }
        }

        public string Search_Text 
        { 
            get { return entry.Text; }
            set { entry.Text = value; }
        }

        public void Clear() 
        { 
            entry.Text = string.Empty;
            if (dropbox.Visible) 
            {
                dropbox.SelectedIndex = 0;
            }
        }

        public PRIS_Search_DropBox()
        {
            InitializeComponent();
        }

        private void entry_TextChanged(object sender, EventArgs e)
        {
            Search_Typed?.Invoke(this, e);
        }

        private void dropbox_TextChanged(object sender, EventArgs e)
        {
            Search_Typed?.Invoke(this, e);
        }
    }
}
