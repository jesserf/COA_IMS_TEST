namespace COA_IMS.Screens.scrn
{
    partial class LogsForm
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
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.account_Logs_Button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.activity_Logs_Button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.parent_panel.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_Panel
            // 
            this.container_Panel.BackColor = System.Drawing.Color.White;
            this.container_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_Panel.Location = new System.Drawing.Point(0, 54);
            this.container_Panel.Name = "container_Panel";
            this.container_Panel.Padding = new System.Windows.Forms.Padding(8);
            this.container_Panel.Size = new System.Drawing.Size(1583, 852);
            this.container_Panel.TabIndex = 3;
            // 
            // parent_panel
            // 
            this.parent_panel.BackColor = System.Drawing.Color.Transparent;
            this.parent_panel.Controls.Add(this.container_Panel);
            this.parent_panel.Controls.Add(this.nav_panel);
            this.parent_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_panel.Location = new System.Drawing.Point(10, 10);
            this.parent_panel.Margin = new System.Windows.Forms.Padding(2);
            this.parent_panel.Name = "parent_panel";
            this.parent_panel.Size = new System.Drawing.Size(1583, 906);
            this.parent_panel.TabIndex = 4;
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.White;
            this.nav_panel.Controls.Add(this.account_Logs_Button);
            this.nav_panel.Controls.Add(this.activity_Logs_Button);
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(0, 0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(1583, 54);
            this.nav_panel.TabIndex = 0;
            // 
            // account_Logs_Button
            // 
            this.account_Logs_Button.Animated = true;
            this.account_Logs_Button.AnimationHoverSpeed = 0.07F;
            this.account_Logs_Button.AnimationSpeed = 0.03F;
            this.account_Logs_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.account_Logs_Button.BaseColor = System.Drawing.Color.Transparent;
            this.account_Logs_Button.BorderColor = System.Drawing.Color.Black;
            this.account_Logs_Button.CheckedBaseColor = System.Drawing.Color.Gray;
            this.account_Logs_Button.CheckedBorderColor = System.Drawing.Color.Black;
            this.account_Logs_Button.CheckedForeColor = System.Drawing.Color.White;
            this.account_Logs_Button.CheckedImage = null;
            this.account_Logs_Button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.account_Logs_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.account_Logs_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.account_Logs_Button.FocusedColor = System.Drawing.Color.Empty;
            this.account_Logs_Button.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.account_Logs_Button.ForeColor = System.Drawing.Color.White;
            this.account_Logs_Button.Image = global::COA_IMS.Properties.Resources.account_logs_white_24;
            this.account_Logs_Button.ImageSize = new System.Drawing.Size(24, 24);
            this.account_Logs_Button.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.account_Logs_Button.Location = new System.Drawing.Point(0, 0);
            this.account_Logs_Button.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.account_Logs_Button.Name = "account_Logs_Button";
            this.account_Logs_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.account_Logs_Button.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.account_Logs_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.account_Logs_Button.OnHoverImage = global::COA_IMS.Properties.Resources.account_logs_darkblue_24;
            this.account_Logs_Button.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.account_Logs_Button.OnPressedColor = System.Drawing.Color.Black;
            this.account_Logs_Button.Size = new System.Drawing.Size(222, 55);
            this.account_Logs_Button.TabIndex = 4;
            this.account_Logs_Button.Text = "ACCOUNT LOGS";
            this.account_Logs_Button.TextOffsetX = 5;
            this.account_Logs_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // activity_Logs_Button
            // 
            this.activity_Logs_Button.Animated = true;
            this.activity_Logs_Button.AnimationHoverSpeed = 0.07F;
            this.activity_Logs_Button.AnimationSpeed = 0.03F;
            this.activity_Logs_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.activity_Logs_Button.BaseColor = System.Drawing.Color.Transparent;
            this.activity_Logs_Button.BorderColor = System.Drawing.Color.Black;
            this.activity_Logs_Button.CheckedBaseColor = System.Drawing.Color.Gray;
            this.activity_Logs_Button.CheckedBorderColor = System.Drawing.Color.Black;
            this.activity_Logs_Button.CheckedForeColor = System.Drawing.Color.White;
            this.activity_Logs_Button.CheckedImage = null;
            this.activity_Logs_Button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.activity_Logs_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activity_Logs_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.activity_Logs_Button.FocusedColor = System.Drawing.Color.Empty;
            this.activity_Logs_Button.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.activity_Logs_Button.ForeColor = System.Drawing.Color.White;
            this.activity_Logs_Button.Image = global::COA_IMS.Properties.Resources.activity_logs_white_24;
            this.activity_Logs_Button.ImageSize = new System.Drawing.Size(24, 24);
            this.activity_Logs_Button.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.activity_Logs_Button.Location = new System.Drawing.Point(223, 0);
            this.activity_Logs_Button.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.activity_Logs_Button.Name = "activity_Logs_Button";
            this.activity_Logs_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.activity_Logs_Button.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.activity_Logs_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.activity_Logs_Button.OnHoverImage = global::COA_IMS.Properties.Resources.activity_logs_darkblue_24;
            this.activity_Logs_Button.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.activity_Logs_Button.OnPressedColor = System.Drawing.Color.Black;
            this.activity_Logs_Button.Size = new System.Drawing.Size(222, 55);
            this.activity_Logs_Button.TabIndex = 5;
            this.activity_Logs_Button.Text = "ACTIVITY LOGS";
            this.activity_Logs_Button.TextOffsetX = 5;
            this.activity_Logs_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1603, 926);
            this.Controls.Add(this.parent_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "LogsForm";
            this.Load += new System.EventHandler(this.LogsForm_Load);
            this.parent_panel.ResumeLayout(false);
            this.nav_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel container_Panel;
        private Guna.UI.WinForms.GunaPanel parent_panel;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private Guna.UI.WinForms.GunaAdvenceButton account_Logs_Button;
        private Guna.UI.WinForms.GunaAdvenceButton activity_Logs_Button;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}