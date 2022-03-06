namespace Team_6_Senior_Project
{
    partial class OpenExistingOptionsMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.existingFileTextBox = new System.Windows.Forms.TextBox();
            this.browseExistingButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backupFileTextBox = new System.Windows.Forms.TextBox();
            this.backupFileButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSV File To Be Imported";
            // 
            // existingFileTextBox
            // 
            this.existingFileTextBox.Location = new System.Drawing.Point(11, 32);
            this.existingFileTextBox.Name = "existingFileTextBox";
            this.existingFileTextBox.Size = new System.Drawing.Size(609, 23);
            this.existingFileTextBox.TabIndex = 1;
            this.existingFileTextBox.TextChanged += new System.EventHandler(this.existingFileTextBox_TextChanged);
            // 
            // browseExistingButton
            // 
            this.browseExistingButton.Location = new System.Drawing.Point(626, 32);
            this.browseExistingButton.Name = "browseExistingButton";
            this.browseExistingButton.Size = new System.Drawing.Size(97, 23);
            this.browseExistingButton.TabIndex = 2;
            this.browseExistingButton.Text = "Browse";
            this.browseExistingButton.UseVisualStyleBackColor = true;
            this.browseExistingButton.Click += new System.EventHandler(this.browseExistingButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Backup CSV File Location (Optional)";
            // 
            // backupFileTextBox
            // 
            this.backupFileTextBox.Location = new System.Drawing.Point(11, 104);
            this.backupFileTextBox.Name = "backupFileTextBox";
            this.backupFileTextBox.Size = new System.Drawing.Size(609, 23);
            this.backupFileTextBox.TabIndex = 4;
            // 
            // backupFileButton
            // 
            this.backupFileButton.Location = new System.Drawing.Point(626, 104);
            this.backupFileButton.Name = "backupFileButton";
            this.backupFileButton.Size = new System.Drawing.Size(97, 23);
            this.backupFileButton.TabIndex = 5;
            this.backupFileButton.Text = "Browse Save";
            this.backupFileButton.UseVisualStyleBackColor = true;
            this.backupFileButton.Click += new System.EventHandler(this.backupFileButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(626, 149);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(97, 23);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // OpenExistingOptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 249);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.backupFileButton);
            this.Controls.Add(this.backupFileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseExistingButton);
            this.Controls.Add(this.existingFileTextBox);
            this.Controls.Add(this.label1);
            this.Name = "OpenExistingOptionsMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox existingFileTextBox;
        private Button browseExistingButton;
        private Label label2;
        private TextBox backupFileTextBox;
        private Button backupFileButton;
        private Button confirmButton;
    }
}