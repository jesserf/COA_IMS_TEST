namespace COA_IMS.UserControlUtil
{
    partial class SearchBar
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.search_box = new Guna.UI.WinForms.GunaTextBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.gunaImageButton1);
            this.flowLayoutPanel1.Controls.Add(this.search_box);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(547, 56);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.Color.Transparent;
            this.search_box.BaseColor = System.Drawing.Color.Transparent;
            this.search_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(82)))));
            this.search_box.BorderSize = 1;
            this.search_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_box.FocusedBaseColor = System.Drawing.Color.White;
            this.search_box.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(82)))));
            this.search_box.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.search_box.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.search_box.Location = new System.Drawing.Point(36, 0);
            this.search_box.Margin = new System.Windows.Forms.Padding(0);
            this.search_box.Name = "search_box";
            this.search_box.PasswordChar = '\0';
            this.search_box.Radius = 15;
            this.search_box.SelectedText = "";
            this.search_box.Size = new System.Drawing.Size(509, 39);
            this.search_box.TabIndex = 4;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::COA_IMS.Properties.Resources.search__1_;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaImageButton1.Location = new System.Drawing.Point(3, 3);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(30, 33);
            this.gunaImageButton1.TabIndex = 2;
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(547, 54);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaTextBox search_box;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}
