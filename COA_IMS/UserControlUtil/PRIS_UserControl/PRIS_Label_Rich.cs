using COA_IMS.Utilities;
using COA_IMS.UserControlUtil.PRIS_UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COA_IMS.UserControlUtil.PRIS_UserControl
{
    public partial class PRIS_Label_Rich : UserControl, IPRIS_UserControl
    {
        public bool IsRequiredValue = false;
        public string SpecialChar;

        private Color CurrentColor;

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
            get { return entry_Panel; }
        }
        public Control IndicatorRoot
        {
            get { return entry_Panel; }
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
                if (SpecialChar != null)
                {
                    return entry.Text.TrimStart(SpecialChar.ToCharArray()).Trim();
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
            set { entry.ReadOnly = value; }
        }
        public bool EnabledText
        {
            get { return entry.Enabled; }
            set { entry.Enabled = value; }
        }
        public int EntryHeight 
        {
            get { return this.Height; }
            set { this.Height = value;  }
        }

        public PRIS_Label_Rich()
        {
            InitializeComponent();
        }

        public PRIS_Label_Rich(string _title, bool _isRequired = true, bool _isReadOnly = false, int _entryHeight = 150, string _specialChar = null,
            bool _showMessage = true)
        {
            InitializeComponent();
            this.title.Text = _title;
            this.message.Visible = _showMessage;
            this.entry.Tag = _title.Replace(":", "").Trim();
            this.IsRequired = _isRequired;
            this.Height = _entryHeight;
            this.SpecialChar = _specialChar;
            this.ReadOnly = _isReadOnly;
        }

        private void entry_Enter(object sender, EventArgs e)
        {
            CurrentColor = entry_Panel.BaseColor;
            entry_Panel.BaseColor = Color.FromArgb(27, 48, 59);
        }

        private void entry_Leave(object sender, EventArgs e)
        {
            entry_Panel.BaseColor = (CurrentColor == Color.Red) ? Color.Red : Theme.Hex_To_RGB("#d3d3d3");
        }


        private void entry_TextChanged(object sender, EventArgs e)
        {
            if (SpecialChar != null) 
            {
                string fixedString = SpecialChar + " ";

                int cursorPosition = entry.SelectionStart;

                if (!entry.Text.StartsWith(fixedString))
                {
                    entry.Text = fixedString + entry.Text.TrimStart(fixedString.ToCharArray());

                    cursorPosition = fixedString.Length;
                }

                entry.SelectionStart = cursorPosition;
            }
        }

        private void PRIS_Label_Rich_Load(object sender, EventArgs e)
        {
            if (SpecialChar != null) 
            {
                string fixedString = SpecialChar + " ";

                if (!entry.Text.StartsWith(fixedString))
                {
                    entry.Text = fixedString + entry.Text.TrimStart(fixedString.ToCharArray());
                }

                entry.SelectionStart = fixedString.Length;
            }
        }


    }
}
