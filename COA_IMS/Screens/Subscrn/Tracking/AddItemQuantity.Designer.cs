namespace COA_IMS.Screens.Subscrn.Tracking
{
    partial class AddItemQuantity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.next_Btn = new Guna.UI.WinForms.GunaButton();
            this.qty_Textbox = new Guna.UI.WinForms.GunaTextBox();
            this.plus_Btn = new Guna.UI.WinForms.GunaButton();
            this.minus_Btn = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.gunaLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.next_Btn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.qty_Textbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.plus_Btn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.minus_Btn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 311);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.gunaLabel1, 2);
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(10, 11);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(150, 39);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Quantity :";
            // 
            // next_Btn
            // 
            this.next_Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.next_Btn.AnimationHoverSpeed = 0.07F;
            this.next_Btn.AnimationSpeed = 0.03F;
            this.next_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.next_Btn.BorderColor = System.Drawing.Color.Black;
            this.next_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.next_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.next_Btn.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.next_Btn.ForeColor = System.Drawing.Color.White;
            this.next_Btn.Image = null;
            this.next_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.next_Btn.Location = new System.Drawing.Point(332, 258);
            this.next_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.next_Btn.Name = "next_Btn";
            this.next_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.next_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.next_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.next_Btn.OnHoverImage = null;
            this.next_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.next_Btn.Size = new System.Drawing.Size(142, 43);
            this.next_Btn.TabIndex = 1;
            this.next_Btn.Text = "Next";
            this.next_Btn.Click += new System.EventHandler(this.next_Btn_Click);
            // 
            // qty_Textbox
            // 
            this.qty_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.qty_Textbox.BaseColor = System.Drawing.Color.White;
            this.qty_Textbox.BorderColor = System.Drawing.Color.Silver;
            this.qty_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qty_Textbox.FocusedBaseColor = System.Drawing.Color.White;
            this.qty_Textbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.qty_Textbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.qty_Textbox.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.qty_Textbox.ForeColor = System.Drawing.Color.Black;
            this.qty_Textbox.Location = new System.Drawing.Point(171, 130);
            this.qty_Textbox.Margin = new System.Windows.Forms.Padding(10);
            this.qty_Textbox.Name = "qty_Textbox";
            this.qty_Textbox.PasswordChar = '\0';
            this.qty_Textbox.SelectedText = "";
            this.qty_Textbox.Size = new System.Drawing.Size(141, 49);
            this.qty_Textbox.TabIndex = 8;
            this.qty_Textbox.Text = "1";
            this.qty_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qty_Textbox.TextChanged += new System.EventHandler(this.qty_Textbox_TextChanged);
            this.qty_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qty_Textbox_KeyPress);
            // 
            // plus_Btn
            // 
            this.plus_Btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.plus_Btn.AnimationHoverSpeed = 0.07F;
            this.plus_Btn.AnimationSpeed = 0.03F;
            this.plus_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.plus_Btn.BorderColor = System.Drawing.Color.Black;
            this.plus_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.plus_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.plus_Btn.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.plus_Btn.ForeColor = System.Drawing.Color.White;
            this.plus_Btn.Image = null;
            this.plus_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.plus_Btn.Location = new System.Drawing.Point(332, 130);
            this.plus_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.plus_Btn.Name = "plus_Btn";
            this.plus_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.plus_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.plus_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.plus_Btn.OnHoverImage = null;
            this.plus_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.plus_Btn.Size = new System.Drawing.Size(50, 50);
            this.plus_Btn.TabIndex = 9;
            this.plus_Btn.Text = "+";
            this.plus_Btn.Click += new System.EventHandler(this.plus_Btn_Click);
            // 
            // minus_Btn
            // 
            this.minus_Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minus_Btn.AnimationHoverSpeed = 0.07F;
            this.minus_Btn.AnimationSpeed = 0.03F;
            this.minus_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.minus_Btn.BorderColor = System.Drawing.Color.Black;
            this.minus_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minus_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.minus_Btn.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.minus_Btn.ForeColor = System.Drawing.Color.White;
            this.minus_Btn.Image = null;
            this.minus_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.minus_Btn.Location = new System.Drawing.Point(101, 130);
            this.minus_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.minus_Btn.Name = "minus_Btn";
            this.minus_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.minus_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.minus_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.minus_Btn.OnHoverImage = null;
            this.minus_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.minus_Btn.Size = new System.Drawing.Size(50, 50);
            this.minus_Btn.TabIndex = 10;
            this.minus_Btn.Text = "-";
            this.minus_Btn.Click += new System.EventHandler(this.minus_Btn_Click);
            // 
            // AddItemQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddItemQuantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemQuantity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddItemQuantity_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton next_Btn;
        private Guna.UI.WinForms.GunaTextBox qty_Textbox;
        private Guna.UI.WinForms.GunaButton plus_Btn;
        private Guna.UI.WinForms.GunaButton minus_Btn;
    }
}