namespace COA_IMS.Screens.scrn
{
    partial class IMS_Settings
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
            this.item_Category_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.item_Supplier_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
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
            this.nav_panel.Controls.Add(this.item_Category_Btn);
            this.nav_panel.Controls.Add(this.item_Supplier_Btn);
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
            // item_Category_Btn
            // 
            this.item_Category_Btn.Animated = true;
            this.item_Category_Btn.AnimationHoverSpeed = 0.07F;
            this.item_Category_Btn.AnimationSpeed = 0.03F;
            this.item_Category_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.item_Category_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.item_Category_Btn.BorderColor = System.Drawing.Color.Black;
            this.item_Category_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.item_Category_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.item_Category_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.item_Category_Btn.CheckedImage = null;
            this.item_Category_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.item_Category_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item_Category_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.item_Category_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.item_Category_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.item_Category_Btn.ForeColor = System.Drawing.Color.White;
            this.item_Category_Btn.Image = global::COA_IMS.Properties.Resources.item_category_white_24;
            this.item_Category_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.item_Category_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.item_Category_Btn.Location = new System.Drawing.Point(0, 0);
            this.item_Category_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.item_Category_Btn.Name = "item_Category_Btn";
            this.item_Category_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.item_Category_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.item_Category_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.item_Category_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.item_category_darkblue_24;
            this.item_Category_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.item_Category_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.item_Category_Btn.Size = new System.Drawing.Size(222, 55);
            this.item_Category_Btn.TabIndex = 4;
            this.item_Category_Btn.Text = "ITEM CATEGORY";
            this.item_Category_Btn.TextOffsetX = 5;
            this.item_Category_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // item_Supplier_Btn
            // 
            this.item_Supplier_Btn.Animated = true;
            this.item_Supplier_Btn.AnimationHoverSpeed = 0.07F;
            this.item_Supplier_Btn.AnimationSpeed = 0.03F;
            this.item_Supplier_Btn.BackColor = System.Drawing.Color.Transparent;
            this.item_Supplier_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.item_Supplier_Btn.BorderColor = System.Drawing.Color.Black;
            this.item_Supplier_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.item_Supplier_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.item_Supplier_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.item_Supplier_Btn.CheckedImage = null;
            this.item_Supplier_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.item_Supplier_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item_Supplier_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.item_Supplier_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.item_Supplier_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.item_Supplier_Btn.ForeColor = System.Drawing.Color.White;
            this.item_Supplier_Btn.Image = global::COA_IMS.Properties.Resources.item_supplier_white_24;
            this.item_Supplier_Btn.ImageSize = new System.Drawing.Size(24, 24);
            this.item_Supplier_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.item_Supplier_Btn.Location = new System.Drawing.Point(223, 0);
            this.item_Supplier_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.item_Supplier_Btn.Name = "item_Supplier_Btn";
            this.item_Supplier_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.item_Supplier_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.item_Supplier_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.item_Supplier_Btn.OnHoverImage = global::COA_IMS.Properties.Resources.item_supplier_darkblue_24;
            this.item_Supplier_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.item_Supplier_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.item_Supplier_Btn.Size = new System.Drawing.Size(222, 55);
            this.item_Supplier_Btn.TabIndex = 7;
            this.item_Supplier_Btn.Text = "ITEM SUPPLIER";
            this.item_Supplier_Btn.TextOffsetX = 5;
            this.item_Supplier_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // IMS_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1603, 926);
            this.Controls.Add(this.parent_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IMS_Settings";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "IMS_Settings";
            this.Load += new System.EventHandler(this.IMS_Settings_Load);
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
        private Guna.UI.WinForms.GunaAdvenceButton item_Category_Btn;
        private Guna.UI.WinForms.GunaAdvenceButton item_Supplier_Btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private Guna.UI.WinForms.GunaPanel parent_panel;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}