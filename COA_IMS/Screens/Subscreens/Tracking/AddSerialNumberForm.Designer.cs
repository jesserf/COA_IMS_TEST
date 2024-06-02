namespace COA_IMS.Screens.Subscrn.Tracking
{
    partial class AddSerialNumberForm
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.sn_Textbox = new Guna.UI.WinForms.GunaTextBox();
            this.next_Btn = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.gunaLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sn_Textbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.next_Btn, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 221);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(22, 10);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(242, 39);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Serial Number :";
            // 
            // sn_Textbox
            // 
            this.sn_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sn_Textbox.BaseColor = System.Drawing.Color.White;
            this.sn_Textbox.BorderColor = System.Drawing.Color.Silver;
            this.sn_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sn_Textbox.FocusedBaseColor = System.Drawing.Color.White;
            this.sn_Textbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sn_Textbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.sn_Textbox.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.sn_Textbox.ForeColor = System.Drawing.Color.LightGray;
            this.sn_Textbox.Location = new System.Drawing.Point(284, 10);
            this.sn_Textbox.Margin = new System.Windows.Forms.Padding(10);
            this.sn_Textbox.Name = "sn_Textbox";
            this.sn_Textbox.PasswordChar = '\0';
            this.sn_Textbox.SelectedText = "";
            this.sn_Textbox.Size = new System.Drawing.Size(490, 49);
            this.sn_Textbox.TabIndex = 8;
            this.sn_Textbox.Text = "none";
            this.sn_Textbox.Enter += new System.EventHandler(this.textbox_Enter);
            this.sn_Textbox.Leave += new System.EventHandler(this.textbox_Leave);
            // 
            // next_Btn
            // 
            this.next_Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.next_Btn.AnimationHoverSpeed = 0.07F;
            this.next_Btn.AnimationSpeed = 0.03F;
            this.next_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.next_Btn.BorderColor = System.Drawing.Color.Black;
            this.next_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.next_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.next_Btn.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.next_Btn.ForeColor = System.Drawing.Color.White;
            this.next_Btn.Image = null;
            this.next_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.next_Btn.Location = new System.Drawing.Point(614, 141);
            this.next_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.next_Btn.Name = "next_Btn";
            this.next_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.next_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.next_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.next_Btn.OnHoverImage = null;
            this.next_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.next_Btn.Size = new System.Drawing.Size(160, 49);
            this.next_Btn.TabIndex = 1;
            this.next_Btn.Text = "Next";
            this.next_Btn.Click += new System.EventHandler(this.next_Btn_Click);
            // 
            // AddSerialNumberForm
            // 
            this.AcceptButton = this.next_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 221);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSerialNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSerialNumberForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaButton next_Btn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox sn_Textbox;
    }
}