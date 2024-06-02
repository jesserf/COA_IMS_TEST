using COA_IMS.UserControlUtil.PRIS_UserControl;
using COA_IMS.Utilities;
using Mysqlx.Crud;
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
    public partial class Role_Create : Form
    {
        private Encryption_Manager Encryption_Manger = new Encryption_Manager();
        private Database_Manager Database_Manager = new Database_Manager();
        private Validator validator = new Validator();
        private Util util = new Util();


        private bool is_ClosingProgrammatically = false;
        public Action RefreshTable;

        public Role_Create()
        {
            InitializeComponent();
            InitializeControls();
        }
        private void Role_Create_Load(object sender, EventArgs e)
        {
            id_Text.Text = util.GenarateUID("user_role_table");
        }

        private void InitializeControls() 
        {
            util.SetControls(controls: PRIS_Info(), parent: content_Panel);


        }

        private List<UserControl[]> PRIS_Info() 
        {
            List<UserControl[]> control = new List<UserControl[]>
            {
                new UserControl[]
                {
                    new PRIS_Label_Entry(_title: "Role Title: ", _isRequired: true),
                    new PRIS_Label_Rich(_title: "Description: ", _isRequired: false, _entryHeight:250)
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
        /*private List<UserControl[]> PRIS_Role()
        {
            List<UserControl[]> control = new List<UserControl[]>
            {
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
*/
        private void Role_Create_FormClosing(object sender, FormClosingEventArgs e)
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

        private async void create_Btn_Click(object sender, EventArgs e)
        {
            if (!validator.PRISRequired(content_Panel, errorProvider))
               return;

            Dictionary<string, string> values = new Dictionary<string, string>();

            var PRISControls = util.SearchControls<UserControl>(content_Panel, new List<Type> { typeof(IPRIS_UserControl) });
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

            using (Database_Manager)
                ret = Database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_role_access,
                                                                                id_Text.Text, values["Role Title"], values["Description"],
                                                                                values["Home"],
                                                                                values["Projects"], values["Projects_Add Records"], values["Projects_View Records"], values["Projects_Update Records"], "0",
                                                                                values["Employee"], values["Employee_Add Records"], values["Employee_View Records"], values["Employee_Update Records"], "0",
                                                                                values["Reports"],
                                                                                values["Maintenance"], values["Maintenance_Add Records"], values["Maintenance_View Records"], values["Maintenance_Update Records"], "0",
                                                                                values["User Settings"],
                                                                                values["Activity Logs"],
                                                                                CurrentUser.user_name));

            if (ret == 1) 
            {
                using (Database_Manager)
                {
                    string code_type = Database_Manager.ExecuteScalar(string.Format(Database_Query.return_module_name, "user_role_table")).ToString();
                    //make activity log
                    Database_Manager.ExecuteQuery(string.Format(Database_Query.log_maintenance_activity_add, CurrentUser.user_name, $"Created Record : {code_type} {id_Text.Text}"));
                }


                //Server
                await ServerManager.SendMessageToClientsAsync(values["Role Title"]);

                //Client
                //await ClientManager.SendMessageAsync(values["Role Title"]);


                MessageBox.Show($"{values["Role Title"]} is successfully added.", "PRIS Record Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                is_ClosingProgrammatically = true;
                RefreshTable.Invoke();
                Close();
            }

            






        }

    }
}
