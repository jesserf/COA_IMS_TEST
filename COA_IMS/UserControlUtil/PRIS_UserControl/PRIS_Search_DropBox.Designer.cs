namespace COA_IMS.UserControlUtil.PRIS_UserControl
{
    partial class PRIS_Search_DropBox
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.entry = new Guna.UI.WinForms.GunaTextBox();
            this.dropbox = new Guna.UI.WinForms.GunaComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gunaPictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.entry, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dropbox, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::COA_IMS.Properties.Resources.search1;
            this.gunaPictureBox1.Location = new System.Drawing.Point(3, 6);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(48, 48);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 14;
            this.gunaPictureBox1.TabStop = false;
            // 
            // entry
            // 
            this.entry.BackColor = System.Drawing.Color.Transparent;
            this.entry.BaseColor = System.Drawing.Color.White;
            this.entry.BorderColor = System.Drawing.Color.Silver;
            this.entry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.entry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entry.FocusedBaseColor = System.Drawing.Color.White;
            this.entry.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.entry.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.entry.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.entry.Location = new System.Drawing.Point(60, 2);
            this.entry.Margin = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.entry.MaxLength = 64;
            this.entry.Name = "entry";
            this.entry.PasswordChar = '\0';
            this.entry.Radius = 6;
            this.entry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.entry.SelectedText = "";
            this.entry.Size = new System.Drawing.Size(354, 56);
            this.entry.TabIndex = 15;
            this.entry.Tag = "";
            this.entry.TextChanged += new System.EventHandler(this.entry_TextChanged);
            // 
            // dropbox
            // 
            this.dropbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dropbox.BackColor = System.Drawing.Color.Transparent;
            this.dropbox.BaseColor = System.Drawing.Color.White;
            this.dropbox.BorderColor = System.Drawing.Color.Silver;
            this.dropbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropbox.DropDownHeight = 350;
            this.dropbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropbox.DropDownWidth = 220;
            this.dropbox.FocusedColor = System.Drawing.Color.Empty;
            this.dropbox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropbox.ForeColor = System.Drawing.Color.Black;
            this.dropbox.FormattingEnabled = true;
            this.dropbox.IntegralHeight = false;
            this.dropbox.ItemHeight = 50;
            this.dropbox.Location = new System.Drawing.Point(420, 2);
            this.dropbox.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dropbox.MaxDropDownItems = 10;
            this.dropbox.Name = "dropbox";
            this.dropbox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.dropbox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.dropbox.Radius = 6;
            this.dropbox.Size = new System.Drawing.Size(130, 56);
            this.dropbox.TabIndex = 8;
            this.dropbox.TextChanged += new System.EventHandler(this.dropbox_TextChanged);
            // 
            // PRIS_Search_DropBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PRIS_Search_DropBox";
            this.Size = new System.Drawing.Size(550, 60);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaComboBox dropbox;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaTextBox entry;
    }
}
