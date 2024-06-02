using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace COA_IMS.UserControlUtil.PRIS_UserControl
{
    public partial class PRIS_Label_DateCheckBox : UserControl, IPRIS_UserControl
    {
        //private bool EnabledText = true;
        public bool IsRequiredValue = false;

        public string DisplayFormat;

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
            get { return date; }
        }
        public Control IndicatorRoot
        {
            get { return date; }
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
            get
            {
                DateTime time = DateTime.Now;
                string value;
                if(check.Checked)
                    value = $"{date.Value.ToString("yyyy-MM-dd")} {time.ToString("HH:mm:ss")}";
                else
                    value = string.Empty ;

                return value;
            }
            set
            {
                date.Value = !string.IsNullOrEmpty(value) ? DateTime.Parse(value) : DateTime.Now;

                if (date.Format == DateTimePickerFormat.Long)
                    readOnly_Entry.Text = date.Value.ToLongDateString();
                else if (date.Format == DateTimePickerFormat.Short)
                    readOnly_Entry.Text = date.Value.ToShortDateString();
                else
                    readOnly_Entry.Text = date.Value.ToString(DisplayFormat);
            }
        }

        public bool ReadOnly
        {
            get { return date.Visible; }
            set
            {
                ReadOnly_Function(value);
            }
        }

        public PRIS_Label_DateCheckBox()
        {
            InitializeComponent();
        }

        public PRIS_Label_DateCheckBox(string _title, bool _isRequired = true, bool _isReadOnly = false, string _diplayFormat = "yyyy-MM-dd HH:mm:ss",
            DateTimePickerFormat _displayDate = DateTimePickerFormat.Long)
        {
            InitializeComponent();
            date.Value = DateTime.Today;
            this.title.Text = _title;
            this.IsRequired = _isRequired;
            DisplayFormat = _diplayFormat;
            date.CustomFormat = _diplayFormat;
            date.Format = _displayDate;
            this.ReadOnly = _isReadOnly;

            readOnly_Entry.Text = "No Date Set";
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(check.Checked);
            this.ReadOnly = check.Checked;
        }

        private void ReadOnly_Function(bool value)
        {
            readOnly_Entry.Visible = !value;

            date.Visible = value;

            readOnly_Entry.Text = !value ?  "No Date Set" : string.Empty;
        }
    }
}
