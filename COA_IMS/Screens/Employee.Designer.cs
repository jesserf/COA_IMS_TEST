namespace COA_IMS.Screens
{
    partial class Employee
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
            this.parent_panel = new Guna.UI.WinForms.GunaPanel();
            this.container_Panel = new Guna.UI.WinForms.GunaPanel();
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            /*this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();*/
            this.employee_Btn = new Guna.UI.WinForms.GunaButton();
            this.inactive_Btn = new Guna.UI.WinForms.GunaButton();
            this.parent_panel.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // parent_panel
            // 
            this.parent_panel.BackColor = System.Drawing.Color.Transparent;
            this.parent_panel.Controls.Add(this.container_Panel);
            this.parent_panel.Controls.Add(this.line_Panel);
            this.parent_panel.Controls.Add(this.nav_panel);
            this.parent_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_panel.Location = new System.Drawing.Point(8, 8);
            this.parent_panel.Margin = new System.Windows.Forms.Padding(2);
            this.parent_panel.Name = "parent_panel";
            this.parent_panel.Size = new System.Drawing.Size(1540, 868);
            this.parent_panel.TabIndex = 0;
            // 
            // container_Panel
            // 
            this.container_Panel.BackColor = System.Drawing.Color.White;
            this.container_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_Panel.Location = new System.Drawing.Point(0, 60);
            this.container_Panel.Name = "container_Panel";
            this.container_Panel.Padding = new System.Windows.Forms.Padding(8);
            this.container_Panel.Size = new System.Drawing.Size(1540, 808);
            this.container_Panel.TabIndex = 2;
            // 
            // line_Panel
            // 
            this.line_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.line_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.line_Panel.Location = new System.Drawing.Point(0, 55);
            this.line_Panel.Name = "line_Panel";
            this.line_Panel.Size = new System.Drawing.Size(1540, 5);
            this.line_Panel.TabIndex = 1;
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.Transparent;
            this.nav_panel.Controls.Add(this.employee_Btn);
            this.nav_panel.Controls.Add(this.inactive_Btn);
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(0, 0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(1540, 55);
            this.nav_panel.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            /*this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;*/
            // 
            // employee_Btn
            // 
            this.employee_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.employee_Btn.AnimationHoverSpeed = 0.07F;
            this.employee_Btn.AnimationSpeed = 0.03F;
            this.employee_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.employee_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.employee_Btn.BorderColor = System.Drawing.Color.Black;
            this.employee_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.employee_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.employee_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.employee_Btn.ForeColor = System.Drawing.Color.White;
            this.employee_Btn.Image = global::COA_IMS.Properties.Resources.document;
            this.employee_Btn.ImageOffsetX = 5;
            this.employee_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.employee_Btn.Location = new System.Drawing.Point(0, 0);
            this.employee_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.employee_Btn.Name = "employee_Btn";
            this.employee_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.employee_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.employee_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.employee_Btn.OnHoverImage = null;
            this.employee_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.employee_Btn.Size = new System.Drawing.Size(200, 55);
            this.employee_Btn.TabIndex = 0;
            this.employee_Btn.Text = "RECORDS";
            this.employee_Btn.TextOffsetX = 5;
            this.employee_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // inactive_Btn
            // 
            this.inactive_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inactive_Btn.AnimationHoverSpeed = 0.07F;
            this.inactive_Btn.AnimationSpeed = 0.03F;
            this.inactive_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.inactive_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.inactive_Btn.BorderColor = System.Drawing.Color.Black;
            this.inactive_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inactive_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.inactive_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.inactive_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.inactive_Btn.ForeColor = System.Drawing.Color.White;
            this.inactive_Btn.Image = global::COA_IMS.Properties.Resources.moon;
            this.inactive_Btn.ImageOffsetX = 5;
            this.inactive_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.inactive_Btn.Location = new System.Drawing.Point(201, 0);
            this.inactive_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.inactive_Btn.Name = "inactive_Btn";
            this.inactive_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.inactive_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.inactive_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.inactive_Btn.OnHoverImage = null;
            this.inactive_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.inactive_Btn.Size = new System.Drawing.Size(200, 55);
            this.inactive_Btn.TabIndex = 1;
            this.inactive_Btn.Text = "INACTIVE";
            this.inactive_Btn.TextOffsetX = 5;
            this.inactive_Btn.Visible = false;
            this.inactive_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.parent_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.parent_panel.ResumeLayout(false);
            this.nav_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel parent_panel;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private Guna.UI.WinForms.GunaButton employee_Btn;
        private Guna.UI.WinForms.GunaButton inactive_Btn;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private Guna.UI.WinForms.GunaPanel container_Panel;
    }
}