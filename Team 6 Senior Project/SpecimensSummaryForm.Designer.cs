namespace Team_6_Senior_Project;
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
            startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            startDateLabel.Location = new System.Drawing.Point(31, 632);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(105, 25);
            startDateLabel.TabIndex = 17;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            endDateLabel.Location = new System.Drawing.Point(31, 688);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(99, 25);
            endDateLabel.TabIndex = 19;
            endDateLabel.Text = "End Date:";
            // 
            // dataGridViewSpecimensSummary
            // 
            this.dataGridViewSpecimensSummary.AllowUserToAddRows = false;
            this.dataGridViewSpecimensSummary.AllowUserToDeleteRows = false;
            this.dataGridViewSpecimensSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecimensSummary.Location = new System.Drawing.Point(15, 46);
            this.dataGridViewSpecimensSummary.Name = "dataGridViewSpecimensSummary";
            this.dataGridViewSpecimensSummary.ReadOnly = true;
            this.dataGridViewSpecimensSummary.RowHeadersWidth = 51;
            this.dataGridViewSpecimensSummary.RowTemplate.Height = 24;
            this.dataGridViewSpecimensSummary.Size = new System.Drawing.Size(1021, 486);
            this.dataGridViewSpecimensSummary.TabIndex = 0;
            this.dataGridViewSpecimensSummary.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridViewSpecimensSummary_DataError);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchDate.Location = new System.Drawing.Point(27, 752);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(200, 43);
            this.btnSearchDate.TabIndex = 4;
            this.btnSearchDate.Text = "Seach With Date Range";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.BtnSearchDate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(25, 557);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(203, 43);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search/Refresh";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(233, 632);
            this.startDateDateTimePicker.MaxDate = new System.DateTime(2024, 12, 15, 0, 0, 0, 0);
            this.startDateDateTimePicker.MinDate = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(381, 30);
            this.startDateDateTimePicker.TabIndex = 2;
            this.startDateDateTimePicker.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTimePicker.Location = new System.Drawing.Point(233, 688);
            this.EndDateTimePicker.MaxDate = new System.DateTime(2024, 12, 14, 0, 0, 0, 0);
            this.EndDateTimePicker.MinDate = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(381, 30);
            this.EndDateTimePicker.TabIndex = 3;
            this.EndDateTimePicker.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuDatabseToolStripMenuItem,
            this.specimensToolStripMenuItem,
            this.templatesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1110, 30);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuDatabseToolStripMenuItem
            // 
            this.mainMenuDatabseToolStripMenuItem.Name = "mainMenuDatabseToolStripMenuItem";
            this.mainMenuDatabseToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.mainMenuDatabseToolStripMenuItem.Text = "Main Menu";
            this.mainMenuDatabseToolStripMenuItem.Click += new System.EventHandler(this.MainMenuDatabseToolStripMenuItem_Click);
            // 
            // specimensToolStripMenuItem
            // 
            this.specimensToolStripMenuItem.Name = "specimensToolStripMenuItem";
            this.specimensToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.specimensToolStripMenuItem.Text = "Specimens";
            this.specimensToolStripMenuItem.Click += new System.EventHandler(this.SpecimenDatabseToolStripMenuItem_Click);
            // 
            // templatesToolStripMenuItem1
            // 
            this.templatesToolStripMenuItem1.Name = "templatesToolStripMenuItem1";
            this.templatesToolStripMenuItem1.Size = new System.Drawing.Size(91, 24);
            this.templatesToolStripMenuItem1.Text = "Templates";
            this.templatesToolStripMenuItem1.Click += new System.EventHandler(this.TemplatesToolStripMenuItem1_Click);
            // 
            // SpecimensSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1110, 825);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.dataGridViewSpecimensSummary);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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