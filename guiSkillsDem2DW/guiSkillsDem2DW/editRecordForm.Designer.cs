namespace guiSkillsDem2DW
{
    partial class editRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editRecordForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeSystemDataGrid = new System.Windows.Forms.DataGridView();
            this.studentIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.marksText = new System.Windows.Forms.TextBox();
            this.gradesText = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.marksLabel = new System.Windows.Forms.Label();
            this.gradesLabel = new System.Windows.Forms.Label();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeSystemDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeFormToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.fileIcon;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // gradeSystemDataGrid
            // 
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
            this.gradeSystemDataGrid.Location = new System.Drawing.Point(513, 58);
            this.gradeSystemDataGrid.Name = "gradeSystemDataGrid";
            this.gradeSystemDataGrid.RowTemplate.Height = 24;
            this.gradeSystemDataGrid.Size = new System.Drawing.Size(681, 590);
            this.gradeSystemDataGrid.TabIndex = 2;
            // 
            // studentIDColumn
            // 
            this.studentIDColumn.HeaderText = "Student ID";
            this.studentIDColumn.Name = "studentIDColumn";
            this.studentIDColumn.ReadOnly = true;
            this.studentIDColumn.ToolTipText = "List of Student\'s IDs";
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.HeaderText = "First Name";
            this.firstNameColumn.Name = "firstNameColumn";
            this.firstNameColumn.ReadOnly = true;
            this.firstNameColumn.ToolTipText = "Column containing Students\' first names";
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Surname";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.ReadOnly = true;
            this.surnameColumn.ToolTipText = "Column containing Students\' surnames";
            // 
            // subjectColumn
            // 
            this.subjectColumn.HeaderText = "Subject";
            this.subjectColumn.Name = "subjectColumn";
            this.subjectColumn.ReadOnly = true;
            this.subjectColumn.ToolTipText = "Column containing the list of subjects Students take";
            // 
            // marksColumn
            // 
            this.marksColumn.HeaderText = "Marks";
            this.marksColumn.Name = "marksColumn";
            this.marksColumn.ReadOnly = true;
            this.marksColumn.ToolTipText = "Column containing Students\' marks";
            // 
            // gradesColumn
            // 
            this.gradesColumn.HeaderText = "Grades";
            this.gradesColumn.Name = "gradesColumn";
            this.gradesColumn.ReadOnly = true;
            this.gradesColumn.ToolTipText = "Column containing Students\' grades";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(197, 84);
            this.firstNameText.Multiline = true;
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(273, 37);
            this.firstNameText.TabIndex = 5;
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(197, 166);
            this.surnameText.Multiline = true;
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(273, 37);
            this.surnameText.TabIndex = 6;
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(197, 249);
            this.subjectText.Multiline = true;
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(273, 37);
            this.subjectText.TabIndex = 7;
            // 
            // marksText
            // 
            this.marksText.Location = new System.Drawing.Point(197, 330);
            this.marksText.Multiline = true;
            this.marksText.Name = "marksText";
            this.marksText.Size = new System.Drawing.Size(273, 37);
            this.marksText.TabIndex = 8;
            // 
            // gradesText
            // 
            this.gradesText.Location = new System.Drawing.Point(197, 410);
            this.gradesText.Multiline = true;
            this.gradesText.Name = "gradesText";
            this.gradesText.Size = new System.Drawing.Size(273, 37);
            this.gradesText.TabIndex = 9;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateButton.FlatAppearance.BorderSize = 2;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(12, 531);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(171, 56);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.toolTip1.SetToolTip(this.updateButton, "Updates record in database");
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(326, 531);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(171, 56);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.toolTip1.SetToolTip(this.cancelButton, "Cancels edit record process and closes current form");
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(7, 84);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.firstNameLabel.TabIndex = 12;
            this.firstNameLabel.Text = "First Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabel.Location = new System.Drawing.Point(7, 162);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(92, 25);
            this.surnameLabel.TabIndex = 13;
            this.surnameLabel.Text = "Surname";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(7, 249);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(78, 25);
            this.subjectLabel.TabIndex = 14;
            this.subjectLabel.Text = "Subject";
            // 
            // marksLabel
            // 
            this.marksLabel.AutoSize = true;
            this.marksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksLabel.Location = new System.Drawing.Point(7, 330);
            this.marksLabel.Name = "marksLabel";
            this.marksLabel.Size = new System.Drawing.Size(66, 25);
            this.marksLabel.TabIndex = 15;
            this.marksLabel.Text = "Marks";
            // 
            // gradesLabel
            // 
            this.gradesLabel.AutoSize = true;
            this.gradesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradesLabel.Location = new System.Drawing.Point(7, 410);
            this.gradesLabel.Name = "gradesLabel";
            this.gradesLabel.Size = new System.Drawing.Size(76, 25);
            this.gradesLabel.TabIndex = 16;
            this.gradesLabel.Text = "Grades";
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Image = global::guiSkillsDem2DW.Properties.Resources.closeIcon;
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.closeFormToolStripMenuItem.Text = "Close Form";
            this.closeFormToolStripMenuItem.ToolTipText = "Closes current form";
            // 
            // editRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 660);
            this.Controls.Add(this.gradesLabel);
            this.Controls.Add(this.marksLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.gradesText);
            this.Controls.Add(this.marksText);
            this.Controls.Add(this.subjectText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.gradeSystemDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "editRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Student Record";
            this.Load += new System.EventHandler(this.editRecordForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeSystemDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.DataGridView gradeSystemDataGrid;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.TextBox marksText;
        private System.Windows.Forms.TextBox gradesText;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label marksLabel;
        private System.Windows.Forms.Label gradesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradesColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}