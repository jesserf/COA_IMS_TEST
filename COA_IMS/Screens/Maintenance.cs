using COA_IMS.Screens.Subscreens.Maintenance;
using COA_IMS.UserControlUtil;
using COA_IMS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens
{
    public partial class Maintenance : Form
    {
        private Database_Manager database_Manager;
        private Tab_Manager tab_Manager;
        private Add_Record Add_Record;
        private View_Record View_Record;
        private Util util;

        private string Query { get; set; }
        private string Active_Form { get; set; }
        private Control[] controls;

        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            database_Manager = new Database_Manager();
            tab_Manager = new Tab_Manager();
            util = new Util(); 


            tab_Manager.set_Buttons(nav_panel);
            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_Button(agency_Btn, false);
            tab_Manager.Header_Title = title_label;

            controls = new Control[] { search_Panel, add_Btn, view_Btn, delete_Btn };

            agency_Btn.PerformClick();
        }

        private void button_Click(object sender, EventArgs e)
        { 
            var button = (GunaButton)sender;
            bool[] buttons = null;
            (bool, int)[] column_Widths = null;
            (string, DataGridViewContentAlignment)[] column_Text_Align = null;

            switch (button.Tag) 
            {
                case "Agency":
                    Query = Database_Query.get_all_agency_records;
                    buttons = new bool[] { true, true, true, true };

                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 40), (true, 25), (true, 20) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Agency Code", DataGridViewContentAlignment.MiddleCenter),
                        ("Agency ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft),
                        ("Cluster", DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Cluster":
                    Query = Database_Query.get_all_cluster_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[]{ (true, 3), (true, 12), (true, 40), (true, 25), (true, 20) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Cluster Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Cluster ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft),
                        ("Sector", DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Contractor":
                    Query = Database_Query.get_all_contractor_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 50), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Contractor Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Contractor ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Division":
                    Query = Database_Query.get_all_division_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 40), (true, 25), (true, 20) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Division Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Division",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft),
                        ("Office",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Office":
                    Query = Database_Query.get_all_office_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 40), (true, 25), (true, 20) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Office Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Office",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft),
                        ("Sector",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Nature":
                    Query = Database_Query.get_all_nature_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 50), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Nature Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Nature",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Position":
                    Query = Database_Query.get_all_position_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 50), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Position Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Postion",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Section":
                    Query = Database_Query.get_all_section_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 40), (true, 25), (true, 20) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Section Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Section ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft),
                        ("Division",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Sector":
                    Query = Database_Query.get_all_sector_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 50), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Sector ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

            }

            tab_Manager.active_Button(button, true);

            this.Active_Form = (string)button.Tag;
            show_Table(Query);
            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            UserControl[] controls = null;
            string insert_Query = null;
            string table = null;

            switch (Active_Form)
            {
                case "Agency":
                    controls = new UserControl[]
                    {
                        new Label_Text("Agency Name:"),
                        new Label_Rich("Description:"),
                        new Label_Drop("Cluster:", Database_Query.get_cluster_options)
                    };
                    insert_Query = Database_Query.set_new_agency;
                    table = "agency_table";

                    break;

                case "Cluster":
                    controls = new UserControl[]
                    {
                        new Label_Text("Cluster Name:"),
                        new Label_Rich("Description:"),
                        new Label_Drop("Sector:", Database_Query.get_sector_options)
                    };
                    insert_Query = Database_Query.set_new_cluster;
                    table = "cluster_table";

                    break;


                case "Contractor":
                    controls = new UserControl[]
                    {
                       new Label_Text("Contractor Name:"),
                       new Label_Rich("Description:")
                    };
                    insert_Query = Database_Query.set_new_contractor;
                    table = "contractor_table";
                    break;

                case "Division":
                    controls = new UserControl[]
                    {
                        new Label_Text("Division Name:"),
                        new Label_Rich("Description:"),
                        new Label_Drop ("Office:",Database_Query.get_office_options)
                    };
                    insert_Query = Database_Query.set_new_division;
                    table = "division_table";
                    break;
                case "Nature":
                    controls = new UserControl[]
                    {
                        new Label_Text("Nature:"),
                        new Label_Rich("Description")
                    };
                    insert_Query = Database_Query.set_new_nature;
                    table = "nature_table";
                    break;

                case "Office":
                    controls = new UserControl[]
                    {
                        new Label_Text("Office Name:"),
                        new Label_Rich ("Description:"),
                        new Label_Drop("Sector:",Database_Query.get_sector_options)
                    };
                    insert_Query = Database_Query.set_new_office;
                    table = "office_table";
                    break;

                case "Position":
                    controls = new UserControl[]
                    {
                        new Label_Text("Position:"),
                        new Label_Rich("Description:")
                    };
                    insert_Query = Database_Query.set_new_position;
                    table = "position_table";
                    break;

                case "Section":
                    controls = new UserControl[]
                    {
                        new Label_Text ("Section:"),
                        new Label_Rich ("Description:"),
                        new Label_Drop ("Division:",Database_Query.get_division_options)
                    };
                    insert_Query =Database_Query.set_new_section;
                    table = "section_table";
                    break;

                case "Sector":
                    controls = new UserControl[]
                    {
                        new Label_Text("Sector:"),
                        new Label_Rich("Description:")
                    };
                    insert_Query = Database_Query.set_new_sector;
                    table = "sector_table";
                    break;
            }
            
            Add_Record = new Add_Record(controls, insert_Query, table);
            Add_Record.callback += callback_Function;
            Add_Record.ShowDialog();
        }

        private void show_Table(string query)
        {
            DataTable dt = new DataTable();

            using (database_Manager)
                dt = database_Manager.ExecuteQuery(query);

            data_View.DataSource = null;
            data_View.Rows.Clear();
            data_View.DataSource = util.format_DataTable(dt);
        }

        public void refresh_Table()
        {
            DataTable dt = new DataTable();

            using (database_Manager)
                dt = database_Manager.ExecuteQuery(Query);

            data_View.DataSource = util.format_DataTable(dt);
        }

        private void refresh_Btn_Click(object sender, EventArgs e)
        {
            refresh_Table();
        }

        private void callback_Function() 
        {
            refresh_Table();
        }

        private void view_Btn_Click(object sender, EventArgs e)
        {

            string record_code = (string)data_View.Rows[data_View.CurrentRow.Index].Cells[1].Value;
            UserControl[] controls = null;
            string read_Query = null;
            string update_Query = null;
            string table = null;

            //Console.WriteLine((string)data_View.Rows[data_View.CurrentRow.Index].Cells[1].Value);
            switch (Active_Form)
            {
                case "Agency":
                    controls = new UserControl[]
                    {
                        new Label_Text("Agency Name:"),
                        new Label_Rich("Description:"),
                        new Label_Drop("Cluster:", Database_Query.get_cluster_options)
                    };
                    read_Query = Database_Query.get_agency_record_by_id;
                    update_Query = Database_Query.update_agency_record_by_id;
                    table = "agency_table";

                    break;

                case "Cluster":
                    controls = new UserControl[]
                    {
                        new Label_Text("Cluster Name:"),
                        new Label_Rich("Description:"),
                        new Label_Drop("Sector:", Database_Query.get_sector_options)
                    };
                    read_Query = "";
                    update_Query = "";
                    table = "cluster_table";

                    break;


                case "Contractor":
                    controls = new UserControl[]
                    {
                       new Label_Text("Contractor Name:"),
                       new Label_Rich("Description:")
                    };
                    read_Query = "";
                    update_Query = "";
                    table = "contractor_table";
                    break;

                case "Division":
                    controls = new UserControl[]
                    {
                        new Label_Text("Division Name:"),
                        new Label_Rich("Description:"),
                        new Label_Drop ("Office:",Database_Query.get_office_options)
                    };
                    read_Query = "";
                    update_Query = "";
                    table = "division_table";
                    break;
                case "Nature":
                    controls = new UserControl[]
                    {
                        new Label_Text("Nature:"),
                        new Label_Rich("Description")
                    };
                    read_Query = "";
                    update_Query = "";
                    table = "nature_table";
                    break;

                case "Office":
                    controls = new UserControl[]
                    {
                        new Label_Text("Office Name:"),
                        new Label_Rich ("Description:"),
                        new Label_Drop("Sector:",Database_Query.get_sector_options)
                    };
                    read_Query = "";
                    update_Query = "";
                    table = "office_table";
                    break;

                case "Position":
                    controls = new UserControl[]
                    {
                        new Label_Text("Position:"),
                        new Label_Rich("Description:")
                    };
                    read_Query = "";
                    update_Query = "";
                    table = "position_table";
                    break;

                case "Section":
                    controls = new UserControl[]
                    {
                        new Label_Text ("Section:"),
                        new Label_Rich ("Description:"),
                        new Label_Drop ("Division:",Database_Query.get_division_options)
                    };
                    read_Query = "";
                    update_Query = "";
                    table = "section_table";
                    break;

                case "Sector":
                    controls = new UserControl[]
                    {
                        new Label_Text("Sector:"),
                        new Label_Rich("Description:")
                    };
                    read_Query = "";
                    update_Query = "";
                    table = "sector_table";
                    break;
            }

            View_Record = new View_Record(record_code, controls, read_Query,update_Query, table);
            View_Record.callback += callback_Function; 
            View_Record.ShowDialog();

        }
    }
}
