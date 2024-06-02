namespace COA_IMS.UserControlUtil.PRIS_UserControl
{
    partial class PRIS_Label_MainCheckBox
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
            this.container_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.content_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.top_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.check = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.message = new Guna.UI.WinForms.GunaLabel();
            this.bottom_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.container_Panel.SuspendLayout();
            this.content_Panel.SuspendLayout();
            this.top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_Panel
            // 
            this.container_Panel.AutoSize = true;
            this.container_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.container_Panel.BackColor = System.Drawing.Color.Transparent;
            this.container_Panel.BaseColor = System.Drawing.Color.Gainsboro;
            this.container_Panel.Controls.Add(this.content_Panel);
            this.container_Panel.Location = new System.Drawing.Point(4, 3);
            this.container_Panel.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.container_Panel.Name = "container_Panel";
            this.container_Panel.Size = new System.Drawing.Size(411, 94);
            this.container_Panel.TabIndex = 0;
            // 
            // content_Panel
            // 
            this.content_Panel.AutoSize = true;
            this.content_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.content_Panel.BackColor = System.Drawing.Color.White;
            this.content_Panel.Controls.Add(this.top_Panel);
            this.content_Panel.Controls.Add(this.bottom_Panel);
            this.content_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.content_Panel.Location = new System.Drawing.Point(3, 3);
            this.content_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(406, 89);
            this.content_Panel.TabIndex = 0;
            // 
            // top_Panel
            // 
            this.top_Panel.BackColor = System.Drawing.Color.Transparent;
            this.top_Panel.ColumnCount = 4;
            this.top_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.top_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.top_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.top_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.top_Panel.Controls.Add(this.check, 0, 0);
            this.top_Panel.Controls.Add(this.title, 2, 0);
            this.top_Panel.Controls.Add(this.gunaLinePanel1, 1, 0);
            this.top_Panel.Controls.Add(this.message, 3, 0);
            this.top_Panel.Location = new System.Drawing.Point(3, 3);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.RowCount = 1;
            this.top_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.top_Panel.Size = new System.Drawing.Size(400, 50);
            this.top_Panel.TabIndex = 0;
            // 
            // check
            // 
            this.check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check.BaseColor = System.Drawing.Color.White;
            this.check.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.FillColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(10, 15);
            this.check.Margin = new System.Windows.Forms.Padding(10);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(20, 20);
            this.check.TabIndex = 0;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(46, 0);
            this.title.Margin = new System.Windows.Forms.Padding(3, 0, 20, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(57, 47);
            this.title.TabIndex = 2;
            this.title.Text = "Label";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(40, 3);
            this.gunaLinePanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(3, 44);
            this.gunaLinePanel1.TabIndex = 3;
            // 
            // message
            // 
            this.message.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Gray;
            this.message.Location = new System.Drawing.Point(123, 14);
            this.message.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 19);
            this.message.TabIndex = 6;
            this.message.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bottom_Panel
            // 
            this.bottom_Panel.AutoSize = true;
            this.bottom_Panel.BackColor = System.Drawing.Color.Transparent;
            this.bottom_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_Panel.Enabled = false;
            this.bottom_Panel.Location = new System.Drawing.Point(3, 56);
            this.bottom_Panel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.bottom_Panel.MinimumSize = new System.Drawing.Size(400, 30);
            this.bottom_Panel.Name = "bottom_Panel";
            this.bottom_Panel.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.bottom_Panel.Size = new System.Drawing.Size(400, 30);
            this.bottom_Panel.TabIndex = 1;
            this.bottom_Panel.Visible = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.content_Panel;
            // 
            // PRIS_Label_MainCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.container_Panel);
            this.Name = "PRIS_Label_MainCheckBox";
            this.Size = new System.Drawing.Size(428, 100);
            this.Load += new System.EventHandler(this.PRIS_Label_RoleCheckBox_Load);
            this.SizeChanged += new System.EventHandler(this.PRIS_Label_MainCheckBox_SizeChanged);
            this.container_Panel.ResumeLayout(false);
            this.container_Panel.PerformLayout();
            this.content_Panel.ResumeLayout(false);
            this.content_Panel.PerformLayout();
            this.top_Panel.ResumeLayout(false);
            this.top_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel container_Panel;
        private System.Windows.Forms.FlowLayoutPanel content_Panel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.TableLayoutPanel top_Panel;
        private Guna.UI.WinForms.GunaMediumCheckBox check;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.FlowLayoutPanel bottom_Panel;
        private Guna.UI.WinForms.GunaLabel message;
    }
}
