using COA_IMS.Utilities;
using Google.Protobuf.WellKnownTypes;
using Guna.UI.WinForms;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COA_IMS.UserControlUtil
{
    public partial class Label_Drop : UserControl
    {
        private readonly Database_Manager database_Manager = new Database_Manager();

        public event EventHandler DropboxChanged;
        public override string Text 
        {
            get { return (string)dropbox.SelectedValue; }
            set {

                if (dropbox.Items.Cast<object>().Any(item => item.ToString().Contains(value)))
                { 
                    dropbox.SelectedValue = value;
                    help_provider.Clear();
                }
                else
                {
                    help_provider.SetError(dropbox, $"{value} is an inactive {this.title.Text.Replace(":", "").ToLower()} record or cannot be used.\r\nConsider updating the {this.title.Text.Replace(":", "").ToLower()} of this record.");
                    SetOption(Query, $"{value} cannot be used.");
                }
            }
        }
        private string Query;
        public string Option_Query 
        {
            get { return Query; }
            set {
                Query = value;
                SetOption(value, $"Select {this.title.Text.Replace(":", "")}");
                
            }
        }
        public string Value 
        {
            get { return dropbox.Text; }
            //set { }
        }
        
        public bool Enable_Info 
        {
            get { return info.Enabled; }
            set { info.Enabled = value;
                info.Visible = value; 
            }
        }

        public string Info_Message
        {
            get { return info.Text; }
            set { info.Text = value; }
        }

        
        public string Title
        {
            get { return this.title.Text.Replace(":", "").Trim(); }
            set { this.title.Text = value; }
            
        }

        public bool Enabled_Dropbox 
        {
            get { return dropbox.Enabled; }
            set {dropbox.Enabled = value;}        
        }

        public Label_Drop(string _title, string option_Query, bool is_enabled = true)
        {
            InitializeComponent();
            this.Enabled_Dropbox = is_enabled;
            this.Title = _title;
            this.Option_Query = option_Query;
            this.dropbox.Tag = _title.Replace(":", "");
        }

        private void SetOption(string query, string message)
        {
            DataTable ret;

            using (database_Manager)
                ret = database_Manager.ExecuteQuery(query);
            if (ret != null)
            {
                var optionPairs = GetOptionPairs(ret);

                optionPairs.Insert(0, new KeyValuePair<string, string>("null", message));
                dropbox.DisplayMember = "value";
                dropbox.ValueMember = "key";
                dropbox.DataSource = new BindingSource(optionPairs, null);
            }

        }

        private List<KeyValuePair<string, string>> GetOptionPairs(DataTable dataTable)
        {
            var optionPairs = new List<KeyValuePair<string, string>>();

            foreach (DataRow row in dataTable.Rows)
            {
                string key = row[0].ToString();
                string value = row[1].ToString();
                optionPairs.Add(new KeyValuePair<string, string>(key, value));
            }

            return optionPairs;
        }

        private void dropbox_TextChanged(object sender, EventArgs e)
        {
            DropboxValue_Changed(EventArgs.Empty);
        }
      
        private void dropbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Text = (string)dropbox.SelectedValue;
            DropboxValue_Changed(EventArgs.Empty);
        }

        protected virtual void DropboxValue_Changed(EventArgs e)
        {
            DropboxChanged?.Invoke(this, e);
        }

        private void dropbox_DropDown(object sender, EventArgs e)
        {

        }
    }
}
