namespace COA_IMS.Screens.Subscrn.Tracking
{
    partial class ButtonWithExit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit_Button = new Guna.UI.WinForms.GunaButton();
            this.item_Name_Button = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // exit_Button
            // 
            this.exit_Button.AnimationHoverSpeed = 0.07F;
            this.exit_Button.AnimationSpeed = 0.03F;
            this.exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.exit_Button.BaseColor = System.Drawing.Color.Maroon;
            this.exit_Button.BorderColor = System.Drawing.Color.Black;
            this.exit_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exit_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_Button.FocusedColor = System.Drawing.Color.Empty;
            this.exit_Button.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.ForeColor = System.Drawing.Color.White;
            this.exit_Button.Image = null;
            this.exit_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.exit_Button.Location = new System.Drawing.Point(394, 0);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.exit_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.exit_Button.OnHoverForeColor = System.Drawing.Color.DarkRed;
            this.exit_Button.OnHoverImage = null;
            this.exit_Button.OnPressedColor = System.Drawing.Color.Black;
            this.exit_Button.Size = new System.Drawing.Size(42, 46);
            this.exit_Button.TabIndex = 1;
            this.exit_Button.Text = "X";
            this.exit_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // item_Name_Button
            // 
            this.item_Name_Button.AnimationHoverSpeed = 0.07F;
            this.item_Name_Button.AnimationSpeed = 0.03F;
            this.item_Name_Button.BackColor = System.Drawing.Color.Transparent;
            this.item_Name_Button.BaseColor = System.Drawing.Color.Gainsboro;
            this.item_Name_Button.BorderColor = System.Drawing.Color.Black;
            this.item_Name_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.item_Name_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_Name_Button.FocusedColor = System.Drawing.Color.Empty;
            this.item_Name_Button.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.item_Name_Button.ForeColor = System.Drawing.Color.Black;
            this.item_Name_Button.Image = null;
            this.item_Name_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.item_Name_Button.Location = new System.Drawing.Point(0, 0);
            this.item_Name_Button.Name = "item_Name_Button";
            this.item_Name_Button.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.item_Name_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.item_Name_Button.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.item_Name_Button.OnHoverImage = null;
            this.item_Name_Button.OnPressedColor = System.Drawing.Color.Black;
            this.item_Name_Button.Size = new System.Drawing.Size(394, 46);
            this.item_Name_Button.TabIndex = 2;
            this.item_Name_Button.Text = "item_Name";
            this.item_Name_Button.Click += new System.EventHandler(this.item_Name_Button_Click);
            // 
            // ButtonWithExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.item_Name_Button);
            this.Controls.Add(this.exit_Button);
            this.Name = "ButtonWithExit";
            this.Size = new System.Drawing.Size(436, 46);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton exit_Button;
        private Guna.UI.WinForms.GunaButton item_Name_Button;
    }
}
