namespace COA_IMS.UserControlUtil.PRIS_UserControl
{
    partial class PRIS_Label_DropBox
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.message = new Guna.UI.WinForms.GunaLabel();
            this.entry_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.control_Panel = new Guna.UI.WinForms.GunaPanel();
            this.entry = new Guna.UI.WinForms.GunaComboBox();
            this.readOnlyEntry = new Guna.UI.WinForms.GunaTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.entry_Panel.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.control_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.control_Panel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.entry_Panel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 40);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Tag = "Entry";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.message, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(400, 40);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(57, 40);
            this.title.TabIndex = 2;
            this.title.Text = "Label";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Gray;
            this.message.Location = new System.Drawing.Point(60, 18);
            this.message.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 19);
            this.message.TabIndex = 3;
            this.message.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.message.Visible = false;
            // 
            // entry_Panel
            // 
            this.entry_Panel.BackColor = System.Drawing.Color.Transparent;
            this.entry_Panel.BaseColor = System.Drawing.Color.LightGray;
            this.entry_Panel.Controls.Add(this.gunaElipsePanel2);
            this.entry_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entry_Panel.Location = new System.Drawing.Point(3, 43);
            this.entry_Panel.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.entry_Panel.Name = "entry_Panel";
            this.entry_Panel.Padding = new System.Windows.Forms.Padding(3);
            this.entry_Panel.Size = new System.Drawing.Size(377, 1);
            this.entry_Panel.TabIndex = 1;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.richTextBox1);
            this.gunaElipsePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel2.Location = new System.Drawing.Point(3, 3);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Padding = new System.Windows.Forms.Padding(4);
            this.gunaElipsePanel2.Radius = 4;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(371, 0);
            this.gunaElipsePanel2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(363, 0);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // control_Panel
            // 
            this.control_Panel.Controls.Add(this.entry);
            this.control_Panel.Controls.Add(this.readOnlyEntry);
            this.control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel.Location = new System.Drawing.Point(3, 43);
            this.control_Panel.Name = "control_Panel";
            this.control_Panel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.control_Panel.Size = new System.Drawing.Size(394, 54);
            this.control_Panel.TabIndex = 3;
            // 
            // entry
            // 
            this.entry.BackColor = System.Drawing.Color.Transparent;
            this.entry.BaseColor = System.Drawing.Color.White;
            this.entry.BorderColor = System.Drawing.Color.Silver;
            this.entry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.entry.DropDownHeight = 300;
            this.entry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entry.FocusedColor = System.Drawing.Color.Empty;
            this.entry.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry.ForeColor = System.Drawing.Color.Black;
            this.entry.FormattingEnabled = true;
            this.entry.IntegralHeight = false;
            this.entry.ItemHeight = 48;
            this.entry.Location = new System.Drawing.Point(0, 0);
            this.entry.Margin = new System.Windows.Forms.Padding(0);
            this.entry.MaxDropDownItems = 15;
            this.entry.Name = "entry";
            this.entry.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.entry.OnHoverItemForeColor = System.Drawing.Color.White;
            this.entry.Radius = 6;
            this.entry.Size = new System.Drawing.Size(374, 54);
            this.entry.TabIndex = 6;
            // 
            // readOnlyEntry
            // 
            this.readOnlyEntry.BackColor = System.Drawing.Color.Transparent;
            this.readOnlyEntry.BaseColor = System.Drawing.Color.White;
            this.readOnlyEntry.BorderColor = System.Drawing.Color.Silver;
            this.readOnlyEntry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.readOnlyEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readOnlyEntry.FocusedBaseColor = System.Drawing.Color.White;
            this.readOnlyEntry.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.readOnlyEntry.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.readOnlyEntry.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.readOnlyEntry.Location = new System.Drawing.Point(0, 0);
            this.readOnlyEntry.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.readOnlyEntry.MaxLength = 64;
            this.readOnlyEntry.Name = "readOnlyEntry";
            this.readOnlyEntry.PasswordChar = '\0';
            this.readOnlyEntry.Radius = 6;
            this.readOnlyEntry.ReadOnly = true;
            this.readOnlyEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.readOnlyEntry.SelectedText = "";
            this.readOnlyEntry.Size = new System.Drawing.Size(374, 54);
            this.readOnlyEntry.TabIndex = 7;
            this.readOnlyEntry.Tag = "";
            this.readOnlyEntry.Visible = false;
            // 
            // PRIS_Label_DropBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PRIS_Label_DropBox";
            this.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.entry_Panel.ResumeLayout(false);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.control_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel control_Panel;
        private Guna.UI.WinForms.GunaComboBox entry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaLabel message;
        private Guna.UI.WinForms.GunaElipsePanel entry_Panel;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Guna.UI.WinForms.GunaTextBox readOnlyEntry;
    }
}
