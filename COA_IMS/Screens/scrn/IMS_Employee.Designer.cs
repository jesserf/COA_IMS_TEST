namespace COA_IMS.Screens.scrn
{
    partial class IMS_Employee
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
            this.content_Panel = new Guna.UI.WinForms.GunaPanel();
            this.container_Panel = new Guna.UI.WinForms.GunaPanel();
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.parent_panel = new Guna.UI.WinForms.GunaPanel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.employee_Table_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.archived_Employees_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.container_Panel.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.parent_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.White;
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(0, 55);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(1599, 890);
            this.content_Panel.TabIndex = 7;
            // 
            // container_Panel
            // 
            this.container_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.container_Panel.Controls.Add(this.content_Panel);
            this.container_Panel.Controls.Add(this.nav_panel);
            this.container_Panel.Controls.Add(this.flowLayoutPanel1);
            this.container_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_Panel.Location = new System.Drawing.Point(0, 0);
            this.container_Panel.Name = "container_Panel";
            this.container_Panel.Size = new System.Drawing.Size(1599, 945);
            this.container_Panel.TabIndex = 3;
            // 
            // nav_panel
            // 
            this.nav_panel.AutoSize = true;
            this.nav_panel.BackColor = System.Drawing.Color.White;
            this.nav_panel.Controls.Add(this.employee_Table_Btn);
            this.nav_panel.Controls.Add(this.archived_Employees_Btn);
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(0, 0);
            this.nav_panel.Margin = new System.Windows.Forms.Padding(0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(1599, 55);
            this.nav_panel.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel1.Controls.Add(this.line_Panel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1601, 56);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // line_Panel
            // 
            this.line_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.line_Panel.Location = new System.Drawing.Point(3, 3);
            this.line_Panel.Name = "line_Panel";
            this.line_Panel.Size = new System.Drawing.Size(1603, 10);
            this.line_Panel.TabIndex = 5;
            // 
            // parent_panel
            // 
            this.parent_panel.BackColor = System.Drawing.Color.Transparent;
            this.parent_panel.Controls.Add(this.container_Panel);
            this.parent_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_panel.Location = new System.Drawing.Point(10, 10);
            this.parent_panel.Margin = new System.Windows.Forms.Padding(2);
            this.parent_panel.Name = "parent_panel";
            this.parent_panel.Size = new System.Drawing.Size(1599, 945);
            this.parent_panel.TabIndex = 4;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // employee_Table_Btn
            // 
            this.employee_Table_Btn.Animated = true;
            this.employee_Table_Btn.AnimationHoverSpeed = 0.07F;
            this.employee_Table_Btn.AnimationSpeed = 0.03F;
            this.employee_Table_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.employee_Table_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.employee_Table_Btn.BorderColor = System.Drawing.Color.Black;
            this.employee_Table_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.employee_Table_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.employee_Table_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.employee_Table_Btn.CheckedImage = null;
            this.employee_Table_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.employee_Table_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_Table_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.employee_Table_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.employee_Table_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.employee_Table_Btn.ForeColor = System.Drawing.Color.White;
            this.employee_Table_Btn.Image = global::COA_IMS.Properties.Resources.employee_table_white_24;
            this.employee_Table_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.employee_Table_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.employee_Table_Btn.Location = new System.Drawing.Point(0, 0);
            this.employee_Table_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.employee_Table_Btn.Name = "employee_Table_Btn";
            this.employee_Table_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.employee_Table_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.employee_Table_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.employee_Table_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.employee_table_darkblue_24;
            this.employee_Table_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.employee_Table_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.employee_Table_Btn.Size = new System.Drawing.Size(222, 55);
            this.employee_Table_Btn.TabIndex = 4;
            this.employee_Table_Btn.Text = "EMPLOYEES";
            this.employee_Table_Btn.TextOffsetX = 5;
            this.employee_Table_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // archived_Employees_Btn
            // 
            this.archived_Employees_Btn.Animated = true;
            this.archived_Employees_Btn.AnimationHoverSpeed = 0.07F;
            this.archived_Employees_Btn.AnimationSpeed = 0.03F;
            this.archived_Employees_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.archived_Employees_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.archived_Employees_Btn.BorderColor = System.Drawing.Color.Black;
            this.archived_Employees_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.archived_Employees_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.archived_Employees_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.archived_Employees_Btn.CheckedImage = null;
            this.archived_Employees_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.archived_Employees_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.archived_Employees_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.archived_Employees_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.archived_Employees_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.archived_Employees_Btn.ForeColor = System.Drawing.Color.White;
            this.archived_Employees_Btn.Image = global::COA_IMS.Properties.Resources.archive_white_24;
            this.archived_Employees_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.archived_Employees_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.archived_Employees_Btn.Location = new System.Drawing.Point(223, 0);
            this.archived_Employees_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.archived_Employees_Btn.Name = "archived_Employees_Btn";
            this.archived_Employees_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.archived_Employees_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.archived_Employees_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.archived_Employees_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.archive_darkblue_24;
            this.archived_Employees_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.archived_Employees_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.archived_Employees_Btn.Size = new System.Drawing.Size(222, 55);
            this.archived_Employees_Btn.TabIndex = 5;
            this.archived_Employees_Btn.Text = "ARCHIVED";
            this.archived_Employees_Btn.TextOffsetX = 5;
            this.archived_Employees_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // IMS_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1619, 965);
            this.Controls.Add(this.parent_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IMS_Employee";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "IMS_Employee";
            this.Load += new System.EventHandler(this.IMS_Employee_Load);
            this.container_Panel.ResumeLayout(false);
            this.container_Panel.PerformLayout();
            this.nav_panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.parent_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel content_Panel;
        private Guna.UI.WinForms.GunaPanel container_Panel;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private Guna.UI.WinForms.GunaAdvenceButton employee_Table_Btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private Guna.UI.WinForms.GunaPanel parent_panel;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI.WinForms.GunaAdvenceButton archived_Employees_Btn;
    }
}