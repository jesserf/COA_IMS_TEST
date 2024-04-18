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
            this.clearbtn = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.addcategorytxt = new Guna.UI.WinForms.GunaTextBox();
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
            this.categorypopup.Controls.Add(this.clearbtn);
            this.categorypopup.Controls.Add(this.gunaButton1);
            this.categorypopup.Controls.Add(this.gunaLabel1);
            this.categorypopup.Controls.Add(this.addcategorytxt);
            this.categorypopup.Location = new System.Drawing.Point(-2, -1);
            this.categorypopup.Name = "categorypopup";
            this.categorypopup.Radius = 10;
            this.categorypopup.Size = new System.Drawing.Size(635, 155);
            this.categorypopup.TabIndex = 0;
            this.categorypopup.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::COA_IMS.Properties.Resources.circle_xmark__1_;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageButton1.Location = new System.Drawing.Point(608, 3);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(28, 33);
            this.gunaImageButton1.TabIndex = 4;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.AnimationHoverSpeed = 0.07F;
            this.clearbtn.AnimationSpeed = 0.03F;
            this.clearbtn.BackColor = System.Drawing.Color.Transparent;
            this.clearbtn.BaseColor = System.Drawing.Color.Firebrick;
            this.clearbtn.BorderColor = System.Drawing.Color.Black;
            this.clearbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clearbtn.FocusedColor = System.Drawing.Color.Empty;
            this.clearbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.Image = null;
            this.clearbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.clearbtn.Location = new System.Drawing.Point(329, 106);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.clearbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clearbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.clearbtn.OnHoverImage = null;
            this.clearbtn.OnPressedColor = System.Drawing.Color.Black;
            this.clearbtn.Radius = 10;
            this.clearbtn.Size = new System.Drawing.Size(130, 39);
            this.clearbtn.TabIndex = 3;
            this.clearbtn.Text = "Clear";
            this.clearbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.ForestGreen;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(188, 106);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(130, 39);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Save";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(16, 14);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(163, 23);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Add new Category";
            // 
            // addcategorytxt
            // 
            this.addcategorytxt.BackColor = System.Drawing.Color.Transparent;
            this.addcategorytxt.BaseColor = System.Drawing.Color.White;
            this.addcategorytxt.BorderColor = System.Drawing.Color.Silver;
            this.addcategorytxt.BorderSize = 1;
            this.addcategorytxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addcategorytxt.FocusedBaseColor = System.Drawing.Color.White;
            this.addcategorytxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.addcategorytxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.addcategorytxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addcategorytxt.Location = new System.Drawing.Point(38, 56);
            this.addcategorytxt.Name = "addcategorytxt";
            this.addcategorytxt.PasswordChar = '\0';
            this.addcategorytxt.Radius = 10;
            this.addcategorytxt.SelectedText = "";
            this.addcategorytxt.Size = new System.Drawing.Size(576, 37);
            this.addcategorytxt.TabIndex = 0;
            this.addcategorytxt.Text = "Category Name";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 156);
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
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox addcategorytxt;
        private Guna.UI.WinForms.GunaButton clearbtn;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}