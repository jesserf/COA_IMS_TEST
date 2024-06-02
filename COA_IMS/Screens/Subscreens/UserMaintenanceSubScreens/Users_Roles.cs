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
    public partial class Users_Roles : Form
    {
        private Database_Manager Database_Manager = new Database_Manager();
        private Util Util = new Util();

        private Role_Create role_Create;
        private Role_View role_View;
        public Users_Roles()
        {
            InitializeComponent();
        }

        private void Users_Roles_Load(object sender, EventArgs e)
        {
            //ClientManager.MessageReceived += Network_Callback;
            ServerManager.MessageReceived += Network_Callback;

            (bool, int)[] column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 35), (true, 50)}; ;
            (string, DataGridViewContentAlignment)[] column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Role Code", DataGridViewContentAlignment.MiddleCenter),
                        ("Role",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft),
                    }; 
            DataTable ret;

            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(Database_Query.get_all_role_records);


            data_View.DataSource = Util.FormatDataTable(ret);
            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);

            PRIS_Seachbox.DropboxValues = null;
            PRIS_Seachbox.Search_Typed += Search_CallBack;

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

        private void Search_CallBack(object sender, EventArgs e) 
        {
            DataTable ret;

            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_role_all_search, PRIS_Seachbox.Search_Text));

            data_View.DataSource = Util.FormatDataTable(ret);
        }

        private void add_RecordBtn_Click(object sender, EventArgs e)
        {
            role_Create = new Role_Create();
            role_Create.RefreshTable += RefreshCallback;
            role_Create.ShowDialog();
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
                ret = Database_Manager.ExecuteQuery(Database_Query.get_all_role_records);

            data_View.DataSource = Util.FormatDataTable(ret);
        }

        private void view_RecordBtn_Click(object sender, EventArgs e)
        {
            role_View = new Role_View((string)data_View.Rows[data_View.CurrentRow.Index].Cells[1].Value);
            role_View.RefreshTable += RefreshCallback;
            role_View.ShowDialog();
        }
    }
}
