namespace COA_IMS.Screens.scrn
{
    partial class IMS_Tracking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.CreateOrder = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.searchBar1 = new COA_IMS.UserControlUtil.SearchBar();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.CreateOrder);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Controls.Add(this.flowLayoutPanel1);
            this.gunaPanel1.Location = new System.Drawing.Point(12, 12);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1579, 902);
            this.gunaPanel1.TabIndex = 0;
            // 
            // CreateOrder
            // 
            this.CreateOrder.AnimationHoverSpeed = 0.07F;
            this.CreateOrder.AnimationSpeed = 0.03F;
            this.CreateOrder.BackColor = System.Drawing.Color.Transparent;
            this.CreateOrder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CreateOrder.BorderColor = System.Drawing.Color.Black;
            this.CreateOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CreateOrder.FocusedColor = System.Drawing.Color.Empty;
            this.CreateOrder.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrder.ForeColor = System.Drawing.Color.White;
            this.CreateOrder.Image = null;
            this.CreateOrder.ImageSize = new System.Drawing.Size(20, 20);
            this.CreateOrder.Location = new System.Drawing.Point(1441, 80);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CreateOrder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CreateOrder.OnHoverForeColor = System.Drawing.Color.White;
            this.CreateOrder.OnHoverImage = null;
            this.CreateOrder.OnPressedColor = System.Drawing.Color.Black;
            this.CreateOrder.Radius = 10;
            this.CreateOrder.Size = new System.Drawing.Size(127, 35);
            this.CreateOrder.TabIndex = 4;
            this.CreateOrder.Text = "CreateOrder";
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.gunaPanel2.Controls.Add(this.pictureBox1);
            this.gunaPanel2.Controls.Add(this.gunaLabel2);
            this.gunaPanel2.Controls.Add(this.gunaDataGridView1);
            this.gunaPanel2.Location = new System.Drawing.Point(6, 159);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1562, 740);
            this.gunaPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COA_IMS.Properties.Resources.clipboard_user;
            this.pictureBox1.Location = new System.Drawing.Point(26, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(62, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(342, 35);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "EQUIPMENT OWNERSHIP";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeight = 21;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(25, 63);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1518, 659);
            this.gunaDataGridView1.TabIndex = 2;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.DeepPurple;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Num
            // 
            this.Num.HeaderText = "#";
            this.Num.Name = "Num";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Owner";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gunaLinePanel1);
            this.flowLayoutPanel1.Controls.Add(this.searchBar1);
            this.flowLayoutPanel1.Controls.Add(this.gunaButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1579, 74);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(3, 3);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1575, 3);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.Color.Transparent;
            this.searchBar1.Location = new System.Drawing.Point(3, 19);
            this.searchBar1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(939, 56);
            this.searchBar1.TabIndex = 20;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::COA_IMS.Properties.Resources.refresh__1_;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton1.Location = new System.Drawing.Point(948, 14);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 12;
            this.gunaButton1.Size = new System.Drawing.Size(54, 54);
            this.gunaButton1.TabIndex = 21;
            // 
            // IMS_Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1603, 926);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IMS_Tracking";
            this.Text = "IMS_Tracking";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControlUtil.SearchBar searchBar1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton CreateOrder;
    }
}