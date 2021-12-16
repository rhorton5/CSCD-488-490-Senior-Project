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
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecimensSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startDateLabel.Location = new System.Drawing.Point(26, 479);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(105, 25);
            startDateLabel.TabIndex = 17;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endDateLabel.Location = new System.Drawing.Point(26, 523);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(132, 25);
            endDateLabel.TabIndex = 19;
            endDateLabel.Text = "End Updated:";
            // 
            // dataGridViewSpecimensSummary
            // 
            this.dataGridViewSpecimensSummary.AllowUserToAddRows = false;
            this.dataGridViewSpecimensSummary.AllowUserToDeleteRows = false;
            this.dataGridViewSpecimensSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecimensSummary.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewSpecimensSummary.Name = "dataGridViewSpecimensSummary";
            this.dataGridViewSpecimensSummary.ReadOnly = true;
            this.dataGridViewSpecimensSummary.RowHeadersWidth = 51;
            this.dataGridViewSpecimensSummary.RowTemplate.Height = 24;
            this.dataGridViewSpecimensSummary.Size = new System.Drawing.Size(1326, 389);
            this.dataGridViewSpecimensSummary.TabIndex = 0;
            this.dataGridViewSpecimensSummary.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewSpecimensSummary_DataError);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.Location = new System.Drawing.Point(23, 575);
            this.btnSearchDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(200, 35);
            this.btnSearchDate.TabIndex = 22;
            this.btnSearchDate.Text = "Seach With Date Range";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(21, 419);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(202, 34);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search/Refresh";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(229, 479);
            this.startDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDateDateTimePicker.MaxDate = new System.DateTime(2024, 12, 15, 0, 0, 0, 0);
            this.startDateDateTimePicker.MinDate = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(381, 30);
            this.startDateDateTimePicker.TabIndex = 18;
            this.startDateDateTimePicker.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTimePicker.Location = new System.Drawing.Point(229, 523);
            this.EndDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndDateTimePicker.MaxDate = new System.DateTime(2024, 12, 14, 0, 0, 0, 0);
            this.EndDateTimePicker.MinDate = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(381, 30);
            this.EndDateTimePicker.TabIndex = 20;
            this.EndDateTimePicker.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // SpecimensSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1372, 766);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.dataGridViewSpecimensSummary);
            this.Name = "SpecimensSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SpecimensSummaryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpecimensSummaryForm_FormClosing);
            this.Load += new System.EventHandler(this.SpecimensSummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecimensSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSpecimensSummary;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
    }
}