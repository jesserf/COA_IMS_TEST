using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using COA_IMS.UserControlUtil;
using COA_IMS.Utilities;
using COA_IMS.Screens;

namespace COA_IMS.Screens.Subscreens.Maintenance
{
    public partial class Add_Record : Form
    {
        private readonly Database_Manager database_Manager = new Database_Manager();
        private readonly Validator validator = new Validator();
        private readonly Util util = new Util();
        //temporary active account
        private readonly string active_account = "admin";

        private string Insert_Query { get; }
        private string Table { get; }

        private bool is_ClosingProgrammatically = false;

        public event Action callback;

        public Add_Record(UserControl[] controls, string insertQuery, string table)
        {
            InitializeComponent();
            InitializeControls(controls);

            Insert_Query = insertQuery;
            Table = table;
        }

        private void Add_Agency_Load(object sender, EventArgs e)
        {
            code_Title.Text = util.generate_ID(Table);
        }

        private void InitializeControls(UserControl[] controls)
        {
            foreach (var control in controls)
            {
                control_Panel.Controls.Add(control);
                control.Size = new Size(control_Panel.Width-8, control.Height);
            }
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            int ret = 0;
            if (validator.Required_TextBox(control_Panel, error_provider, error_Message))
            {

                // Adds the required values inside of a list.
                var values = new List<string> { code_Title.Text };

                // Loops through the controls and add its value to the  list.
                foreach (Control control in control_Panel.Controls)
                    values.Add(control.Text?.Trim() ?? "");

                // Adds the active account
                values.Add("james");

                
                var entries = new List<List<string>> { values };

                using (database_Manager) 
                    ret = database_Manager.ExecuteNonQuery(util.generate_Query(entries, Insert_Query));

            }

            if (ret == 1) 
            {
                Console.WriteLine(Table);
                Console.WriteLine(string.Format(Database_Query.return_module_name, Table));
                string code_type = database_Manager.ExecuteScalar(string.Format(Database_Query.return_module_name, Table)).ToString();
                //make activity log
                database_Manager.ExecuteQuery(string.Format(Database_Query.log_maintenance_activity, active_account, code_type, code_Title.Text));
                if (MessageBox.Show($"{code_Title.Text} is successfully added.", "New Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    is_ClosingProgrammatically = true; 
                    Close();
                    callback?.Invoke();
                }
            }
            
        }

        private void Add_Record_FormClosing(object sender, FormClosingEventArgs e)
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