namespace COA_IMS.Screens.scrn
{
    partial class InventoryMain
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
            this.content_Panel = new Guna.UI.WinForms.GunaPanel();
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.parent_panel = new Guna.UI.WinForms.GunaPanel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.inventory_Table_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.disposal_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.archived_Table_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.container_Panel.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.parent_panel.SuspendLayout();
            this.SuspendLayout();
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
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.White;
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(0, 55);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(1583, 851);
            this.content_Panel.TabIndex = 7;
            // 
            // nav_panel
            // 
            this.nav_panel.AutoSize = true;
            this.nav_panel.BackColor = System.Drawing.Color.White;
            this.nav_panel.Controls.Add(this.inventory_Table_Btn);
            this.nav_panel.Controls.Add(this.disposal_Btn);
            this.nav_panel.Controls.Add(this.archived_Table_Btn);
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
            this.parent_panel.TabIndex = 3;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // inventory_Table_Btn
            // 
            this.inventory_Table_Btn.Animated = true;
            this.inventory_Table_Btn.AnimationHoverSpeed = 0.07F;
            this.inventory_Table_Btn.AnimationSpeed = 0.03F;
            this.inventory_Table_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.inventory_Table_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.inventory_Table_Btn.BorderColor = System.Drawing.Color.Black;
            this.inventory_Table_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.inventory_Table_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.inventory_Table_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.inventory_Table_Btn.CheckedImage = null;
            this.inventory_Table_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.inventory_Table_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventory_Table_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.inventory_Table_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.inventory_Table_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.inventory_Table_Btn.ForeColor = System.Drawing.Color.White;
            this.inventory_Table_Btn.Image = global::COA_IMS.Properties.Resources.newspaper__1_;
            this.inventory_Table_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.inventory_Table_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.inventory_Table_Btn.Location = new System.Drawing.Point(0, 0);
            this.inventory_Table_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.inventory_Table_Btn.Name = "inventory_Table_Btn";
            this.inventory_Table_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.inventory_Table_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.inventory_Table_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.inventory_Table_Btn.OnHoverImage = null;
            this.inventory_Table_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.inventory_Table_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.inventory_Table_Btn.Size = new System.Drawing.Size(222, 55);
            this.inventory_Table_Btn.TabIndex = 4;
            this.inventory_Table_Btn.Text = "INVENTORY TABLE";
            this.inventory_Table_Btn.TextOffsetX = 5;
            this.inventory_Table_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // disposal_Btn
            // 
            this.disposal_Btn.Animated = true;
            this.disposal_Btn.AnimationHoverSpeed = 0.07F;
            this.disposal_Btn.AnimationSpeed = 0.03F;
            this.disposal_Btn.BackColor = System.Drawing.Color.Transparent;
            this.disposal_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.disposal_Btn.BorderColor = System.Drawing.Color.Black;
            this.disposal_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.disposal_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.disposal_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.disposal_Btn.CheckedImage = null;
            this.disposal_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.disposal_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disposal_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.disposal_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.disposal_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.disposal_Btn.ForeColor = System.Drawing.Color.White;
            this.disposal_Btn.Image = global::COA_IMS.Properties.Resources.newspaper__1_;
            this.disposal_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.disposal_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.disposal_Btn.Location = new System.Drawing.Point(223, 0);
            this.disposal_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.disposal_Btn.Name = "disposal_Btn";
            this.disposal_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.disposal_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.disposal_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.disposal_Btn.OnHoverImage = null;
            this.disposal_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.disposal_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.disposal_Btn.Size = new System.Drawing.Size(222, 55);
            this.disposal_Btn.TabIndex = 7;
            this.disposal_Btn.Text = "DISPOSAL";
            this.disposal_Btn.TextOffsetX = 5;
            this.disposal_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // archived_Table_Btn
            // 
            this.archived_Table_Btn.Animated = true;
            this.archived_Table_Btn.AnimationHoverSpeed = 0.07F;
            this.archived_Table_Btn.AnimationSpeed = 0.03F;
            this.archived_Table_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.archived_Table_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.archived_Table_Btn.BorderColor = System.Drawing.Color.Black;
            this.archived_Table_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.archived_Table_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.archived_Table_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.archived_Table_Btn.CheckedImage = null;
            this.archived_Table_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.archived_Table_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.archived_Table_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.archived_Table_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.archived_Table_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.archived_Table_Btn.ForeColor = System.Drawing.Color.White;
            this.archived_Table_Btn.Image = global::COA_IMS.Properties.Resources.newspaper__1_;
            this.archived_Table_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.archived_Table_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.archived_Table_Btn.Location = new System.Drawing.Point(446, 0);
            this.archived_Table_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.archived_Table_Btn.Name = "archived_Table_Btn";
            this.archived_Table_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.archived_Table_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.archived_Table_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.archived_Table_Btn.OnHoverImage = null;
            this.archived_Table_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.archived_Table_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.archived_Table_Btn.Size = new System.Drawing.Size(222, 55);
            this.archived_Table_Btn.TabIndex = 5;
            this.archived_Table_Btn.Text = "ARCHIVED TABLE";
            this.archived_Table_Btn.TextOffsetX = 5;
            this.archived_Table_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // InventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1603, 926);
            this.Controls.Add(this.parent_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "InventoryMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryMain_Load);
            this.container_Panel.ResumeLayout(false);
            this.container_Panel.PerformLayout();
            this.nav_panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.parent_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel container_Panel;
        private Guna.UI.WinForms.GunaPanel parent_panel;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private Guna.UI.WinForms.GunaAdvenceButton archived_Table_Btn;
        private Guna.UI.WinForms.GunaAdvenceButton disposal_Btn;
        private Guna.UI.WinForms.GunaAdvenceButton inventory_Table_Btn;
        private Guna.UI.WinForms.GunaPanel content_Panel;
    }
}