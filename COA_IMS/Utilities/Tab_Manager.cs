using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace COA_IMS.Utilities
{
    internal class Tab_Manager
    {

        private List<Control> Navigation_Buttons = new List<Control>();

        private List<object> Sub_Frames = new List<object>();
        public Control Header_Title { get; set; }
        
        private string selected_color { get; set; }
        private string unselected_color { get; set; }


        public Tab_Manager() 
        {
            this.selected_color = (!string.IsNullOrEmpty(selected_color)) ? selected_color : "#365486";
            this.unselected_color = (!string.IsNullOrEmpty(unselected_color)) ? unselected_color : "#1B303B";
        }

        public List<object> Sub_frames 
        { 
            get { return Sub_Frames; }
            set { Sub_Frames = value; }
        }
        public List<Control> Nav_buttons 
        {
            get { return Navigation_Buttons; }
            set { Navigation_Buttons = value; }
        }
        public void active_Button(GunaButton button, bool has_Title = false)
        {
            foreach (var buttons in Navigation_Buttons)
            {
                if (buttons.Name.Equals(button.Name))
                {
                    button.BackColor = Theme.Hex_To_RGB(selected_color);
                    if (has_Title)
                        change_Title(button.Tag.ToString().ToUpper());
                }
                else
                {
                    buttons.BackColor = Theme.Hex_To_RGB(unselected_color);
                }
            }
        }


        public void set_Colors(string selected_color = null, string unselected_color = null)
        { 
            this.selected_color = selected_color;
            this.unselected_color = unselected_color;
        }

        private void change_Title(string title) 
        { 
            Header_Title.Text = title;
        }

        public void set_Buttons(Control panel)
        {
            foreach (Control control in panel.Controls)
                if (control is GunaButton)
                    Nav_buttons.Add(control);
        }

        public Form switch_Form(Form form, Form current_Form, GunaPanel main_Panel)
        {

            //This function is repsonsible for switching forms.
            //form = the form to be displayed.
            //current_form = the currently displayed form.
            //main_Panel = is the panel on which the form should be attached.

            
            //If form is not active, hide the inactive form to allow current form to show.
            if (current_Form != null && current_Form != form)
                current_Form.Hide();

            //Allow the from to fill the main panel.
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;


            //Add the form to the main panel if the form does not a children of the main panel.
            if (!main_Panel.Controls.Contains(form))
                main_Panel.Controls.Add(form);

            //Show the form and set the current form. 
            form.Show();
            return form;


        }

        public Form switch_Form(Form form, Form current_Form, GunaElipsePanel main_Panel)
        {

            //This function is repsonsible for switching forms.
            //form = the form to be displayed.
            //current_form = the currently displayed form.
            //main_Panel = is the panel on which the form should be attached.


            //If form is not active, hide the inactive form to allow current form to show.
            if (current_Form != null && current_Form != form)
                current_Form.Hide();

            //Allow the from to fill the main panel.
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;


            //Add the form to the main panel if the form does not a children of the main panel.
            if (!main_Panel.Controls.Contains(form))
                main_Panel.Controls.Add(form);

            //Show the form and set the current form. 
            form.Show();
            return form;


        }
    }
}
