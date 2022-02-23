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
            this.openSaveLocationButton = new System.Windows.Forms.Button();
            this.exportFileLabel = new System.Windows.Forms.Label();
            this.mergeCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backupDatabaseButton
            // 
            this.backupDatabaseButton.AutoSize = true;
            this.backupDatabaseButton.Location = new System.Drawing.Point(12, 146);
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
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(623, 36);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(130, 23);
            this.openFolderButton.TabIndex = 2;
            this.openFolderButton.Text = "Open Folder";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // importFolderLabel
            // 
            this.importFolderLabel.AutoSize = true;
            this.importFolderLabel.Location = new System.Drawing.Point(12, 19);
            this.importFolderLabel.Name = "importFolderLabel";
            this.importFolderLabel.Size = new System.Drawing.Size(112, 15);
            this.importFolderLabel.TabIndex = 3;
            this.importFolderLabel.Text = "Imported File Name";
            // 
            // saveFolderTextBox
            // 
            this.saveFolderTextBox.Enabled = false;
            this.saveFolderTextBox.Location = new System.Drawing.Point(12, 88);
            this.saveFolderTextBox.Name = "saveFolderTextBox";
            this.saveFolderTextBox.Size = new System.Drawing.Size(604, 23);
            this.saveFolderTextBox.TabIndex = 4;
            // 
            // openSaveLocationButton
            // 
            this.openSaveLocationButton.Enabled = false;
            this.openSaveLocationButton.Location = new System.Drawing.Point(623, 88);
            this.openSaveLocationButton.Name = "openSaveLocationButton";
            this.openSaveLocationButton.Size = new System.Drawing.Size(130, 23);
            this.openSaveLocationButton.TabIndex = 5;
            this.openSaveLocationButton.Text = "Open Save Location";
            this.openSaveLocationButton.UseVisualStyleBackColor = true;
            this.openSaveLocationButton.Click += new System.EventHandler(this.openSaveLocationButton_Click);
            // 
            // exportFileLabel
            // 
            this.exportFileLabel.AutoSize = true;
            this.exportFileLabel.Location = new System.Drawing.Point(12, 70);
            this.exportFileLabel.Name = "exportFileLabel";
            this.exportFileLabel.Size = new System.Drawing.Size(110, 15);
            this.exportFileLabel.TabIndex = 6;
            this.exportFileLabel.Text = "Exported File Name";
            // 
            // mergeCheckBox
            // 
            this.mergeCheckBox.AutoSize = true;
            this.mergeCheckBox.Location = new System.Drawing.Point(193, 146);
            this.mergeCheckBox.Name = "mergeCheckBox";
            this.mergeCheckBox.Size = new System.Drawing.Size(221, 19);
            this.mergeCheckBox.TabIndex = 7;
            this.mergeCheckBox.Text = "Merge The Imported File To Database";
            this.mergeCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(12, 128);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(49, 15);
            this.optionsLabel.TabIndex = 8;
            this.optionsLabel.Text = "Options";
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(623, 146);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(704, 146);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OpenExistingOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 186);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.mergeCheckBox);
            this.Controls.Add(this.exportFileLabel);
            this.Controls.Add(this.openSaveLocationButton);
            this.Controls.Add(this.saveFolderTextBox);
            this.Controls.Add(this.importFolderLabel);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.folderNameTextBox);
            this.Controls.Add(this.backupDatabaseButton);
            this.Name = "OpenExistingOptionsForm";
            this.Text = "Select Your Options For Your File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox backupDatabaseButton;
        private TextBox folderNameTextBox;
        private Button openFolderButton;
        private Label importFolderLabel;
        private TextBox saveFolderTextBox;
        private Button openSaveLocationButton;
        private Label exportFileLabel;
        private CheckBox mergeCheckBox;
        private Label optionsLabel;
        private Button confirmButton;
        private Button cancelButton;
    }
}