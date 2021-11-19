
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
            this.specimenDataGrid = new System.Windows.Forms.DataGridView();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentAttributeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specimenDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.templateToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.dataSummaryToolStripMenuItem,
            this.startMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // specimenDataGrid
            // 
            this.specimenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specimenDataGrid.Location = new System.Drawing.Point(31, 59);
            this.specimenDataGrid.Name = "specimenDataGrid";
            this.specimenDataGrid.Size = new System.Drawing.Size(738, 329);
            this.specimenDataGrid.TabIndex = 1;
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Location = new System.Drawing.Point(38, 409);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(62, 13);
            this.searchByLabel.TabIndex = 2;
            this.searchByLabel.Text = "Search By: ";
            this.searchByLabel.Click += new System.EventHandler(this.searchByLabel_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(106, 407);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(582, 20);
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
            // 
            // tableMenuBindingSource
            // 
            this.tableMenuBindingSource.DataSource = typeof(Team_6_Senior_Project.TableMenu);
            // 
            // currentAttributeLabel
            // 
            this.currentAttributeLabel.AutoSize = true;
            this.currentAttributeLabel.Location = new System.Drawing.Point(146, 33);
            this.currentAttributeLabel.Name = "currentAttributeLabel";
            this.currentAttributeLabel.Size = new System.Drawing.Size(113, 13);
            this.currentAttributeLabel.TabIndex = 5;
            this.currentAttributeLabel.Text = "Current Attribute Table";
            this.currentAttributeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TableMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentAttributeLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.specimenDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableMenu";
            this.Text = "View All Table";
            this.Load += new System.EventHandler(this.TableMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specimenDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMenuBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView specimenDataGrid;
        private System.Windows.Forms.BindingSource tableMenuBindingSource;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label currentAttributeLabel;
    }
}