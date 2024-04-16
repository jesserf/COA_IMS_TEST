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
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
        }


        [Bindable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [Category("Appearance")]
        public override string Text
        {
            get { return search_box.Text; }
            set
            {
                if (search_box.Text != value)
                {
                    search_box.Text = value; this.Invalidate();
                    if (TextChanged != null)
                        TextChanged(this.search_box, EventArgs.Empty);
                }
            }
        }

        public void Ambatu(EventHandler eventHandler)
        {
            search_box.TextChanged += eventHandler;
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
        public new event EventHandler TextChanged;
    }
}
