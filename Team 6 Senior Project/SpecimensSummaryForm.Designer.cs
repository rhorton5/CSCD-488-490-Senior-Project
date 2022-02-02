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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecimensSummaryForm));
            this.dataGridViewSpecimensSummary = new System.Windows.Forms.DataGridView();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.homeButton = new System.Windows.Forms.ToolStripButton();
            this.exportStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.goToSpecimenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecimensSummary)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            startDateLabel.Location = new System.Drawing.Point(27, 474);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(87, 20);
            startDateLabel.TabIndex = 17;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            endDateLabel.Location = new System.Drawing.Point(27, 516);
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
            this.dataGridViewSpecimensSummary.Location = new System.Drawing.Point(13, 34);
            this.dataGridViewSpecimensSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSpecimensSummary.Name = "dataGridViewSpecimensSummary";
            this.dataGridViewSpecimensSummary.ReadOnly = true;
            this.dataGridViewSpecimensSummary.RowHeadersWidth = 51;
            this.dataGridViewSpecimensSummary.RowTemplate.Height = 24;
            this.dataGridViewSpecimensSummary.Size = new System.Drawing.Size(893, 364);
            this.dataGridViewSpecimensSummary.TabIndex = 0;
            this.dataGridViewSpecimensSummary.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridViewSpecimensSummary_DataError);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchDate.Location = new System.Drawing.Point(24, 564);
            this.btnSearchDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(175, 32);
            this.btnSearchDate.TabIndex = 4;
            this.btnSearchDate.Text = "Seach With Date Range";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.BtnSearchDate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(22, 418);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search/Refresh";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(204, 474);
            this.startDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDateDateTimePicker.MaxDate = new System.DateTime(2024, 12, 15, 0, 0, 0, 0);
            this.startDateDateTimePicker.MinDate = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(334, 26);
            this.startDateDateTimePicker.TabIndex = 2;
            this.startDateDateTimePicker.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTimePicker.Location = new System.Drawing.Point(204, 516);
            this.EndDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndDateTimePicker.MaxDate = new System.DateTime(2024, 12, 14, 0, 0, 0, 0);
            this.EndDateTimePicker.MinDate = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(334, 26);
            this.EndDateTimePicker.TabIndex = 3;
            this.EndDateTimePicker.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeButton,
            this.exportStripButton,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(971, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // homeButton
            // 
            this.homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeButton.Image = global::Team_6_Senior_Project.Properties.Resources.house_icon;
            this.homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(23, 22);
            this.homeButton.Text = "Go To Main Menu";
            this.homeButton.Click += new System.EventHandler(this.MainMenuDatabseToolStripMenuItem_Click);
            // 
            // exportStripButton
            // 
            this.exportStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exportStripButton.Image")));
            this.exportStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportStripButton.Name = "exportStripButton";
            this.exportStripButton.Size = new System.Drawing.Size(23, 22);
            this.exportStripButton.Text = "Export to CSV";
            this.exportStripButton.Click += new System.EventHandler(this.exportStripButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToSpecimenToolStripMenuItem,
            this.goToTemplateToolStripMenuItem,
            this.goToMainMenuToolStripMenuItem});
            this.toolStripButton2.Image = global::Team_6_Senior_Project.Properties.Resources.Arrow;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // goToSpecimenToolStripMenuItem
            // 
            this.goToSpecimenToolStripMenuItem.Name = "goToSpecimenToolStripMenuItem";
            this.goToSpecimenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToSpecimenToolStripMenuItem.Text = "Go To Specimen";
            this.goToSpecimenToolStripMenuItem.Click += new System.EventHandler(this.SpecimenDatabseToolStripMenuItem_Click);
            // 
            // goToTemplateToolStripMenuItem
            // 
            this.goToTemplateToolStripMenuItem.Name = "goToTemplateToolStripMenuItem";
            this.goToTemplateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToTemplateToolStripMenuItem.Text = "Go To Template";
            this.goToTemplateToolStripMenuItem.Click += new System.EventHandler(this.TemplatesToolStripMenuItem1_Click);
            // 
            // goToMainMenuToolStripMenuItem
            // 
            this.goToMainMenuToolStripMenuItem.Name = "goToMainMenuToolStripMenuItem";
            this.goToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToMainMenuToolStripMenuItem.Text = "Go To Main Menu";
            this.goToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuDatabseToolStripMenuItem_Click);
            // 
            // SpecimensSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(971, 619);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.dataGridViewSpecimensSummary);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SpecimensSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SpecimensSummaryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpecimensSummaryForm_FormClosing);
            this.Load += new System.EventHandler(this.SpecimensSummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecimensSummary)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewSpecimensSummary;
    private System.Windows.Forms.Button btnSearchDate;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
    private System.Windows.Forms.DateTimePicker EndDateTimePicker;
    private ToolStrip toolStrip1;
    private ToolStripButton homeButton;
    private ToolStripButton exportStripButton;
    private ToolStripSplitButton toolStripButton2;
    private ToolStripMenuItem goToSpecimenToolStripMenuItem;
    private ToolStripMenuItem goToTemplateToolStripMenuItem;
    private ToolStripMenuItem goToMainMenuToolStripMenuItem;
}