using System;
using System.Drawing;
using System.Windows.Forms;

namespace COA_IMS.UserControlUtil
{
    public partial class Label_Rich : UserControl
    {
        public override string Text
        {
            get { return this.richText.Text; }
            set { this.richText.Text = value; }
        }

        public Label_Rich(string _title)
        {
            InitializeComponent();
            this.title.Text = _title;
            this.richText.Tag = _title.Replace(":", "") ;
        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            this.Text = richText.Text;

            if (this.Text.Length == richText.MaxLength)
            {
                label_rich_error.SetError(richText, "Maximum characters reached.");
                richText.BorderColor = Color.Red;
            }
        }
    }
}
