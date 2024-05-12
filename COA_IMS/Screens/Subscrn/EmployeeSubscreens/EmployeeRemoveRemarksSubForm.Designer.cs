namespace COA_IMS.Screens.Subscrn.EmployeeSubscreens
{
    partial class EmployeeRemoveRemarksSubForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.remarks_Textbox = new Guna.UI.WinForms.GunaTextBox();
            this.remove_Btn = new Guna.UI.WinForms.GunaButton();
            this.cancel_Btn = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.cancel_Btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.remove_Btn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.remarks_Textbox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(103, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remarks (optional)";
            // 
            // remarks_Textbox
            // 
            this.remarks_Textbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.remarks_Textbox.BackColor = System.Drawing.Color.Transparent;
            this.remarks_Textbox.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.remarks_Textbox.BorderColor = System.Drawing.Color.Silver;
            this.remarks_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.remarks_Textbox.FocusedBaseColor = System.Drawing.Color.White;
            this.remarks_Textbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.remarks_Textbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.remarks_Textbox.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarks_Textbox.Location = new System.Drawing.Point(195, 45);
            this.remarks_Textbox.Margin = new System.Windows.Forms.Padding(10);
            this.remarks_Textbox.Name = "remarks_Textbox";
            this.remarks_Textbox.PasswordChar = '\0';
            this.remarks_Textbox.Radius = 10;
            this.remarks_Textbox.SelectedText = "";
            this.remarks_Textbox.Size = new System.Drawing.Size(259, 166);
            this.remarks_Textbox.TabIndex = 1;
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
            this.remove_Btn.Location = new System.Drawing.Point(254, 266);
            this.remove_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.remove_Btn.Name = "remove_Btn";
            this.remove_Btn.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.remove_Btn.OnHoverBorderColor = System.Drawing.Color.Firebrick;
            this.remove_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.remove_Btn.OnHoverImage = null;
            this.remove_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.remove_Btn.Radius = 10;
            this.remove_Btn.Size = new System.Drawing.Size(140, 44);
            this.remove_Btn.TabIndex = 2;
            this.remove_Btn.Text = "Remove";
            this.remove_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.remove_Btn.Click += new System.EventHandler(this.remove_Btn_Click);
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
            this.cancel_Btn.Location = new System.Drawing.Point(22, 266);
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
            // EmployeeRemoveRemarksSubForm
            // 
            this.AcceptButton = this.remove_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancel_Btn;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeRemoveRemarksSubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Employee";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox remarks_Textbox;
        private Guna.UI.WinForms.GunaButton cancel_Btn;
        private Guna.UI.WinForms.GunaButton remove_Btn;
    }
}