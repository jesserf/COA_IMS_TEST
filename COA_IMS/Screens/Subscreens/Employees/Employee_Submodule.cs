using COA_IMS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscreens.Employees
{
    public partial class Employee_Submodule : Form
    {
        private Database_Manager database_manager = new Database_Manager();
        private Theme theme = new Theme();
        private Util util = new Util();

        private Add_Employee add_Employee;
        private View_Employee view_Employee;
        public Employee_Submodule()
        {
            InitializeComponent();
            
        }

        private void add_RecordBtn_Click(object sender, EventArgs e)
        {
            add_Employee = new Add_Employee();
            add_Employee.callback += refresh_Callback;
            add_Employee.ShowDialog();
            
        }

        private void Employee_Submodule_Load(object sender, EventArgs e)
        {
            (bool, int)[] column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 35), (true, 20), (true, 20), (true, 10) }; ;
            (string, DataGridViewContentAlignment)[] column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Employee Code", DataGridViewContentAlignment.MiddleCenter),
                        ("Full Name",DataGridViewContentAlignment.MiddleLeft),
                        ("Office",DataGridViewContentAlignment.MiddleLeft),
                        ("Position", DataGridViewContentAlignment.MiddleLeft),
                        ("Status", DataGridViewContentAlignment.MiddleLeft)
                    }; ;
            database_manager = new Database_Manager();
            DataTable dt = new DataTable();

            using (database_manager)
                dt = database_manager.ExecuteQuery(Database_Query.get_employee_records);


            data_View.DataSource = util.format_DataTable(dt);
            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }

        private void refresh_Btn_Click(object sender, EventArgs e)
        {
            refresh_Table();
        }
        private void refresh_Callback() 
        {
            refresh_Table();
        }
        private void refresh_Table() 
        {
            DataTable dt = new DataTable();

            using (database_manager)
                dt = database_manager.ExecuteQuery(Database_Query.get_employee_records);

            data_View.DataSource = util.format_DataTable(dt);
        }

        private void view_RecordBtn_Click(object sender, EventArgs e)
        {
            string record_code = (string)data_View.Rows[data_View.CurrentRow.Index].Cells[1].Value;

            view_Employee = new View_Employee(record_code);
            view_Employee.callback += refresh_Callback;
            view_Employee.ShowDialog();
        }
    }
}
