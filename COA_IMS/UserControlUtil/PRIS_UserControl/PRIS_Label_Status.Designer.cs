namespace COA_IMS.UserControlUtil.PRIS_UserControl
{
    partial class PRIS_Label_Status
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
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.icon = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.control_Panel = new Guna.UI.WinForms.GunaPanel();
            this.readOnly_Entry = new Guna.UI.WinForms.GunaTextBox();
            this.entry = new Guna.UI.WinForms.GunaComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.control_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.icon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.control_Panel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(79, 60);
            this.title.TabIndex = 1;
            this.title.Text = "Status : ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon
            // 
            this.icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icon.BaseColor = System.Drawing.Color.Gainsboro;
            this.icon.Image = global::COA_IMS.Properties.Resources.search1;
            this.icon.Location = new System.Drawing.Point(90, 15);
            this.icon.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(30, 30);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 2;
            this.icon.TabStop = false;
            this.icon.UseTransfarantBackground = false;
            this.icon.WaitOnLoad = true;
            // 
            // control_Panel
            // 
            this.control_Panel.Controls.Add(this.entry);
            this.control_Panel.Controls.Add(this.readOnly_Entry);
            this.control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel.Location = new System.Drawing.Point(125, 0);
            this.control_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.control_Panel.Name = "control_Panel";
            this.control_Panel.Padding = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.control_Panel.Size = new System.Drawing.Size(275, 60);
            this.control_Panel.TabIndex = 3;
            // 
            // readOnly_Entry
            // 
            this.readOnly_Entry.BackColor = System.Drawing.Color.Transparent;
            this.readOnly_Entry.BaseColor = System.Drawing.Color.White;
            this.readOnly_Entry.BorderColor = System.Drawing.Color.Silver;
            this.readOnly_Entry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.readOnly_Entry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readOnly_Entry.FocusedBaseColor = System.Drawing.Color.White;
            this.readOnly_Entry.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.readOnly_Entry.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.readOnly_Entry.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnly_Entry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.readOnly_Entry.Location = new System.Drawing.Point(3, 3);
            this.readOnly_Entry.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.readOnly_Entry.MaxLength = 64;
            this.readOnly_Entry.Name = "readOnly_Entry";
            this.readOnly_Entry.PasswordChar = '\0';
            this.readOnly_Entry.Radius = 6;
            this.readOnly_Entry.ReadOnly = true;
            this.readOnly_Entry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.readOnly_Entry.SelectedText = "";
            this.readOnly_Entry.Size = new System.Drawing.Size(252, 54);
            this.readOnly_Entry.TabIndex = 7;
            this.readOnly_Entry.Tag = "";
            // 
            // entry
            // 
            this.entry.BackColor = System.Drawing.Color.Transparent;
            this.entry.BaseColor = System.Drawing.Color.White;
            this.entry.BorderColor = System.Drawing.Color.Silver;
            this.entry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.entry.DropDownHeight = 220;
            this.entry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entry.FocusedColor = System.Drawing.Color.Empty;
            this.entry.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry.ForeColor = System.Drawing.Color.Black;
            this.entry.FormattingEnabled = true;
            this.entry.IntegralHeight = false;
            this.entry.ItemHeight = 48;
            this.entry.Location = new System.Drawing.Point(3, 3);
            this.entry.Margin = new System.Windows.Forms.Padding(0);
            this.entry.MaxDropDownItems = 10;
            this.entry.Name = "entry";
            this.entry.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.entry.OnHoverItemForeColor = System.Drawing.Color.White;
            this.entry.Radius = 6;
            this.entry.Size = new System.Drawing.Size(252, 54);
            this.entry.TabIndex = 4;
            this.entry.TextChanged += new System.EventHandler(this.entry_TextChanged);
            // 
            // PRIS_Label_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PRIS_Label_Status";
            this.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.Size = new System.Drawing.Size(400, 80);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.control_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaCirclePictureBox icon;
        private Guna.UI.WinForms.GunaPanel control_Panel;
        private Guna.UI.WinForms.GunaComboBox entry;
        private Guna.UI.WinForms.GunaTextBox readOnly_Entry;
    }
}
