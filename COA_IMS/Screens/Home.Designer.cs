namespace COA_IMS
{
    partial class Home
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

        protected string[] column_names = {"User Name", "Activity", "Time"};

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Main_Panel.BaseColor = System.Drawing.Color.White;
            this.Main_Panel.Location = new System.Drawing.Point(14, 14);
            this.Main_Panel.Margin = new System.Windows.Forms.Padding(5);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Radius = 10;
            this.Main_Panel.Size = new System.Drawing.Size(1563, 873);
            this.Main_Panel.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1591, 901);
            this.Controls.Add(this.Main_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel Main_Panel;
        /*private UserControlUtil.DataTableMultiplePages dataTableMultiplePages1;*/
    }
}