using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Screens.Subscrn.Tracking
{
    public partial class AddItemQuantity : Form
    {
        public int qty { get; set; }
        private int minimum_quantity = 1, maximum_quantity;
        public AddItemQuantity(int maximum_quantity)
        {
            InitializeComponent();
            qty = 1;
            this.maximum_quantity = maximum_quantity;
            minus_Btn.Enabled = false;
            if(maximum_quantity == 1)
            {
                plus_Btn.Enabled = false;
            }
        }

        private void plus_Btn_Click(object sender, EventArgs e)
        {
            qty = Convert.ToInt32(qty_Textbox.Text);
            qty += 1;
            qty_Textbox.Text = qty.ToString();
            if (qty == maximum_quantity)
                plus_Btn.Enabled = false;
        }

        private void minus_Btn_Click(object sender, EventArgs e)
        {
            qty = Convert.ToInt32(qty_Textbox.Text);
            qty -= 1;
            qty_Textbox.Text = qty.ToString();
            if (qty == 1)
                minus_Btn.Enabled = false;
        }

        private void qty_Textbox_TextChanged(object sender, EventArgs e)
        {
            qty = Convert.ToInt32(qty_Textbox.Text);
            if (qty < maximum_quantity)
                plus_Btn.Enabled = true;
            if (qty >= 2)
                minus_Btn.Enabled = true;
            if(qty > maximum_quantity)
            {
                qty = maximum_quantity;
                qty_Textbox.Text = qty.ToString();
            }
        }

        private void next_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItemQuantity_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void qty_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character (like backspace or delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If the pressed key is not a digit and not a control character, ignore it
                e.Handled = true;
            }

            
        }
    }
}
