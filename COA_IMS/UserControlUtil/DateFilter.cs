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
    public partial class DateFilter : UserControl
    {
        public DateFilter()
        {
            InitializeComponent();
            from_DateTimePicker.Value = DateTime.Today;
            to_DateTimePicker.Value = DateTime.Today;
            from_DateTimePicker.MaxDate = DateTime.Today;
            to_DateTimePicker.MaxDate = DateTime.Today;
        }

        [Bindable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [Category("Appearance")]
        public DateTime fromValue
        {
            get { return from_DateTimePicker.Value; }
            set
            {
                if (from_DateTimePicker.Value != value)
                {
                    from_DateTimePicker.Value = value; this.Invalidate();
                    if (FromValueChanged != null)
                        FromValueChanged(this.from_DateTimePicker, EventArgs.Empty);
                }
            }
        }

        [Bindable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [Category("Appearance")]
        public DateTime toValue
        {
            get { return to_DateTimePicker.Value; }
            set
            {
                if (to_DateTimePicker.Value != value)
                {
                    to_DateTimePicker.Value = value; this.Invalidate();
                    if (ToValueChanged != null)
                        ToValueChanged(this.to_DateTimePicker, EventArgs.Empty);
                }
            }
        }

        public void Ambatu(EventHandler eventHandler)
        {
            from_DateTimePicker.ValueChanged += FromValueChanged;
            to_DateTimePicker.ValueChanged += ToValueChanged;
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
        public  event EventHandler FromValueChanged;
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
        public  event EventHandler ToValueChanged;
    }
}
