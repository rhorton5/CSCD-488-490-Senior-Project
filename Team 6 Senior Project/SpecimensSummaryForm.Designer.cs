namespace Team_6_Senior_Project
{
    partial class SpecimensSummaryForm
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
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            this.dataGridViewSpecimensSummary = new System.Windows.Forms.DataGridView();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuDatabseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specimensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecimensSummary)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startDateLabel.Location = new System.Drawing.Point(23, 411);
            startDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(87, 20);
            startDateLabel.TabIndex = 17;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endDateLabel.Location = new System.Drawing.Point(23, 447);
            endDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(81, 20);
            endDateLabel.TabIndex = 19;
            endDateLabel.Text = "End Date:";
            // 
            // dataGridViewSpecimensSummary
            // 
            this.dataGridViewSpecimensSummary.AllowUserToAddRows = false;
            this.dataGridViewSpecimensSummary.AllowUserToDeleteRows = false;
            this.dataGridViewSpecimensSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecimensSummary.Location = new System.Drawing.Point(11, 30);
            this.dataGridViewSpecimensSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSpecimensSummary.Name = "dataGridViewSpecimensSummary";
            this.dataGridViewSpecimensSummary.ReadOnly = true;
            this.dataGridViewSpecimensSummary.RowHeadersWidth = 51;
            this.dataGridViewSpecimensSummary.RowTemplate.Height = 24;
            this.dataGridViewSpecimensSummary.Size = new System.Drawing.Size(994, 316);
            this.dataGridViewSpecimensSummary.TabIndex = 0;
            this.dataGridViewSpecimensSummary.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewSpecimensSummary_DataError);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.Location = new System.Drawing.Point(20, 489);
            this.btnSearchDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(150, 28);
            this.btnSearchDate.TabIndex = 22;
            this.btnSearchDate.Text = "Seach With Date Range";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(19, 362);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 28);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search/Refresh";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(175, 411);
            this.startDateDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDateDateTimePicker.MaxDate = new System.DateTime(2024, 12, 15, 0, 0, 0, 0);
            this.startDateDateTimePicker.MinDate = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(287, 26);
            this.startDateDateTimePicker.TabIndex = 18;
            this.startDateDateTimePicker.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTimePicker.Location = new System.Drawing.Point(175, 447);
            this.EndDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EndDateTimePicker.MaxDate = new System.DateTime(2024, 12, 14, 0, 0, 0, 0);
            this.EndDateTimePicker.MinDate = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(287, 26);
            this.EndDateTimePicker.TabIndex = 20;
            this.EndDateTimePicker.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuDatabseToolStripMenuItem,
            this.specimensToolStripMenuItem,
            this.templatesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuDatabseToolStripMenuItem
            // 
            this.mainMenuDatabseToolStripMenuItem.Name = "mainMenuDatabseToolStripMenuItem";
            this.mainMenuDatabseToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mainMenuDatabseToolStripMenuItem.Text = "Main Menu";
            this.mainMenuDatabseToolStripMenuItem.Click += new System.EventHandler(this.mainMenuDatabseToolStripMenuItem_Click);
            // 
            // specimensToolStripMenuItem
            // 
            this.specimensToolStripMenuItem.Name = "specimensToolStripMenuItem";
            this.specimensToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.specimensToolStripMenuItem.Text = "Specimens";
            this.specimensToolStripMenuItem.Click += new System.EventHandler(this.specimenDatabseToolStripMenuItem_Click);
            // 
            // templatesToolStripMenuItem1
            // 
            this.templatesToolStripMenuItem1.Name = "templatesToolStripMenuItem1";
            this.templatesToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.templatesToolStripMenuItem1.Text = "Templates";
            this.templatesToolStripMenuItem1.Click += new System.EventHandler(this.templatesToolStripMenuItem1_Click);
            // 
            // SpecimensSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1029, 622);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.dataGridViewSpecimensSummary);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SpecimensSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SpecimensSummaryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpecimensSummaryForm_FormClosing);
            this.Load += new System.EventHandler(this.SpecimensSummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecimensSummary)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSpecimensSummary;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuDatabseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specimensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem1;
    }
}