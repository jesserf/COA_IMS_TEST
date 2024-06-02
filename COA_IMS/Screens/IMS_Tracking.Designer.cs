namespace COA_IMS.Screens.scrn
{
    partial class IMS_Tracking
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.content_Panel = new Guna.UI.WinForms.GunaPanel();
            this.container_Panel = new Guna.UI.WinForms.GunaPanel();
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.parent_panel = new Guna.UI.WinForms.GunaPanel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tracking_Table_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.add_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.returned_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.emp_History_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.item_History_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1.SuspendLayout();
            this.container_Panel.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.parent_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Location = new System.Drawing.Point(12, 12);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1579, 902);
            this.gunaPanel1.TabIndex = 0;
            // 
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.White;
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(0, 55);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(1583, 851);
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
            this.container_Panel.Size = new System.Drawing.Size(1583, 906);
            this.container_Panel.TabIndex = 3;
            // 
            // nav_panel
            // 
            this.nav_panel.AutoSize = true;
            this.nav_panel.BackColor = System.Drawing.Color.White;
            this.nav_panel.Controls.Add(this.tracking_Table_Btn);
            this.nav_panel.Controls.Add(this.add_Btn);
            this.nav_panel.Controls.Add(this.returned_Btn);
            this.nav_panel.Controls.Add(this.emp_History_Btn);
            this.nav_panel.Controls.Add(this.item_History_Btn);
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(0, 0);
            this.nav_panel.Margin = new System.Windows.Forms.Padding(0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(1583, 55);
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
            this.parent_panel.Size = new System.Drawing.Size(1583, 906);
            this.parent_panel.TabIndex = 4;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // tracking_Table_Btn
            // 
            this.tracking_Table_Btn.Animated = true;
            this.tracking_Table_Btn.AnimationHoverSpeed = 0.07F;
            this.tracking_Table_Btn.AnimationSpeed = 0.03F;
            this.tracking_Table_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.tracking_Table_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.tracking_Table_Btn.BorderColor = System.Drawing.Color.Black;
            this.tracking_Table_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.tracking_Table_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.tracking_Table_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.tracking_Table_Btn.CheckedImage = null;
            this.tracking_Table_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.tracking_Table_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tracking_Table_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.tracking_Table_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.tracking_Table_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.tracking_Table_Btn.ForeColor = System.Drawing.Color.White;
            this.tracking_Table_Btn.Image = global::COA_IMS.Properties.Resources.tracking_ics_white_24;
            this.tracking_Table_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.tracking_Table_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.tracking_Table_Btn.Location = new System.Drawing.Point(0, 0);
            this.tracking_Table_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.tracking_Table_Btn.Name = "tracking_Table_Btn";
            this.tracking_Table_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.tracking_Table_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.tracking_Table_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.tracking_Table_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.tracking_ics_darkblue_24;
            this.tracking_Table_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.tracking_Table_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.tracking_Table_Btn.Size = new System.Drawing.Size(230, 55);
            this.tracking_Table_Btn.TabIndex = 4;
            this.tracking_Table_Btn.Text = "TRACKING TABLE";
            this.tracking_Table_Btn.TextOffsetX = 5;
            this.tracking_Table_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // add_Btn
            // 
            this.add_Btn.Animated = true;
            this.add_Btn.AnimationHoverSpeed = 0.07F;
            this.add_Btn.AnimationSpeed = 0.03F;
            this.add_Btn.BackColor = System.Drawing.Color.Transparent;
            this.add_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.add_Btn.BorderColor = System.Drawing.Color.Black;
            this.add_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.add_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.add_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.add_Btn.CheckedImage = null;
            this.add_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.add_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.add_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_Btn.ForeColor = System.Drawing.Color.White;
            this.add_Btn.Image = global::COA_IMS.Properties.Resources.add_tracking_white_24;
            this.add_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.add_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.add_Btn.Location = new System.Drawing.Point(231, 0);
            this.add_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.add_Btn.Name = "add_Btn";
            this.add_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.add_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.add_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.add_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.add_tracking_darkblue_24;
            this.add_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.add_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.add_Btn.Size = new System.Drawing.Size(230, 55);
            this.add_Btn.TabIndex = 7;
            this.add_Btn.Text = "ADD";
            this.add_Btn.TextOffsetX = 5;
            this.add_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // returned_Btn
            // 
            this.returned_Btn.Animated = true;
            this.returned_Btn.AnimationHoverSpeed = 0.07F;
            this.returned_Btn.AnimationSpeed = 0.03F;
            this.returned_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.returned_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.returned_Btn.BorderColor = System.Drawing.Color.Black;
            this.returned_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.returned_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.returned_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.returned_Btn.CheckedImage = null;
            this.returned_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.returned_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returned_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.returned_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.returned_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.returned_Btn.ForeColor = System.Drawing.Color.White;
            this.returned_Btn.Image = global::COA_IMS.Properties.Resources.returned_table_white_24;
            this.returned_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.returned_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.returned_Btn.Location = new System.Drawing.Point(462, 0);
            this.returned_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.returned_Btn.Name = "returned_Btn";
            this.returned_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.returned_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.returned_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.returned_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.returned_table_darkblue_24;
            this.returned_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.returned_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.returned_Btn.Size = new System.Drawing.Size(230, 55);
            this.returned_Btn.TabIndex = 5;
            this.returned_Btn.Text = "RETURNED";
            this.returned_Btn.TextOffsetX = 5;
            this.returned_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // emp_History_Btn
            // 
            this.emp_History_Btn.Animated = true;
            this.emp_History_Btn.AnimationHoverSpeed = 0.07F;
            this.emp_History_Btn.AnimationSpeed = 0.03F;
            this.emp_History_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.emp_History_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.emp_History_Btn.BorderColor = System.Drawing.Color.Black;
            this.emp_History_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.emp_History_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.emp_History_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.emp_History_Btn.CheckedImage = null;
            this.emp_History_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.emp_History_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp_History_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.emp_History_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.emp_History_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.emp_History_Btn.ForeColor = System.Drawing.Color.White;
            this.emp_History_Btn.Image = global::COA_IMS.Properties.Resources.employee_history_white_24;
            this.emp_History_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.emp_History_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.emp_History_Btn.Location = new System.Drawing.Point(693, 0);
            this.emp_History_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.emp_History_Btn.Name = "emp_History_Btn";
            this.emp_History_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.emp_History_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.emp_History_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.emp_History_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.employee_history_darkblue_24;
            this.emp_History_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.emp_History_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.emp_History_Btn.Size = new System.Drawing.Size(230, 55);
            this.emp_History_Btn.TabIndex = 8;
            this.emp_History_Btn.Text = "EMPLOYEE HISTORY";
            this.emp_History_Btn.TextOffsetX = 5;
            this.emp_History_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // item_History_Btn
            // 
            this.item_History_Btn.Animated = true;
            this.item_History_Btn.AnimationHoverSpeed = 0.07F;
            this.item_History_Btn.AnimationSpeed = 0.03F;
            this.item_History_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.item_History_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.item_History_Btn.BorderColor = System.Drawing.Color.Black;
            this.item_History_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.item_History_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.item_History_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.item_History_Btn.CheckedImage = null;
            this.item_History_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.item_History_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item_History_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.item_History_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.item_History_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.item_History_Btn.ForeColor = System.Drawing.Color.White;
            this.item_History_Btn.Image = global::COA_IMS.Properties.Resources.item_history_white_24;
            this.item_History_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.item_History_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.item_History_Btn.Location = new System.Drawing.Point(924, 0);
            this.item_History_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.item_History_Btn.Name = "item_History_Btn";
            this.item_History_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.item_History_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.item_History_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.item_History_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.item_history_darkblue_24;
            this.item_History_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.item_History_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.item_History_Btn.Size = new System.Drawing.Size(230, 55);
            this.item_History_Btn.TabIndex = 9;
            this.item_History_Btn.Text = "ITEM HISTORY";
            this.item_History_Btn.TextOffsetX = 5;
            this.item_History_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // IMS_Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1603, 926);
            this.Controls.Add(this.parent_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IMS_Tracking";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "IMS_Tracking";
            this.Load += new System.EventHandler(this.IMS_Tracking_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.container_Panel.ResumeLayout(false);
            this.container_Panel.PerformLayout();
            this.nav_panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.parent_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        //new master
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel content_Panel;
        private Guna.UI.WinForms.GunaPanel container_Panel;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private Guna.UI.WinForms.GunaAdvenceButton tracking_Table_Btn;
        private Guna.UI.WinForms.GunaAdvenceButton add_Btn;
        private Guna.UI.WinForms.GunaAdvenceButton returned_Btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private Guna.UI.WinForms.GunaPanel parent_panel;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI.WinForms.GunaAdvenceButton emp_History_Btn;
        private Guna.UI.WinForms.GunaAdvenceButton item_History_Btn;
        //master end
    }
}