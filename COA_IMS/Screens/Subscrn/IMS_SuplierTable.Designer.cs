namespace COA_IMS.Screens.Subscrn
{
    partial class IMS_SuplierTable
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
            this.AddSupplier = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // AddSupplier
            // 
            this.AddSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSupplier.AnimationHoverSpeed = 0.07F;
            this.AddSupplier.AnimationSpeed = 0.03F;
            this.AddSupplier.BackColor = System.Drawing.Color.Transparent;
            this.AddSupplier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.AddSupplier.BorderColor = System.Drawing.Color.Black;
            this.AddSupplier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.AddSupplier.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupplier.ForeColor = System.Drawing.Color.White;
            this.AddSupplier.Image = null;
            this.AddSupplier.ImageSize = new System.Drawing.Size(20, 20);
            this.AddSupplier.Location = new System.Drawing.Point(1470, 68);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.AddSupplier.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.AddSupplier.OnHoverForeColor = System.Drawing.Color.Bisque;
            this.AddSupplier.OnHoverImage = null;
            this.AddSupplier.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.AddSupplier.Radius = 10;
            this.AddSupplier.Size = new System.Drawing.Size(147, 47);
            this.AddSupplier.TabIndex = 1;
            this.AddSupplier.Text = "Add Supplier";
            this.AddSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddSupplier.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // IMS_SuplierTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1629, 926);
            this.Controls.Add(this.AddSupplier);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IMS_SuplierTable";
            this.Text = "IMS_SuplierTable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton AddSupplier;
    }
}