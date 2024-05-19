using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Utilities
{
    internal class Theme
    {
        Color old_column_color = Color.FromArgb(27, 48, 59);
        Color old_row_color = Color.FromArgb(77, 109, 128);

        Color orange_column_color = Color.FromArgb(198, 134, 33);
        Color orange_row_color = Color.FromArgb(230, 181, 104);

        public static Color dark_pink_header = Color.FromArgb(195, 141, 140);
        public static Color dark_pink_row = Color.FromArgb(235, 111, 108);	
        public static Color Hex_To_RGB(string hex)
        {
            // Remove '#' if present
            hex = hex.TrimStart('#');

            // Check if the hex string is valid
            if (hex.Length != 6)
                throw new ArgumentException("Invalid hexadecimal color representation.", nameof(hex));

            // Parse hexadecimal values for each color component
            int r = int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            int g = int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            int b = int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            // Return the corresponding Color object
            return Color.FromArgb(r, g, b);
        }


        public static void gridView_Style(
            //Required Parameters
             GunaDataGridView guna_Table, 
             (bool is_Percentage, int value)[] column_Width,
             (string title, DataGridViewContentAlignment alignment)[] column_Properties,

             int row_Height = 50, int col_height = 55)
        {
            // Create column header style
            GunaDataGridViewHeaderStyle columnHeaderStyle = new GunaDataGridViewHeaderStyle(guna_Table.ColumnHeadersDefaultCellStyle, guna_Table);
            columnHeaderStyle.Font = new Font("Bahnschrift", 14.25F);
            columnHeaderStyle.Height = col_height;
            columnHeaderStyle.BackColor = dark_pink_header;


            // Create row style
            GunaDataGridViewRowsStyle rowStyle = new GunaDataGridViewRowsStyle(guna_Table.DefaultCellStyle, guna_Table);
            rowStyle.SelectionBackColor = dark_pink_row;
            rowStyle.SelectionForeColor = Color.White;
            rowStyle.Font = new Font("Bahnschrift", 14.25F);
            rowStyle.Height = row_Height;

            // Set column designs, title, and alignemnts
            for (int i = 0; i < guna_Table.Columns.Count; i++)
            {
                guna_Table.Columns[i].HeaderText = column_Properties[i].title;
                guna_Table.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                guna_Table.Columns[i].DefaultCellStyle.Alignment = column_Properties[i].alignment;

                if (i < guna_Table.Columns.Count - 1)
                {
                    guna_Table.Columns[i].DividerWidth = 1;
                }
            }


            // Set column widths
            if (column_Width.Length > 0 && column_Width.Length == guna_Table.Columns.Count)
            {
                for (int i = 0; i < column_Width.Length; i++)
                {
                    int width = column_Width[i].is_Percentage ? (int)Math.Round((column_Width[i].value / 100.0) * guna_Table.Width) : column_Width[i].value;
                    guna_Table.Columns[i].Width = width;
                }
            }


            // Apply alternating row colors
            for (int i = 0; i < guna_Table.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    rowStyle.BackColor = Hex_To_RGB("#F0F0F0");

            }
        }
        public static void AlternateTableRows(GunaDataGridView guna_Table)
        {
            // Create row style
            GunaDataGridViewRowsStyle rowStyle = new GunaDataGridViewRowsStyle(guna_Table.DefaultCellStyle, guna_Table);

            // Apply alternating row colors
            for (int i = 0; i < guna_Table.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    rowStyle.BackColor = Hex_To_RGB("#F0F0F0");

            }
        }

        public static void ChangeButtonBaseColor(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.Red; // Change button base color to red (example)
                }
            }
        }
        public static string Number_To_Currency(double num)
        {
            return "₱" + num.ToString("N2");
        }
        public static double Currency_To_Number(string currency)
        {
            // Remove currency symbol and thousand separators
            string cleanCurrency = currency.Replace("₱", "").Replace(",", "");

            // Parse the remaining string as a double
            if (double.TryParse(cleanCurrency, out double result))
            {
                return result;
            }
            else
            {
                // Handle parsing failure, return a default value or throw an exception
                throw new ArgumentException("Invalid currency format");
            }
        }
    }
}
