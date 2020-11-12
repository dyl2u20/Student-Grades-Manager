namespace guiSkillsDem2DW
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.gradeSystemDataGrid = new System.Windows.Forms.DataGridView();
            this.studentIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recordNameLabel = new System.Windows.Forms.Label();
            this.recordCount = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.lastRecordButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.firstRecordButton = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedStudentRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gradeSystemDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradeSystemDataGrid
            // 
            this.gradeSystemDataGrid.AllowUserToAddRows = false;
            this.gradeSystemDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradeSystemDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gradeSystemDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gradeSystemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeSystemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDColumn,
            this.firstNameColumn,
            this.surnameColumn,
            this.subjectColumn,
            this.marksColumn,
            this.gradesColumn});
            this.gradeSystemDataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.gradeSystemDataGrid.Location = new System.Drawing.Point(0, 90);
            this.gradeSystemDataGrid.MultiSelect = false;
            this.gradeSystemDataGrid.Name = "gradeSystemDataGrid";
            this.gradeSystemDataGrid.ReadOnly = true;
            this.gradeSystemDataGrid.RowTemplate.Height = 24;
            this.gradeSystemDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gradeSystemDataGrid.Size = new System.Drawing.Size(980, 598);
            this.gradeSystemDataGrid.TabIndex = 2;
            this.gradeSystemDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeSystemDataGrid_CellClick);
            this.gradeSystemDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeSystemDataGrid_CellContentClick);
            this.gradeSystemDataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gradeSystemDataGrid_ColumnHeaderMouseClick);
            this.gradeSystemDataGrid.SelectionChanged += new System.EventHandler(this.gradeSystemDataGrid_SelectionChanged);
            // 
            // studentIDColumn
            // 
            this.studentIDColumn.HeaderText = "Student ID";
            this.studentIDColumn.Name = "studentIDColumn";
            this.studentIDColumn.ReadOnly = true;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.HeaderText = "First Name";
            this.firstNameColumn.Name = "firstNameColumn";
            this.firstNameColumn.ReadOnly = true;
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Surname";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.ReadOnly = true;
            // 
            // subjectColumn
            // 
            this.subjectColumn.HeaderText = "Subject";
            this.subjectColumn.Name = "subjectColumn";
            this.subjectColumn.ReadOnly = true;
            // 
            // marksColumn
            // 
            this.marksColumn.HeaderText = "Marks";
            this.marksColumn.Name = "marksColumn";
            this.marksColumn.ReadOnly = true;
            // 
            // gradesColumn
            // 
            this.gradesColumn.HeaderText = "Grades";
            this.gradesColumn.Name = "gradesColumn";
            this.gradesColumn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recordNameLabel
            // 
            this.recordNameLabel.AutoSize = true;
            this.recordNameLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordNameLabel.Location = new System.Drawing.Point(11, 57);
            this.recordNameLabel.Name = "recordNameLabel";
            this.recordNameLabel.Size = new System.Drawing.Size(96, 27);
            this.recordNameLabel.TabIndex = 4;
            this.recordNameLabel.Text = "Record:";
            // 
            // recordCount
            // 
            this.recordCount.AutoSize = true;
            this.recordCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.recordCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recordCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordCount.Location = new System.Drawing.Point(199, 56);
            this.recordCount.Name = "recordCount";
            this.recordCount.Size = new System.Drawing.Size(63, 25);
            this.recordCount.TabIndex = 7;
            this.recordCount.Text = "0 of 0";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(663, 49);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(305, 35);
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::guiSkillsDem2DW.Properties.Resources.searchIcon;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(602, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(55, 35);
            this.searchButton.TabIndex = 11;
            this.toolTip1.SetToolTip(this.searchButton, "Searches database ");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lastRecordButton
            // 
            this.lastRecordButton.BackColor = System.Drawing.SystemColors.Control;
            this.lastRecordButton.BackgroundImage = global::guiSkillsDem2DW.Properties.Resources.lastRecordIcon;
            this.lastRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lastRecordButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.lastRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastRecordButton.Location = new System.Drawing.Point(333, 56);
            this.lastRecordButton.Name = "lastRecordButton";
            this.lastRecordButton.Size = new System.Drawing.Size(37, 28);
            this.lastRecordButton.TabIndex = 9;
            this.toolTip1.SetToolTip(this.lastRecordButton, "Goes to last record");
            this.lastRecordButton.UseVisualStyleBackColor = false;
            this.lastRecordButton.Click += new System.EventHandler(this.lastRecordButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.SystemColors.Control;
            this.forwardButton.BackgroundImage = global::guiSkillsDem2DW.Properties.Resources.forwardButtonIcon;
            this.forwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forwardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Location = new System.Drawing.Point(290, 56);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(37, 28);
            this.forwardButton.TabIndex = 8;
            this.toolTip1.SetToolTip(this.forwardButton, "Goes to next record");
            this.forwardButton.UseVisualStyleBackColor = false;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.BackgroundImage = global::guiSkillsDem2DW.Properties.Resources.backButtonIcon;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(156, 56);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(37, 28);
            this.backButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.backButton, "Goes to previous record");
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // firstRecordButton
            // 
            this.firstRecordButton.BackColor = System.Drawing.SystemColors.Control;
            this.firstRecordButton.BackgroundImage = global::guiSkillsDem2DW.Properties.Resources.firstRecordIcon;
            this.firstRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstRecordButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.firstRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstRecordButton.Location = new System.Drawing.Point(113, 56);
            this.firstRecordButton.Name = "firstRecordButton";
            this.firstRecordButton.Size = new System.Drawing.Size(37, 28);
            this.firstRecordButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.firstRecordButton, "Goes to first record");
            this.firstRecordButton.UseVisualStyleBackColor = false;
            this.firstRecordButton.Click += new System.EventHandler(this.firstRecordButton_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeApplicationToolStripMenuItem,
            this.openDatabaseToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.fileIcon;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.ToolTipText = "File Menu";
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.closeIcon;
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.closeApplicationToolStripMenuItem.Text = "Close application";
            this.closeApplicationToolStripMenuItem.ToolTipText = "Closes Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.openFileIcon;
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.openDatabaseToolStripMenuItem.Text = "Open Database";
            this.openDatabaseToolStripMenuItem.ToolTipText = "Opens Database";
            this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.openDatabaseToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.editStudentDetailsToolStripMenuItem,
            this.deleteSelectedStudentRecordToolStripMenuItem});
            this.editToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.editIcon;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.ToolTipText = "Opens edit menu";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.inserttIconn;
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.insertToolStripMenuItem.Text = "Insert new Student record";
            this.insertToolStripMenuItem.ToolTipText = "Opens insert record form";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // editStudentDetailsToolStripMenuItem
            // 
            this.editStudentDetailsToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.editIcon;
            this.editStudentDetailsToolStripMenuItem.Name = "editStudentDetailsToolStripMenuItem";
            this.editStudentDetailsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.editStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.editStudentDetailsToolStripMenuItem.Text = "Edit Student details";
            this.editStudentDetailsToolStripMenuItem.ToolTipText = "Opens edit details form";
            this.editStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.editStudentDetailsToolStripMenuItem_Click);
            // 
            // deleteSelectedStudentRecordToolStripMenuItem
            // 
            this.deleteSelectedStudentRecordToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.deleteIcon;
            this.deleteSelectedStudentRecordToolStripMenuItem.Name = "deleteSelectedStudentRecordToolStripMenuItem";
            this.deleteSelectedStudentRecordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.deleteSelectedStudentRecordToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.deleteSelectedStudentRecordToolStripMenuItem.Text = "Delete selected Student record";
            this.deleteSelectedStudentRecordToolStripMenuItem.ToolTipText = "Deletes selected record";
            this.deleteSelectedStudentRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedStudentRecordToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshDatabaseToolStripMenuItem,
            this.ascendingOrderToolStripMenuItem,
            this.descendingOrderToolStripMenuItem,
            this.goToolStripMenuItem});
            this.viewToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.findIcon1;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.ToolTipText = "Opens view menu";
            // 
            // refreshDatabaseToolStripMenuItem
            // 
            this.refreshDatabaseToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.refreshIcon;
            this.refreshDatabaseToolStripMenuItem.Name = "refreshDatabaseToolStripMenuItem";
            this.refreshDatabaseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshDatabaseToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.refreshDatabaseToolStripMenuItem.Text = "Refresh Database";
            this.refreshDatabaseToolStripMenuItem.ToolTipText = "Refreshes database";
            this.refreshDatabaseToolStripMenuItem.Click += new System.EventHandler(this.refreshDatabaseToolStripMenuItem_Click);
            // 
            // ascendingOrderToolStripMenuItem
            // 
            this.ascendingOrderToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.ascendingOrderIcon;
            this.ascendingOrderToolStripMenuItem.Name = "ascendingOrderToolStripMenuItem";
            this.ascendingOrderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.ascendingOrderToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.ascendingOrderToolStripMenuItem.Text = "Ascending Order";
            this.ascendingOrderToolStripMenuItem.ToolTipText = "Lists records in ascending order";
            this.ascendingOrderToolStripMenuItem.Click += new System.EventHandler(this.ascendingOrderToolStripMenuItem_Click);
            // 
            // descendingOrderToolStripMenuItem
            // 
            this.descendingOrderToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.descendingOrderIcon;
            this.descendingOrderToolStripMenuItem.Name = "descendingOrderToolStripMenuItem";
            this.descendingOrderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.descendingOrderToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.descendingOrderToolStripMenuItem.Text = "Descending Order";
            this.descendingOrderToolStripMenuItem.ToolTipText = "Lists records in descending order";
            this.descendingOrderToolStripMenuItem.Click += new System.EventHandler(this.descendingOrderToolStripMenuItem_Click);
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstRecordToolStripMenuItem,
            this.previousRecordToolStripMenuItem,
            this.nextRecordToolStripMenuItem,
            this.lastRecordToolStripMenuItem});
            this.goToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.goToIcon;
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.goToolStripMenuItem.Text = "Go To";
            this.goToolStripMenuItem.ToolTipText = "Displays go to record options";
            // 
            // firstRecordToolStripMenuItem
            // 
            this.firstRecordToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.firstRecordIcon;
            this.firstRecordToolStripMenuItem.Name = "firstRecordToolStripMenuItem";
            this.firstRecordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.firstRecordToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.firstRecordToolStripMenuItem.Text = "First Record";
            this.firstRecordToolStripMenuItem.ToolTipText = "Goes to first record";
            this.firstRecordToolStripMenuItem.Click += new System.EventHandler(this.firstRecordToolStripMenuItem_Click);
            // 
            // previousRecordToolStripMenuItem
            // 
            this.previousRecordToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.backButtonIcon;
            this.previousRecordToolStripMenuItem.Name = "previousRecordToolStripMenuItem";
            this.previousRecordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.previousRecordToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.previousRecordToolStripMenuItem.Text = "Previous Record";
            this.previousRecordToolStripMenuItem.ToolTipText = "Goes to previous record";
            this.previousRecordToolStripMenuItem.Click += new System.EventHandler(this.previousRecordToolStripMenuItem_Click);
            // 
            // nextRecordToolStripMenuItem
            // 
            this.nextRecordToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.forwardButtonIcon;
            this.nextRecordToolStripMenuItem.Name = "nextRecordToolStripMenuItem";
            this.nextRecordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.nextRecordToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.nextRecordToolStripMenuItem.Text = "Next Record";
            this.nextRecordToolStripMenuItem.ToolTipText = "Goes to next record";
            this.nextRecordToolStripMenuItem.Click += new System.EventHandler(this.nextRecordToolStripMenuItem_Click);
            // 
            // lastRecordToolStripMenuItem
            // 
            this.lastRecordToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.lastRecordIcon;
            this.lastRecordToolStripMenuItem.Name = "lastRecordToolStripMenuItem";
            this.lastRecordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.lastRecordToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.lastRecordToolStripMenuItem.Text = "Last Record";
            this.lastRecordToolStripMenuItem.ToolTipText = "Goes to last record";
            this.lastRecordToolStripMenuItem.Click += new System.EventHandler(this.lastRecordToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 685);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.lastRecordButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.recordCount);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.firstRecordButton);
            this.Controls.Add(this.recordNameLabel);
            this.Controls.Add(this.gradeSystemDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Grades System";
            ((System.ComponentModel.ISupportInitialize)(this.gradeSystemDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gradeSystemDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradesColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label recordNameLabel;
        private System.Windows.Forms.Button firstRecordButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label recordCount;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button lastRecordButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedStudentRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastRecordToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

