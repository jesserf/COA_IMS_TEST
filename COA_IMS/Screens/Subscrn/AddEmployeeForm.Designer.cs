namespace COA_IMS.Screens.Subscrn
{
    partial class AddEmployeeForm
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
            this.office_ComboBox = new System.Windows.Forms.ComboBox();
            this.position_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_Button = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.employee_Name_Textbox = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.office_ComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.position_ComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.save_Button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.employee_Name_Textbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 576);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // office_ComboBox
            // 
            this.office_ComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.office_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.office_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.office_ComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.office_ComboBox.Font = new System.Drawing.Font("Calibri", 15F);
            this.office_ComboBox.FormattingEnabled = true;
            this.office_ComboBox.Location = new System.Drawing.Point(267, 386);
            this.office_ComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.office_ComboBox.Name = "office_ComboBox";
            this.office_ComboBox.Size = new System.Drawing.Size(367, 32);
            this.office_ComboBox.TabIndex = 3;
            // 
            // position_ComboBox
            // 
            this.position_ComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.position_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.position_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.position_ComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.position_ComboBox.Font = new System.Drawing.Font("Calibri", 15F);
            this.position_ComboBox.FormattingEnabled = true;
            this.position_ComboBox.Location = new System.Drawing.Point(267, 271);
            this.position_ComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.position_ComboBox.Name = "position_ComboBox";
            this.position_ComboBox.Size = new System.Drawing.Size(367, 32);
            this.position_ComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(102, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save_Button
            // 
            this.save_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save_Button.AnimationHoverSpeed = 0.07F;
            this.save_Button.AnimationSpeed = 0.03F;
            this.save_Button.BackColor = System.Drawing.Color.Transparent;
            this.save_Button.BaseColor = System.Drawing.Color.ForestGreen;
            this.save_Button.BorderColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.save_Button, 2);
            this.save_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save_Button.FocusedColor = System.Drawing.Color.Empty;
            this.save_Button.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Button.ForeColor = System.Drawing.Color.White;
            this.save_Button.Image = null;
            this.save_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.save_Button.Location = new System.Drawing.Point(231, 510);
            this.save_Button.Margin = new System.Windows.Forms.Padding(10, 50, 10, 10);
            this.save_Button.Name = "save_Button";
            this.save_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.save_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.save_Button.OnHoverImage = null;
            this.save_Button.OnPressedColor = System.Drawing.Color.Black;
            this.save_Button.Radius = 10;
            this.save_Button.Size = new System.Drawing.Size(182, 55);
            this.save_Button.TabIndex = 4;
            this.save_Button.Text = "Save";
            this.save_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name:";
            // 
            // employee_Name_Textbox
            // 
            this.employee_Name_Textbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.employee_Name_Textbox.BackColor = System.Drawing.Color.Transparent;
            this.employee_Name_Textbox.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.employee_Name_Textbox.BorderColor = System.Drawing.Color.Silver;
            this.employee_Name_Textbox.BorderSize = 0;
            this.employee_Name_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employee_Name_Textbox.FocusedBaseColor = System.Drawing.Color.White;
            this.employee_Name_Textbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.employee_Name_Textbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.employee_Name_Textbox.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_Name_Textbox.Location = new System.Drawing.Point(267, 154);
            this.employee_Name_Textbox.Margin = new System.Windows.Forms.Padding(10);
            this.employee_Name_Textbox.Name = "employee_Name_Textbox";
            this.employee_Name_Textbox.PasswordChar = '\0';
            this.employee_Name_Textbox.Radius = 10;
            this.employee_Name_Textbox.SelectedText = "";
            this.employee_Name_Textbox.Size = new System.Drawing.Size(367, 36);
            this.employee_Name_Textbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 390);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Office:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Employee Position:";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEmployeeForm";
            this.Text = "Add Employee";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton save_Button;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox employee_Name_Textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox office_ComboBox;
        private System.Windows.Forms.ComboBox position_ComboBox;
    }
}