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
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.inventory_Table_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.archived_Table_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.categorybtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Supplierbtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.disposal_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.parent_panel = new Guna.UI.WinForms.GunaPanel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.container_Panel.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.parent_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_Panel
            // 
            this.container_Panel.BackColor = System.Drawing.Color.White;
            this.container_Panel.Controls.Add(this.content_Panel);
            this.container_Panel.Controls.Add(this.line_Panel);
            this.container_Panel.Controls.Add(this.nav_panel);
            this.container_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_Panel.Location = new System.Drawing.Point(0, 0);
            this.container_Panel.Name = "container_Panel";
            this.container_Panel.Size = new System.Drawing.Size(1603, 926);
            this.container_Panel.TabIndex = 3;
            // 
            // content_Panel
            // 
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(0, 60);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(1603, 866);
            this.content_Panel.TabIndex = 6;
            // 
            // line_Panel
            // 
            this.line_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.line_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.line_Panel.Location = new System.Drawing.Point(0, 55);
            this.line_Panel.Name = "line_Panel";
            this.line_Panel.Size = new System.Drawing.Size(1603, 5);
            this.line_Panel.TabIndex = 5;
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.White;
            this.nav_panel.Controls.Add(this.inventory_Table_Btn);
            this.nav_panel.Controls.Add(this.archived_Table_Btn);
            this.nav_panel.Controls.Add(this.categorybtn);
            this.nav_panel.Controls.Add(this.Supplierbtn);
            this.nav_panel.Controls.Add(this.disposal_Btn);
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(0, 0);
            this.nav_panel.Margin = new System.Windows.Forms.Padding(0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(1603, 55);
            this.nav_panel.TabIndex = 4;
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
            this.inventory_Table_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.inventory_Table_Btn.Location = new System.Drawing.Point(0, 0);
            this.inventory_Table_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.inventory_Table_Btn.Name = "inventory_Table_Btn";
            this.inventory_Table_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.inventory_Table_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.inventory_Table_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.inventory_Table_Btn.OnHoverImage = null;
            this.inventory_Table_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.inventory_Table_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.inventory_Table_Btn.Size = new System.Drawing.Size(222, 55);
            this.inventory_Table_Btn.TabIndex = 4;
            this.inventory_Table_Btn.Text = "INVENTORY TABLE";
            this.inventory_Table_Btn.TextOffsetX = 5;
            this.inventory_Table_Btn.Click += new System.EventHandler(this.button_Click);
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
            this.archived_Table_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.archived_Table_Btn.Location = new System.Drawing.Point(223, 0);
            this.archived_Table_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.archived_Table_Btn.Name = "archived_Table_Btn";
            this.archived_Table_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.archived_Table_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.archived_Table_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.archived_Table_Btn.OnHoverImage = null;
            this.archived_Table_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.archived_Table_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.archived_Table_Btn.Size = new System.Drawing.Size(222, 55);
            this.archived_Table_Btn.TabIndex = 5;
            this.archived_Table_Btn.Text = "ARCHIVED TABLE";
            this.archived_Table_Btn.TextOffsetX = 5;
            this.archived_Table_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // categorybtn
            // 
            this.categorybtn.Animated = true;
            this.categorybtn.AnimationHoverSpeed = 0.07F;
            this.categorybtn.AnimationSpeed = 0.03F;
            this.categorybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.categorybtn.BaseColor = System.Drawing.Color.Transparent;
            this.categorybtn.BorderColor = System.Drawing.Color.Black;
            this.categorybtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.categorybtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.categorybtn.CheckedForeColor = System.Drawing.Color.White;
            this.categorybtn.CheckedImage = null;
            this.categorybtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.categorybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categorybtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.categorybtn.FocusedColor = System.Drawing.Color.Empty;
            this.categorybtn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.categorybtn.ForeColor = System.Drawing.Color.White;
            this.categorybtn.Image = global::COA_IMS.Properties.Resources.newspaper__1_;
            this.categorybtn.ImageSize = new System.Drawing.Size(20, 20);
            this.categorybtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.categorybtn.Location = new System.Drawing.Point(446, 0);
            this.categorybtn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.categorybtn.Name = "categorybtn";
            this.categorybtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.categorybtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.categorybtn.OnHoverForeColor = System.Drawing.Color.White;
            this.categorybtn.OnHoverImage = null;
            this.categorybtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.categorybtn.OnPressedColor = System.Drawing.Color.Black;
            this.categorybtn.Size = new System.Drawing.Size(222, 55);
            this.categorybtn.TabIndex = 6;
            this.categorybtn.Text = "CATEGORY";
            this.categorybtn.TextOffsetX = 5;
            this.categorybtn.Click += new System.EventHandler(this.button_Click);
            // 
            // Supplierbtn
            // 
            this.Supplierbtn.Animated = true;
            this.Supplierbtn.AnimationHoverSpeed = 0.07F;
            this.Supplierbtn.AnimationSpeed = 0.03F;
            this.Supplierbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.Supplierbtn.BaseColor = System.Drawing.Color.Transparent;
            this.Supplierbtn.BorderColor = System.Drawing.Color.Black;
            this.Supplierbtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Supplierbtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.Supplierbtn.CheckedForeColor = System.Drawing.Color.White;
            this.Supplierbtn.CheckedImage = null;
            this.Supplierbtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Supplierbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Supplierbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Supplierbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Supplierbtn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.Supplierbtn.ForeColor = System.Drawing.Color.White;
            this.Supplierbtn.Image = global::COA_IMS.Properties.Resources.newspaper__1_;
            this.Supplierbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.Supplierbtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Supplierbtn.Location = new System.Drawing.Point(669, 0);
            this.Supplierbtn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.Supplierbtn.Name = "Supplierbtn";
            this.Supplierbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.Supplierbtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.Supplierbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Supplierbtn.OnHoverImage = null;
            this.Supplierbtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Supplierbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Supplierbtn.Size = new System.Drawing.Size(222, 55);
            this.Supplierbtn.TabIndex = 5;
            this.Supplierbtn.Text = "SUPPLIER";
            this.Supplierbtn.TextOffsetX = 5;
            this.Supplierbtn.Click += new System.EventHandler(this.button_Click);
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
            this.disposal_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.disposal_Btn.Location = new System.Drawing.Point(892, 0);
            this.disposal_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.disposal_Btn.Name = "disposal_Btn";
            this.disposal_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.disposal_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.disposal_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.disposal_Btn.OnHoverImage = null;
            this.disposal_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.disposal_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.disposal_Btn.Size = new System.Drawing.Size(222, 55);
            this.disposal_Btn.TabIndex = 7;
            this.disposal_Btn.Text = "DISPOSAL";
            this.disposal_Btn.TextOffsetX = 5;
            this.disposal_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // parent_panel
            // 
            this.parent_panel.BackColor = System.Drawing.Color.Transparent;
            this.parent_panel.Controls.Add(this.container_Panel);
            this.parent_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_panel.Location = new System.Drawing.Point(0, 0);
            this.parent_panel.Margin = new System.Windows.Forms.Padding(2);
            this.parent_panel.Name = "parent_panel";
            this.parent_panel.Size = new System.Drawing.Size(1603, 926);
            this.parent_panel.TabIndex = 3;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // InventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 926);
            this.Controls.Add(this.parent_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryMain";
            this.Text = "InventoryMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryMain_Load);
            this.container_Panel.ResumeLayout(false);
            this.nav_panel.ResumeLayout(false);
            this.parent_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel container_Panel;
        private Guna.UI.WinForms.GunaPanel parent_panel;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private Guna.UI.WinForms.GunaAdvenceButton inventory_Table_Btn;
        private Guna.UI.WinForms.GunaAdvenceButton archived_Table_Btn;
        private Guna.UI.WinForms.GunaAdvenceButton categorybtn;
        private Guna.UI.WinForms.GunaAdvenceButton Supplierbtn;
        private Guna.UI.WinForms.GunaAdvenceButton disposal_Btn;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private Guna.UI.WinForms.GunaPanel content_Panel;
    }
}