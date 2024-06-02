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
    public partial class PRIS_Date_Picker : UserControl, IPRIS_UserControl
    {
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
        public bool ReadOnly
        {
            get { return date.Visible; }
            set 
            {
                ReadOnly_Function(value);
            }
        }

        public string Value
        {
            get 
            {
                //DateTime time = DateTime.Now;
                //var value = $"{date.Value.ToString("yyyy-MM-dd")} {time.ToString("HH:mm:ss")}";
                return date.Value.ToString("yyyy-MM-dd HH:mm:ss");  
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
        public PRIS_Date_Picker()
        {
            InitializeComponent();
            date.Value = DateTime.Today;
        }

        public PRIS_Date_Picker(string _title, bool _isRequired = true, bool _isReadOnly = false, string _diplayFormat = "yyyy-MM-dd HH:mm:ss", 
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
        }

        private void ReadOnly_Function(bool value) 
        {
            readOnly_Entry.Visible = value;
            date.Visible = !value;
        }

    }
}
