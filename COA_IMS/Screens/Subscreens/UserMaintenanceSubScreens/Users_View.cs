using COA_IMS.UserControlUtil.PRIS_UserControl;
using COA_IMS.UserControlUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COA_IMS.Utilities;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COA_IMS.Screens.Subscreens.Users
{
    public partial class Users_View : Form
    {
        private Encryption_Manager Encryption_Manager = new Encryption_Manager();
        private Database_Manager Database_Manager = new Database_Manager();
        private Validator validator = new Validator();
        private Util util = new Util();
        private Audit_Trail audit_Trail;

        private PRIS_Label_Entry PRIS_Password;

        public Action RefreshTable;

        private bool is_ClosingProgrammatically = false;
        private string RecordCode;


        private Dictionary<string, string> InitialValues;
        public Users_View(string _code)
        {
            InitializeComponent();
            RecordCode = _code;
            InitializeControls();

            
        }

        private void InitializeControls()
        {
            util.SetControls(controls: PRISUserControls_Selection(), parent: account_Panel);
            util.SetControls(controls: PRISUserControls_Roles(), parent: content_Panel);

            PRIS_Password.Visible = false;
        }

        private void Users_View_Load(object sender, EventArgs e)
        {
            SetValues();
            validator.PRISReadOnly(parent_Panel, true);
        }
        private List<UserControl[]> PRISUserControls_Selection()
        {
            List<UserControl[]> control = new List<UserControl[]>
            {
                new UserControl[]
                {

                    new PRIS_Label_Entry(_title: "Employee Name :", _isRequired: false, _isReadOnly: true, _enabledText: false, _showMessage: false),
                    new PRIS_Label_Entry(_title: "Office :", _isRequired: false, _isReadOnly: true, _enabledText: false, _showMessage: false),
                    new PRIS_Label_Entry(_title: "Position :", _isRequired: false, _isReadOnly: true, _enabledText: false, _showMessage: false),
                    new PRIS_Label_Entry(_title: "Username :", _isRequired: true, _isReadOnly: true, _enabledText: false, _showMessage: false),
                    PRIS_Password = new PRIS_Label_Entry(_title: "Password :", _isRequired: false),
                    new PRIS_Label_Selector(_title:"Role :",
                            _searchQuery : Database_Query.get_role_search,
                            _query: Database_Query.get_user_role_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Role Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Role",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft),
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),},
                            _enabled: true, _read_Only: true, _isRequired: true, _showMessage: false),
                }
            };

            return control;
        }
        private List<UserControl[]> PRISUserControls_Roles()
        {
            List<UserControl[]> control = new List<UserControl[]>
            {
                new UserControl[]
                {
                    new PRIS_Label_MainCheckBox(_title: "Home", _isChecked: true, _isReadOnly: true, _enableCheck: false),

                    new PRIS_Label_MainCheckBox(_title: "Projects", _isChecked: false, _isReadOnly: true,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", true, true),("Update Records", false, true), }),

                    new PRIS_Label_MainCheckBox(_title: "Employee", _isChecked: false, _isReadOnly: true,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", true, true),("Update Records", false, true), }),

                    new PRIS_Label_MainCheckBox(_title: "Reports", _isChecked: false,_isReadOnly: true), 

                    new PRIS_Label_MainCheckBox(_title: "Maintenance", _isChecked: false,_isReadOnly: true,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", true, true),("Update Records", false, true), }),

                    new PRIS_Label_MainCheckBox(_title: "User Settings", _isChecked: false,_isReadOnly: true),

                    new PRIS_Label_MainCheckBox(_title: "Activity Logs", _isChecked: false, _isReadOnly : true),
                }
            };

            return control;
        }
        private void SetValues() 
        {
            var controls = util.SearchControls<UserControl>(account_Panel, new List<Type> { typeof(IPRIS_UserControl) });
            DataTable ret, name;
            InitialValues = new Dictionary<string, string>();

            using (Database_Manager)
            {
                ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_record, RecordCode));
                name = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_full_name_by_id, (string)ret.Rows[0][0]));
            }

            ((PRIS_Label_Entry)controls[0]).Value = (string)name.Rows[0][0];

            for (int retIndex = 1; retIndex < ret.Columns.Count; retIndex++) 
            {
                var pris = (IPRIS_UserControl)controls[retIndex];
                if (pris.IsVisible)
                {
                    pris.Value = (string)ret.Rows[0][retIndex];
                    InitialValues.Add(pris.Title,pris.Value);
                }
                else 
                {
                    InitialValues.Add(pris.Title, "");
                }

            }
            title.Text = (string)ret.Rows[0][0];
            var role = (PRIS_Label_Selector)controls[5];
            role.SelectionChanged += Set_RoleInfo;
            role.Value = (string)ret.Rows[0][4];
            Set_PrivilegeInfo();


        

        }
        private void Set_RoleInfo(object sender, EventArgs e)
        {
            var selector = (PRIS_Label_Selector)sender;
            var checkBoxes = util.SearchControls<UserControl>(content_Panel, new List<Type> { typeof(PRIS_Label_MainCheckBox) });

            DataTable ret, projects, employees, maintenance;

            var role_code = selector.Value;

            using (Database_Manager)
            {
                ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_role_access_by_id, role_code));

                projects = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_role_projects_by_id, role_code));
                employees = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_role_employee_by_id, role_code));
                maintenance = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_role_maintenance_by_id, role_code));
            }

            for (int entryIndex = 0; entryIndex < ret.Columns.Count; entryIndex++)
            {
                var pris = (PRIS_Label_MainCheckBox)checkBoxes[entryIndex];

                pris.Value = ret.Rows.Count == 0 ? null : ret.Rows[0][entryIndex].ToString();


                if (pris.HasBoxes && ret.Rows.Count != 0)
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


        private void Set_PrivilegeInfo()
        {
            var checkBoxes = util.SearchControls<UserControl>(content_Panel, new List<Type> { typeof(PRIS_Label_MainCheckBox) });

            DataTable ret, projects, employees, maintenance;

            using (Database_Manager)
            {
                ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_access_by_id, RecordCode));

                projects = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_project_access_by_id, RecordCode));
                employees = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_employee_access_by_id, RecordCode));
                maintenance = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_maintenance_access_by_id, RecordCode));
            }

            for (int entryIndex = 0; entryIndex < ret.Columns.Count; entryIndex++)
            {
                var pris = (PRIS_Label_MainCheckBox)checkBoxes[entryIndex];

                pris.Value = ret.Rows.Count == 0 ? null : ret.Rows[0][entryIndex].ToString();
                if (pris.HasBoxes && ret.Rows.Count != 0)
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

        private void Users_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_ClosingProgrammatically)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No;

                else if (e.CloseReason == CloseReason.WindowsShutDown)
                    Close();
            }
        }

        private void update_Role_Click(object sender, EventArgs e)
        {
            change_ViewControls(true);
            
            

        }


        private void change_ViewControls(bool is_Enabled = true)
        {

            PRIS_Password.Visible = is_Enabled;
            update_Btn.Enabled = !is_Enabled;
            delete_Btn.Enabled = !is_Enabled;

            this.bottom_Panel.Visible = is_Enabled;
            this.bottom_Panel.Enabled = is_Enabled;

            validator.PRISReadOnly(parent_Panel, !is_Enabled);
        }

        private void cancel_Btn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                change_ViewControls(false);
                SetValues();
            }
        }

        private async void save_Btn_Click(object sender, EventArgs e)
        {
            if (!validator.PRISRequired(parent_Panel, error_Provider))
                return;

            Dictionary<string, string> values = new Dictionary<string, string>();

            var PRISControls = util.SearchControls<UserControl>(parent_Panel, new List<Type> { typeof(IPRIS_UserControl) });
            string message = string.Empty;
            int ret = 0;

            if (MessageBox.Show("Are you sure you want to update?", "PRIS Update Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            foreach (IPRIS_UserControl pris in PRISControls)
            {
                if (pris is PRIS_Label_MainCheckBox)
                {
                    var checkbox = (PRIS_Label_MainCheckBox)pris;
                    if (checkbox.HasBoxes)
                    {
                        for (int checkIndex = 0; checkIndex < checkbox.BoxValues.Count; checkIndex++)
                        {
                            values.Add($"{checkbox.Title}_{checkbox.BoxTitle[checkIndex]}", checkbox.BoxValues[checkIndex] ? "1" : "0");
                        }
                    }
                }
                values.Add(pris.Title, pris.Value);
            }


            using (Database_Manager) 
            {
                if (!string.IsNullOrEmpty(PRIS_Password.Value))
                {
                    ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_password, Encryption_Manager.EncryptPassword(PRIS_Password.Value), values["Username"]));
                    
                }
                ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_role, values["Role"], values["Username"]));
                ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_access, values["Home"],
                                                                        values["Projects"], values["Projects_Add Records"], values["Projects_View Records"], values["Projects_Update Records"], "0",
                                                                        values["Employee"], values["Employee_Add Records"], values["Employee_View Records"], values["Employee_Update Records"], "0",
                                                                        values["Reports"], values["Maintenance"], values["Maintenance_Add Records"], values["Maintenance_View Records"], values["Maintenance_Update Records"], "0",
                                                                        values["User Settings"],
                                                                        values["Activity Logs"], values["Username"]));

                ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.update_user_trail, CurrentUser.user_name, RecordCode));


            }

            using (Database_Manager)
            {
                Database_Manager.ExecuteQuery(string.Format(Database_Query.log_maintenance_activity_add, CurrentUser.user_name, $"Updated Record : USERS {values["Username"]}"));
            }

            //Server
            await ServerManager.SendMessageToClientsAsync(values["Username"]);

            //Client
            //await ClientManager.SendMessageAsync(values["Username"]);

            if (ret != 0)
                MessageBox.Show($"{values["Username"]} is successfully updated.", "PRIS Record Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            else 
                MessageBox.Show($"{values["Username"]} record and password successfully updated.", "PRIS Record Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            is_ClosingProgrammatically = true;
            RefreshTable.Invoke();
            Close();

        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure to deactivate {title.Text} account?", "Deactivation Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                using (Database_Manager)
                    Database_Manager.ExecuteNonQuery(string.Format(Database_Query.delete_user_record_by_id, "user_info_table", title.Text));

                MessageBox.Show($"{title.Text} is successfully deactivated", "Deactivation Confirmation");
                is_ClosingProgrammatically = true;
                Close();
                RefreshTable?.Invoke();
            }
        }

        private void audit_Btn_Click(object sender, EventArgs e)
        {
            audit_Trail = new Audit_Trail(RecordCode, "user_info_table", customQuery: Database_Query.get_user_audit_trail);
            audit_Trail.ShowDialog();
        }
    }
}
