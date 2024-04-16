namespace COA_IMS.Screens
{
    partial class ActivityLogs
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
            this.container_Panel = new Guna.UI.WinForms.GunaPanel();
            this.parent_panel = new Guna.UI.WinForms.GunaPanel();
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.account_Logs_Btn = new Guna.UI.WinForms.GunaButton();
            this.inactive_Btn = new Guna.UI.WinForms.GunaButton();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.parent_panel.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_Panel
            // 
            this.container_Panel.BackColor = System.Drawing.Color.White;
            this.container_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_Panel.Location = new System.Drawing.Point(0, 60);
            this.container_Panel.Name = "container_Panel";
            this.container_Panel.Padding = new System.Windows.Forms.Padding(8);
            this.container_Panel.Size = new System.Drawing.Size(1583, 834);
            this.container_Panel.TabIndex = 3;
            // 
            // parent_panel
            // 
            this.parent_panel.BackColor = System.Drawing.Color.Transparent;
            this.parent_panel.Controls.Add(this.container_Panel);
            this.parent_panel.Controls.Add(this.line_Panel);
            this.parent_panel.Controls.Add(this.nav_panel);
            this.parent_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_panel.Location = new System.Drawing.Point(10, 10);
            this.parent_panel.Margin = new System.Windows.Forms.Padding(2);
            this.parent_panel.Name = "parent_panel";
            this.parent_panel.Size = new System.Drawing.Size(1583, 894);
            this.parent_panel.TabIndex = 2;
            // 
            // line_Panel
            // 
            this.line_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.line_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.line_Panel.Location = new System.Drawing.Point(0, 55);
            this.line_Panel.Name = "line_Panel";
            this.line_Panel.Size = new System.Drawing.Size(1583, 5);
            this.line_Panel.TabIndex = 1;
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.Transparent;
            this.nav_panel.Controls.Add(this.account_Logs_Btn);
            this.nav_panel.Controls.Add(this.inactive_Btn);
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(0, 0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(1583, 55);
            this.nav_panel.TabIndex = 0;
            // 
            // account_Logs_Btn
            // 
            this.account_Logs_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.account_Logs_Btn.AnimationHoverSpeed = 0.07F;
            this.account_Logs_Btn.AnimationSpeed = 0.03F;
            this.account_Logs_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.account_Logs_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.account_Logs_Btn.BorderColor = System.Drawing.Color.Black;
            this.account_Logs_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.account_Logs_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.account_Logs_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.account_Logs_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.account_Logs_Btn.ForeColor = System.Drawing.Color.White;
            this.account_Logs_Btn.Image = global::COA_IMS.Properties.Resources.document;
            this.account_Logs_Btn.ImageOffsetX = 5;
            this.account_Logs_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.account_Logs_Btn.Location = new System.Drawing.Point(0, 0);
            this.account_Logs_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.account_Logs_Btn.Name = "account_Logs_Btn";
            this.account_Logs_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.account_Logs_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.account_Logs_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.account_Logs_Btn.OnHoverImage = null;
            this.account_Logs_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.account_Logs_Btn.Size = new System.Drawing.Size(222, 55);
            this.account_Logs_Btn.TabIndex = 0;
            this.account_Logs_Btn.Text = "ACCOUNT LOGS";
            this.account_Logs_Btn.TextOffsetX = 5;
            this.account_Logs_Btn.Click += new System.EventHandler(this.button_Click);
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
            this.inactive_Btn.Location = new System.Drawing.Point(223, 0);
            this.inactive_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.inactive_Btn.Name = "inactive_Btn";
            this.inactive_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.inactive_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.inactive_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.inactive_Btn.OnHoverImage = null;
            this.inactive_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.inactive_Btn.Size = new System.Drawing.Size(180, 55);
            this.inactive_Btn.TabIndex = 1;
            this.inactive_Btn.Text = "INACTIVE";
            this.inactive_Btn.TextOffsetX = 5;
            this.inactive_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // ActivityLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1603, 914);
            this.Controls.Add(this.parent_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivityLogs";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "LogsTab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ActivityLogs_Load);
            this.parent_panel.ResumeLayout(false);
            this.nav_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel container_Panel;
        private Guna.UI.WinForms.GunaPanel parent_panel;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private Guna.UI.WinForms.GunaButton account_Logs_Btn;
        private Guna.UI.WinForms.GunaButton inactive_Btn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}