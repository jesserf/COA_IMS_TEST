using COA_IMS.UserControlUtil;
using COA_IMS.UserControlUtil.PRIS_UserControl;
using COA_IMS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscreens.Users
{
    public partial class Users_Create : Form
    {
        private Encryption_Manager Encryption_Manger = new Encryption_Manager();
        private Database_Manager database_Manager = new Database_Manager();
        private Validator validator = new Validator();
        private Util util = new Util();

        private bool is_ClosingProgrammatically = false;

        public Action RefreshTable;
        public Users_Create()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            util.SetControls(controls: PRISUserControls_Selection(), parent: selection_Panel);
            util.SetControls(controls: PRISUserControls_Roles(), parent: content_Panel);

            var userInfo_Selectors = util.SearchControls<UserControl>(parent_Panel, new List<Type> { typeof(PRIS_Label_Selector) });
            foreach (PRIS_Label_Selector pris in userInfo_Selectors) 
                pris.SelectionChanged += Set_Info;
        }

        private void Set_Info(object sender, EventArgs e) 
        {
            var pris = (PRIS_Label_Selector)sender;

            switch (pris.Title) 
            {
                case "Employee Name":
                    Set_EmployeeInfo(pris.Value, pris.RawValue);
                    break;
                case "Role":
                    Set_RoleInfo(pris.Value);
                    break;
            }
        }
        private void Set_RoleInfo(string role_code) 
        {
            var checkBoxes = util.SearchControls<UserControl>(content_Panel, new List<Type> { typeof(PRIS_Label_MainCheckBox) });
             
            DataTable ret, projects, employees, maintenance;

            using (database_Manager) 
            {
                ret = database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_role_access_by_id, role_code));

                projects = database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_role_projects_by_id, role_code));
                employees = database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_role_employee_by_id, role_code));
                maintenance = database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_role_maintenance_by_id, role_code));
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
                        boxValue.Add(value.Rows[0][valueIndex].ToString() == "1" ? true : false );
                    pris.BoxValues = boxValue;
                }
            }

        }
        private void Set_EmployeeInfo(string user_code, string user_name) 
        {

            Random random = new Random();
            DataTable ret;
            
            var userInfo_Entry = util.SearchControls<UserControl>(left_Content_Panel, new List<Type> { typeof(PRIS_Label_Entry) });

            
            using (database_Manager)
                ret = database_Manager.ExecuteQuery(string.Format(Database_Query.get_employee_off_pos_by_id, user_code));

            for (int entryIndex = 0; entryIndex < ret.Columns.Count; entryIndex++)
                ((PRIS_Label_Entry)userInfo_Entry[entryIndex]).Value = ret.Rows.Count == 0 ? null : ret.Rows[0][entryIndex].ToString();
            
            if (!(user_code is null)) 
            {
                foreach (IPRIS_UserControl pris in userInfo_Entry)
                {
                    switch (pris.Title)
                    {
                        case "Username":
                            pris.Value = util.GenerateUserName(random,user_name);
                            break;
                        case "Password":
                            pris.Value = util.GeneratePassword(random, user_name);
                            break;
                    }
                }
            }
        
        }
        private List<UserControl[]> PRISUserControls_Selection()
        {
            List<UserControl[]> control = new List<UserControl[]>
            {
                new UserControl[]
                {
                    new PRIS_Label_Selector(_title:"Employee Name:",
                            _searchQuery : Database_Query.get_employee_search,
                            _query: Database_Query.get_free_employee_account_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Employee Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Employee Name",DataGridViewContentAlignment.MiddleLeft),
                                    ("Email",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),},
                            _enabled: true, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Entry(_title: "Office :", _isRequired: false, _isReadOnly: true, _showMessage: false),
                    new PRIS_Label_Entry(_title: "Position :", _isRequired: false, _isReadOnly: true, _showMessage: false),

                    new PRIS_Label_Entry(_title: "Username :", _isRequired: true, _isReadOnly: false),
                    new PRIS_Label_Entry(_title: "Password :", _isRequired: true, _isReadOnly: false),
                    new PRIS_Label_Selector(_title:"Role :",
                            _searchQuery : Database_Query.get_role_search,
                            _query: Database_Query.get_user_role_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Role Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Role",DataGridViewContentAlignment.MiddleLeft),
                                    ("Role",DataGridViewContentAlignment.MiddleLeft),
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),},
                            _enabled: true, _read_Only: false, _isRequired: true),

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
                    new PRIS_Label_MainCheckBox(_title: "Home", _isChecked: true, _isReadOnly: true),

                    new PRIS_Label_MainCheckBox(_title: "Projects", _isChecked: false, 
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", true, true),("Update Records", false, true), }),

                    new PRIS_Label_MainCheckBox(_title: "Employee", _isChecked: false,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", true, true),("Update Records", false, true), }),
                    
                    new PRIS_Label_MainCheckBox(_title: "Reports", _isChecked: false),

                    new PRIS_Label_MainCheckBox(_title: "Maintenance", _isChecked: false,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", true, true),("Update Records", false, true), }),

                    new PRIS_Label_MainCheckBox(_title: "User Settings", _isChecked: false),

                    new PRIS_Label_MainCheckBox(_title: "Activity Logs", _isChecked: false),
                }
            };

            return control;
        }

        
        private async void create_Btn_Click(object sender, EventArgs e)
        {
            if (!validator.PRISRequired(parent_Panel, error_Provider))
                return;

            Dictionary<string, string> values = new Dictionary<string, string>();
            
            var PRISControls = util.SearchControls<UserControl>(parent_Panel, new List<Type> { typeof(IPRIS_UserControl) });
            int ret = 0;


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

            using (database_Manager)
            {
                ret += database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_user_cred, values["Username"], Encryption_Manger.EncryptPassword(values["Password"])));
                ret += database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_user_info, values["Username"], values["Employee Name"], values["Role"], CurrentUser.user_name));
                ret += database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_user_access, values["Username"], values["Home"],
                                                                            values["Projects"], values["Projects_Add Records"], values["Projects_View Records"], values["Projects_Update Records"], "0",
                                                                            values["Employee"], values["Employee_Add Records"], values["Employee_View Records"], values["Employee_Update Records"], "0",
                                                                            values["Reports"], values["Maintenance"], values["Maintenance_Add Records"], values["Maintenance_View Records"], values["Maintenance_Update Records"], "0",
                                                                            values["User Settings"], values["Activity Logs"]));
            }

            if (ret == 3) 
            {

                using (database_Manager)
                {
                    database_Manager.ExecuteQuery(string.Format(Database_Query.log_maintenance_activity_add, CurrentUser.user_name, $"Created Record : USERS {values["Username"]}"));
                }

                //Server
                await ServerManager.SendMessageToClientsAsync(values["Username"]);

                //Client
                //await ClientManager.SendMessageAsync(values["Username"]);


                MessageBox.Show($"{values["Username"]} is successfully added.", "PRIS Record Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                is_ClosingProgrammatically = true;
                RefreshTable.Invoke();
                Close();
            }


        }

        private void refresh_Btn_Click(object sender, EventArgs e)
        {
            Reset_Controls();
        }
        private void Reset_Controls() 
        {
            var controls = util.SearchControls<UserControl>(parent_Panel, new List<Type> { typeof(IPRIS_UserControl) });

            foreach (IPRIS_UserControl con in controls)
                con.Value = null;

            validator.PRISClearErrors(parent_Panel, error_Provider);
        }

        private void Users_Create_FormClosing(object sender, FormClosingEventArgs e)
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
