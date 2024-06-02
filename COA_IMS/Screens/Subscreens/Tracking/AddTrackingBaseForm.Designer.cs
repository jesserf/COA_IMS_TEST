namespace COA_IMS.Screens.Subscrn.Tracking
{
    partial class AddTrackingBaseForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.next_Btn = new Guna.UI.WinForms.GunaButton();
            this.back_Btn = new Guna.UI.WinForms.GunaButton();
            this.main_Panel = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.next_Btn);
            this.flowLayoutPanel1.Controls.Add(this.back_Btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 717);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1567, 100);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // next_Btn
            // 
            this.next_Btn.AnimationHoverSpeed = 0.07F;
            this.next_Btn.AnimationSpeed = 0.03F;
            this.next_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.next_Btn.BorderColor = System.Drawing.Color.Black;
            this.next_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.next_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.next_Btn.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.next_Btn.ForeColor = System.Drawing.Color.White;
            this.next_Btn.Image = null;
            this.next_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.next_Btn.Location = new System.Drawing.Point(1395, 10);
            this.next_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.next_Btn.Name = "next_Btn";
            this.next_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.next_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.next_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.next_Btn.OnHoverImage = null;
            this.next_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.next_Btn.Size = new System.Drawing.Size(160, 49);
            this.next_Btn.TabIndex = 0;
            this.next_Btn.Text = "Next";
            this.next_Btn.Click += new System.EventHandler(this.next_Button_Click);
            // 
            // back_Btn
            // 
            this.back_Btn.AnimationHoverSpeed = 0.07F;
            this.back_Btn.AnimationSpeed = 0.03F;
            this.back_Btn.BaseColor = System.Drawing.Color.LightGray;
            this.back_Btn.BorderColor = System.Drawing.Color.Silver;
            this.back_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.back_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.back_Btn.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.back_Btn.ForeColor = System.Drawing.Color.Black;
            this.back_Btn.Image = null;
            this.back_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.back_Btn.Location = new System.Drawing.Point(1215, 10);
            this.back_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.back_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.back_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.back_Btn.OnHoverImage = null;
            this.back_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.back_Btn.Size = new System.Drawing.Size(160, 49);
            this.back_Btn.TabIndex = 1;
            this.back_Btn.Text = "BACK";
            this.back_Btn.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // main_Panel
            // 
            this.main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Panel.Location = new System.Drawing.Point(0, 0);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(1567, 717);
            this.main_Panel.TabIndex = 10;
            // 
            // AddTrackingBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1567, 817);
            this.Controls.Add(this.main_Panel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTrackingBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTrackingBaseForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaButton next_Btn;
        private Guna.UI.WinForms.GunaButton back_Btn;
        private Guna.UI.WinForms.GunaPanel main_Panel;
    }
}