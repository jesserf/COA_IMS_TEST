using COA_IMS.Screens.scrn;
using COA_IMS.Screens.Subscrn.LogsSubscreens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscrn
{
    public partial class CategoryTab : Form
    {
        public CategoryTab()
        {
            InitializeComponent();
        }

        private void addcategorybtn_Click(object sender, EventArgs e)
        {
           CategoryForm catform = new CategoryForm();
            catform.ShowDialog();
        }
        private void addunitbtn_Click(object sender, EventArgs e)
        {
            UnitForm catform = new UnitForm();
            catform.ShowDialog();
        }

        private void CategoryTab_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
