namespace COA_IMS.Screens
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.SidebarContainer = new Guna.UI.WinForms.GunaPanel();
            this.tab_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.home_Panel = new Guna.UI.WinForms.GunaPanel();
            this.HomeBtn = new Guna.UI.WinForms.GunaButton();
            this.projects_Panel = new Guna.UI.WinForms.GunaPanel();
            this.Createbtn = new Guna.UI.WinForms.GunaButton();
            this.employee_Panel = new Guna.UI.WinForms.GunaPanel();
            this.EmployeeBtn = new Guna.UI.WinForms.GunaButton();
            this.report_Panel = new Guna.UI.WinForms.GunaPanel();
            this.ReportBtn = new Guna.UI.WinForms.GunaButton();
            this.user_Panel = new Guna.UI.WinForms.GunaPanel();
            this.UserBtn = new Guna.UI.WinForms.GunaButton();
            this.maintenance_Panel = new Guna.UI.WinForms.GunaPanel();
            this.MaintenanceBtn = new Guna.UI.WinForms.GunaButton();
            this.activity_Panel = new Guna.UI.WinForms.GunaPanel();
            this.LogBtn = new Guna.UI.WinForms.GunaButton();
            this.logo_Panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.logout_Panel = new Guna.UI.WinForms.GunaPanel();
            this.Logoutbtn = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.header_Panel = new Guna.UI.WinForms.GunaPanel();
            this.title_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.headerTitle = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.Main_Form = new Guna.UI.WinForms.GunaPanel();
            this.button_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SidebarContainer.SuspendLayout();
            this.tab_panel.SuspendLayout();
            this.home_Panel.SuspendLayout();
            this.projects_Panel.SuspendLayout();
            this.employee_Panel.SuspendLayout();
            this.report_Panel.SuspendLayout();
            this.user_Panel.SuspendLayout();
            this.maintenance_Panel.SuspendLayout();
            this.activity_Panel.SuspendLayout();
            this.logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.logout_Panel.SuspendLayout();
            this.header_Panel.SuspendLayout();
            this.title_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarContainer
            // 
            this.SidebarContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.SidebarContainer.Controls.Add(this.tab_panel);
            this.SidebarContainer.Controls.Add(this.logo_Panel);
            this.SidebarContainer.Controls.Add(this.logout_Panel);
            this.SidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.SidebarContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarContainer.MaximumSize = new System.Drawing.Size(250, 1056);
            this.SidebarContainer.MinimumSize = new System.Drawing.Size(95, 845);
            this.SidebarContainer.Name = "SidebarContainer";
            this.SidebarContainer.Size = new System.Drawing.Size(95, 845);
            this.SidebarContainer.TabIndex = 10;
            // 
            // tab_panel
            // 
            this.tab_panel.BackColor = System.Drawing.Color.Transparent;
            this.tab_panel.Controls.Add(this.home_Panel);
            this.tab_panel.Controls.Add(this.projects_Panel);
            this.tab_panel.Controls.Add(this.employee_Panel);
            this.tab_panel.Controls.Add(this.report_Panel);
            this.tab_panel.Controls.Add(this.user_Panel);
            this.tab_panel.Controls.Add(this.maintenance_Panel);
            this.tab_panel.Controls.Add(this.activity_Panel);
            this.tab_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_panel.Location = new System.Drawing.Point(0, 144);
            this.tab_panel.Margin = new System.Windows.Forms.Padding(0);
            this.tab_panel.Name = "tab_panel";
            this.tab_panel.Size = new System.Drawing.Size(95, 588);
            this.tab_panel.TabIndex = 6;
            // 
            // home_Panel
            // 
            this.home_Panel.BackColor = System.Drawing.Color.Transparent;
            this.home_Panel.Controls.Add(this.HomeBtn);
            this.home_Panel.Location = new System.Drawing.Point(0, 0);
            this.home_Panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.home_Panel.Name = "home_Panel";
            this.home_Panel.Size = new System.Drawing.Size(95, 70);
            this.home_Panel.TabIndex = 7;
            // 
            // HomeBtn
            // 
            this.HomeBtn.AnimationHoverSpeed = 0.07F;
            this.HomeBtn.AnimationSpeed = 0.03F;
            this.HomeBtn.BaseColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BorderColor = System.Drawing.Color.Black;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.HomeBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HomeBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.HomeBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.HomeBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.HomeBtn.OnHoverImage = null;
            this.HomeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.HomeBtn.Size = new System.Drawing.Size(95, 70);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Tag = "Dashboard";
            this.HomeBtn.TextOffsetX = 18;
            this.HomeBtn.Click += new System.EventHandler(this.button_Click);
            this.HomeBtn.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // projects_Panel
            // 
            this.projects_Panel.BackColor = System.Drawing.Color.Transparent;
            this.projects_Panel.Controls.Add(this.Createbtn);
            this.projects_Panel.Location = new System.Drawing.Point(0, 78);
            this.projects_Panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.projects_Panel.Name = "projects_Panel";
            this.projects_Panel.Size = new System.Drawing.Size(95, 70);
            this.projects_Panel.TabIndex = 9;
            // 
            // Createbtn
            // 
            this.Createbtn.AnimationHoverSpeed = 0.07F;
            this.Createbtn.AnimationSpeed = 0.03F;
            this.Createbtn.BaseColor = System.Drawing.Color.Transparent;
            this.Createbtn.BorderColor = System.Drawing.Color.Black;
            this.Createbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Createbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Createbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Createbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Createbtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbtn.ForeColor = System.Drawing.Color.White;
            this.Createbtn.Image = ((System.Drawing.Image)(resources.GetObject("Createbtn.Image")));
            this.Createbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Createbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Createbtn.Location = new System.Drawing.Point(0, 0);
            this.Createbtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Createbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Createbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Createbtn.OnHoverImage = null;
            this.Createbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Createbtn.Size = new System.Drawing.Size(95, 70);
            this.Createbtn.TabIndex = 3;
            this.Createbtn.Tag = "Projects";
            this.Createbtn.TextOffsetX = 18;
            this.Createbtn.Click += new System.EventHandler(this.button_Click);
            this.Createbtn.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // employee_Panel
            // 
            this.employee_Panel.BackColor = System.Drawing.Color.Transparent;
            this.employee_Panel.Controls.Add(this.EmployeeBtn);
            this.employee_Panel.Location = new System.Drawing.Point(0, 156);
            this.employee_Panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.employee_Panel.Name = "employee_Panel";
            this.employee_Panel.Size = new System.Drawing.Size(95, 70);
            this.employee_Panel.TabIndex = 9;
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.AnimationHoverSpeed = 0.07F;
            this.EmployeeBtn.AnimationSpeed = 0.03F;
            this.EmployeeBtn.BaseColor = System.Drawing.Color.Transparent;
            this.EmployeeBtn.BorderColor = System.Drawing.Color.Black;
            this.EmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EmployeeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.EmployeeBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.EmployeeBtn.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeBtn.Image")));
            this.EmployeeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmployeeBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.EmployeeBtn.Location = new System.Drawing.Point(0, 0);
            this.EmployeeBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.EmployeeBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EmployeeBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.EmployeeBtn.OnHoverImage = null;
            this.EmployeeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.EmployeeBtn.Size = new System.Drawing.Size(95, 70);
            this.EmployeeBtn.TabIndex = 5;
            this.EmployeeBtn.Tag = "Employees";
            this.EmployeeBtn.TextOffsetX = 18;
            this.EmployeeBtn.Click += new System.EventHandler(this.button_Click);
            this.EmployeeBtn.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // report_Panel
            // 
            this.report_Panel.BackColor = System.Drawing.Color.Transparent;
            this.report_Panel.Controls.Add(this.ReportBtn);
            this.report_Panel.Location = new System.Drawing.Point(0, 234);
            this.report_Panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.report_Panel.Name = "report_Panel";
            this.report_Panel.Size = new System.Drawing.Size(95, 70);
            this.report_Panel.TabIndex = 9;
            // 
            // ReportBtn
            // 
            this.ReportBtn.AnimationHoverSpeed = 0.07F;
            this.ReportBtn.AnimationSpeed = 0.03F;
            this.ReportBtn.BaseColor = System.Drawing.Color.Transparent;
            this.ReportBtn.BorderColor = System.Drawing.Color.Black;
            this.ReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ReportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ReportBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.White;
            this.ReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReportBtn.Image")));
            this.ReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReportBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.ReportBtn.Location = new System.Drawing.Point(0, 0);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ReportBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ReportBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ReportBtn.OnHoverImage = null;
            this.ReportBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ReportBtn.Size = new System.Drawing.Size(95, 70);
            this.ReportBtn.TabIndex = 4;
            this.ReportBtn.Tag = "Reports";
            this.ReportBtn.TextOffsetX = 18;
            this.ReportBtn.Click += new System.EventHandler(this.button_Click);
            this.ReportBtn.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // user_Panel
            // 
            this.user_Panel.BackColor = System.Drawing.Color.Transparent;
            this.user_Panel.Controls.Add(this.UserBtn);
            this.user_Panel.Location = new System.Drawing.Point(0, 312);
            this.user_Panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.user_Panel.Name = "user_Panel";
            this.user_Panel.Size = new System.Drawing.Size(95, 70);
            this.user_Panel.TabIndex = 9;
            // 
            // UserBtn
            // 
            this.UserBtn.AnimationHoverSpeed = 0.07F;
            this.UserBtn.AnimationSpeed = 0.03F;
            this.UserBtn.BaseColor = System.Drawing.Color.Transparent;
            this.UserBtn.BorderColor = System.Drawing.Color.Black;
            this.UserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UserBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserBtn.FocusedColor = System.Drawing.Color.Empty;
            this.UserBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.ForeColor = System.Drawing.Color.White;
            this.UserBtn.Image = ((System.Drawing.Image)(resources.GetObject("UserBtn.Image")));
            this.UserBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.UserBtn.Location = new System.Drawing.Point(0, 0);
            this.UserBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.UserBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.UserBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.UserBtn.OnHoverImage = null;
            this.UserBtn.OnPressedColor = System.Drawing.Color.Black;
            this.UserBtn.Size = new System.Drawing.Size(95, 70);
            this.UserBtn.TabIndex = 5;
            this.UserBtn.Tag = "User Settings";
            this.UserBtn.TextOffsetX = 18;
            this.UserBtn.Click += new System.EventHandler(this.button_Click);
            this.UserBtn.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // maintenance_Panel
            // 
            this.maintenance_Panel.BackColor = System.Drawing.Color.Transparent;
            this.maintenance_Panel.Controls.Add(this.MaintenanceBtn);
            this.maintenance_Panel.Location = new System.Drawing.Point(0, 390);
            this.maintenance_Panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.maintenance_Panel.Name = "maintenance_Panel";
            this.maintenance_Panel.Size = new System.Drawing.Size(95, 70);
            this.maintenance_Panel.TabIndex = 9;
            // 
            // MaintenanceBtn
            // 
            this.MaintenanceBtn.AnimationHoverSpeed = 0.07F;
            this.MaintenanceBtn.AnimationSpeed = 0.03F;
            this.MaintenanceBtn.BaseColor = System.Drawing.Color.Transparent;
            this.MaintenanceBtn.BorderColor = System.Drawing.Color.Black;
            this.MaintenanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaintenanceBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MaintenanceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaintenanceBtn.FocusedColor = System.Drawing.Color.Empty;
            this.MaintenanceBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintenanceBtn.ForeColor = System.Drawing.Color.White;
            this.MaintenanceBtn.Image = ((System.Drawing.Image)(resources.GetObject("MaintenanceBtn.Image")));
            this.MaintenanceBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaintenanceBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.MaintenanceBtn.Location = new System.Drawing.Point(0, 0);
            this.MaintenanceBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.MaintenanceBtn.Name = "MaintenanceBtn";
            this.MaintenanceBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.MaintenanceBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MaintenanceBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.MaintenanceBtn.OnHoverImage = null;
            this.MaintenanceBtn.OnPressedColor = System.Drawing.Color.Black;
            this.MaintenanceBtn.Size = new System.Drawing.Size(95, 70);
            this.MaintenanceBtn.TabIndex = 6;
            this.MaintenanceBtn.Tag = "Maintenance";
            this.MaintenanceBtn.TextOffsetX = 18;
            this.MaintenanceBtn.Click += new System.EventHandler(this.button_Click);
            this.MaintenanceBtn.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // activity_Panel
            // 
            this.activity_Panel.BackColor = System.Drawing.Color.Transparent;
            this.activity_Panel.Controls.Add(this.LogBtn);
            this.activity_Panel.Location = new System.Drawing.Point(0, 468);
            this.activity_Panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.activity_Panel.Name = "activity_Panel";
            this.activity_Panel.Size = new System.Drawing.Size(95, 70);
            this.activity_Panel.TabIndex = 9;
            // 
            // LogBtn
            // 
            this.LogBtn.AnimationHoverSpeed = 0.07F;
            this.LogBtn.AnimationSpeed = 0.03F;
            this.LogBtn.BaseColor = System.Drawing.Color.Transparent;
            this.LogBtn.BorderColor = System.Drawing.Color.Black;
            this.LogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LogBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBtn.ForeColor = System.Drawing.Color.White;
            this.LogBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogBtn.Image")));
            this.LogBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.LogBtn.Location = new System.Drawing.Point(0, 0);
            this.LogBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LogBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LogBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LogBtn.OnHoverImage = null;
            this.LogBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LogBtn.Size = new System.Drawing.Size(95, 70);
            this.LogBtn.TabIndex = 5;
            this.LogBtn.Tag = "Activity Logs";
            this.LogBtn.TextOffsetX = 18;
            this.LogBtn.Click += new System.EventHandler(this.button_Click);
            this.LogBtn.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // logo_Panel
            // 
            this.logo_Panel.Controls.Add(this.gunaCirclePictureBox1);
            this.logo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_Panel.Location = new System.Drawing.Point(0, 0);
            this.logo_Panel.Name = "logo_Panel";
            this.logo_Panel.Size = new System.Drawing.Size(95, 144);
            this.logo_Panel.TabIndex = 8;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(11, 8);
            this.gunaCirclePictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(70, 70);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // logout_Panel
            // 
            this.logout_Panel.Controls.Add(this.Logoutbtn);
            this.logout_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_Panel.Location = new System.Drawing.Point(0, 732);
            this.logout_Panel.Name = "logout_Panel";
            this.logout_Panel.Size = new System.Drawing.Size(95, 113);
            this.logout_Panel.TabIndex = 7;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logoutbtn.AnimationHoverSpeed = 0.07F;
            this.Logoutbtn.AnimationSpeed = 0.03F;
            this.Logoutbtn.BackColor = System.Drawing.Color.Transparent;
            this.Logoutbtn.BaseColor = System.Drawing.Color.Transparent;
            this.Logoutbtn.BorderColor = System.Drawing.Color.Black;
            this.Logoutbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Logoutbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Logoutbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Logoutbtn.ForeColor = System.Drawing.Color.White;
            this.Logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("Logoutbtn.Image")));
            this.Logoutbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Logoutbtn.Location = new System.Drawing.Point(16, 35);
            this.Logoutbtn.Margin = new System.Windows.Forms.Padding(8);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Logoutbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Logoutbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Logoutbtn.OnHoverImage = null;
            this.Logoutbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Logoutbtn.Radius = 8;
            this.Logoutbtn.Size = new System.Drawing.Size(63, 61);
            this.Logoutbtn.TabIndex = 1;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.AutoSize = true;
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1540, 0);
            this.gunaElipsePanel1.TabIndex = 2;
            // 
            // header_Panel
            // 
            this.header_Panel.Controls.Add(this.title_Panel);
            this.header_Panel.Controls.Add(this.gunaLabel1);
            this.header_Panel.Controls.Add(this.gunaPictureBox2);
            this.header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_Panel.Location = new System.Drawing.Point(95, 0);
            this.header_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.header_Panel.Name = "header_Panel";
            this.header_Panel.Size = new System.Drawing.Size(1445, 90);
            this.header_Panel.TabIndex = 12;
            // 
            // title_Panel
            // 
            this.title_Panel.AutoSize = true;
            this.title_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.title_Panel.BackColor = System.Drawing.Color.Transparent;
            this.title_Panel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title_Panel.Controls.Add(this.headerTitle);
            this.title_Panel.Location = new System.Drawing.Point(-6, 11);
            this.title_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.title_Panel.Name = "title_Panel";
            this.title_Panel.Size = new System.Drawing.Size(144, 67);
            this.title_Panel.TabIndex = 10;
            // 
            // headerTitle
            // 
            this.headerTitle.AutoSize = true;
            this.headerTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTitle.ForeColor = System.Drawing.Color.White;
            this.headerTitle.Location = new System.Drawing.Point(45, 18);
            this.headerTitle.Margin = new System.Windows.Forms.Padding(20);
            this.headerTitle.Name = "headerTitle";
            this.headerTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.headerTitle.Size = new System.Drawing.Size(79, 29);
            this.headerTitle.TabIndex = 10;
            this.headerTitle.Text = "120123";
            this.headerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1266, 28);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(111, 25);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "MAMA MO";
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(1383, 15);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(50, 50);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 11;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Visible = false;
            // 
            // Main_Form
            // 
            this.Main_Form.BackColor = System.Drawing.Color.Silver;
            this.Main_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Form.Location = new System.Drawing.Point(95, 90);
            this.Main_Form.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Form.Name = "Main_Form";
            this.Main_Form.Size = new System.Drawing.Size(1445, 755);
            this.Main_Form.TabIndex = 13;
            // 
            // button_ToolTip
            // 
            this.button_ToolTip.ForeColor = System.Drawing.Color.Black;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.Main_Form);
            this.Controls.Add(this.header_Panel);
            this.Controls.Add(this.SidebarContainer);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 822);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.SidebarContainer.ResumeLayout(false);
            this.tab_panel.ResumeLayout(false);
            this.home_Panel.ResumeLayout(false);
            this.projects_Panel.ResumeLayout(false);
            this.employee_Panel.ResumeLayout(false);
            this.report_Panel.ResumeLayout(false);
            this.user_Panel.ResumeLayout(false);
            this.maintenance_Panel.ResumeLayout(false);
            this.activity_Panel.ResumeLayout(false);
            this.logo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.logout_Panel.ResumeLayout(false);
            this.header_Panel.ResumeLayout(false);
            this.header_Panel.PerformLayout();
            this.title_Panel.ResumeLayout(false);
            this.title_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel SidebarContainer;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaButton Logoutbtn;
        private Guna.UI.WinForms.GunaPanel header_Panel;
        private Guna.UI.WinForms.GunaElipsePanel title_Panel;
        private Guna.UI.WinForms.GunaLabel headerTitle;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPanel Main_Form;
        private System.Windows.Forms.FlowLayoutPanel tab_panel;
        private Guna.UI.WinForms.GunaButton HomeBtn;
        private Guna.UI.WinForms.GunaButton Createbtn;
        private Guna.UI.WinForms.GunaButton EmployeeBtn;
        private Guna.UI.WinForms.GunaButton ReportBtn;
        private Guna.UI.WinForms.GunaButton UserBtn;
        private Guna.UI.WinForms.GunaButton MaintenanceBtn;
        private Guna.UI.WinForms.GunaButton LogBtn;
        private Guna.UI.WinForms.GunaPanel home_Panel;
        private Guna.UI.WinForms.GunaPanel projects_Panel;
        private Guna.UI.WinForms.GunaPanel employee_Panel;
        private Guna.UI.WinForms.GunaPanel report_Panel;
        private Guna.UI.WinForms.GunaPanel user_Panel;
        private Guna.UI.WinForms.GunaPanel maintenance_Panel;
        private Guna.UI.WinForms.GunaPanel activity_Panel;
        private Guna.UI.WinForms.GunaPanel logout_Panel;
        private Guna.UI.WinForms.GunaPanel logo_Panel;
        private System.Windows.Forms.ToolTip button_ToolTip;
    }
}