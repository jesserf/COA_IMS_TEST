namespace COA_IMS.Screens.Subscrn
{
    partial class CategoryForm
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
            this.categorypopup = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.clear_Button = new Guna.UI.WinForms.GunaButton();
            this.save_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.add_Category_TextBox = new Guna.UI.WinForms.GunaTextBox();
            this.categorypopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // categorypopup
            // 
            this.categorypopup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categorypopup.BackColor = System.Drawing.Color.Transparent;
            this.categorypopup.BaseColor = System.Drawing.Color.White;
            this.categorypopup.Controls.Add(this.gunaImageButton1);
            this.categorypopup.Controls.Add(this.clear_Button);
            this.categorypopup.Controls.Add(this.save_Button);
            this.categorypopup.Controls.Add(this.gunaLabel1);
            this.categorypopup.Controls.Add(this.add_Category_TextBox);
            this.categorypopup.Location = new System.Drawing.Point(-2, -1);
            this.categorypopup.Name = "categorypopup";
            this.categorypopup.Radius = 10;
            this.categorypopup.Size = new System.Drawing.Size(634, 155);
            this.categorypopup.TabIndex = 0;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::COA_IMS.Properties.Resources.circle_xmark__1_;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageButton1.Location = new System.Drawing.Point(603, 5);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(28, 33);
            this.gunaImageButton1.TabIndex = 4;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.AnimationHoverSpeed = 0.07F;
            this.clear_Button.AnimationSpeed = 0.03F;
            this.clear_Button.BackColor = System.Drawing.Color.Transparent;
            this.clear_Button.BaseColor = System.Drawing.Color.Firebrick;
            this.clear_Button.BorderColor = System.Drawing.Color.Black;
            this.clear_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clear_Button.FocusedColor = System.Drawing.Color.Empty;
            this.clear_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clear_Button.ForeColor = System.Drawing.Color.White;
            this.clear_Button.Image = null;
            this.clear_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.clear_Button.Location = new System.Drawing.Point(329, 106);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.clear_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clear_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.clear_Button.OnHoverImage = null;
            this.clear_Button.OnPressedColor = System.Drawing.Color.Black;
            this.clear_Button.Radius = 10;
            this.clear_Button.Size = new System.Drawing.Size(130, 39);
            this.clear_Button.TabIndex = 3;
            this.clear_Button.Text = "Clear";
            this.clear_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.AnimationHoverSpeed = 0.07F;
            this.save_Button.AnimationSpeed = 0.03F;
            this.save_Button.BackColor = System.Drawing.Color.Transparent;
            this.save_Button.BaseColor = System.Drawing.Color.ForestGreen;
            this.save_Button.BorderColor = System.Drawing.Color.Black;
            this.save_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save_Button.FocusedColor = System.Drawing.Color.Empty;
            this.save_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.save_Button.ForeColor = System.Drawing.Color.White;
            this.save_Button.Image = null;
            this.save_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.save_Button.Location = new System.Drawing.Point(188, 106);
            this.save_Button.Name = "save_Button";
            this.save_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.save_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.save_Button.OnHoverImage = null;
            this.save_Button.OnPressedColor = System.Drawing.Color.Black;
            this.save_Button.Radius = 10;
            this.save_Button.Size = new System.Drawing.Size(130, 39);
            this.save_Button.TabIndex = 2;
            this.save_Button.Text = "Save";
            this.save_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(16, 17);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(163, 23);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Add new Category";
            // 
            // add_Category_TextBox
            // 
            this.add_Category_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.add_Category_TextBox.BaseColor = System.Drawing.Color.White;
            this.add_Category_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.add_Category_TextBox.BorderSize = 1;
            this.add_Category_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.add_Category_TextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.add_Category_TextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.add_Category_TextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.add_Category_TextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_Category_TextBox.Location = new System.Drawing.Point(36, 56);
            this.add_Category_TextBox.Name = "add_Category_TextBox";
            this.add_Category_TextBox.PasswordChar = '\0';
            this.add_Category_TextBox.Radius = 10;
            this.add_Category_TextBox.SelectedText = "";
            this.add_Category_TextBox.Size = new System.Drawing.Size(576, 37);
            this.add_Category_TextBox.TabIndex = 0;
            this.add_Category_TextBox.Text = "Category Name";
            this.add_Category_TextBox.Enter += new System.EventHandler(this.textbox_Enter);
            this.add_Category_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PressEnter);
            this.add_Category_TextBox.Leave += new System.EventHandler(this.textbox_Leave);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 156);
            this.Controls.Add(this.categorypopup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.categorypopup.ResumeLayout(false);
            this.categorypopup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel categorypopup;
        private Guna.UI.WinForms.GunaButton save_Button;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox add_Category_TextBox;
        private Guna.UI.WinForms.GunaButton clear_Button;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}