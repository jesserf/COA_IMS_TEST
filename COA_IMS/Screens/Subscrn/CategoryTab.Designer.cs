namespace COA_IMS.Screens.Subscrn
{
    partial class CategoryTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryTab));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reports_Button = new Guna.UI.WinForms.GunaButton();
            this.refresh_Button = new Guna.UI.WinForms.GunaButton();
            this.sortComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.searchBar1 = new COA_IMS.UserControlUtil.SearchBar();
            this.dateFilter1 = new COA_IMS.UserControlUtil.DateFilter();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.addcategorybtn = new Guna.UI.WinForms.GunaButton();
            this.LogsTable = new Guna.UI.WinForms.GunaDataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.previous_Button = new Guna.UI.WinForms.GunaButton();
            this.pageCountTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.next_Button = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogsTable)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 92);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1626, 49);
            this.gunaElipsePanel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.78075F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.21925F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.sortComboBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchBar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateFilter1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1626, 49);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.reports_Button);
            this.flowLayoutPanel1.Controls.Add(this.refresh_Button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1503, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(117, 43);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // reports_Button
            // 
            this.reports_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reports_Button.AnimationHoverSpeed = 0.07F;
            this.reports_Button.AnimationSpeed = 0.03F;
            this.reports_Button.BackColor = System.Drawing.Color.Transparent;
            this.reports_Button.BaseColor = System.Drawing.Color.Gray;
            this.reports_Button.BorderColor = System.Drawing.Color.Black;
            this.reports_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reports_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reports_Button.FocusedColor = System.Drawing.Color.Empty;
            this.reports_Button.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.reports_Button.ForeColor = System.Drawing.Color.White;
            this.reports_Button.Image = global::COA_IMS.Properties.Resources.business_report__1_;
            this.reports_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.reports_Button.Location = new System.Drawing.Point(3, 3);
            this.reports_Button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.reports_Button.Name = "reports_Button";
            this.reports_Button.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.reports_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.reports_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.reports_Button.OnHoverImage = null;
            this.reports_Button.OnPressedColor = System.Drawing.Color.Black;
            this.reports_Button.Radius = 12;
            this.reports_Button.Size = new System.Drawing.Size(42, 35);
            this.reports_Button.TabIndex = 4;
            // 
            // refresh_Button
            // 
            this.refresh_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refresh_Button.AnimationHoverSpeed = 0.07F;
            this.refresh_Button.AnimationSpeed = 0.03F;
            this.refresh_Button.BackColor = System.Drawing.Color.Transparent;
            this.refresh_Button.BaseColor = System.Drawing.Color.Gray;
            this.refresh_Button.BorderColor = System.Drawing.Color.Black;
            this.refresh_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refresh_Button.FocusedColor = System.Drawing.Color.Empty;
            this.refresh_Button.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.refresh_Button.ForeColor = System.Drawing.Color.White;
            this.refresh_Button.Image = global::COA_IMS.Properties.Resources.refresh__1_;
            this.refresh_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.refresh_Button.Location = new System.Drawing.Point(51, 3);
            this.refresh_Button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.refresh_Button.Name = "refresh_Button";
            this.refresh_Button.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.refresh_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refresh_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.refresh_Button.OnHoverImage = null;
            this.refresh_Button.OnPressedColor = System.Drawing.Color.Black;
            this.refresh_Button.Radius = 12;
            this.refresh_Button.Size = new System.Drawing.Size(42, 35);
            this.refresh_Button.TabIndex = 5;
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortComboBox.BackColor = System.Drawing.Color.Transparent;
            this.sortComboBox.BaseColor = System.Drawing.Color.Gray;
            this.sortComboBox.BorderColor = System.Drawing.Color.Transparent;
            this.sortComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.sortComboBox.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.sortComboBox.ForeColor = System.Drawing.Color.White;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "User Name",
            "Activity"});
            this.sortComboBox.Location = new System.Drawing.Point(1303, 4);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.OnHoverItemBaseColor = System.Drawing.Color.Silver;
            this.sortComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sortComboBox.Radius = 12;
            this.sortComboBox.Size = new System.Drawing.Size(185, 35);
            this.sortComboBox.TabIndex = 2;
            // 
            // searchBar1
            // 
            this.searchBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchBar1.BackColor = System.Drawing.Color.Transparent;
            this.searchBar1.Location = new System.Drawing.Point(3, 3);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(548, 43);
            this.searchBar1.TabIndex = 3;
            // 
            // dateFilter1
            // 
            this.dateFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateFilter1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateFilter1.BackColor = System.Drawing.Color.Transparent;
            this.dateFilter1.fromValue = new System.DateTime(2024, 4, 8, 10, 35, 15, 477);
            this.dateFilter1.Location = new System.Drawing.Point(559, 3);
            this.dateFilter1.Name = "dateFilter1";
            this.dateFilter1.Size = new System.Drawing.Size(640, 43);
            this.dateFilter1.TabIndex = 5;
            this.dateFilter1.toValue = new System.DateTime(2024, 4, 8, 10, 35, 15, 477);
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.addcategorybtn);
            this.gunaElipsePanel2.Controls.Add(this.LogsTable);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(0, 177);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(1625, 632);
            this.gunaElipsePanel2.TabIndex = 4;
            // 
            // addcategorybtn
            // 
            this.addcategorybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addcategorybtn.AnimationHoverSpeed = 0.07F;
            this.addcategorybtn.AnimationSpeed = 0.03F;
            this.addcategorybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(82)))));
            this.addcategorybtn.BaseColor = System.Drawing.Color.White;
            this.addcategorybtn.BorderColor = System.Drawing.Color.Black;
            this.addcategorybtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addcategorybtn.FocusedColor = System.Drawing.Color.Empty;
            this.addcategorybtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addcategorybtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(82)))));
            this.addcategorybtn.Image = global::COA_IMS.Properties.Resources.add__1_;
            this.addcategorybtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addcategorybtn.Location = new System.Drawing.Point(1445, 5);
            this.addcategorybtn.Name = "addcategorybtn";
            this.addcategorybtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addcategorybtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addcategorybtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addcategorybtn.OnHoverImage = null;
            this.addcategorybtn.OnPressedColor = System.Drawing.Color.Black;
            this.addcategorybtn.Radius = 10;
            this.addcategorybtn.Size = new System.Drawing.Size(154, 42);
            this.addcategorybtn.TabIndex = 2;
            this.addcategorybtn.Text = "Add new Category";
            this.addcategorybtn.Click += new System.EventHandler(this.addcategorybtn_Click);
            // 
            // LogsTable
            // 
            this.LogsTable.AllowUserToAddRows = false;
            this.LogsTable.AllowUserToDeleteRows = false;
            this.LogsTable.AllowUserToResizeColumns = false;
            this.LogsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.LogsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.LogsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LogsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(82)))));
            this.LogsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LogsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LogsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.LogsTable.ColumnHeadersHeight = 20;
            this.LogsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LogsTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.LogsTable.EnableHeadersVisualStyles = false;
            this.LogsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(82)))));
            this.LogsTable.Location = new System.Drawing.Point(0, -39);
            this.LogsTable.Margin = new System.Windows.Forms.Padding(15);
            this.LogsTable.Name = "LogsTable";
            this.LogsTable.ReadOnly = true;
            this.LogsTable.RowHeadersVisible = false;
            this.LogsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogsTable.Size = new System.Drawing.Size(1625, 671);
            this.LogsTable.TabIndex = 8;
            this.LogsTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(82)))));
            this.LogsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(82)))));
            this.LogsTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LogsTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LogsTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LogsTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LogsTable.ThemeStyle.HeaderStyle.Height = 20;
            this.LogsTable.ThemeStyle.ReadOnly = true;
            this.LogsTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LogsTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LogsTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LogsTable.ThemeStyle.RowsStyle.Height = 22;
            this.LogsTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LogsTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 790);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1603, 76);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel2.Controls.Add(this.previous_Button);
            this.flowLayoutPanel2.Controls.Add(this.pageCountTextbox);
            this.flowLayoutPanel2.Controls.Add(this.next_Button);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(701, 9);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 64);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // previous_Button
            // 
            this.previous_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previous_Button.AnimationHoverSpeed = 0.07F;
            this.previous_Button.AnimationSpeed = 0.03F;
            this.previous_Button.BackColor = System.Drawing.Color.White;
            this.previous_Button.BaseColor = System.Drawing.Color.White;
            this.previous_Button.BorderColor = System.Drawing.Color.White;
            this.previous_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.previous_Button.FocusedColor = System.Drawing.Color.White;
            this.previous_Button.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.previous_Button.ForeColor = System.Drawing.Color.White;
            this.previous_Button.Image = ((System.Drawing.Image)(resources.GetObject("previous_Button.Image")));
            this.previous_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.previous_Button.Location = new System.Drawing.Point(3, 3);
            this.previous_Button.Name = "previous_Button";
            this.previous_Button.OnHoverBaseColor = System.Drawing.Color.White;
            this.previous_Button.OnHoverBorderColor = System.Drawing.Color.White;
            this.previous_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.previous_Button.OnHoverImage = null;
            this.previous_Button.OnPressedColor = System.Drawing.Color.White;
            this.previous_Button.Size = new System.Drawing.Size(46, 42);
            this.previous_Button.TabIndex = 0;
            this.previous_Button.Text = "<";
            // 
            // pageCountTextbox
            // 
            this.pageCountTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageCountTextbox.BackColor = System.Drawing.Color.White;
            this.pageCountTextbox.BaseColor = System.Drawing.Color.White;
            this.pageCountTextbox.BorderColor = System.Drawing.Color.White;
            this.pageCountTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pageCountTextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.pageCountTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pageCountTextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.pageCountTextbox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageCountTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.pageCountTextbox.Location = new System.Drawing.Point(55, 15);
            this.pageCountTextbox.Name = "pageCountTextbox";
            this.pageCountTextbox.PasswordChar = '\0';
            this.pageCountTextbox.SelectedText = "";
            this.pageCountTextbox.Size = new System.Drawing.Size(90, 30);
            this.pageCountTextbox.TabIndex = 2;
            this.pageCountTextbox.Text = "1";
            this.pageCountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // next_Button
            // 
            this.next_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.next_Button.AnimationHoverSpeed = 0.07F;
            this.next_Button.AnimationSpeed = 0.03F;
            this.next_Button.BackColor = System.Drawing.Color.Transparent;
            this.next_Button.BaseColor = System.Drawing.Color.White;
            this.next_Button.BorderColor = System.Drawing.Color.Black;
            this.next_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.next_Button.FocusedColor = System.Drawing.Color.Empty;
            this.next_Button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_Button.ForeColor = System.Drawing.Color.White;
            this.next_Button.Image = ((System.Drawing.Image)(resources.GetObject("next_Button.Image")));
            this.next_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.next_Button.Location = new System.Drawing.Point(151, 3);
            this.next_Button.Name = "next_Button";
            this.next_Button.OnHoverBaseColor = System.Drawing.Color.White;
            this.next_Button.OnHoverBorderColor = System.Drawing.Color.White;
            this.next_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.next_Button.OnHoverImage = null;
            this.next_Button.OnPressedColor = System.Drawing.Color.White;
            this.next_Button.Size = new System.Drawing.Size(46, 42);
            this.next_Button.TabIndex = 1;
            this.next_Button.Text = ">";
            // 
            // CategoryTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1603, 866);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryTab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategoryTab_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gunaElipsePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogsTable)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton addcategorybtn;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaButton reports_Button;
        private Guna.UI.WinForms.GunaButton refresh_Button;
        private Guna.UI.WinForms.GunaComboBox sortComboBox;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaDataGridView LogsTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI.WinForms.GunaButton previous_Button;
        private Guna.UI.WinForms.GunaTextBox pageCountTextbox;
        private Guna.UI.WinForms.GunaButton next_Button;
        private UserControlUtil.DateFilter dateFilter1;
        private UserControlUtil.SearchBar searchBar1;
    }
}