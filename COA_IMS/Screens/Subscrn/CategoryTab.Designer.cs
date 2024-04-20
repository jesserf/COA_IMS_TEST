namespace COA_IMS.Screens.Subscrn
{
    partial class CategoryTab
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.addcategorybtn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(12, 79);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1579, 40);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 41);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(186, 33);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "All Categories";
            // 
            // addcategorybtn
            // 
            this.addcategorybtn.AnimationHoverSpeed = 0.07F;
            this.addcategorybtn.AnimationSpeed = 0.03F;
            this.addcategorybtn.BackColor = System.Drawing.Color.Transparent;
            this.addcategorybtn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.addcategorybtn.BorderColor = System.Drawing.Color.Black;
            this.addcategorybtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addcategorybtn.FocusedColor = System.Drawing.Color.Empty;
            this.addcategorybtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addcategorybtn.ForeColor = System.Drawing.Color.White;
            this.addcategorybtn.Image = global::COA_IMS.Properties.Resources.multiple1;
            this.addcategorybtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addcategorybtn.Location = new System.Drawing.Point(1431, 32);
            this.addcategorybtn.Name = "addcategorybtn";
            this.addcategorybtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addcategorybtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addcategorybtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addcategorybtn.OnHoverImage = null;
            this.addcategorybtn.OnPressedColor = System.Drawing.Color.Black;
            this.addcategorybtn.Radius = 5;
            this.addcategorybtn.Size = new System.Drawing.Size(160, 42);
            this.addcategorybtn.TabIndex = 2;
            this.addcategorybtn.Text = "Add new Category";
            this.addcategorybtn.Click += new System.EventHandler(this.addcategorybtn_Click);
            // 
            // CategoryTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1603, 866);
            this.Controls.Add(this.addcategorybtn);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton addcategorybtn;
    }
}