namespace COA_IMS.Screens.Subscrn.SettingsSubscreens
{
    partial class MiscCategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.add_New_Label = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.category_Name_TextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.add_Category_Button = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sortComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.category_Label = new Guna.UI.WinForms.GunaLabel();
            this.previous_Button = new Guna.UI.WinForms.GunaButton();
            this.pageCountTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.next_Button = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.searchBar1 = new COA_IMS.UserControlUtil.SearchBar();
            this.refresh_Button = new Guna.UI.WinForms.GunaButton();
            this.data_View = new Guna.UI.WinForms.GunaDataGridView();
            this.searchbar_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_View)).BeginInit();
            this.searchbar_Panel.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 12;
            this.gunaElipse1.TargetControl = this.flowLayoutPanel3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Controls.Add(this.add_New_Label);
            this.flowLayoutPanel3.Controls.Add(this.gunaLinePanel1);
            this.flowLayoutPanel3.Controls.Add(this.category_Name_TextBox);
            this.flowLayoutPanel3.Controls.Add(this.add_Category_Button);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(732, 208);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // add_New_Label
            // 
            this.add_New_Label.AutoSize = true;
            this.add_New_Label.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_New_Label.ForeColor = System.Drawing.Color.DimGray;
            this.add_New_Label.Location = new System.Drawing.Point(13, 10);
            this.add_New_Label.Name = "add_New_Label";
            this.add_New_Label.Size = new System.Drawing.Size(318, 39);
            this.add_New_Label.TabIndex = 0;
            this.add_New_Label.Text = "ADD NEW CATEGORY";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Gray;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(13, 52);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(712, 2);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // category_Name_TextBox
            // 
            this.category_Name_TextBox.BackColor = System.Drawing.Color.White;
            this.category_Name_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.category_Name_TextBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.category_Name_TextBox.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_Name_TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.category_Name_TextBox.LineColor = System.Drawing.Color.Gainsboro;
            this.category_Name_TextBox.Location = new System.Drawing.Point(13, 60);
            this.category_Name_TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.category_Name_TextBox.Name = "category_Name_TextBox";
            this.category_Name_TextBox.PasswordChar = '\0';
            this.category_Name_TextBox.SelectedText = "";
            this.category_Name_TextBox.Size = new System.Drawing.Size(417, 39);
            this.category_Name_TextBox.TabIndex = 3;
            this.category_Name_TextBox.Text = "Category Name";
            this.category_Name_TextBox.Enter += new System.EventHandler(this.textbox_Enter);
            this.category_Name_TextBox.Leave += new System.EventHandler(this.textbox_Leave);
            // 
            // add_Category_Button
            // 
            this.add_Category_Button.AnimationHoverSpeed = 0.07F;
            this.add_Category_Button.AnimationSpeed = 0.03F;
            this.add_Category_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(175)))));
            this.add_Category_Button.BorderColor = System.Drawing.Color.Black;
            this.add_Category_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_Category_Button.FocusedColor = System.Drawing.Color.Empty;
            this.add_Category_Button.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Category_Button.ForeColor = System.Drawing.Color.White;
            this.add_Category_Button.Image = global::COA_IMS.Properties.Resources.add_file;
            this.add_Category_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.add_Category_Button.Location = new System.Drawing.Point(13, 122);
            this.add_Category_Button.Name = "add_Category_Button";
            this.add_Category_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(141)))), ((int)(((byte)(140)))));
            this.add_Category_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add_Category_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.add_Category_Button.OnHoverImage = null;
            this.add_Category_Button.OnPressedColor = System.Drawing.Color.Black;
            this.add_Category_Button.Size = new System.Drawing.Size(110, 42);
            this.add_Category_Button.TabIndex = 5;
            this.add_Category_Button.Text = "ADD";
            this.add_Category_Button.Click += new System.EventHandler(this.add_Category_Button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sortComboBox);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 33);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(735, 800);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortComboBox.BackColor = System.Drawing.Color.Transparent;
            this.sortComboBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(175)))));
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
            this.sortComboBox.Location = new System.Drawing.Point(3, 3);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(141)))), ((int)(((byte)(140)))));
            this.sortComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sortComboBox.Radius = 12;
            this.sortComboBox.Size = new System.Drawing.Size(185, 35);
            this.sortComboBox.TabIndex = 2;
            this.sortComboBox.SelectedValueChanged += new System.EventHandler(this.sortComboBox_SelectedValueChanged);
            // 
            // category_Label
            // 
            this.category_Label.AutoSize = true;
            this.category_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.category_Label.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_Label.ForeColor = System.Drawing.Color.DimGray;
            this.category_Label.Location = new System.Drawing.Point(10, 10);
            this.category_Label.Name = "category_Label";
            this.category_Label.Size = new System.Drawing.Size(169, 39);
            this.category_Label.TabIndex = 18;
            this.category_Label.Text = "CATEGORY";
            // 
            // previous_Button
            // 
            this.previous_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previous_Button.AnimationHoverSpeed = 0.07F;
            this.previous_Button.AnimationSpeed = 0.03F;
            this.previous_Button.BackColor = System.Drawing.Color.Transparent;
            this.previous_Button.BaseColor = System.Drawing.Color.Transparent;
            this.previous_Button.BorderColor = System.Drawing.Color.White;
            this.previous_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.previous_Button.FocusedColor = System.Drawing.Color.White;
            this.previous_Button.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.previous_Button.ForeColor = System.Drawing.Color.White;
            this.previous_Button.Image = global::COA_IMS.Properties.Resources.caret_left;
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
            this.previous_Button.Click += new System.EventHandler(this.previous_Button_Click);
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
            this.next_Button.BaseColor = System.Drawing.Color.Transparent;
            this.next_Button.BorderColor = System.Drawing.Color.Black;
            this.next_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.next_Button.FocusedColor = System.Drawing.Color.Empty;
            this.next_Button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_Button.ForeColor = System.Drawing.Color.White;
            this.next_Button.Image = global::COA_IMS.Properties.Resources.caret_right;
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
            this.next_Button.Click += new System.EventHandler(this.next_Button_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel2.Controls.Add(this.previous_Button);
            this.flowLayoutPanel2.Controls.Add(this.pageCountTextbox);
            this.flowLayoutPanel2.Controls.Add(this.next_Button);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(257, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 53);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.BackColor = System.Drawing.Color.Gray;
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(10, 49);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(714, 2);
            this.gunaLinePanel2.TabIndex = 26;
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.Color.Transparent;
            this.searchBar1.Location = new System.Drawing.Point(3, 10);
            this.searchBar1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(587, 45);
            this.searchBar1.TabIndex = 20;
            // 
            // refresh_Button
            // 
            this.refresh_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refresh_Button.AnimationHoverSpeed = 0.07F;
            this.refresh_Button.AnimationSpeed = 0.03F;
            this.refresh_Button.BackColor = System.Drawing.Color.Transparent;
            this.refresh_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(175)))));
            this.refresh_Button.BorderColor = System.Drawing.Color.Black;
            this.refresh_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refresh_Button.FocusedColor = System.Drawing.Color.Empty;
            this.refresh_Button.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.refresh_Button.ForeColor = System.Drawing.Color.White;
            this.refresh_Button.Image = global::COA_IMS.Properties.Resources.refresh__1_;
            this.refresh_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.refresh_Button.Location = new System.Drawing.Point(596, 13);
            this.refresh_Button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.refresh_Button.Name = "refresh_Button";
            this.refresh_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(141)))), ((int)(((byte)(140)))));
            this.refresh_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refresh_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.refresh_Button.OnHoverImage = null;
            this.refresh_Button.OnPressedColor = System.Drawing.Color.Black;
            this.refresh_Button.Radius = 12;
            this.refresh_Button.Size = new System.Drawing.Size(42, 35);
            this.refresh_Button.TabIndex = 21;
            this.refresh_Button.Click += new System.EventHandler(this.RePopulate_Table);
            // 
            // data_View
            // 
            this.data_View.AllowUserToAddRows = false;
            this.data_View.AllowUserToDeleteRows = false;
            this.data_View.AllowUserToResizeColumns = false;
            this.data_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.data_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.data_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_View.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(175)))));
            this.data_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(111)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.data_View.ColumnHeadersHeight = 20;
            this.data_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_View.DefaultCellStyle = dataGridViewCellStyle15;
            this.data_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_View.EnableHeadersVisualStyles = false;
            this.data_View.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(82)))));
            this.data_View.Location = new System.Drawing.Point(10, 116);
            this.data_View.Margin = new System.Windows.Forms.Padding(0);
            this.data_View.Name = "data_View";
            this.data_View.ReadOnly = true;
            this.data_View.RowHeadersVisible = false;
            this.data_View.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_View.Size = new System.Drawing.Size(714, 545);
            this.data_View.TabIndex = 29;
            this.data_View.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.data_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.data_View.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(175)))));
            this.data_View.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(82)))));
            this.data_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_View.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_View.ThemeStyle.HeaderStyle.Height = 20;
            this.data_View.ThemeStyle.ReadOnly = true;
            this.data_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.data_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_View.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.data_View.ThemeStyle.RowsStyle.Height = 22;
            this.data_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // searchbar_Panel
            // 
            this.searchbar_Panel.Controls.Add(this.searchBar1);
            this.searchbar_Panel.Controls.Add(this.refresh_Button);
            this.searchbar_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchbar_Panel.Location = new System.Drawing.Point(10, 51);
            this.searchbar_Panel.Name = "searchbar_Panel";
            this.searchbar_Panel.Size = new System.Drawing.Size(714, 65);
            this.searchbar_Panel.TabIndex = 28;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Controls.Add(this.data_View);
            this.gunaPanel1.Controls.Add(this.searchbar_Panel);
            this.gunaPanel1.Controls.Add(this.gunaLinePanel2);
            this.gunaPanel1.Controls.Add(this.tableLayoutPanel2);
            this.gunaPanel1.Controls.Add(this.category_Label);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(834, 33);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(33, 33, 33, 100);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.gunaPanel1.Size = new System.Drawing.Size(736, 733);
            this.gunaPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 661);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(714, 60);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gunaPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1603, 866);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // MiscCategoryForm
            // 
            this.AcceptButton = this.add_Category_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1603, 866);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiscCategoryForm";
            this.Text = "MiscCategoryForm";
            this.VisibleChanged += new System.EventHandler(this.RePopulate_Table);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_View)).EndInit();
            this.searchbar_Panel.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Guna.UI.WinForms.GunaLabel add_New_Label;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLineTextBox category_Name_TextBox;
        private Guna.UI.WinForms.GunaButton add_Category_Button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaComboBox sortComboBox;
        private Guna.UI.WinForms.GunaLabel category_Label;
        private Guna.UI.WinForms.GunaButton previous_Button;
        private Guna.UI.WinForms.GunaTextBox pageCountTextbox;
        private Guna.UI.WinForms.GunaButton next_Button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private UserControlUtil.SearchBar searchBar1;
        private Guna.UI.WinForms.GunaButton refresh_Button;
        private Guna.UI.WinForms.GunaDataGridView data_View;
        private System.Windows.Forms.FlowLayoutPanel searchbar_Panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}