namespace Team_6_Senior_Project
{
    partial class TableMenu
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
        private void InitializeComponent(string fileName)
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTemplateLabel = new System.Windows.Forms.Label();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.attributeComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.templatesToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.dataSummaryToolStripMenuItem,
            this.startMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddMenu_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveMenu_Click);
            // 
            // templatesToolStripMenuItem
            // 
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            this.templatesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.templatesToolStripMenuItem.Text = "Templates";
            this.templatesToolStripMenuItem.Click += new System.EventHandler(this.TemplatesMenu_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportMenu_Click);
            // 
            // dataSummaryToolStripMenuItem
            // 
            this.dataSummaryToolStripMenuItem.Name = "dataSummaryToolStripMenuItem";
            this.dataSummaryToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.dataSummaryToolStripMenuItem.Text = "Data Summary";
            this.dataSummaryToolStripMenuItem.Click += new System.EventHandler(this.DataSummaryMenu_Click);
            // 
            // startMenuToolStripMenuItem
            // 
            this.startMenuToolStripMenuItem.Name = "startMenuToolStripMenuItem";
            this.startMenuToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.startMenuToolStripMenuItem.Text = "Start Menu";
            this.startMenuToolStripMenuItem.Click += new System.EventHandler(this.StartMenu_Click);
            // 
            // currentTemplateLabel
            // 
            this.currentTemplateLabel.AutoSize = true;
            this.currentTemplateLabel.Location = new System.Drawing.Point(242, 58);
            this.currentTemplateLabel.Name = "currentTemplateLabel";
            this.currentTemplateLabel.Size = new System.Drawing.Size(119, 13);
            this.currentTemplateLabel.TabIndex = 1;
            this.currentTemplateLabel.Text = "Current Template Name";
            this.currentTemplateLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Location = new System.Drawing.Point(52, 536);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(62, 13);
            this.searchByLabel.TabIndex = 2;
            this.searchByLabel.Text = "Search By: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCol,
            this.entryDateCol,
            this.idNumCol,
            this.weightCol,
            this.notesCol});
            this.dataGridView1.Location = new System.Drawing.Point(55, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 423);
            this.dataGridView1.TabIndex = 3;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            // 
            // entryDateCol
            // 
            this.entryDateCol.HeaderText = "Entry Date";
            this.entryDateCol.Name = "entryDateCol";
            // 
            // idNumCol
            // 
            this.idNumCol.HeaderText = "ID#";
            this.idNumCol.Name = "idNumCol";
            // 
            // weightCol
            // 
            this.weightCol.HeaderText = "Weight";
            this.weightCol.Name = "weightCol";
            // 
            // notesCol
            // 
            this.notesCol.HeaderText = "Notes";
            this.notesCol.Name = "notesCol";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(524, 527);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(236, 529);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(282, 20);
            this.searchTextBox.TabIndex = 5;
            // 
            // attributeComboBox
            // 
            this.attributeComboBox.FormattingEnabled = true;
            this.attributeComboBox.Location = new System.Drawing.Point(109, 527);
            this.attributeComboBox.Name = "attributeComboBox";
            this.attributeComboBox.Size = new System.Drawing.Size(121, 21);
            this.attributeComboBox.TabIndex = 6;
            // 
            // TableMenu
            // 
            this.ClientSize = new System.Drawing.Size(772, 573);
            this.Controls.Add(this.attributeComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.currentTemplateLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startMenuToolStripMenuItem;
        private System.Windows.Forms.Label currentTemplateLabel;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesCol;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox attributeComboBox;
    }
}
#endregion