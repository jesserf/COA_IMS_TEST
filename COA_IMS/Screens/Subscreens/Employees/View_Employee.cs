using COA_IMS.UserControlUtil;
using COA_IMS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace COA_IMS.Screens.Subscreens.Employees
{
    public partial class View_Employee : Form
    {
        private Validator validator = new Validator();
        private Database_Manager database_manager = new Database_Manager();
        private Util util = new Util();

        private bool is_ClosingProgrammatically = false;
        public event Action callback;
        private string Record_ID
        {
            get { return emp_id.Text; }
            set { emp_id.Text = value;}
        }
        public View_Employee(string record_ID)
        {
            InitializeComponent();
            InitializeControls();
            Record_ID = record_ID;
            validator.readOnly_Controls(control_Panel, false);
        }

        private void View_Employee_Load(object sender, EventArgs e)
        {
            SetValues();    
        }
        private void SetValues() 
        {
            DataTable ret;
            using (database_manager)
                ret = database_manager.ExecuteQuery(string.Format(Database_Query.get_employee_record_by_id, this.Record_ID));


            var user_control = validator.search_Controls<UserControl>(control_Panel, new List<Type> { typeof(Label_Text), typeof(Label_Drop) });

            for (int row_Index = 0; row_Index < ret.Columns.Count; row_Index++)
            {
                if (user_control[row_Index] is Label_Text label_Text)
                    label_Text.Text = ret.Rows[0][row_Index].ToString();

                else if (user_control[row_Index] is Label_Drop label_Drop)
                    label_Drop.Text = ret.Rows[0][row_Index].ToString();

            }
        }

        private Dictionary<string, int> dropboxMapping = new Dictionary<string, int>
        {
            { "Sector", 1 },
            { "Office", 2 },
            { "Division", 3 },
            { "Section", 4 }
        };

        private void InitializeControls()
        {
            var controls = new List<UserControl[]>
            {
                new UserControl[]
                {
                    new Label_Text("Full Name :"),
                    new Label_Text("Email :"),
                    new Label_Text("Contact Number :")
                },
                new UserControl[]
                {
                    new Label_Drop("Sector :", Database_Query.get_sector_options, false),
                    new Label_Drop("Office :", Database_Query.get_office_options, false),
                    new Label_Drop("Division :", Database_Query.get_division_options, false),
                    new Label_Drop("Section :", Database_Query.get_section_option, false),
                    new Label_Drop("Position :", Database_Query.get_position_options, false)
                }
            };

            for (int i = 0; i < controls.Count; i++)
            {
                var panel = new FlowLayoutPanel
                {
                    Size = new Size(control_Panel.Width / 2, control_Panel.Height),
                    Margin = Padding.Empty
                };

                control_Panel.Controls.Add(panel);

                foreach (var control in controls[i])
                {
                    panel.Controls.Add(control);
                    control.Width = panel.Width;

                    if (control is Label_Drop labelDrop)
                        labelDrop.DropboxChanged += label_Drop_Callback;
                }
            }
        }

        private void update_Btn_Click(object sender, EventArgs e)
        {
            change_ViewControls(true);
            var panel = control_Panel.Controls[1];
            for (int con_Index = 0; con_Index < panel.Controls.Count; con_Index++)
            {
                Label_Drop label_drop = panel.Controls[con_Index] as Label_Drop;
                label_drop.Enable_Info = true;
                label_drop.Info_Message = $"Curr: {label_drop.Value}";

                if (con_Index >= 1)
                    label_drop.Enabled_Dropbox = false;
                
                

            }


        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { 
                
                change_ViewControls(false); 

                SetValues();

                var panel = control_Panel.Controls[1];
                for (int con_Index = 0; con_Index < panel.Controls.Count; con_Index++)
                {
                    Label_Drop label_drop = panel.Controls[con_Index] as Label_Drop;
                    label_drop.Enable_Info = false;


                }
            }
        }



        private void change_ViewControls(bool is_Enabled = true)
        {
            validator.readOnly_Controls(control_Panel, is_Enabled);

            update_Btn.Enabled = !is_Enabled;
            delete_Btn.Enabled = !is_Enabled;

            bottom_Panel.Visible = is_Enabled;
            bottom_Panel.Enabled = is_Enabled;

        }

        private void label_Drop_Callback(object sender, EventArgs e)
        {
            var currentDropbox = (Label_Drop)sender;
            var panel = control_Panel.Controls[1];

            if (!dropboxMapping.TryGetValue(currentDropbox.Title, out int num))
                return;

            
            var nextDropbox = (Label_Drop)panel.Controls[num];

            switch (currentDropbox.Title)
            {
                case "Sector":
                    nextDropbox.Option_Query = string.Format(Database_Query.get_office_options_by_id, currentDropbox.Text);
                    break;
                case "Office":
                    nextDropbox.Option_Query = string.Format(Database_Query.get_division_options_by_id, currentDropbox.Text);
                    break;
                case "Division":
                    nextDropbox.Option_Query = string.Format(Database_Query.get_section_options_by_id, currentDropbox.Text);
                    break;
            }

            nextDropbox.Enabled_Dropbox = !string.Equals(currentDropbox.Text, "null");
            if (!nextDropbox.Enabled_Dropbox)
            {
                for (int i = num; i < panel.Controls.Count; i++)
                {
                    if (panel.Controls[i] is Label_Drop dropbox)
                        dropbox.Enabled_Dropbox = false;
                }
            }

        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            int ret = 0;
            if (!validator.Required_TextBox(control_Panel, error_View, error_Message))
                return;

            if (MessageBox.Show("Proceed to update employee record?", "Employee Record Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
               return;

            var holder = new List<List<string>>();

            foreach (Control control in control_Panel.Controls)
            {
                var values = new List<string> {};

                foreach (Control subControl in control.Controls)
                    values.Add(subControl.Text);

                holder.Add(values);
            }

            var entries = new List<List<string>> { holder[0].Concat(new List<string> { holder[1][3], holder[1][4], "admin" , emp_id.Text }).ToList() };

            using (database_manager)
                ret = database_manager.ExecuteNonQuery(util.generate_Query(entries, Database_Query.update_employee_record_by_id));

                if (ret == 1)
            {
                if (MessageBox.Show($"{emp_id.Text} is successfully added.", "New Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    is_ClosingProgrammatically = true;
                    callback?.Invoke();
                    Close();
                }
            }
        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure to delete {emp_id.Text}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                using (database_manager)
                    database_manager.ExecuteNonQuery(string.Format(Database_Query.delete_record_by_id, "emp_info_table", this.Record_ID));

                MessageBox.Show($"{emp_id.Text} is successfully deleted", "Delete Confirmation");
                is_ClosingProgrammatically = true;
                Close();
                callback?.Invoke();
            }
        }
    }
}
