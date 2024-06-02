using COA_IMS.Utilities;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscreens.Users
{
    public partial class Users_Lists : Form
    {
        private Database_Manager Database_Manager = new Database_Manager();
        private Util util = new Util();

        private Users_Create Users_Create;
        private Users_View Users_View;
        

        public Action ToCreate;
        public Users_Lists()
        {
            InitializeComponent();
            
        }
        private void Users_Lists_Load(object sender, EventArgs e)
        {

            //ClientManager.MessageReceived += Network_Callback;
            ServerManager.MessageReceived += Network_Callback;

            Set_Record();

            PRIS_Seachbox.DropboxValues = new List<string>() { "All", "Code", "Full Name", "Office", "Position", "Role" };
            PRIS_Seachbox.Search_Typed += SearchBar_CallBack;

        }

        private async void Network_Callback(object sender, string message)
        {

            Console.WriteLine(message);
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate { Refresh_Table(); });
            else
                Refresh_Table();

            //Server
            await ServerManager.SendMessageToClientsAsync("Reset Clients");
        }

        private void add_RecordBtn_Click(object sender, EventArgs e)
        {
            Users_Create = new Users_Create();
            Users_Create.RefreshTable += RefreshCallback;
            Users_Create.ShowDialog();
        }

        private void Set_Record() 
        {
            (bool, int)[] column_Widths = new (bool, int)[] { (true, 3), (true, 15), (true, 30), (true, 20), (true, 20), (true, 12) }; ;
            (string, DataGridViewContentAlignment)[] column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Employee Code", DataGridViewContentAlignment.MiddleCenter),
                        ("Full Name",DataGridViewContentAlignment.MiddleLeft),
                        ("Office",DataGridViewContentAlignment.MiddleLeft),
                        ("Position", DataGridViewContentAlignment.MiddleLeft),
                        ("Role", DataGridViewContentAlignment.MiddleLeft)
                    }; ;

            DataTable ret;

            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(Database_Query.get_all_active_user);


            data_View.DataSource = util.FormatDataTable(ret);
            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }
        private void SearchBar_CallBack(object sender, EventArgs e) 
        {
            DataTable ret = null;
            using (Database_Manager)
            {
                switch (PRIS_Seachbox.Dropbox_Text)
                {
                    case "All":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_users_all_search, PRIS_Seachbox.Search_Text));
                        break;
                    case "Code":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_users_code_search, PRIS_Seachbox.Search_Text));
                        break;
                    case "Full Name":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_users_name_search, PRIS_Seachbox.Search_Text));
                        break;
                    case "Office":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_users_office_search, PRIS_Seachbox.Search_Text));
                        break;
                    case "Position":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_users_position_search, PRIS_Seachbox.Search_Text));
                        break;
                    case "Role":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_users_role_search, PRIS_Seachbox.Search_Text));
                        break;
                }
            }
            data_View.DataSource = util.FormatDataTable(ret);

        }

        private void refresh_Btn_Click(object sender, EventArgs e)
        {
            Refresh_Table();
        }

        public void RefreshCallback()
        {
            Refresh_Table();
        }
        private void Refresh_Table() 
        {
            DataTable ret;

            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(Database_Query.get_all_active_user);

            data_View.DataSource = util.FormatDataTable(ret);
        }

        private void view_RecordBtn_Click(object sender, EventArgs e)
        {
            string record_code = (string)data_View.Rows[data_View.CurrentRow.Index].Cells[1].Value;

            Users_View = new Users_View(_code: record_code);
            Users_View.RefreshTable += RefreshCallback;
            Users_View.ShowDialog();
        }
    }
}
