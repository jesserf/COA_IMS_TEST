using COA_IMS.UserControlUtil.PRIS_UserControl;
using COA_IMS.Utilities;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace COA_IMS.UserControlUtil
{
    public partial class PRIS_Label_Selector : UserControl, IPRIS_UserControl
    {
        private Dictionary<string, string> valuePairs = new Dictionary<string, string>();
        private Database_Manager database_Manager = new Database_Manager();
        private Selector selector;

        private DataTable options; 
        public event EventHandler SelectionChanged;
        public string infoText;

        public bool IsRequiredValue = false;
        public bool IsMessageVisible
        {
            get { return message.Visible; }
            set { message.Visible = value; }

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
            get { return search; }
        }
        public bool IsRequired
        {
            get { return IsRequiredValue; }
            set
            {
                IsRequiredValue = value;
                message.Text = value ? "(Required)" : "(Optional)";
            }
        }
        public string Title
        {
            get { return title.Text.Replace(":", " ").Trim(); }
            set { title.Text = value;}
        }
        public string Value
        {
            get { return ReturnValues.FirstOrDefault(x => x.Value == entry.Text).Key;}
            set 
            { 
                entry.Text = !string.IsNullOrEmpty(value) ? value: $"Select {this.Title} Record";
                Selection_ChangeEvent(EventArgs.Empty);
            }
        }
        public Control Button
        {
            get { return search; }
        }
        public DataTable RawOptions 
        {
            get { return options; }
        }
        public string RawValue
        {
            get { return entry.Text; }
        }
        public bool ReadOnly
        {
            get { return search.Enabled; }
            set 
            { 
                search.Visible = !value;
                if (value)
                    entry.Margin = new Padding(3,3,20,3);
                else
                    entry.Margin = new Padding(3,3,3,3);
            }
        }
        public Dictionary<string, string> ReturnValues 
        {
            get { return valuePairs; }
            set { valuePairs = value; Value = value[valuePairs.Keys.Single()];} 
        }
        public bool EnableSelector
        {
            get { return search.Enabled; }
            set { SetControls(value); }
        }
        public string EntryText 
        {
            get { return entry.Text; }
            set {  entry.Text = value; }
        }
        public string InfoText 
        {
            get { return infoText; }
            set {  infoText = value; }
        }

        public string SelectorQuery { get; set; }
        public string SearchQuery { get; set; }
        private (string, DataGridViewContentAlignment)[] ColumnsTitlesAlignment { get; set; }
        private (bool, int)[] ColumnWidths { get; set; }

        public PRIS_Label_Selector()
        {
            InitializeComponent();
        }

        public PRIS_Label_Selector(string _title, string _query, string _searchQuery,
            (string, DataGridViewContentAlignment)[] _column_Title_Alignment,
            (bool, int)[] _column_Widths, bool _enabled = true, bool _read_Only = false,
            bool _isRequired = true, bool _showMessage = true
            )
        {
            InitializeComponent();
            this.Title = _title;
            this.message.Visible = _showMessage;
            this.EnableSelector = _enabled;
            this.entry.Tag = $"!req_{this.Title}";
            this.entry.Text = $"Select {this.Title} Record";
            this.IsRequired = _isRequired;
            this.SelectorQuery = _query;
            this.ColumnsTitlesAlignment = _column_Title_Alignment;
            this.ColumnWidths = _column_Widths;
            this.ReadOnly = _read_Only;
            this.SearchQuery = _searchQuery;
            SetSelection();
        }

        private void SetControls(bool value) 
        {
            search.Enabled = value;
            entry.Enabled = value;
            entry.BaseColor = value ? Color.White : Color.Gainsboro;
        }

        private void SetSelection() 
        {
            DataTable ret;
            using (database_Manager)
               ret = database_Manager.ExecuteQuery(this.SelectorQuery);

            options = ret;
            foreach (DataRow row in ret.Rows)
                ReturnValues.Add((string)row[0], (string)row[1]);
        }


        private void search_Click(object sender, EventArgs e)
        {
            CallSelector(sender);
        }

        protected virtual void Selection_ChangeEvent(EventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }

        private void CallSelector(object sender) 
        {
            selector = new Selector(sender, this.Title, this.SelectorQuery, this.ColumnsTitlesAlignment, this.ColumnWidths, this.SearchQuery);
            selector.InfoText = this.InfoText;
            selector.ShowDialog();
        }

        private void entry_DoubleClick(object sender, EventArgs e)
        {
            if(search.Visible)
                CallSelector(search);
        }
    }
}
