namespace COA_IMS.Screens.Subscreens.Users
{
    partial class Role_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role_Create));
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.bottom_Panel = new Guna.UI.WinForms.GunaPanel();
            this.cancel_Btn = new Guna.UI.WinForms.GunaButton();
            this.create_Btn = new Guna.UI.WinForms.GunaButton();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.container_Panel = new Guna.UI.WinForms.GunaPanel();
            this.content_Panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.id_Text = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.top_Panel.SuspendLayout();
            this.bottom_Panel.SuspendLayout();
            this.container_Panel.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // top_Panel
            // 
            this.top_Panel.Controls.Add(this.title);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(10, 10);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(1664, 55);
            this.top_Panel.TabIndex = 0;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(238, 55);
            this.title.TabIndex = 2;
            this.title.Text = "New User Role";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottom_Panel
            // 
            this.bottom_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.bottom_Panel.Controls.Add(this.cancel_Btn);
            this.bottom_Panel.Controls.Add(this.create_Btn);
            this.bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_Panel.Location = new System.Drawing.Point(10, 836);
            this.bottom_Panel.Name = "bottom_Panel";
            this.bottom_Panel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.bottom_Panel.Size = new System.Drawing.Size(1664, 65);
            this.bottom_Panel.TabIndex = 1;
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.AnimationHoverSpeed = 0.07F;
            this.cancel_Btn.AnimationSpeed = 0.03F;
            this.cancel_Btn.BackColor = System.Drawing.Color.Transparent;
            this.cancel_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.cancel_Btn.BorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancel_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancel_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.cancel_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.cancel_Btn.Image = global::COA_IMS.Properties.Resources.search;
            this.cancel_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.cancel_Btn.Location = new System.Drawing.Point(10, 0);
            this.cancel_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.cancel_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancel_Btn.OnHoverImage = null;
            this.cancel_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.cancel_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cancel_Btn.Radius = 8;
            this.cancel_Btn.Size = new System.Drawing.Size(130, 55);
            this.cancel_Btn.TabIndex = 10;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // create_Btn
            // 
            this.create_Btn.AnimationHoverSpeed = 0.07F;
            this.create_Btn.AnimationSpeed = 0.03F;
            this.create_Btn.BackColor = System.Drawing.Color.Transparent;
            this.create_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.create_Btn.BorderColor = System.Drawing.Color.Black;
            this.create_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.create_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.create_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.create_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_Btn.ForeColor = System.Drawing.Color.White;
            this.create_Btn.Image = global::COA_IMS.Properties.Resources.search1;
            this.create_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.create_Btn.Location = new System.Drawing.Point(1524, 0);
            this.create_Btn.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.create_Btn.Name = "create_Btn";
            this.create_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.create_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.create_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.create_Btn.OnHoverImage = null;
            this.create_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.create_Btn.Radius = 8;
            this.create_Btn.Size = new System.Drawing.Size(130, 55);
            this.create_Btn.TabIndex = 9;
            this.create_Btn.Text = "Create";
            this.create_Btn.Click += new System.EventHandler(this.create_Btn_Click);
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(10, 65);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1664, 5);
            this.gunaLinePanel1.TabIndex = 3;
            // 
            // container_Panel
            // 
            this.container_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.container_Panel.Controls.Add(this.content_Panel);
            this.container_Panel.Controls.Add(this.gunaPanel4);
            this.container_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_Panel.Location = new System.Drawing.Point(10, 70);
            this.container_Panel.Name = "container_Panel";
            this.container_Panel.Padding = new System.Windows.Forms.Padding(10);
            this.container_Panel.Size = new System.Drawing.Size(1664, 766);
            this.container_Panel.TabIndex = 4;
            // 
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.White;
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(10, 70);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Padding = new System.Windows.Forms.Padding(10);
            this.content_Panel.Size = new System.Drawing.Size(1644, 686);
            this.content_Panel.TabIndex = 6;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Controls.Add(this.id_Text);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel4.Location = new System.Drawing.Point(10, 10);
            this.gunaPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.gunaPanel4.Size = new System.Drawing.Size(1644, 60);
            this.gunaPanel4.TabIndex = 3;
            // 
            // id_Text
            // 
            this.id_Text.BackColor = System.Drawing.Color.White;
            this.id_Text.Dock = System.Windows.Forms.DockStyle.Left;
            this.id_Text.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_Text.Location = new System.Drawing.Point(0, 0);
            this.id_Text.Name = "id_Text";
            this.id_Text.Size = new System.Drawing.Size(220, 52);
            this.id_Text.TabIndex = 0;
            this.id_Text.Text = "ACCOUNT INFO";
            this.id_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this.content_Panel;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 6;
            this.gunaElipse2.TargetControl = this.id_Text;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Role_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1684, 911);
            this.Controls.Add(this.container_Panel);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.bottom_Panel);
            this.Controls.Add(this.top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Role_Create";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIS Create Role";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Role_Create_FormClosing);
            this.Load += new System.EventHandler(this.Role_Create_Load);
            this.top_Panel.ResumeLayout(false);
            this.bottom_Panel.ResumeLayout(false);
            this.container_Panel.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel top_Panel;
        private Guna.UI.WinForms.GunaPanel bottom_Panel;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaPanel container_Panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaLabel id_Text;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Guna.UI.WinForms.GunaPanel content_Panel;
        private Guna.UI.WinForms.GunaButton cancel_Btn;
        private Guna.UI.WinForms.GunaButton create_Btn;
    }
}