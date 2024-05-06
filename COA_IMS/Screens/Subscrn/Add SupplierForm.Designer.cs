namespace COA_IMS.Screens.Subscrn
{
    partial class Add_SupplierForm
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
            this.save_Button = new Guna.UI.WinForms.GunaButton();
            this.contact_Person_Textbox = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contact_Number_Textbox = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address_Textbox = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.supplier_Name_Textbox = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.save_Button.Location = new System.Drawing.Point(231, 483);
            this.save_Button.Name = "save_Button";
            this.save_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.save_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.save_Button.OnHoverImage = null;
            this.save_Button.OnPressedColor = System.Drawing.Color.Black;
            this.save_Button.Radius = 10;
            this.save_Button.Size = new System.Drawing.Size(182, 55);
            this.save_Button.TabIndex = 9;
            this.save_Button.Text = "Save";
            this.save_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save_Button.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // contact_Person_Textbox
            // 
            this.contact_Person_Textbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.contact_Person_Textbox.BackColor = System.Drawing.Color.Transparent;
            this.contact_Person_Textbox.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.contact_Person_Textbox.BorderColor = System.Drawing.Color.Silver;
            this.contact_Person_Textbox.BorderSize = 0;
            this.contact_Person_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contact_Person_Textbox.FocusedBaseColor = System.Drawing.Color.DarkGray;
            this.contact_Person_Textbox.FocusedBorderColor = System.Drawing.Color.DimGray;
            this.contact_Person_Textbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.contact_Person_Textbox.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_Person_Textbox.Location = new System.Drawing.Point(267, 414);
            this.contact_Person_Textbox.Margin = new System.Windows.Forms.Padding(10);
            this.contact_Person_Textbox.Name = "contact_Person_Textbox";
            this.contact_Person_Textbox.PasswordChar = '\0';
            this.contact_Person_Textbox.Radius = 10;
            this.contact_Person_Textbox.SelectedText = "";
            this.contact_Person_Textbox.Size = new System.Drawing.Size(367, 36);
            this.contact_Person_Textbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 419);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contact Person";
            // 
            // contact_Number_Textbox
            // 
            this.contact_Number_Textbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.contact_Number_Textbox.BackColor = System.Drawing.Color.Transparent;
            this.contact_Number_Textbox.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.contact_Number_Textbox.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.contact_Number_Textbox.BorderSize = 0;
            this.contact_Number_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contact_Number_Textbox.FocusedBaseColor = System.Drawing.Color.DarkGray;
            this.contact_Number_Textbox.FocusedBorderColor = System.Drawing.Color.DimGray;
            this.contact_Number_Textbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.contact_Number_Textbox.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_Number_Textbox.Location = new System.Drawing.Point(267, 318);
            this.contact_Number_Textbox.Margin = new System.Windows.Forms.Padding(10);
            this.contact_Number_Textbox.Name = "contact_Number_Textbox";
            this.contact_Number_Textbox.PasswordChar = '\0';
            this.contact_Number_Textbox.Radius = 10;
            this.contact_Number_Textbox.SelectedText = "";
            this.contact_Number_Textbox.Size = new System.Drawing.Size(367, 36);
            this.contact_Number_Textbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contact Number";
            // 
            // address_Textbox
            // 
            this.address_Textbox.BackColor = System.Drawing.Color.Transparent;
            this.address_Textbox.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.address_Textbox.BorderColor = System.Drawing.Color.LightGray;
            this.address_Textbox.BorderSize = 0;
            this.address_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address_Textbox.FocusedBaseColor = System.Drawing.Color.DarkGray;
            this.address_Textbox.FocusedBorderColor = System.Drawing.Color.DimGray;
            this.address_Textbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.address_Textbox.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_Textbox.Location = new System.Drawing.Point(267, 202);
            this.address_Textbox.Margin = new System.Windows.Forms.Padding(10);
            this.address_Textbox.Name = "address_Textbox";
            this.address_Textbox.PasswordChar = '\0';
            this.address_Textbox.Radius = 10;
            this.address_Textbox.SelectedText = "";
            this.address_Textbox.Size = new System.Drawing.Size(367, 58);
            this.address_Textbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // supplier_Name_Textbox
            // 
            this.supplier_Name_Textbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.supplier_Name_Textbox.BackColor = System.Drawing.Color.Transparent;
            this.supplier_Name_Textbox.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.supplier_Name_Textbox.BorderColor = System.Drawing.Color.Silver;
            this.supplier_Name_Textbox.BorderSize = 0;
            this.supplier_Name_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplier_Name_Textbox.FocusedBaseColor = System.Drawing.Color.DarkGray;
            this.supplier_Name_Textbox.FocusedBorderColor = System.Drawing.Color.DimGray;
            this.supplier_Name_Textbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.supplier_Name_Textbox.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_Name_Textbox.Location = new System.Drawing.Point(267, 126);
            this.supplier_Name_Textbox.Margin = new System.Windows.Forms.Padding(10);
            this.supplier_Name_Textbox.Name = "supplier_Name_Textbox";
            this.supplier_Name_Textbox.PasswordChar = '\0';
            this.supplier_Name_Textbox.Radius = 10;
            this.supplier_Name_Textbox.SelectedText = "";
            this.supplier_Name_Textbox.Size = new System.Drawing.Size(367, 36);
            this.supplier_Name_Textbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(116, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Supplier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.save_Button, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.contact_Person_Textbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.supplier_Name_Textbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.contact_Number_Textbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.address_Textbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 576);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Add_SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Supplier";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton save_Button;
        private Guna.UI.WinForms.GunaTextBox contact_Person_Textbox;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox contact_Number_Textbox;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox address_Textbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox supplier_Name_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}