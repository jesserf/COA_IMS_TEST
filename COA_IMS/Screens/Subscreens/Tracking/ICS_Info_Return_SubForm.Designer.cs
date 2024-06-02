namespace COA_IMS.Screens.Subscrn.Tracking
{
    partial class ICS_Info_Return_SubForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancel_Btn = new Guna.UI.WinForms.GunaButton();
            this.remove_Btn = new Guna.UI.WinForms.GunaButton();
            this.from_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.now_Checkbox = new Guna.UI.WinForms.GunaCheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.from_DateTimePicker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancel_Btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.remove_Btn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.now_Checkbox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 321);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancel_Btn.AnimationHoverSpeed = 0.07F;
            this.cancel_Btn.AnimationSpeed = 0.03F;
            this.cancel_Btn.BackColor = System.Drawing.Color.Transparent;
            this.cancel_Btn.BaseColor = System.Drawing.Color.White;
            this.cancel_Btn.BorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.cancel_Btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.ForeColor = System.Drawing.Color.Black;
            this.cancel_Btn.Image = null;
            this.cancel_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancel_Btn.Location = new System.Drawing.Point(92, 266);
            this.cancel_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.cancel_Btn.OnHoverBorderColor = System.Drawing.Color.Firebrick;
            this.cancel_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancel_Btn.OnHoverImage = null;
            this.cancel_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.cancel_Btn.Radius = 10;
            this.cancel_Btn.Size = new System.Drawing.Size(140, 44);
            this.cancel_Btn.TabIndex = 3;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // remove_Btn
            // 
            this.remove_Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.remove_Btn.AnimationHoverSpeed = 0.07F;
            this.remove_Btn.AnimationSpeed = 0.03F;
            this.remove_Btn.BackColor = System.Drawing.Color.Transparent;
            this.remove_Btn.BaseColor = System.Drawing.Color.Silver;
            this.remove_Btn.BorderColor = System.Drawing.Color.Black;
            this.remove_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.remove_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.remove_Btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_Btn.ForeColor = System.Drawing.Color.Black;
            this.remove_Btn.Image = null;
            this.remove_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.remove_Btn.Location = new System.Drawing.Point(334, 266);
            this.remove_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.remove_Btn.Name = "remove_Btn";
            this.remove_Btn.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.remove_Btn.OnHoverBorderColor = System.Drawing.Color.Firebrick;
            this.remove_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.remove_Btn.OnHoverImage = null;
            this.remove_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.remove_Btn.Radius = 10;
            this.remove_Btn.Size = new System.Drawing.Size(120, 44);
            this.remove_Btn.TabIndex = 2;
            this.remove_Btn.Text = "Remove";
            this.remove_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.remove_Btn.Click += new System.EventHandler(this.remove_Btn_Click);
            // 
            // from_DateTimePicker
            // 
            this.from_DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.from_DateTimePicker.CalendarFont = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.from_DateTimePicker.Font = new System.Drawing.Font("Bahnschrift", 13.25F);
            this.from_DateTimePicker.Location = new System.Drawing.Point(28, 113);
            this.from_DateTimePicker.Name = "from_DateTimePicker";
            this.from_DateTimePicker.Size = new System.Drawing.Size(293, 29);
            this.from_DateTimePicker.TabIndex = 4;
            // 
            // now_Checkbox
            // 
            this.now_Checkbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.now_Checkbox.BaseColor = System.Drawing.Color.White;
            this.now_Checkbox.Checked = true;
            this.now_Checkbox.CheckedOffColor = System.Drawing.Color.Gray;
            this.now_Checkbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.now_Checkbox.FillColor = System.Drawing.Color.White;
            this.now_Checkbox.Font = new System.Drawing.Font("Bahnschrift", 13.25F);
            this.now_Checkbox.Location = new System.Drawing.Point(327, 117);
            this.now_Checkbox.Name = "now_Checkbox";
            this.now_Checkbox.Size = new System.Drawing.Size(74, 22);
            this.now_Checkbox.TabIndex = 5;
            this.now_Checkbox.Text = " Now";
            // 
            // ICS_Info_Return_SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ICS_Info_Return_SubForm";
            this.Text = "ICS_Info_Return_SubForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaButton cancel_Btn;
        private Guna.UI.WinForms.GunaButton remove_Btn;
        private System.Windows.Forms.DateTimePicker from_DateTimePicker;
        private Guna.UI.WinForms.GunaCheckBox now_Checkbox;
    }
}