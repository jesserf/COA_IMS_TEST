using COA_IMS.UserControlUtil.PRIS_UserControl;
using COA_IMS.Utilities;
using MySqlX.XDevAPI.Relational;
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

namespace COA_IMS.Screens.Subscreens.Users
{
    public partial class Role_View : Form
    {
        private Database_Manager Database_Manager = new Database_Manager();
        private Validator validator = new Validator();
        private Util util = new Util();

        private string RoleCode;
        private bool is_ClosingProgrammatically = false;

        public Action RefreshTable;
        private Audit_Trail Audit_Trail;

        private int status = 0;
        public Role_View(string _roleCode)
        {
            InitializeComponent();
            RoleCode = _roleCode;
            InitializeControls();

            using (Database_Manager)
            {
                status = Convert.ToInt32(Database_Manager.ExecuteScalar(string.Format(Database_Query.get_record_status, "user_role_table", RoleCode)));
            }

            delete_Btn.Enabled = (status == -1 || status == -2) ? false : true;
            //update_Btn.Enabled = status == -2 ? false : true;
        }

        private void Role_View_Load(object sender, EventArgs e)
        {

            SetRecord();

        }

        private void SetRecord()
        {
            validator.PRISReadOnly(_parent: content_Panel, true);
            
            var controls = util.SearchControls<UserControl>(content_Panel, new List<Type>() { typeof(IPRIS_UserControl) });
            DataTable ret, roles, projects, employees, maintenance;

            using (Database_Manager)
            {
                ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_role_record, RoleCode));
                roles = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_role_access_record, RoleCode));

                projects = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_projects_access_record, RoleCode));
                employees = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_employee_access_record, RoleCode));
                maintenance = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_maintenance_access_record, RoleCode));
            }

            for (int retIndex = 0; retIndex < ret.Columns.Count; retIndex++)
            {
                if (controls[retIndex] is PRIS_Label_Entry || controls[retIndex] is PRIS_Label_Rich)
                    ((IPRIS_UserControl)controls[retIndex]).Value = (string)ret.Rows[0][retIndex];
                
            }
           
            for (int roleIndex = 0; roleIndex < roles.Columns.Count; roleIndex++) 
            {
                if (controls[roleIndex + 2] is PRIS_Label_MainCheckBox)
                {
                    var pris = (PRIS_Label_MainCheckBox)controls[roleIndex + 2];
                    pris.Value = roles.Rows.Count == 0 ? null : roles.Rows[0][roleIndex].ToString();

                    if (pris.HasBoxes && roles.Rows.Count != 0)
                    {
                        DataTable value = null;
                        List<bool> boxValue = new List<bool>();
                        switch (pris.Title)
                        {
                            case "Projects":
                                value = projects;
                                break;
                            case "Employee":
                                value = employees;
                                break;
                            case "Maintenance":
                                value = maintenance;
                                break;
                        }
                        for (int valueIndex = 0; valueIndex < value.Columns.Count; valueIndex++)
                            boxValue.Add(value.Rows[0][valueIndex].ToString() == "1" ? true : false);
                        pris.BoxValues = boxValue;
                    }
                }
            }
        }

        private void InitializeControls()
        {
            util.SetControls(controls: PRIS_Info(), parent: content_Panel);
            this.title.Text = RoleCode;

        }

        private List<UserControl[]> PRIS_Info()
        {
            List<UserControl[]> control = new List<UserControl[]>
            {
                new UserControl[]
                {
                    new PRIS_Label_Entry(_title: "Role Title: ", _isRequired: true),
                    new PRIS_Label_Rich(_title: "Description: ", _isRequired: false,_entryHeight:250)
                },
                new UserControl[]
                {
                    new PRIS_Label_MainCheckBox(_title: "Home", _isChecked: true, _isReadOnly: true),
                    new PRIS_Label_MainCheckBox(_title: "Projects", _isChecked: false,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", false, true),("Update Records", false, true), }),
                    new PRIS_Label_MainCheckBox(_title: "Employee", _isChecked: false,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", false, true),("Update Records", false, true), }),
                    new PRIS_Label_MainCheckBox(_title: "Reports", _isChecked: false),
                    new PRIS_Label_MainCheckBox(_title: "Maintenance", _isChecked: false,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", false, true),("Update Records", false, true), }),
                    new PRIS_Label_MainCheckBox(_title: "User Settings", _isChecked: false),
                    new PRIS_Label_MainCheckBox(_title: "Activity Logs", _isChecked: false),
                }
            };

            return control;

        }

        private void update_Role_Click(object sender, EventArgs e)
        {
            change_ViewControls(true);
        }

        private void change_ViewControls(bool is_Enabled = true)
        {
            validator.PRISReadOnly(content_Panel, !is_Enabled);

            update_Btn.Enabled = !is_Enabled;
            delete_Btn.Enabled = !is_Enabled;

            this.save_Btn.Visible = is_Enabled;
            this.cancel_Btn.Visible = is_Enabled;

        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                change_ViewControls(false);
                SetRecord();
            }
        }

        private async void create_Btn_Click(object sender, EventArgs e)
        {
            if (!validator.PRISRequired(container_Panel, errorProvider))
                return;

            int ret = 0;
            Dictionary<string, string> values = new Dictionary<string, string>();

            var controls = util.SearchControls<UserControl>(parent: container_Panel, new List<Type>() { typeof(IPRIS_UserControl) });

            foreach ( IPRIS_UserControl pris in controls )
            {
                if(pris is PRIS_Label_MainCheckBox)
                {
                    var checkbox = (PRIS_Label_MainCheckBox)pris;
                    if (checkbox.HasBoxes)
                        for (int checkIndex = 0; checkIndex < checkbox.BoxValues.Count; checkIndex++)
                            values.Add($"{checkbox.Title}_{checkbox.BoxTitle[checkIndex]}", checkbox.BoxValues[checkIndex] ? "1" : "0");
                        
                }
                //Console.WriteLine($"{pris.Title} {pris.Value}");
                values.Add(pris.Title, pris.Value);
            }

            using (Database_Manager) 
            {
                ret = Database_Manager.ExecuteNonQuery(string.Format(Database_Query.update_role_access, values["Role Title"], values["Description"],
                                                                                values["Home"],
                                                                                values["Projects"], values["Projects_Add Records"], values["Projects_View Records"], values["Projects_Update Records"], "0",
                                                                                values["Employee"], values["Employee_Add Records"], values["Employee_View Records"], values["Employee_Update Records"], "0",
                                                                                values["Reports"],
                                                                                values["Maintenance"], values["Maintenance_Add Records"], values["Maintenance_View Records"], values["Maintenance_Update Records"], "0",
                                                                                values["User Settings"],
                                                                                values["Activity Logs"],
                                                                                CurrentUser.user_name, RoleCode));
            }

            if (ret == 1) 
            {

                using (Database_Manager)
                {
                    string code_type = Database_Manager.ExecuteScalar(string.Format(Database_Query.return_module_name, "user_role_table")).ToString();
                    //make activity log
                    Database_Manager.ExecuteQuery(string.Format(Database_Query.log_maintenance_activity_add, CurrentUser.user_name, $"Updated Record : {code_type} {RoleCode}"));
                }

                //Server
                await ServerManager.SendMessageToClientsAsync(values["Role Title"]);

                //Client
                //await ClientManager.SendMessageAsync(values["Role Title"]);

                MessageBox.Show($"{values["Role Title"]} successfully updated.", "PRIS Record Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                is_ClosingProgrammatically = true;
                RefreshTable?.Invoke();
                Close();


            }
        }

        private void Role_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_ClosingProgrammatically)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No;

                else if (e.CloseReason == CloseReason.WindowsShutDown)
                    Close();
            }
        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure to delete {title.Text}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {    
                using (Database_Manager)
                    Database_Manager.ExecuteNonQuery(string.Format(Database_Query.delete_record_by_id, "user_role_table", title.Text));
                
                MessageBox.Show($"{title.Text} is successfully deleted", "Delete Confirmation");
                is_ClosingProgrammatically = true;
                RefreshTable?.Invoke();
                Close();
            }
        }

        private void audit_Trail_Btn_Click(object sender, EventArgs e)
        {
            Audit_Trail = new Audit_Trail(RoleCode, "user_role_table");
            Audit_Trail.ShowDialog();
        }
    }
}
