namespace COA_IMS.Screens
{
    partial class Projects
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
            this.lists_Btn = new Guna.UI.WinForms.GunaButton();
            this.create_Btn = new Guna.UI.WinForms.GunaButton();
            this.archive_Btn = new Guna.UI.WinForms.GunaButton();
            this.parent_panel.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // parent_panel
            // 
            this.parent_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parent_panel.BackColor = System.Drawing.Color.Transparent;
            this.parent_panel.Controls.Add(this.container_Panel);
            this.parent_panel.Controls.Add(this.line_Panel);
            this.parent_panel.Controls.Add(this.nav_panel);
            this.parent_panel.Location = new System.Drawing.Point(12, 12);
            this.parent_panel.Name = "parent_panel";
            this.parent_panel.Size = new System.Drawing.Size(1567, 877);
            this.parent_panel.TabIndex = 1;
            // 
            // container_Panel
            // 
            this.container_Panel.BackColor = System.Drawing.Color.White;
            this.container_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_Panel.Location = new System.Drawing.Point(0, 60);
            this.container_Panel.Name = "container_Panel";
            this.container_Panel.Padding = new System.Windows.Forms.Padding(5);
            this.container_Panel.Size = new System.Drawing.Size(1567, 817);
            this.container_Panel.TabIndex = 2;
            // 
            // line_Panel
            // 
            this.line_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.line_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.line_Panel.Location = new System.Drawing.Point(0, 55);
            this.line_Panel.Name = "line_Panel";
            this.line_Panel.Size = new System.Drawing.Size(1567, 5);
            this.line_Panel.TabIndex = 1;
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.Transparent;
            this.nav_panel.Controls.Add(this.lists_Btn);
            this.nav_panel.Controls.Add(this.create_Btn);
            this.nav_panel.Controls.Add(this.archive_Btn);
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(0, 0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(1567, 55);
            this.nav_panel.TabIndex = 0;
            // 
            // lists_Btn
            // 
            this.lists_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lists_Btn.AnimationHoverSpeed = 0.07F;
            this.lists_Btn.AnimationSpeed = 0.03F;
            this.lists_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.lists_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.lists_Btn.BorderColor = System.Drawing.Color.Black;
            this.lists_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.lists_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.lists_Btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lists_Btn.ForeColor = System.Drawing.Color.White;
            this.lists_Btn.Image = global::COA_IMS.Properties.Resources.apps_sort;
            this.lists_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.lists_Btn.Location = new System.Drawing.Point(0, 0);
            this.lists_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.lists_Btn.Name = "lists_Btn";
            this.lists_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.lists_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lists_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.lists_Btn.OnHoverImage = null;
            this.lists_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.lists_Btn.Size = new System.Drawing.Size(180, 55);
            this.lists_Btn.TabIndex = 0;
            this.lists_Btn.Text = "LISTS";
            this.lists_Btn.Click += new System.EventHandler(this.button_Clicked);
            // 
            // create_Btn
            // 
            this.create_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.create_Btn.AnimationHoverSpeed = 0.07F;
            this.create_Btn.AnimationSpeed = 0.03F;
            this.create_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.create_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.create_Btn.BorderColor = System.Drawing.Color.Black;
            this.create_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.create_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.create_Btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_Btn.ForeColor = System.Drawing.Color.White;
            this.create_Btn.Image = global::COA_IMS.Properties.Resources.select;
            this.create_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.create_Btn.Location = new System.Drawing.Point(181, 0);
            this.create_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.create_Btn.Name = "create_Btn";
            this.create_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.create_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.create_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.create_Btn.OnHoverImage = null;
            this.create_Btn.OnPressedColor = System.Drawing.Color.White;
            this.create_Btn.Size = new System.Drawing.Size(180, 55);
            this.create_Btn.TabIndex = 1;
            this.create_Btn.Text = "CREATE";
            this.create_Btn.Click += new System.EventHandler(this.button_Clicked);
            // 
            // archive_Btn
            // 
            this.archive_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.archive_Btn.AnimationHoverSpeed = 0.07F;
            this.archive_Btn.AnimationSpeed = 0.03F;
            this.archive_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.archive_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.archive_Btn.BorderColor = System.Drawing.Color.Black;
            this.archive_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.archive_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.archive_Btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archive_Btn.ForeColor = System.Drawing.Color.White;
            this.archive_Btn.Image = global::COA_IMS.Properties.Resources.folder_download;
            this.archive_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.archive_Btn.Location = new System.Drawing.Point(362, 0);
            this.archive_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.archive_Btn.Name = "archive_Btn";
            this.archive_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.archive_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.archive_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.archive_Btn.OnHoverImage = null;
            this.archive_Btn.OnPressedColor = System.Drawing.Color.White;
            this.archive_Btn.Size = new System.Drawing.Size(180, 55);
            this.archive_Btn.TabIndex = 2;
            this.archive_Btn.Text = "ARCHIVED";
            this.archive_Btn.Click += new System.EventHandler(this.button_Clicked);
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1591, 901);
            this.Controls.Add(this.parent_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Projects";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.Projects_Load);
            this.parent_panel.ResumeLayout(false);
            this.nav_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel parent_panel;
        private Guna.UI.WinForms.GunaPanel container_Panel;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private Guna.UI.WinForms.GunaButton lists_Btn;
        private Guna.UI.WinForms.GunaButton create_Btn;
        private Guna.UI.WinForms.GunaButton archive_Btn;
    }
}