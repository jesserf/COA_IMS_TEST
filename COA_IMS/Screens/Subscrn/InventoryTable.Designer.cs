namespace COA_IMS.Screens.Subscrn
{
    partial class InventoryTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryTable));
            this.LogsTable = new Guna.UI.WinForms.GunaDataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sortComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.add_item = new Guna.UI.WinForms.GunaButton();
            this.pageCountTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.main_Panel = new System.Windows.Forms.Panel();
            this.content_Panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.previous_Button = new Guna.UI.WinForms.GunaButton();
            this.next_Button = new Guna.UI.WinForms.GunaButton();
            this.reports_Button = new Guna.UI.WinForms.GunaButton();
            this.refresh_Button = new Guna.UI.WinForms.GunaButton();
            this.add_Item_Btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.searchBar1 = new COA_IMS.UserControlUtil.SearchBar();
            ((System.ComponentModel.ISupportInitialize)(this.LogsTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.main_Panel.SuspendLayout();
            this.content_Panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogsTable
            // 
            this.LogsTable.AllowUserToAddRows = false;
            this.LogsTable.AllowUserToDeleteRows = false;
            this.LogsTable.AllowUserToResizeColumns = false;
            this.LogsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.LogsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LogsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LogsTable.BackgroundColor = System.Drawing.Color.White;
            this.LogsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LogsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LogsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LogsTable.ColumnHeadersHeight = 20;
            this.LogsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LogsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.LogsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsTable.EnableHeadersVisualStyles = false;
            this.LogsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LogsTable.Location = new System.Drawing.Point(0, 0);
            this.LogsTable.Margin = new System.Windows.Forms.Padding(15);
            this.LogsTable.Name = "LogsTable";
            this.LogsTable.ReadOnly = true;
            this.LogsTable.RowHeadersVisible = false;
            this.LogsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogsTable.Size = new System.Drawing.Size(1567, 594);
            this.LogsTable.TabIndex = 7;
            this.LogsTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.13805F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.86195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.Controls.Add(this.add_Item_Btn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchBar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sortComboBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.add_Item_Btn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1567, 144);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // add_Item_Btn
            // 
            this.add_Item_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_Item_Btn.AnimationHoverSpeed = 0.07F;
            this.add_Item_Btn.AnimationSpeed = 0.03F;
            this.add_Item_Btn.BackColor = System.Drawing.Color.Transparent;
            this.add_Item_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.add_Item_Btn.BorderColor = System.Drawing.Color.Black;
            this.add_Item_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.add_Item_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.add_Item_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.add_Item_Btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("add_Item_Btn.CheckedImage")));
            this.add_Item_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.add_Item_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Item_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_Item_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.add_Item_Btn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.add_Item_Btn.ForeColor = System.Drawing.Color.White;
            this.add_Item_Btn.Image = global::COA_IMS.Properties.Resources.add_product;
            this.add_Item_Btn.ImageSize = new System.Drawing.Size(32, 32);
            this.add_Item_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.add_Item_Btn.Location = new System.Drawing.Point(554, 23);
            this.add_Item_Btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.add_Item_Btn.Name = "add_Item_Btn";
            this.add_Item_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.add_Item_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.add_Item_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.add_Item_Btn.OnHoverImage = null;
            this.add_Item_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.add_Item_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.add_Item_Btn.Size = new System.Drawing.Size(180, 42);
            this.add_Item_Btn.TabIndex = 8;
            this.add_Item_Btn.Text = "ADD ITEM";
            this.add_Item_Btn.Click += new System.EventHandler(this.add_item_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.reports_Button);
            this.flowLayoutPanel1.Controls.Add(this.refresh_Button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1417, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(118, 43);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortComboBox.BackColor = System.Drawing.Color.Transparent;
            this.sortComboBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
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
            this.sortComboBox.Location = new System.Drawing.Point(1187, 30);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(202)))), ((int)(((byte)(148)))));
            this.sortComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sortComboBox.Radius = 12;
            this.sortComboBox.Size = new System.Drawing.Size(191, 35);
            this.sortComboBox.TabIndex = 2;
            // 
            // add_item
            // 
            this.add_item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_item.AnimationHoverSpeed = 0.07F;
            this.add_item.AnimationSpeed = 0.03F;
            this.add_item.BackColor = System.Drawing.Color.Transparent;
            this.add_item.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.add_item.BorderColor = System.Drawing.Color.Black;
            this.add_item.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_item.FocusedColor = System.Drawing.Color.Empty;
            this.add_item.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_item.ForeColor = System.Drawing.Color.White;
            this.add_item.Image = null;
            this.add_item.ImageSize = new System.Drawing.Size(20, 20);
            this.add_item.Location = new System.Drawing.Point(553, 25);
            this.add_item.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.add_item.Name = "add_item";
            this.add_item.OnHoverBaseColor = System.Drawing.Color.White;
            this.add_item.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add_item.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.add_item.OnHoverImage = null;
            this.add_item.OnPressedColor = System.Drawing.Color.Black;
            this.add_item.Radius = 12;
            this.add_item.Size = new System.Drawing.Size(191, 40);
            this.add_item.TabIndex = 0;
            this.add_item.Text = "Add Item";
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
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
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.tableLayoutPanel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1567, 144);
            this.gunaPanel1.TabIndex = 8;
            // 
            // main_Panel
            // 
            this.main_Panel.Controls.Add(this.content_Panel);
            this.main_Panel.Controls.Add(this.tableLayoutPanel2);
            this.main_Panel.Controls.Add(this.gunaPanel1);
            this.main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Panel.Location = new System.Drawing.Point(0, 0);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(1567, 817);
            this.main_Panel.TabIndex = 11;
            // 
            // content_Panel
            // 
            this.content_Panel.Controls.Add(this.LogsTable);
            this.content_Panel.Location = new System.Drawing.Point(0, 147);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(1567, 594);
            this.content_Panel.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 741);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1567, 76);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel2.Controls.Add(this.previous_Button);
            this.flowLayoutPanel2.Controls.Add(this.pageCountTextbox);
            this.flowLayoutPanel2.Controls.Add(this.next_Button);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(683, 9);
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
            // reports_Button
            // 
            this.reports_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reports_Button.AnimationHoverSpeed = 0.07F;
            this.reports_Button.AnimationSpeed = 0.03F;
            this.reports_Button.BackColor = System.Drawing.Color.Transparent;
            this.reports_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
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
            this.reports_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(202)))), ((int)(((byte)(148)))));
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
            this.refresh_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
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
            this.refresh_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(202)))), ((int)(((byte)(148)))));
            this.refresh_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refresh_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.refresh_Button.OnHoverImage = null;
            this.refresh_Button.OnPressedColor = System.Drawing.Color.Black;
            this.refresh_Button.Radius = 12;
            this.refresh_Button.Size = new System.Drawing.Size(42, 35);
            this.refresh_Button.TabIndex = 5;
            // 
            // add_Item_Btn
            // 
            this.add_Item_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_Item_Btn.AnimationHoverSpeed = 0.07F;
            this.add_Item_Btn.AnimationSpeed = 0.03F;
            this.add_Item_Btn.BackColor = System.Drawing.Color.Transparent;
            this.add_Item_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.add_Item_Btn.BorderColor = System.Drawing.Color.Black;
            this.add_Item_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.add_Item_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.add_Item_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.add_Item_Btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("add_Item_Btn.CheckedImage")));
            this.add_Item_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.add_Item_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Item_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_Item_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.add_Item_Btn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.add_Item_Btn.ForeColor = System.Drawing.Color.White;
            this.add_Item_Btn.Image = global::COA_IMS.Properties.Resources.add_product;
            this.add_Item_Btn.ImageSize = new System.Drawing.Size(32, 32);
            this.add_Item_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.add_Item_Btn.Location = new System.Drawing.Point(560, 92);
            this.add_Item_Btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.add_Item_Btn.Name = "add_Item_Btn";
            this.add_Item_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.add_Item_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(82)))));
            this.add_Item_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.add_Item_Btn.OnHoverImage = null;
            this.add_Item_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.add_Item_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.add_Item_Btn.Radius = 10;
            this.add_Item_Btn.Size = new System.Drawing.Size(180, 42);
            this.add_Item_Btn.TabIndex = 8;
            this.add_Item_Btn.Text = "ADD ITEM";
            this.add_Item_Btn.Click += new System.EventHandler(this.add_item_Click);
            // 
            // searchBar1
            // 
            this.searchBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchBar1.Location = new System.Drawing.Point(3, 98);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(544, 43);
            this.searchBar1.TabIndex = 3;
            // 
            // InventoryTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1567, 817);
            this.Controls.Add(this.main_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryTable";
            this.Text = "InventoryTable";
            ((System.ComponentModel.ISupportInitialize)(this.LogsTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.main_Panel.ResumeLayout(false);
            this.content_Panel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView LogsTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaButton reports_Button;
        private Guna.UI.WinForms.GunaButton refresh_Button;
        private Guna.UI.WinForms.GunaComboBox sortComboBox;
        private Guna.UI.WinForms.GunaButton add_item;
        private UserControlUtil.SearchBar searchBar1;
        private Guna.UI.WinForms.GunaButton previous_Button;
        private Guna.UI.WinForms.GunaTextBox pageCountTextbox;
        private Guna.UI.WinForms.GunaButton next_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.Panel content_Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI.WinForms.GunaAdvenceButton add_Item_Btn;
    }
}