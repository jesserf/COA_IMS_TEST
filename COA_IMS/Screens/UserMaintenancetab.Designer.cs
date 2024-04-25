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
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.activebtn = new Guna.UI.WinForms.GunaButton();
            this.deactbtn = new Guna.UI.WinForms.GunaButton();
            this.accountbtn = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.activebtn);
            this.gunaElipsePanel1.Controls.Add(this.deactbtn);
            this.gunaElipsePanel1.Controls.Add(this.accountbtn);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(13, 13);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 1;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1594, 940);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // activebtn
            // 
            this.activebtn.AnimationHoverSpeed = 0.07F;
            this.activebtn.AnimationSpeed = 0.03F;
            this.activebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.activebtn.BorderColor = System.Drawing.Color.Black;
            this.activebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.activebtn.FocusedColor = System.Drawing.Color.Empty;
            this.activebtn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activebtn.ForeColor = System.Drawing.Color.White;
            this.activebtn.Image = null;
            this.activebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.activebtn.Location = new System.Drawing.Point(502, -1);
            this.activebtn.Name = "activebtn";
            this.activebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.activebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.activebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.activebtn.OnHoverImage = null;
            this.activebtn.OnPressedColor = System.Drawing.Color.Black;
            this.activebtn.Size = new System.Drawing.Size(250, 55);
            this.activebtn.TabIndex = 2;
            this.activebtn.Text = "Active Accounts";
            this.activebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activebtn.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // deactbtn
            // 
            this.deactbtn.AnimationHoverSpeed = 0.07F;
            this.deactbtn.AnimationSpeed = 0.03F;
            this.deactbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.deactbtn.BorderColor = System.Drawing.Color.Black;
            this.deactbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deactbtn.FocusedColor = System.Drawing.Color.Empty;
            this.deactbtn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactbtn.ForeColor = System.Drawing.Color.White;
            this.deactbtn.Image = null;
            this.deactbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deactbtn.Location = new System.Drawing.Point(251, -1);
            this.deactbtn.Name = "deactbtn";
            this.deactbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.deactbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deactbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deactbtn.OnHoverImage = null;
            this.deactbtn.OnPressedColor = System.Drawing.Color.Black;
            this.deactbtn.Size = new System.Drawing.Size(250, 55);
            this.deactbtn.TabIndex = 1;
            this.deactbtn.Text = "Deactivated Accounts";
            this.deactbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deactbtn.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // accountbtn
            // 
            this.accountbtn.AnimationHoverSpeed = 0.07F;
            this.accountbtn.AnimationSpeed = 0.03F;
            this.accountbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.accountbtn.BorderColor = System.Drawing.Color.Black;
            this.accountbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.accountbtn.FocusedColor = System.Drawing.Color.Empty;
            this.accountbtn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountbtn.ForeColor = System.Drawing.Color.White;
            this.accountbtn.Image = null;
            this.accountbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.accountbtn.Location = new System.Drawing.Point(0, -1);
            this.accountbtn.Name = "accountbtn";
            this.accountbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.accountbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.accountbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.accountbtn.OnHoverImage = null;
            this.accountbtn.OnPressedColor = System.Drawing.Color.Black;
            this.accountbtn.Size = new System.Drawing.Size(250, 55);
            this.accountbtn.TabIndex = 0;
            this.accountbtn.Text = "Accounts";
            this.accountbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accountbtn.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // UserMaintenancetab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1619, 965);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMaintenancetab";
            this.Text = "UserMaintenancetab";
            this.gunaElipsePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton accountbtn;
        private Guna.UI.WinForms.GunaButton activebtn;
        private Guna.UI.WinForms.GunaButton deactbtn;
    }
}