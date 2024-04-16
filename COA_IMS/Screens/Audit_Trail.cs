using COA_IMS.UserControlUtil;
using COA_IMS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens
{
    public partial class Audit_Trail : Form
    {

        private string Record_ID { get; set; }
        private string Table { get; set; }
        private Database_Manager database_Manager;
        
        public Audit_Trail(string record_ID, string table)
        {
            InitializeComponent();
            this.Record_ID = record_ID;
            this.Table = table;
        }

        private void Audit_Trail_Load(object sender, EventArgs e)
        {
            GunaTextBox[] gunaTextBox = new GunaTextBox[] {createdBy_Text, createdDate_Text, updatedBy_Text, updatedDate_Text};
            database_Manager = new Database_Manager();

            DataTable ret = new DataTable();
            
            using (database_Manager)
            {
                ret = database_Manager.ExecuteQuery(string.Format(Database_Query.get_audit_trail_by_id, this.Table, this.Record_ID));
            }

            if (gunaTextBox.Length == ret.Columns.Count) 
            {
                for (int control = 0; control < gunaTextBox.Length; control++)
                {
                    gunaTextBox[control].Text = ret.Rows[0][control].ToString();
                }
            
            }

            



            


        }
    }
}
