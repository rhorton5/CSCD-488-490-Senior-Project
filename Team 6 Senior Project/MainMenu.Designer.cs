using System;

namespace Team_6_Senior_Project
{
    partial class MainMenu
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
            this.openExistingButton = new System.Windows.Forms.Button();
            this.createNewTableButton = new System.Windows.Forms.Button();
            this.setDefaultTableButton = new System.Windows.Forms.Button();
            this.btnSpecimens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openExistingButton
            // 
            this.openExistingButton.Location = new System.Drawing.Point(67, 34);
            this.openExistingButton.Margin = new System.Windows.Forms.Padding(4);
            this.openExistingButton.Name = "openExistingButton";
            this.openExistingButton.Size = new System.Drawing.Size(513, 70);
            this.openExistingButton.TabIndex = 0;
            this.openExistingButton.Text = "Open Existing";
            this.openExistingButton.UseVisualStyleBackColor = true;
            this.openExistingButton.Click += new System.EventHandler(this.openExistingButton_Click);
            // 
            // createNewTableButton
            // 
            this.createNewTableButton.Location = new System.Drawing.Point(67, 129);
            this.createNewTableButton.Margin = new System.Windows.Forms.Padding(4);
            this.createNewTableButton.Name = "createNewTableButton";
            this.createNewTableButton.Size = new System.Drawing.Size(513, 70);
            this.createNewTableButton.TabIndex = 1;
            this.createNewTableButton.Text = "Create New";
            this.createNewTableButton.UseVisualStyleBackColor = true;
            this.createNewTableButton.Click += new System.EventHandler(this.createNewTableButton_Click);
            // 
            // setDefaultTableButton
            // 
            this.setDefaultTableButton.Location = new System.Drawing.Point(67, 224);
            this.setDefaultTableButton.Margin = new System.Windows.Forms.Padding(4);
            this.setDefaultTableButton.Name = "setDefaultTableButton";
            this.setDefaultTableButton.Size = new System.Drawing.Size(513, 70);
            this.setDefaultTableButton.TabIndex = 2;
            this.setDefaultTableButton.Text = "Set Default";
            this.setDefaultTableButton.UseVisualStyleBackColor = true;
            this.setDefaultTableButton.Click += new System.EventHandler(this.setDefaultTableButton_Click);
            // 
            // btnSpecimens
            // 
            this.btnSpecimens.Location = new System.Drawing.Point(67, 374);
            this.btnSpecimens.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpecimens.Name = "btnSpecimens";
            this.btnSpecimens.Size = new System.Drawing.Size(513, 70);
            this.btnSpecimens.TabIndex = 3;
            this.btnSpecimens.Text = "Specimens";
            this.btnSpecimens.UseVisualStyleBackColor = true;
            this.btnSpecimens.Click += new System.EventHandler(this.btnSpecimens_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 495);
            this.Controls.Add(this.btnSpecimens);
            this.Controls.Add(this.setDefaultTableButton);
            this.Controls.Add(this.createNewTableButton);
            this.Controls.Add(this.openExistingButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "CSCD 488/490 Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openExistingButton;
        private System.Windows.Forms.Button createNewTableButton;
        private System.Windows.Forms.Button setDefaultTableButton;
        private System.Windows.Forms.Button btnSpecimens;
    }
}

