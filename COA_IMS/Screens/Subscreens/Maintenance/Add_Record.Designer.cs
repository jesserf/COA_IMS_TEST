namespace COA_IMS.Screens.Subscreens.Maintenance
{
    partial class Add_Record
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
            this.components = new System.ComponentModel.Container();
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.parent_Panel = new Guna.UI.WinForms.GunaPanel();
            this.controlMain_Panel = new Guna.UI.WinForms.GunaPanel();
            this.contro_Control_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.control_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.error_Message = new Guna.UI.WinForms.GunaLabel();
            this.button_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.save_Btn = new Guna.UI.WinForms.GunaButton();
            this.cancel_Btn = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.code_Title = new Guna.UI.WinForms.GunaLabel();
            this.error_provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.top_Panel.SuspendLayout();
            this.parent_Panel.SuspendLayout();
            this.controlMain_Panel.SuspendLayout();
            this.contro_Control_Panel.SuspendLayout();
            this.button_Panel.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).BeginInit();
            this.SuspendLayout();
            // 
            // top_Panel
            // 
            this.top_Panel.Controls.Add(this.title);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(10, 10);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(614, 50);
            this.top_Panel.TabIndex = 1;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(208, 50);
            this.title.TabIndex = 0;
            this.title.Text = "New Record";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line_Panel
            // 
            this.line_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.line_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.line_Panel.Location = new System.Drawing.Point(10, 60);
            this.line_Panel.Name = "line_Panel";
            this.line_Panel.Size = new System.Drawing.Size(614, 5);
            this.line_Panel.TabIndex = 2;
            // 
            // parent_Panel
            // 
            this.parent_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.parent_Panel.Controls.Add(this.controlMain_Panel);
            this.parent_Panel.Controls.Add(this.gunaPanel2);
            this.parent_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_Panel.Location = new System.Drawing.Point(10, 65);
            this.parent_Panel.Name = "parent_Panel";
            this.parent_Panel.Padding = new System.Windows.Forms.Padding(8);
            this.parent_Panel.Size = new System.Drawing.Size(614, 586);
            this.parent_Panel.TabIndex = 3;
            // 
            // controlMain_Panel
            // 
            this.controlMain_Panel.Controls.Add(this.contro_Control_Panel);
            this.controlMain_Panel.Controls.Add(this.button_Panel);
            this.controlMain_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMain_Panel.Location = new System.Drawing.Point(8, 68);
            this.controlMain_Panel.Name = "controlMain_Panel";
            this.controlMain_Panel.Size = new System.Drawing.Size(598, 510);
            this.controlMain_Panel.TabIndex = 3;
            // 
            // contro_Control_Panel
            // 
            this.contro_Control_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contro_Control_Panel.BackColor = System.Drawing.Color.Transparent;
            this.contro_Control_Panel.BaseColor = System.Drawing.Color.White;
            this.contro_Control_Panel.Controls.Add(this.control_Panel);
            this.contro_Control_Panel.Controls.Add(this.error_Message);
            this.contro_Control_Panel.Location = new System.Drawing.Point(0, 0);
            this.contro_Control_Panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.contro_Control_Panel.Name = "contro_Control_Panel";
            this.contro_Control_Panel.Padding = new System.Windows.Forms.Padding(5);
            this.contro_Control_Panel.Radius = 8;
            this.contro_Control_Panel.Size = new System.Drawing.Size(598, 452);
            this.contro_Control_Panel.TabIndex = 6;
            // 
            // control_Panel
            // 
            this.control_Panel.AutoSize = true;
            this.control_Panel.BackColor = System.Drawing.Color.Transparent;
            this.control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.control_Panel.Location = new System.Drawing.Point(5, 5);
            this.control_Panel.Name = "control_Panel";
            this.control_Panel.Size = new System.Drawing.Size(588, 410);
            this.control_Panel.TabIndex = 3;
            this.control_Panel.WrapContents = false;
            // 
            // error_Message
            // 
            this.error_Message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.error_Message.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_Message.ForeColor = System.Drawing.Color.Red;
            this.error_Message.Location = new System.Drawing.Point(5, 415);
            this.error_Message.Margin = new System.Windows.Forms.Padding(3);
            this.error_Message.Name = "error_Message";
            this.error_Message.Padding = new System.Windows.Forms.Padding(5);
            this.error_Message.Size = new System.Drawing.Size(588, 32);
            this.error_Message.TabIndex = 2;
            this.error_Message.Text = "Error Message";
            this.error_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error_Message.Visible = false;
            // 
            // button_Panel
            // 
            this.button_Panel.ColumnCount = 2;
            this.button_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.button_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.button_Panel.Controls.Add(this.save_Btn, 1, 0);
            this.button_Panel.Controls.Add(this.cancel_Btn, 0, 0);
            this.button_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Panel.Location = new System.Drawing.Point(0, 450);
            this.button_Panel.Margin = new System.Windows.Forms.Padding(8);
            this.button_Panel.Name = "button_Panel";
            this.button_Panel.RowCount = 1;
            this.button_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.88889F));
            this.button_Panel.Size = new System.Drawing.Size(598, 60);
            this.button_Panel.TabIndex = 3;
            // 
            // save_Btn
            // 
            this.save_Btn.AnimationHoverSpeed = 0.07F;
            this.save_Btn.AnimationSpeed = 0.03F;
            this.save_Btn.BackColor = System.Drawing.Color.Transparent;
            this.save_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.save_Btn.BorderColor = System.Drawing.Color.Black;
            this.save_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.save_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.save_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Btn.ForeColor = System.Drawing.Color.White;
            this.save_Btn.Image = null;
            this.save_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.save_Btn.Location = new System.Drawing.Point(438, 8);
            this.save_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.save_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.save_Btn.OnHoverImage = null;
            this.save_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.save_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.save_Btn.Radius = 8;
            this.save_Btn.Size = new System.Drawing.Size(160, 52);
            this.save_Btn.TabIndex = 0;
            this.save_Btn.Text = "Save Record";
            this.save_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save_Btn.Click += new System.EventHandler(this.save_Btn_Click);
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.AnimationHoverSpeed = 0.07F;
            this.cancel_Btn.AnimationSpeed = 0.03F;
            this.cancel_Btn.BackColor = System.Drawing.Color.Transparent;
            this.cancel_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.cancel_Btn.BorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancel_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancel_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.cancel_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.cancel_Btn.Image = null;
            this.cancel_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancel_Btn.Location = new System.Drawing.Point(0, 8);
            this.cancel_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cancel_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancel_Btn.OnHoverImage = null;
            this.cancel_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.cancel_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cancel_Btn.Radius = 8;
            this.cancel_Btn.Size = new System.Drawing.Size(160, 52);
            this.cancel_Btn.TabIndex = 1;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaElipsePanel1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(8, 8);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.gunaPanel2.Size = new System.Drawing.Size(598, 60);
            this.gunaPanel2.TabIndex = 2;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.code_Title);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 8;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(200, 52);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // code_Title
            // 
            this.code_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code_Title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_Title.Location = new System.Drawing.Point(0, 0);
            this.code_Title.Name = "code_Title";
            this.code_Title.Size = new System.Drawing.Size(200, 52);
            this.code_Title.TabIndex = 0;
            this.code_Title.Text = "ABC000000000";
            this.code_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error_provider
            // 
            this.error_provider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_provider.ContainerControl = this;
            // 
            // Add_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.parent_Panel);
            this.Controls.Add(this.line_Panel);
            this.Controls.Add(this.top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 680);
            this.Name = "Add_Record";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIS Add Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Record_FormClosing);
            this.Load += new System.EventHandler(this.Add_Agency_Load);
            this.top_Panel.ResumeLayout(false);
            this.parent_Panel.ResumeLayout(false);
            this.controlMain_Panel.ResumeLayout(false);
            this.contro_Control_Panel.ResumeLayout(false);
            this.contro_Control_Panel.PerformLayout();
            this.button_Panel.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel top_Panel;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private Guna.UI.WinForms.GunaPanel parent_Panel;
        private Guna.UI.WinForms.GunaPanel controlMain_Panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaLabel code_Title;
        private Guna.UI.WinForms.GunaButton save_Btn;
        private System.Windows.Forms.ErrorProvider error_provider;
        private System.Windows.Forms.TableLayoutPanel button_Panel;
        private Guna.UI.WinForms.GunaButton cancel_Btn;
        private Guna.UI.WinForms.GunaElipsePanel contro_Control_Panel;
        private System.Windows.Forms.FlowLayoutPanel control_Panel;
        private Guna.UI.WinForms.GunaLabel error_Message;
    }
}