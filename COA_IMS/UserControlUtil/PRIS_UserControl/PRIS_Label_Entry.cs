using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COA_IMS.UserControlUtil.PRIS_UserControl
{
    public partial class PRIS_Label_Entry : UserControl, IPRIS_UserControl
    {
        private bool EnabledText = true;
        private string SpecChar = string.Empty;
        public bool IsRequiredValue = false;
        private bool IsCurrency;

        public event EventHandler Text_Changed;

        public bool IsMessageVisible 
        {
            get { return message.Visible; }
            set { message.Visible = value;  }

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
            set 
            { 
                IsRequiredValue = value;
                message.Text = value ? "(Required)" : "(Optional)";

            }
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
                if (IsCurrency) 
                {
                    return entry.Text.Replace("₱", "").Replace(",", "").Trim();
                }
                else 
                {
                    return entry.Text.Trim();
                }
                
            }
            set { entry.Text = value; }
        }

        public bool ReadOnly
        {
            get { return entry.ReadOnly; }
            set 
            {
                if (EnabledText)
                    entry.ReadOnly = value; 
            }
        }

        public string SpecialChar
        {
            set 
            {
                if (value != null) 
                { 
                    SpecChar = $"{value}";
                    entry.Text = $"{value}";
                    
                }
            
            }
        
        }
        public PRIS_Label_Entry()
        {
            InitializeComponent();
        }

        public PRIS_Label_Entry(string _title, bool _isRequired = true, bool _isReadOnly = false, bool _enabledText = true,
            string _specialChar = null, HorizontalAlignment _textAlign = HorizontalAlignment.Left, bool _isCurrency = false,
            bool _showMessage = true, bool _isPassword = false) 
        {
            InitializeComponent();
            this.title.Text = _title;
            this.message.Visible = _showMessage;
            this.entry.Tag = _title.Replace(":","").Trim();
            this.IsRequired = _isRequired;
            this.ReadOnly = _isReadOnly;
            this.EnabledText = _enabledText;
            this.SpecialChar = _specialChar;
            this.entry.TextAlign = _textAlign;
            this.IsCurrency = _isCurrency;

            if (_isPassword) 
            {
                entry.PasswordChar = '*';
            }
        }
        private void entry_TextChanged(object sender, EventArgs e)
        {
            if (!entry.Text.StartsWith(SpecChar))
            {
                SpecChar += entry.Text ;

                entry.SelectionStart = entry.Text.Length;
            }

            Text_ChangeEvent(EventArgs.Empty);


        }

        protected virtual void Text_ChangeEvent(EventArgs e)
        {
            Text_Changed?.Invoke(this, e);
        }

        private void entry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsCurrency)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                    return;
                }

                string textWithoutCurrency = entry.Text.Replace("₱", "");
                string newText = textWithoutCurrency + e.KeyChar;

                // Check if the pressed key is a decimal separator
                if (e.KeyChar == '.')
                {
                    if (textWithoutCurrency.Contains(".") || string.IsNullOrEmpty(textWithoutCurrency))
                    {
                        e.Handled = true;
                        return;
                    }
                    else if (!string.IsNullOrEmpty(textWithoutCurrency) && !textWithoutCurrency.Contains("."))
                    {
                        newText += "."; // Add the decimal separator to the text
                    }
                }

                // Try parsing the combined text as a decimal value
                if (decimal.TryParse(newText, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal value))
                {
                    // Split the value into integer and decimal parts
                    decimal integerPart = Math.Truncate(value);
                    decimal decimalPart = value - integerPart;

                    // Limit decimal part to two decimal places
                    decimalPart = Math.Round(decimalPart, 2);

                    string formattedIntegerPart = integerPart.ToString("N0", CultureInfo.CurrentCulture);
                    string formattedValue = $"₱ {formattedIntegerPart}";

                    // Append decimal part if not zero
                    if (decimalPart != 0)
                    {
                        formattedValue += $"{decimalPart.ToString().Substring(1)}";
                    }

                    // Update the entry text
                    entry.Text = formattedValue;
                    entry.SelectionStart = entry.Text.Length; // Move the cursor to the end
                    e.Handled = true; // Prevent the entry from further processing the key press
                }

            }
        }
    }
}
