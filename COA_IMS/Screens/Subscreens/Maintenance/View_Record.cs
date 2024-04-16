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

namespace COA_IMS.Screens.Subscreens.Maintenance
{
    public partial class View_Record : Form
    {

        private Database_Manager database_Manager;
        private Util util;
        private Validator validator;
        private Audit_Trail audit_Trail;
        private string Record_ID { get; set; }
        private string Read_Query { get; set; } 
        private string Update_Query { get; set; }
        private string Table { get; set; }

        private bool is_ClosingProgrammatically = false;

        public event Action callback;


        public View_Record(string record_ID, UserControl[] controls, string read_Query, string update_Query, string table)
        {
            InitializeComponent();
            InitializeControls(controls);
            this.Record_ID = record_ID;
            this.Read_Query = read_Query;
            this.Update_Query = update_Query;
            this.Table = table; 
        }

        private void View_Record_Load(object sender, EventArgs e)
        {
            database_Manager = new Database_Manager();
            validator = new Validator();
            util = new Util();

            code_Title.Text = this.Record_ID;
            set_Records();
        }

        private void InitializeControls(UserControl[] controls)
        {
            for (int i = 0; i < controls.Length; i++)
            {
                control_Panel.Controls.Add(controls[i]);
                control_Panel.Controls[i].Size = new Size(control_Panel.Size.Width - 8, control_Panel.Controls[i].Size.Height);
            }

        }

        private void set_Records() 
        {
            validator.readOnly_Controls(control_Panel);
            DataTable ret = new DataTable();

            using (database_Manager) 
            {
                ret = database_Manager.ExecuteQuery(string.Format(this.Read_Query, this.Record_ID));
            }

            if (ret.Columns.Count == control_Panel.Controls.Count)
                for (int control = 0; control < ret.Columns.Count; control++) 
                    control_Panel.Controls[control].Text = (string)ret.Rows[0][control];
            
        }

        private void update_Btn_Click(object sender, EventArgs e)
        {
            change_ViewControls(true);
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                change_ViewControls(false);
        }

        private void change_ViewControls(bool is_Enabled = true) 
        {
            validator.readOnly_Controls(control_Panel, is_Enabled);

            update_Btn.Enabled = !is_Enabled;
            delete_Btn.Enabled = !is_Enabled;

            this.button_Panel.Visible = is_Enabled;
            this.button_Panel.Enabled = is_Enabled;

        }

        private void audit_Trail_Btn_Click(object sender, EventArgs e)
        {
            audit_Trail = new Audit_Trail(this.Record_ID, this.Table);
            audit_Trail.ShowDialog();
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            int ret = 0;
            if (validator.Required_TextBox(control_Panel, error_provider, error_Message))
            {
                List<List<string>> entries = new List<List<string>>();

                List<string> values = new List<string>();

                foreach (Control control in control_Panel.Controls)
                    values.Add(control.Text?.Trim() ?? "");

                values.Add("james");
                values.Add(code_Title.Text);
                entries.Add(values);

                using (database_Manager)
                    ret = database_Manager.ExecuteNonQuery(util.generate_Query(entries, Update_Query));

            }
            if (ret == 1)
            {
                if (MessageBox.Show($"{code_Title.Text} is successfully Updated.", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    is_ClosingProgrammatically = true;
                    Close();
                    callback?.Invoke();
                }
            }

        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are you sure to delete {code_Title.Text}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                using (database_Manager)
                    database_Manager.ExecuteNonQuery(string.Format(Database_Query.delete_record_by_id, this.Table, this.Record_ID));

                MessageBox.Show($"{code_Title.Text} is successfully deleted", "Delete Confirmation");
                is_ClosingProgrammatically = true;
                Close();
                callback?.Invoke();
            }

        }


        private void View_Record_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_ClosingProgrammatically)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No;

                else if (e.CloseReason == CloseReason.WindowsShutDown)
                    Close();
            }
        }
    }
}
