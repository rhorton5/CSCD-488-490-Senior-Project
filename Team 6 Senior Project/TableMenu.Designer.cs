
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSCDTeam6DataSet = new Team_6_Senior_Project.CSCDTeam6DataSet();
            this.cscdTeam6DataSet1 = new Team_6_Senior_Project.CSCDTeam6DataSet();
            this.specimensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specimensTableAdapter = new Team_6_Senior_Project.CSCDTeam6DataSetTableAdapters.SpecimensTableAdapter();
            this.SpecimensDataGridView = new System.Windows.Forms.DataGridView();
            this.specimensIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specimensBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSCDTeam6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cscdTeam6DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specimensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecimensDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specimensBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.templateToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.dataSummaryToolStripMenuItem,
            this.startMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // templateToolStripMenuItem
            // 
            this.templateToolStripMenuItem.Name = "templateToolStripMenuItem";
            this.templateToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.templateToolStripMenuItem.Text = "Template";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // dataSummaryToolStripMenuItem
            // 
            this.dataSummaryToolStripMenuItem.Name = "dataSummaryToolStripMenuItem";
            this.dataSummaryToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.dataSummaryToolStripMenuItem.Text = "Data Summary";
            // 
            // startMenuToolStripMenuItem
            // 
            this.startMenuToolStripMenuItem.Name = "startMenuToolStripMenuItem";
            this.startMenuToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.startMenuToolStripMenuItem.Text = "Start Menu";
            this.startMenuToolStripMenuItem.Click += new System.EventHandler(this.startMenuToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Location = new System.Drawing.Point(38, 409);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(62, 13);
            this.searchByLabel.TabIndex = 2;
            this.searchByLabel.Text = "Search By: ";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(221, 407);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(467, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(694, 404);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tableMenuBindingSource
            // 
            this.tableMenuBindingSource.DataSource = this.cSCDTeam6DataSet;
            this.tableMenuBindingSource.Position = 0;
            // 
            // cSCDTeam6DataSet
            // 
            this.cSCDTeam6DataSet.DataSetName = "CSCDTeam6DataSet";
            this.cSCDTeam6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cscdTeam6DataSet1
            // 
            this.cscdTeam6DataSet1.DataSetName = "CSCDTeam6DataSet";
            this.cscdTeam6DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specimensBindingSource
            // 
            this.specimensBindingSource.DataMember = "Specimens";
            this.specimensBindingSource.DataSource = this.cSCDTeam6DataSet;
            // 
            // specimensTableAdapter
            // 
            this.specimensTableAdapter.ClearBeforeFill = true;
            // 
            // SpecimensDataGridView
            // 
            this.SpecimensDataGridView.AllowUserToOrderColumns = true;
            this.SpecimensDataGridView.AutoGenerateColumns = false;
            this.SpecimensDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SpecimensDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecimensDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specimensIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn});
            this.SpecimensDataGridView.DataSource = this.specimensBindingSource1;
            this.SpecimensDataGridView.Location = new System.Drawing.Point(18, 38);
            this.SpecimensDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SpecimensDataGridView.Name = "SpecimensDataGridView";
            this.SpecimensDataGridView.RowHeadersWidth = 51;
            this.SpecimensDataGridView.RowTemplate.Height = 24;
            this.SpecimensDataGridView.Size = new System.Drawing.Size(817, 285);
            this.SpecimensDataGridView.TabIndex = 5;
            this.SpecimensDataGridView.DataSourceChanged += new System.EventHandler(this.SpecimensDataGridView_DataSourceChanged);
            this.SpecimensDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.SpecimensDataGridView_RowLeave);
            // 
            // specimensIDDataGridViewTextBoxColumn
            // 
            this.specimensIDDataGridViewTextBoxColumn.DataPropertyName = "SpecimensID";
            this.specimensIDDataGridViewTextBoxColumn.HeaderText = "SpecimensID";
            this.specimensIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specimensIDDataGridViewTextBoxColumn.Name = "specimensIDDataGridViewTextBoxColumn";
            this.specimensIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            this.lastUpdatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specimensBindingSource1
            // 
            this.specimensBindingSource1.DataMember = "Specimens";
            this.specimensBindingSource1.DataSource = this.tableMenuBindingSource;
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(94, 406);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchComboBox.TabIndex = 6;
            // 
            // TableMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.SpecimensDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableMenu";
            this.Text = "View All Table";
            this.Load += new System.EventHandler(this.TableMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSCDTeam6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cscdTeam6DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specimensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecimensDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specimensBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startMenuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource tableMenuBindingSource;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private CSCDTeam6DataSet cSCDTeam6DataSet;
        private CSCDTeam6DataSet cscdTeam6DataSet1;
        private System.Windows.Forms.BindingSource specimensBindingSource;
        private CSCDTeam6DataSetTableAdapters.SpecimensTableAdapter specimensTableAdapter;
        private System.Windows.Forms.DataGridView SpecimensDataGridView;
        private System.Windows.Forms.BindingSource specimensBindingSource1;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn specimensIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
    }
}