using COA_IMS.Properties;
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

namespace COA_IMS.UserControlUtil.PRIS_UserControl
{
    public partial class PRIS_Label_Status : UserControl, IPRIS_UserControl
    {
        public bool IsRequiredValue = false;

        public bool IsMessageVisible
        {
            get { return false; }
            set {  }

        }
        public bool IsVisible
        {
            get { return this.Visible; }
            set { this.Visible = value; }
        }
        public Control ErrorRoot
        {
            get { return entry; }
        }
        public Control IndicatorRoot
        {
            get { return entry; }
        }
        public bool IsRequired
        {
            get { return IsRequiredValue; }
            set { IsRequiredValue = value; }
        }
        public string Title
        {
            get { return title.Text.Replace(":", " ").Trim(); }
            set { title.Text = value; }
        }

        public string Value
        {
            get { return entry.SelectedValue.ToString(); }
            set 
            {     
                entry.SelectedIndex = entry.FindStringExact(value); 
                readOnly_Entry.Text = entry.Text;
            }
        }

        public bool ReadOnly
        {
            get { return entry.Visible; }
            set { ReadOnly_Function(value); }
        }


        public DataTable DropdownOptions 
        { 
            get{ return (DataTable)entry.DataSource; }
            set
            { 
                entry.DisplayMember = "title";
                entry.ValueMember = "code";
                entry.DataSource = value;
            }
        }

        public PRIS_Label_Status()
        {
            InitializeComponent();
        }


        public PRIS_Label_Status(string _title, DataTable _options, string _value, bool _readOnly , bool _icons = true)
        {
            InitializeComponent();
            this.title.Text = _title;
            this.DropdownOptions = _options;
            this.icon.Visible = _icons;
            this.Value = _value;
            this.ReadOnly = _readOnly;
            
        }

        private void entry_TextChanged(object sender, EventArgs e)
        {
            if (icon.Enabled || icon.Visible) 
            {
                switch (entry.SelectedValue) 
                {
                    case "SYSTEM_STS000002":
                        icon.Image = Resources.search1;
                        break;
                    case "SYSTEM_STS000001":
                        icon.Image = Resources.search1;
                        break;
                    case "SYSTEM_STS000003":
                        icon.Image = Resources.search1;
                        break;
                    case "SYSTEM_STS000004":
                        icon.Image = Resources.search1;
                        break;
                    default:
                        icon.Image = null; 
                        break;
                }
            }
        }

        private void ReadOnly_Function(bool value) 
        {
            readOnly_Entry.Visible = value;
            entry.Visible = !value;
        }


    }
}
