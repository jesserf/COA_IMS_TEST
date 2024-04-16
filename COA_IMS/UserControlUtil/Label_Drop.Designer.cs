namespace COA_IMS.UserControlUtil
{
    partial class Label_Drop
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.dropbox = new Guna.UI.WinForms.GunaComboBox();
            this.error_drop = new System.Windows.Forms.ErrorProvider(this.components);
            this.help_provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.info = new Guna.UI.WinForms.GunaLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_drop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_provider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.info, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dropbox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(57, 40);
            this.title.TabIndex = 0;
            this.title.Text = "Label";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dropbox
            // 
            this.dropbox.BackColor = System.Drawing.Color.Transparent;
            this.dropbox.BaseColor = System.Drawing.Color.White;
            this.dropbox.BorderColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.SetColumnSpan(this.dropbox, 2);
            this.dropbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropbox.DropDownHeight = 200;
            this.dropbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropbox.FocusedColor = System.Drawing.Color.Empty;
            this.dropbox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.dropbox.FormattingEnabled = true;
            this.dropbox.IntegralHeight = false;
            this.dropbox.ItemHeight = 40;
            this.dropbox.Location = new System.Drawing.Point(3, 43);
            this.dropbox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.dropbox.Name = "dropbox";
            this.dropbox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.dropbox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.dropbox.Radius = 8;
            this.dropbox.Size = new System.Drawing.Size(377, 46);
            this.dropbox.TabIndex = 1;
            this.dropbox.DropDown += new System.EventHandler(this.dropbox_DropDown);
            this.dropbox.SelectionChangeCommitted += new System.EventHandler(this.dropbox_SelectionChangeCommitted);
            this.dropbox.TextChanged += new System.EventHandler(this.dropbox_TextChanged);
            // 
            // error_drop
            // 
            this.error_drop.BlinkRate = 0;
            this.error_drop.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_drop.ContainerControl = this;
            // 
            // help_provider
            // 
            this.help_provider.BlinkRate = 0;
            this.help_provider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.help_provider.ContainerControl = this;
            // 
            // info
            // 
            this.info.AutoEllipsis = true;
            this.info.AutoSize = true;
            this.info.Dock = System.Windows.Forms.DockStyle.Left;
            this.info.Enabled = false;
            this.info.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.info.Location = new System.Drawing.Point(330, 3);
            this.info.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(50, 34);
            this.info.TabIndex = 2;
            this.info.Text = "Label";
            this.info.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.info.Visible = false;
            // 
            // Label_Drop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Label_Drop";
            this.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_drop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_provider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaComboBox dropbox;
        private System.Windows.Forms.ErrorProvider error_drop;
        private System.Windows.Forms.ErrorProvider help_provider;
        private Guna.UI.WinForms.GunaLabel info;
    }
}
