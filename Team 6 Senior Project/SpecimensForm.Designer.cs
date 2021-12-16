namespace Team_6_Senior_Project
{
    partial class SpecimensForm
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
            System.Windows.Forms.Label specimensIDLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label createdDateLabel;
            System.Windows.Forms.Label lastUpdatedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecimensForm));
            this.specimensBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.specimensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSCDTeam6DataSet = new Team_6_Senior_Project.CSCDTeam6DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.specimensBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.openToolStripExport = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.cmbDropDownList = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextSearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.specimensDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specimensIDTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.createdDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastUpdatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.specimensTableAdapter = new Team_6_Senior_Project.CSCDTeam6DataSetTableAdapters.SpecimensTableAdapter();
            this.tableAdapterManager = new Team_6_Senior_Project.CSCDTeam6DataSetTableAdapters.TableAdapterManager();
            this.templatesTableAdapter = new Team_6_Senior_Project.CSCDTeam6DataSetTableAdapters.TemplatesTableAdapter();
            this.templatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            specimensIDLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            createdDateLabel = new System.Windows.Forms.Label();
            lastUpdatedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.specimensBindingNavigator)).BeginInit();
            this.specimensBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specimensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSCDTeam6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specimensDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // specimensIDLabel
            // 
            specimensIDLabel.AutoSize = true;
            specimensIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specimensIDLabel.Location = new System.Drawing.Point(12, 315);
            specimensIDLabel.Name = "specimensIDLabel";
            specimensIDLabel.Size = new System.Drawing.Size(140, 25);
            specimensIDLabel.TabIndex = 2;
            specimensIDLabel.Text = "Specimens ID:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            typeLabel.Location = new System.Drawing.Point(13, 343);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(63, 25);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "Type:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weightLabel.Location = new System.Drawing.Point(12, 375);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(80, 25);
            weightLabel.TabIndex = 6;
            weightLabel.Text = "Weight:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(13, 402);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(69, 25);
            notesLabel.TabIndex = 8;
            notesLabel.Text = "Notes:";
            // 
            // createdDateLabel
            // 
            createdDateLabel.AutoSize = true;
            createdDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdDateLabel.Location = new System.Drawing.Point(12, 436);
            createdDateLabel.Name = "createdDateLabel";
            createdDateLabel.Size = new System.Drawing.Size(134, 25);
            createdDateLabel.TabIndex = 10;
            createdDateLabel.Text = "Created Date:";
            // 
            // lastUpdatedLabel
            // 
            lastUpdatedLabel.AutoSize = true;
            lastUpdatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastUpdatedLabel.Location = new System.Drawing.Point(12, 471);
            lastUpdatedLabel.Name = "lastUpdatedLabel";
            lastUpdatedLabel.Size = new System.Drawing.Size(134, 25);
            lastUpdatedLabel.TabIndex = 12;
            lastUpdatedLabel.Text = "Last Updated:";
            // 
            // specimensBindingNavigator
            // 
            this.specimensBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.specimensBindingNavigator.BindingSource = this.specimensBindingSource;
            this.specimensBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.specimensBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.specimensBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.specimensBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.specimensBindingNavigatorSaveItem,
            this.openToolStripExport,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButtonSearch,
            this.cmbDropDownList,
            this.toolStripTextSearchBox,
            this.toolStripButtonClear});
            this.specimensBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.specimensBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.specimensBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.specimensBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.specimensBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.specimensBindingNavigator.Name = "specimensBindingNavigator";
            this.specimensBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.specimensBindingNavigator.Size = new System.Drawing.Size(1233, 28);
            this.specimensBindingNavigator.TabIndex = 0;
            this.specimensBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // specimensBindingSource
            // 
            this.specimensBindingSource.DataMember = "Specimens";
            this.specimensBindingSource.DataSource = this.cSCDTeam6DataSet;
            // 
            // cSCDTeam6DataSet
            // 
            this.cSCDTeam6DataSet.DataSetName = "CSCDTeam6DataSet";
            this.cSCDTeam6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Team_6_Senior_Project.Properties.Resources.house_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // specimensBindingNavigatorSaveItem
            // 
            this.specimensBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.specimensBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("specimensBindingNavigatorSaveItem.Image")));
            this.specimensBindingNavigatorSaveItem.Name = "specimensBindingNavigatorSaveItem";
            this.specimensBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 25);
            this.specimensBindingNavigatorSaveItem.Text = "Save Data";
            this.specimensBindingNavigatorSaveItem.Click += new System.EventHandler(this.specimensBindingNavigatorSaveItem_Click);
            // 
            // openToolStripExport
            // 
            this.openToolStripExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripExport.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripExport.Image")));
            this.openToolStripExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripExport.Name = "openToolStripExport";
            this.openToolStripExport.Size = new System.Drawing.Size(29, 25);
            this.openToolStripExport.Text = "Export";
            this.openToolStripExport.Click += new System.EventHandler(this.openToolStripExport_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(57, 25);
            this.toolStripButtonSearch.Text = "Search";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // cmbDropDownList
            // 
            this.cmbDropDownList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDropDownList.Items.AddRange(new object[] {
            "SpecimensID",
            "Type",
            "Weight",
            "Notes",
            "CreatedDate",
            "LastUpdated"});
            this.cmbDropDownList.Name = "cmbDropDownList";
            this.cmbDropDownList.Size = new System.Drawing.Size(121, 28);
            this.cmbDropDownList.Text = "Type";
            // 
            // toolStripTextSearchBox
            // 
            this.toolStripTextSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextSearchBox.Name = "toolStripTextSearchBox";
            this.toolStripTextSearchBox.Size = new System.Drawing.Size(240, 28);
            this.toolStripTextSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextSearchBox_KeyPress);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(47, 25);
            this.toolStripButtonClear.Text = "Clear";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // specimensDataGridView
            // 
            this.specimensDataGridView.AllowUserToAddRows = false;
            this.specimensDataGridView.AllowUserToOrderColumns = true;
            this.specimensDataGridView.AutoGenerateColumns = false;
            this.specimensDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specimensDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.specimensDataGridView.DataSource = this.specimensBindingSource;
            this.specimensDataGridView.Location = new System.Drawing.Point(0, 31);
            this.specimensDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specimensDataGridView.Name = "specimensDataGridView";
            this.specimensDataGridView.ReadOnly = true;
            this.specimensDataGridView.RowHeadersWidth = 51;
            this.specimensDataGridView.RowTemplate.Height = 24;
            this.specimensDataGridView.Size = new System.Drawing.Size(1152, 271);
            this.specimensDataGridView.TabIndex = 1;
            this.specimensDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.specimensDataGridView_CellEnter);
            this.specimensDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.specimensDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SpecimensID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SpecimensID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn3.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn4.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LastUpdated";
            this.dataGridViewTextBoxColumn6.HeaderText = "LastUpdated";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // specimensIDTextBox
            // 
            this.specimensIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specimensBindingSource, "SpecimensID", true));
            this.specimensIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specimensIDTextBox.Location = new System.Drawing.Point(205, 306);
            this.specimensIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specimensIDTextBox.Name = "specimensIDTextBox";
            this.specimensIDTextBox.ReadOnly = true;
            this.specimensIDTextBox.Size = new System.Drawing.Size(476, 30);
            this.specimensIDTextBox.TabIndex = 3;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specimensBindingSource, "Type", true));
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(72, 338);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(29, 30);
            this.typeTextBox.TabIndex = 5;
            this.typeTextBox.Visible = false;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specimensBindingSource, "Weight", true));
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(205, 372);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(476, 30);
            this.weightTextBox.TabIndex = 7;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightTextBox_KeyPress);
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specimensBindingSource, "Notes", true));
            this.notesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(205, 401);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(476, 30);
            this.notesTextBox.TabIndex = 9;
            this.notesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notesTextBox_KeyPress);
            // 
            // createdDateDateTimePicker
            // 
            this.createdDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.specimensBindingSource, "CreatedDate", true));
            this.createdDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.createdDateDateTimePicker.Location = new System.Drawing.Point(205, 436);
            this.createdDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createdDateDateTimePicker.MaxDate = new System.DateTime(2024, 12, 15, 0, 0, 0, 0);
            this.createdDateDateTimePicker.MinDate = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.createdDateDateTimePicker.Name = "createdDateDateTimePicker";
            this.createdDateDateTimePicker.Size = new System.Drawing.Size(476, 30);
            this.createdDateDateTimePicker.TabIndex = 11;
            this.createdDateDateTimePicker.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // lastUpdatedDateTimePicker
            // 
            this.lastUpdatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.specimensBindingSource, "LastUpdated", true));
            this.lastUpdatedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastUpdatedDateTimePicker.Location = new System.Drawing.Point(205, 473);
            this.lastUpdatedDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastUpdatedDateTimePicker.MaxDate = new System.DateTime(2024, 12, 14, 0, 0, 0, 0);
            this.lastUpdatedDateTimePicker.MinDate = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            this.lastUpdatedDateTimePicker.Name = "lastUpdatedDateTimePicker";
            this.lastUpdatedDateTimePicker.Size = new System.Drawing.Size(476, 30);
            this.lastUpdatedDateTimePicker.TabIndex = 13;
            this.lastUpdatedDateTimePicker.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(17, 530);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 33);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(213, 530);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 33);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(433, 530);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 33);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbType
            // 
            this.cmbType.AutoCompleteCustomSource.AddRange(new string[] {
            "Potato",
            "Wheat"});
            this.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specimensBindingSource, "Type", true));
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(205, 338);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(476, 33);
            this.cmbType.TabIndex = 5;
            this.cmbType.SelectedValueChanged += new System.EventHandler(this.cmbType_SelectedValueChanged);
            this.cmbType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbType_KeyPress);
            // 
            // specimensTableAdapter
            // 
            this.specimensTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SpecimensTableAdapter = this.specimensTableAdapter;
            this.tableAdapterManager.TemplatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Team_6_Senior_Project.CSCDTeam6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // templatesTableAdapter
            // 
            this.templatesTableAdapter.ClearBeforeFill = true;
            // 
            // templatesBindingSource
            // 
            this.templatesBindingSource.DataMember = "Templates";
            this.templatesBindingSource.DataSource = this.cSCDTeam6DataSet;
            // 
            // SpecimensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 628);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(specimensIDLabel);
            this.Controls.Add(this.specimensIDTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(createdDateLabel);
            this.Controls.Add(this.createdDateDateTimePicker);
            this.Controls.Add(lastUpdatedLabel);
            this.Controls.Add(this.lastUpdatedDateTimePicker);
            this.Controls.Add(this.specimensDataGridView);
            this.Controls.Add(this.specimensBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SpecimensForm";
            this.Text = "SpecimensForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpecimensForm_FormClosing);
            this.Load += new System.EventHandler(this.SpecimensForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.specimensBindingNavigator)).EndInit();
            this.specimensBindingNavigator.ResumeLayout(false);
            this.specimensBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specimensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSCDTeam6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specimensDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSCDTeam6DataSet cSCDTeam6DataSet;
        private System.Windows.Forms.BindingSource specimensBindingSource;
        private CSCDTeam6DataSetTableAdapters.SpecimensTableAdapter specimensTableAdapter;
        private CSCDTeam6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator specimensBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton specimensBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView specimensDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripButton openToolStripExport;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextSearchBox;
        private System.Windows.Forms.ToolStripComboBox cmbDropDownList;
        private System.Windows.Forms.TextBox specimensIDTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.DateTimePicker createdDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker lastUpdatedDateTimePicker;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private CSCDTeam6DataSetTableAdapters.TemplatesTableAdapter templatesTableAdapter;
        private System.Windows.Forms.BindingSource templatesBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
    }
}