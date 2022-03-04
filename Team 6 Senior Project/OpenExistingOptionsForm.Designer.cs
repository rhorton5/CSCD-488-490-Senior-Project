namespace Team_6_Senior_Project
{
    partial class OpenExistingOptionsForm
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
            this.backupDatabaseButton = new System.Windows.Forms.CheckBox();
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.importFolderLabel = new System.Windows.Forms.Label();
            this.saveFolderTextBox = new System.Windows.Forms.TextBox();
            this.browseSaveLocationButton = new System.Windows.Forms.Button();
            this.exportFileLabel = new System.Windows.Forms.Label();
            this.mergeCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backupDatabaseButton
            // 
            this.backupDatabaseButton.AutoSize = true;
            this.backupDatabaseButton.Location = new System.Drawing.Point(90, 147);
            this.backupDatabaseButton.Name = "backupDatabaseButton";
            this.backupDatabaseButton.Size = new System.Drawing.Size(175, 19);
            this.backupDatabaseButton.TabIndex = 0;
            this.backupDatabaseButton.Text = "Backup Database to CSV File";
            this.backupDatabaseButton.UseVisualStyleBackColor = true;
            this.backupDatabaseButton.CheckedChanged += new System.EventHandler(this.backupDatabaseButton_CheckedChanged);
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(12, 37);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(604, 23);
            this.folderNameTextBox.TabIndex = 1;
            this.folderNameTextBox.TextChanged += new System.EventHandler(this.folderNameTextBox_TextChanged);
            // 
            // openFolderButton
            // 
            this.openFolderButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.openFolderButton.Location = new System.Drawing.Point(623, 36);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(96, 23);
            this.openFolderButton.TabIndex = 2;
            this.openFolderButton.Text = "Browse";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // importFolderLabel
            // 
            this.importFolderLabel.AutoSize = true;
            this.importFolderLabel.Location = new System.Drawing.Point(12, 19);
            this.importFolderLabel.Name = "importFolderLabel";
            this.importFolderLabel.Size = new System.Drawing.Size(128, 15);
            this.importFolderLabel.TabIndex = 3;
            this.importFolderLabel.Text = "Existing CSV File Name";
            // 
            // saveFolderTextBox
            // 
            this.saveFolderTextBox.Enabled = false;
            this.saveFolderTextBox.Location = new System.Drawing.Point(12, 114);
            this.saveFolderTextBox.Name = "saveFolderTextBox";
            this.saveFolderTextBox.Size = new System.Drawing.Size(604, 23);
            this.saveFolderTextBox.TabIndex = 4;
            // 
            // browseSaveLocationButton
            // 
            this.browseSaveLocationButton.Enabled = false;
            this.browseSaveLocationButton.Location = new System.Drawing.Point(623, 113);
            this.browseSaveLocationButton.Name = "browseSaveLocationButton";
            this.browseSaveLocationButton.Size = new System.Drawing.Size(96, 23);
            this.browseSaveLocationButton.TabIndex = 5;
            this.browseSaveLocationButton.Text = "Browse Backup";
            this.browseSaveLocationButton.UseVisualStyleBackColor = true;
            this.browseSaveLocationButton.Click += new System.EventHandler(this.openSaveLocationButton_Click);
            // 
            // exportFileLabel
            // 
            this.exportFileLabel.AutoSize = true;
            this.exportFileLabel.Location = new System.Drawing.Point(12, 96);
            this.exportFileLabel.Name = "exportFileLabel";
            this.exportFileLabel.Size = new System.Drawing.Size(183, 15);
            this.exportFileLabel.TabIndex = 6;
            this.exportFileLabel.Text = "Backup CSV File Name (Optional)";
            // 
            // mergeCheckBox
            // 
            this.mergeCheckBox.AutoSize = true;
            this.mergeCheckBox.Location = new System.Drawing.Point(90, 66);
            this.mergeCheckBox.Name = "mergeCheckBox";
            this.mergeCheckBox.Size = new System.Drawing.Size(221, 19);
            this.mergeCheckBox.TabIndex = 7;
            this.mergeCheckBox.Text = "Merge The Imported File To Database";
            this.mergeCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(12, 66);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(49, 15);
            this.optionsLabel.TabIndex = 8;
            this.optionsLabel.Text = "Options";
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(623, 147);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(96, 23);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(725, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Options";
            // 
            // OpenExistingOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.mergeCheckBox);
            this.Controls.Add(this.exportFileLabel);
            this.Controls.Add(this.browseSaveLocationButton);
            this.Controls.Add(this.saveFolderTextBox);
            this.Controls.Add(this.importFolderLabel);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.folderNameTextBox);
            this.Controls.Add(this.backupDatabaseButton);
            this.Name = "OpenExistingOptionsForm";
            this.Text = "Open Existing File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox backupDatabaseButton;
        private TextBox folderNameTextBox;
        private Button openFolderButton;
        private Label importFolderLabel;
        private TextBox saveFolderTextBox;
        private Button browseSaveLocationButton;
        private Label exportFileLabel;
        private CheckBox mergeCheckBox;
        private Label optionsLabel;
        private Button confirmButton;
        private Button cancelButton;
        private Label label1;
    }
}