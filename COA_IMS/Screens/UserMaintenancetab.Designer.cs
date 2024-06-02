namespace COA_IMS.Screens
{
    partial class UserMaintenancetab
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
            this.parent_Panel = new Guna.UI.WinForms.GunaPanel();
            this.content_Panel = new Guna.UI.WinForms.GunaPanel();
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.user_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.roles_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deactive_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.parent_Panel.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // parent_Panel
            // 
            this.parent_Panel.BackColor = System.Drawing.Color.White;
            this.parent_Panel.Controls.Add(this.content_Panel);
            this.parent_Panel.Controls.Add(this.nav_panel);
            this.parent_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_Panel.Location = new System.Drawing.Point(10, 10);
            this.parent_Panel.Name = "parent_Panel";
            this.parent_Panel.Size = new System.Drawing.Size(1599, 945);
            this.parent_Panel.TabIndex = 0;
            // 
            // content_Panel
            // 
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(0, 55);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(1599, 890);
            this.content_Panel.TabIndex = 6;
            // 
            // nav_panel
            // 
            this.nav_panel.AutoSize = true;
            this.nav_panel.BackColor = System.Drawing.Color.White;
            this.nav_panel.Controls.Add(this.user_Btn);
            this.nav_panel.Controls.Add(this.roles_Btn);
            this.nav_panel.Controls.Add(this.deactive_Btn);
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(0, 0);
            this.nav_panel.Margin = new System.Windows.Forms.Padding(0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(1599, 55);
            this.nav_panel.TabIndex = 5;
            // 
            // user_Btn
            // 
            this.user_Btn.Animated = true;
            this.user_Btn.AnimationHoverSpeed = 0.07F;
            this.user_Btn.AnimationSpeed = 0.03F;
            this.user_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.user_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.user_Btn.BorderColor = System.Drawing.Color.Black;
            this.user_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.user_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.user_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.user_Btn.CheckedImage = null;
            this.user_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.user_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.user_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.user_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.user_Btn.ForeColor = System.Drawing.Color.White;
            this.user_Btn.Image = global::COA_IMS.Properties.Resources.users_white_24;
            this.user_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.user_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.user_Btn.Location = new System.Drawing.Point(0, 0);
            this.user_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.user_Btn.Name = "user_Btn";
            this.user_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.user_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.user_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.user_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.users_darkblue_24;
            this.user_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.user_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.user_Btn.Size = new System.Drawing.Size(230, 55);
            this.user_Btn.TabIndex = 4;
            this.user_Btn.Text = "USERS";
            this.user_Btn.TextOffsetX = 5;
            this.user_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // roles_Btn
            // 
            this.roles_Btn.Animated = true;
            this.roles_Btn.AnimationHoverSpeed = 0.07F;
            this.roles_Btn.AnimationSpeed = 0.03F;
            this.roles_Btn.BackColor = System.Drawing.Color.Transparent;
            this.roles_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.roles_Btn.BorderColor = System.Drawing.Color.Black;
            this.roles_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.roles_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.roles_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.roles_Btn.CheckedImage = null;
            this.roles_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.roles_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roles_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.roles_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.roles_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.roles_Btn.ForeColor = System.Drawing.Color.White;
            this.roles_Btn.Image = global::COA_IMS.Properties.Resources.roles_white_24;
            this.roles_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.roles_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.roles_Btn.Location = new System.Drawing.Point(231, 0);
            this.roles_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.roles_Btn.Name = "roles_Btn";
            this.roles_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.roles_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.roles_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.roles_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.roles_darkblue_24;
            this.roles_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.roles_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.roles_Btn.Size = new System.Drawing.Size(230, 55);
            this.roles_Btn.TabIndex = 7;
            this.roles_Btn.Text = "ROLES";
            this.roles_Btn.TextOffsetX = 5;
            this.roles_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // deactive_Btn
            // 
            this.deactive_Btn.Animated = true;
            this.deactive_Btn.AnimationHoverSpeed = 0.07F;
            this.deactive_Btn.AnimationSpeed = 0.03F;
            this.deactive_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.deactive_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.deactive_Btn.BorderColor = System.Drawing.Color.Black;
            this.deactive_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.deactive_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.deactive_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.deactive_Btn.CheckedImage = null;
            this.deactive_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deactive_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deactive_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deactive_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.deactive_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.deactive_Btn.ForeColor = System.Drawing.Color.White;
            this.deactive_Btn.Image = global::COA_IMS.Properties.Resources.deactive_white_24;
            this.deactive_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.deactive_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.deactive_Btn.Location = new System.Drawing.Point(462, 0);
            this.deactive_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.deactive_Btn.Name = "deactive_Btn";
            this.deactive_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.deactive_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.deactive_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.deactive_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.deactive_darkblue_24;
            this.deactive_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.deactive_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.deactive_Btn.Size = new System.Drawing.Size(230, 55);
            this.deactive_Btn.TabIndex = 5;
            this.deactive_Btn.Text = "DEACTIVATED";
            this.deactive_Btn.TextOffsetX = 5;
            this.deactive_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // UserMaintenancetab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1619, 965);
            this.Controls.Add(this.parent_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMaintenancetab";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "UserMaintenancetab";
            this.Load += new System.EventHandler(this.User_Load);
            this.parent_Panel.ResumeLayout(false);
            this.parent_Panel.PerformLayout();
            this.nav_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel parent_Panel;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private Guna.UI.WinForms.GunaAdvenceButton user_Btn;
        private Guna.UI.WinForms.GunaAdvenceButton roles_Btn;
        private Guna.UI.WinForms.GunaAdvenceButton deactive_Btn;
        private Guna.UI.WinForms.GunaPanel content_Panel;
    }
}