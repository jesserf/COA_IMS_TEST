using COA_IMS.UserControlUtil;
using COA_IMS.Utilities;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscreens.Employees
{
    public partial class Add_Employee : Form
    {
        private Database_Manager database_manager = new Database_Manager();
        private Validator validator = new Validator();
        private Util util = new Util();
        
        private bool is_ClosingProgrammatically = false;
        public event Action callback;

        private Dictionary<string, int> dropboxMapping = new Dictionary<string, int>
        {
            { "Sector", 1 },
            { "Office", 2 },
            { "Division", 3 },
            { "Section", 4 }
        };

        public Add_Employee()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void Add_Record_Load(object sender, EventArgs e)
        {
            emp_id.Text = util.generate_ID("emp_info_table");
        }

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
                    new Label_Drop("Sector :", Database_Query.get_sector_options, true),
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

        private void label_Drop_Callback(object sender, EventArgs e)
        {
            var currentDropbox = (Label_Drop)sender;
            if (!dropboxMapping.TryGetValue(currentDropbox.Title, out int num))
                return;

            var panel = control_Panel.Controls[1];
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
            int ret;
            if (!validator.Required_TextBox(control_Panel, error_Employee, error_Message))
                return;

            //if (MessageBox.Show("Proceed to add employee record?", "Employee Record Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
            //   return;

            var holder = new List<List<string>>();

            foreach (Control control in control_Panel.Controls)
            {
                var values = new List<string> { emp_id.Text };

                foreach (Control subControl in control.Controls)
                    values.Add(subControl.Text);

                holder.Add(values);
            }

            var entries = new List<List<string>> { holder[0].Concat(new List<string> { holder[1][4], holder[1][5], "admin" }).ToList() };

            using (database_manager)
                ret = database_manager.ExecuteNonQuery(util.generate_Query(entries, Database_Query.set_new_employee));
                
            
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

        private void Add_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_ClosingProgrammatically)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No;
                else if (e.CloseReason == CloseReason.WindowsShutDown)
                    Close();
            }
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            is_ClosingProgrammatically = false;
            Close();
        }
    }
}
