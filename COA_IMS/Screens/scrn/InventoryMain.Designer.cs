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
            this.parent_panel = new Guna.UI.WinForms.GunaPanel();
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.inventory_Table_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
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
            this.container_Panel.Size = new System.Drawing.Size(1603, 866);
            this.container_Panel.TabIndex = 3;
            // 
            // parent_panel
            // 
            this.parent_panel.BackColor = System.Drawing.Color.Transparent;
            this.parent_panel.Controls.Add(this.container_Panel);
            this.parent_panel.Controls.Add(this.line_Panel);
            this.parent_panel.Controls.Add(this.nav_panel);
            this.parent_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_panel.Location = new System.Drawing.Point(0, 0);
            this.parent_panel.Margin = new System.Windows.Forms.Padding(2);
            this.parent_panel.Name = "parent_panel";
            this.parent_panel.Size = new System.Drawing.Size(1603, 926);
            this.parent_panel.TabIndex = 3;
            // 
            // line_Panel
            // 
            this.line_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.line_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.line_Panel.Location = new System.Drawing.Point(0, 55);
            this.line_Panel.Name = "line_Panel";
            this.line_Panel.Size = new System.Drawing.Size(1603, 5);
            this.line_Panel.TabIndex = 1;
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.White;
            this.nav_panel.Controls.Add(this.inventory_Table_Btn);
            this.nav_panel.Controls.Add(this.gunaAdvenceButton1);
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(0, 0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(1603, 55);
            this.nav_panel.TabIndex = 0;
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
            this.inventory_Table_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
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
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Animated = true;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::COA_IMS.Properties.Resources.newspaper__1_;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(223, 0);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(222, 55);
            this.gunaAdvenceButton1.TabIndex = 5;
            this.gunaAdvenceButton1.Text = "ARCHIVED TABLE";
            this.gunaAdvenceButton1.TextOffsetX = 5;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.button_Click);
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
            this.Load += new System.EventHandler(this.InventoryMain_Load);
            this.parent_panel.ResumeLayout(false);
            this.nav_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel container_Panel;
        private Guna.UI.WinForms.GunaPanel parent_panel;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI.WinForms.GunaAdvenceButton inventory_Table_Btn;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}