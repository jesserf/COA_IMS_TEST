using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Mysqlx;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace COA_IMS.Utilities
{
    internal class Validator
    {

        public Validator()
        {
        }

        public List<T> search_Controls<T>(Control parent, List<Type> types) where T : Control
        {
            List<T> ret_Controls = new List<T>();
            Queue<Control> q_control = new Queue<Control>();

            q_control.Enqueue(parent);

            while (q_control.Count > 0)
            {
                Control con = q_control.Dequeue();

                foreach (Type type in types)
                {
                    if (type.IsAssignableFrom(con.GetType()))
                    {
                        ret_Controls.Add((T)con);
                        break;
                    }
                }

                if (con.HasChildren)
                {
                    foreach (Control child_Control in con.Controls)
                        q_control.Enqueue(child_Control);
                }
            }

            return ret_Controls;
        }
        public bool Required_TextBox(Control parent, ErrorProvider error, GunaLabel error_Label = null)
        {
            List<Control> guna_TextBox = search_Controls<Control>(parent, new List<Type> {typeof(GunaTextBox)});

            bool is_Required = true; 

            foreach (GunaTextBox text_Box in guna_TextBox) 
            {
                if (string.IsNullOrWhiteSpace(text_Box.Text))
                {
                    error.SetError(text_Box, $"{text_Box.Tag} is required.");
                    text_Box.BorderColor = Color.Red;
                    is_Required = false;
                    if (error_Label != null)
                    {
                        error_Label.Text = "Fill the required fields.";
                        error_Label.Visible = true;
                    }
                }
                else
                {
                    text_Box.BorderColor = Color.Silver; 
                }
            }

            return is_Required;
        }

        public bool Required_TextBox(List<GunaTextBox> textBox, ErrorProvider error) 
        {
            bool is_Required = true;

            foreach (GunaTextBox text_Box in textBox)
            {
                if (string.IsNullOrWhiteSpace(text_Box.Text))
                {
                    error.SetError(text_Box, $"{text_Box.Tag} is required.");
                    text_Box.BorderColor = Color.Red;
                    is_Required = false;
                }
                else
                {
                    text_Box.BorderColor = Color.Silver;
                }
            }
            return is_Required;


        }

        public void readOnly_Controls( Control parent, bool is_Enabled = false) 
        {
            List<Control> controls = search_Controls<Control>(parent, new List<Type> { typeof(GunaTextBox), typeof(GunaComboBox)});

            foreach (Control control in controls) 
            {
                if (control is GunaTextBox)
                {  
                    GunaTextBox textBox = (GunaTextBox)control;
                    textBox.ReadOnly = !is_Enabled;
                }
                else if (control is GunaComboBox) 
                { 
                    GunaComboBox comboBox = (GunaComboBox)control;
                    comboBox.Enabled = is_Enabled;
                }
            }
            
        }
    }
}
