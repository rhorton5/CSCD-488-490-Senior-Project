namespace Team_6_Senior_Project;
partial class TemplatesForm
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
        System.Windows.Forms.Label typeLabel;
        System.Windows.Forms.Label minWeightLabel;
        System.Windows.Forms.Label maxWeightLabel;
        System.Windows.Forms.Label notesLabel;
        System.Windows.Forms.Label createdDateLabel;
        System.Windows.Forms.Label lastUpdatedLabel;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplatesForm));
        this.cSCDTeam6DataSet = new Team_6_Senior_Project.CSCDTeam6DataSet();
        this.templatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
        this.templatesTableAdapter = new Team_6_Senior_Project.CSCDTeam6DataSetTableAdapters.TemplatesTableAdapter();
        this.tableAdapterManager = new Team_6_Senior_Project.CSCDTeam6DataSetTableAdapters.TableAdapterManager();
        this.templatesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
        this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
        this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
        this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
        this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
        this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
        this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
        this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
        this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
        this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
        this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
        this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        this.templatesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
        this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
        this.cmbDropDownList = new System.Windows.Forms.ToolStripComboBox();
        this.toolStripTextSearchBox = new System.Windows.Forms.ToolStripTextBox();
        this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
        this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
        this.specimensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.goToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.templatesDataGridView = new System.Windows.Forms.DataGridView();
        this.typeTextBox = new System.Windows.Forms.TextBox();
        this.minWeightTextBox = new System.Windows.Forms.TextBox();
        this.maxWeightTextBox = new System.Windows.Forms.TextBox();
        this.notesTextBox = new System.Windows.Forms.TextBox();
        this.createdDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
        this.lastUpdatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnAdd = new System.Windows.Forms.Button();
        this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        typeLabel = new System.Windows.Forms.Label();
        minWeightLabel = new System.Windows.Forms.Label();
        maxWeightLabel = new System.Windows.Forms.Label();
        notesLabel = new System.Windows.Forms.Label();
        createdDateLabel = new System.Windows.Forms.Label();
        lastUpdatedLabel = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.cSCDTeam6DataSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.templatesBindingSource)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.templatesBindingNavigator)).BeginInit();
        this.templatesBindingNavigator.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.templatesDataGridView)).BeginInit();
        this.SuspendLayout();
        // 
        // typeLabel
        // 
        typeLabel.AutoSize = true;
        typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        typeLabel.Location = new System.Drawing.Point(7, 454);
        typeLabel.Name = "typeLabel";
        typeLabel.Size = new System.Drawing.Size(63, 25);
        typeLabel.TabIndex = 2;
        typeLabel.Text = "Type:";
        // 
        // minWeightLabel
        // 
        minWeightLabel.AutoSize = true;
        minWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        minWeightLabel.Location = new System.Drawing.Point(7, 489);
        minWeightLabel.Name = "minWeightLabel";
        minWeightLabel.Size = new System.Drawing.Size(117, 25);
        minWeightLabel.TabIndex = 4;
        minWeightLabel.Text = "Min Weight:";
        // 
        // maxWeightLabel
        // 
        maxWeightLabel.AutoSize = true;
        maxWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        maxWeightLabel.Location = new System.Drawing.Point(7, 523);
        maxWeightLabel.Name = "maxWeightLabel";
        maxWeightLabel.Size = new System.Drawing.Size(123, 25);
        maxWeightLabel.TabIndex = 6;
        maxWeightLabel.Text = "Max Weight:";
        // 
        // notesLabel
        // 
        notesLabel.AutoSize = true;
        notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        notesLabel.Location = new System.Drawing.Point(7, 558);
        notesLabel.Name = "notesLabel";
        notesLabel.Size = new System.Drawing.Size(69, 25);
        notesLabel.TabIndex = 8;
        notesLabel.Text = "Notes:";
        // 
        // createdDateLabel
        // 
        createdDateLabel.AutoSize = true;
        createdDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        createdDateLabel.Location = new System.Drawing.Point(7, 595);
        createdDateLabel.Name = "createdDateLabel";
        createdDateLabel.Size = new System.Drawing.Size(134, 25);
        createdDateLabel.TabIndex = 10;
        createdDateLabel.Text = "Created Date:";
        // 
        // lastUpdatedLabel
        // 
        lastUpdatedLabel.AutoSize = true;
        lastUpdatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lastUpdatedLabel.Location = new System.Drawing.Point(7, 631);
        lastUpdatedLabel.Name = "lastUpdatedLabel";
        lastUpdatedLabel.Size = new System.Drawing.Size(134, 25);
        lastUpdatedLabel.TabIndex = 12;
        lastUpdatedLabel.Text = "Last Updated:";
        // 
        // cSCDTeam6DataSet
        // 
        this.cSCDTeam6DataSet.DataSetName = "CSCDTeam6DataSet";
        this.cSCDTeam6DataSet.Namespace = "http://tempuri.org/CSCDTeam6DataSet.xsd";
        this.cSCDTeam6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // templatesBindingSource
        // 
        this.templatesBindingSource.DataMember = "Templates";
        this.templatesBindingSource.DataSource = this.cSCDTeam6DataSet;
        // 
        // templatesTableAdapter
        // 
        this.templatesTableAdapter.ClearBeforeFill = true;
        // 
        // tableAdapterManager
        // 
        this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
        this.tableAdapterManager.SpecimensTableAdapter = null;
        this.tableAdapterManager.TemplatesTableAdapter = this.templatesTableAdapter;
        this.tableAdapterManager.UpdateOrder = Team_6_Senior_Project.CSCDTeam6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
        // 
        // templatesBindingNavigator
        // 
        this.templatesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
        this.templatesBindingNavigator.BindingSource = this.templatesBindingSource;
        this.templatesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
        this.templatesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
        this.templatesBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.templatesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
        this.templatesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
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
            this.templatesBindingNavigatorSaveItem,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton,
            this.toolStripButtonSearch,
            this.cmbDropDownList,
            this.toolStripTextSearchBox,
            this.toolStripButtonClear,
            this.toolStripSplitButton1});
        this.templatesBindingNavigator.Location = new System.Drawing.Point(0, 0);
        this.templatesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
        this.templatesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
        this.templatesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
        this.templatesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
        this.templatesBindingNavigator.Name = "templatesBindingNavigator";
        this.templatesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
        this.templatesBindingNavigator.Size = new System.Drawing.Size(1093, 30);
        this.templatesBindingNavigator.TabIndex = 0;
        this.templatesBindingNavigator.Text = "bindingNavigator1";
        // 
        // bindingNavigatorAddNewItem
        // 
        this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
        this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
        this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
        this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 27);
        this.bindingNavigatorAddNewItem.Text = "Add new";
        this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
        // 
        // bindingNavigatorCountItem
        // 
        this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
        this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 27);
        this.bindingNavigatorCountItem.Text = "of {0}";
        this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
        // 
        // bindingNavigatorDeleteItem
        // 
        this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
        this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
        this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
        this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 27);
        this.bindingNavigatorDeleteItem.Text = "Delete";
        this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
        // 
        // toolStripButton1
        // 
        this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.toolStripButton1.Image = global::Team_6_Senior_Project.Properties.Resources.house_icon;
        this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.toolStripButton1.Name = "toolStripButton1";
        this.toolStripButton1.Size = new System.Drawing.Size(29, 27);
        this.toolStripButton1.Text = "homeButton";
        this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
        // 
        // bindingNavigatorMoveFirstItem
        // 
        this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
        this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
        this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
        this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 27);
        this.bindingNavigatorMoveFirstItem.Text = "Move first";
        // 
        // bindingNavigatorMovePreviousItem
        // 
        this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
        this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
        this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
        this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 27);
        this.bindingNavigatorMovePreviousItem.Text = "Move previous";
        // 
        // bindingNavigatorSeparator
        // 
        this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
        this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
        // 
        // bindingNavigatorPositionItem
        // 
        this.bindingNavigatorPositionItem.AccessibleName = "Position";
        this.bindingNavigatorPositionItem.AutoSize = false;
        this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
        this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
        this.bindingNavigatorPositionItem.Text = "0";
        this.bindingNavigatorPositionItem.ToolTipText = "Current position";
        // 
        // bindingNavigatorSeparator1
        // 
        this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
        this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
        // 
        // bindingNavigatorMoveNextItem
        // 
        this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
        this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
        this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
        this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 27);
        this.bindingNavigatorMoveNextItem.Text = "Move next";
        // 
        // bindingNavigatorMoveLastItem
        // 
        this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
        this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
        this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
        this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 27);
        this.bindingNavigatorMoveLastItem.Text = "Move last";
        // 
        // bindingNavigatorSeparator2
        // 
        this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
        this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
        // 
        // templatesBindingNavigatorSaveItem
        // 
        this.templatesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.templatesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("templatesBindingNavigatorSaveItem.Image")));
        this.templatesBindingNavigatorSaveItem.Name = "templatesBindingNavigatorSaveItem";
        this.templatesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 27);
        this.templatesBindingNavigatorSaveItem.Text = "Save Data";
        this.templatesBindingNavigatorSaveItem.Click += new System.EventHandler(this.TemplatesBindingNavigatorSaveItem_Click);
        // 
        // openToolStripButton
        // 
        this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
        this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.openToolStripButton.Name = "openToolStripButton";
        this.openToolStripButton.Size = new System.Drawing.Size(29, 27);
        this.openToolStripButton.Text = "&Open";
        this.openToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
        // 
        // saveToolStripButton
        // 
        this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
        this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.saveToolStripButton.Name = "saveToolStripButton";
        this.saveToolStripButton.Size = new System.Drawing.Size(29, 27);
        this.saveToolStripButton.Text = "&Save";
        // 
        // toolStripSeparator
        // 
        this.toolStripSeparator.Name = "toolStripSeparator";
        this.toolStripSeparator.Size = new System.Drawing.Size(6, 30);
        // 
        // copyToolStripButton
        // 
        this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
        this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.copyToolStripButton.Name = "copyToolStripButton";
        this.copyToolStripButton.Size = new System.Drawing.Size(29, 27);
        this.copyToolStripButton.Text = "&Copy";
        // 
        // pasteToolStripButton
        // 
        this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
        this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.pasteToolStripButton.Name = "pasteToolStripButton";
        this.pasteToolStripButton.Size = new System.Drawing.Size(29, 27);
        this.pasteToolStripButton.Text = "&Paste";
        // 
        // toolStripSeparator1
        // 
        this.toolStripSeparator1.Name = "toolStripSeparator1";
        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
        // 
        // helpToolStripButton
        // 
        this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
        this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.helpToolStripButton.Name = "helpToolStripButton";
        this.helpToolStripButton.Size = new System.Drawing.Size(29, 27);
        this.helpToolStripButton.Text = "He&lp";
        // 
        // toolStripButtonSearch
        // 
        this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
        this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.toolStripButtonSearch.Name = "toolStripButtonSearch";
        this.toolStripButtonSearch.Size = new System.Drawing.Size(65, 27);
        this.toolStripButtonSearch.Text = "Search";
        this.toolStripButtonSearch.Click += new System.EventHandler(this.ToolStripButtonSearch_Click);
        // 
        // cmbDropDownList
        // 
        this.cmbDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
        this.cmbDropDownList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        this.cmbDropDownList.Items.AddRange(new object[] {
            "Type",
            "MinWeight",
            "MaxWeight",
            "Notes",
            "CreatedDate",
            "LastUpdated"});
        this.cmbDropDownList.Name = "cmbDropDownList";
        this.cmbDropDownList.Size = new System.Drawing.Size(121, 30);
        this.cmbDropDownList.Text = "Type";
        // 
        // toolStripTextSearchBox
        // 
        this.toolStripTextSearchBox.Name = "toolStripTextSearchBox";
        this.toolStripTextSearchBox.Size = new System.Drawing.Size(240, 30);
        this.toolStripTextSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolStripTextSearchBox_KeyPress);
        // 
        // toolStripButtonClear
        // 
        this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
        this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.toolStripButtonClear.Name = "toolStripButtonClear";
        this.toolStripButtonClear.Size = new System.Drawing.Size(53, 27);
        this.toolStripButtonClear.Text = "Clear";
        this.toolStripButtonClear.Click += new System.EventHandler(this.ToolStripButtonClear_Click);
        // 
        // toolStripSplitButton1
        // 
        this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specimensToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.goToMainMenuToolStripMenuItem});
        this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
        this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.toolStripSplitButton1.Name = "toolStripSplitButton1";
        this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 27);
        this.toolStripSplitButton1.Text = "Go To New Window";
        // 
        // specimensToolStripMenuItem
        // 
        this.specimensToolStripMenuItem.Name = "specimensToolStripMenuItem";
        this.specimensToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
        this.specimensToolStripMenuItem.Text = "Go To Specimens";
        this.specimensToolStripMenuItem.Click += new System.EventHandler(this.SpecimensToolStripMenuItem_Click);
        // 
        // summaryToolStripMenuItem
        // 
        this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
        this.summaryToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
        this.summaryToolStripMenuItem.Text = "Go To Summary";
        this.summaryToolStripMenuItem.Click += new System.EventHandler(this.SummaryToolStripMenuItem_Click);
        // 
        // goToMainMenuToolStripMenuItem
        // 
        this.goToMainMenuToolStripMenuItem.Name = "goToMainMenuToolStripMenuItem";
        this.goToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
        this.goToMainMenuToolStripMenuItem.Text = "Go To Main Menu";
        this.goToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.GoToMainMenuToolStripMenuItem_Click);
        // 
        // templatesDataGridView
        // 
        this.templatesDataGridView.AllowUserToAddRows = false;
        this.templatesDataGridView.AllowUserToOrderColumns = true;
        this.templatesDataGridView.AutoGenerateColumns = false;
        this.templatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.templatesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
        this.templatesDataGridView.DataSource = this.templatesBindingSource;
        this.templatesDataGridView.Location = new System.Drawing.Point(0, 37);
        this.templatesDataGridView.Name = "templatesDataGridView";
        this.templatesDataGridView.ReadOnly = true;
        this.templatesDataGridView.RowHeadersWidth = 51;
        this.templatesDataGridView.RowTemplate.Height = 24;
        this.templatesDataGridView.Size = new System.Drawing.Size(1077, 397);
        this.templatesDataGridView.TabIndex = 1;
        this.templatesDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TemplatesDataGridView_CellEnter);
        this.templatesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TemplatesDataGridView_DataError);
        this.templatesDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.TemplatesDataGridView_UserDeletingRow);
        // 
        // typeTextBox
        // 
        this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.templatesBindingSource, "Type", true));
        this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.typeTextBox.Location = new System.Drawing.Point(164, 454);
        this.typeTextBox.Name = "typeTextBox";
        this.typeTextBox.Size = new System.Drawing.Size(359, 30);
        this.typeTextBox.TabIndex = 3;
        this.typeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeTextBox_KeyPress);
        // 
        // minWeightTextBox
        // 
        this.minWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.templatesBindingSource, "MinWeight", true));
        this.minWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.minWeightTextBox.Location = new System.Drawing.Point(164, 489);
        this.minWeightTextBox.Name = "minWeightTextBox";
        this.minWeightTextBox.Size = new System.Drawing.Size(359, 30);
        this.minWeightTextBox.TabIndex = 5;
        this.minWeightTextBox.TextChanged += new System.EventHandler(this.MinWeightTextBox_TextChanged);
        this.minWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinWeightTextBox_KeyPress);
        // 
        // maxWeightTextBox
        // 
        this.maxWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.templatesBindingSource, "MaxWeight", true));
        this.maxWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.maxWeightTextBox.Location = new System.Drawing.Point(164, 523);
        this.maxWeightTextBox.Name = "maxWeightTextBox";
        this.maxWeightTextBox.Size = new System.Drawing.Size(359, 30);
        this.maxWeightTextBox.TabIndex = 7;
        this.maxWeightTextBox.TextChanged += new System.EventHandler(this.MaxWeightTextBox_TextChanged);
        this.maxWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxWeightTextBox_KeyPress);
        // 
        // notesTextBox
        // 
        this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.templatesBindingSource, "Notes", true));
        this.notesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.notesTextBox.Location = new System.Drawing.Point(164, 558);
        this.notesTextBox.Name = "notesTextBox";
        this.notesTextBox.Size = new System.Drawing.Size(359, 30);
        this.notesTextBox.TabIndex = 9;
        this.notesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotesTextBox_KeyPress);
        // 
        // createdDateDateTimePicker
        // 
        this.createdDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.templatesBindingSource, "CreatedDate", true));
        this.createdDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.createdDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.createdDateDateTimePicker.Location = new System.Drawing.Point(164, 594);
        this.createdDateDateTimePicker.Name = "createdDateDateTimePicker";
        this.createdDateDateTimePicker.Size = new System.Drawing.Size(359, 30);
        this.createdDateDateTimePicker.TabIndex = 11;
        // 
        // lastUpdatedDateTimePicker
        // 
        this.lastUpdatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.templatesBindingSource, "LastUpdated", true));
        this.lastUpdatedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lastUpdatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.lastUpdatedDateTimePicker.Location = new System.Drawing.Point(164, 629);
        this.lastUpdatedDateTimePicker.Name = "lastUpdatedDateTimePicker";
        this.lastUpdatedDateTimePicker.Size = new System.Drawing.Size(359, 30);
        this.lastUpdatedDateTimePicker.TabIndex = 13;
        // 
        // btnSave
        // 
        this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnSave.Location = new System.Drawing.Point(425, 693);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(120, 42);
        this.btnSave.TabIndex = 19;
        this.btnSave.Text = "Save";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
        // 
        // btnDelete
        // 
        this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnDelete.Location = new System.Drawing.Point(205, 693);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(120, 42);
        this.btnDelete.TabIndex = 18;
        this.btnDelete.Text = "Delete";
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
        // 
        // btnAdd
        // 
        this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnAdd.Location = new System.Drawing.Point(9, 693);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(120, 42);
        this.btnAdd.TabIndex = 17;
        this.btnAdd.Text = "Add New";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
        // 
        // dataGridViewTextBoxColumn1
        // 
        this.dataGridViewTextBoxColumn1.DataPropertyName = "Type";
        this.dataGridViewTextBoxColumn1.HeaderText = "Type";
        this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn1.ReadOnly = true;
        this.dataGridViewTextBoxColumn1.Width = 125;
        // 
        // dataGridViewTextBoxColumn2
        // 
        this.dataGridViewTextBoxColumn2.DataPropertyName = "MinWeight";
        this.dataGridViewTextBoxColumn2.HeaderText = "MinWeight";
        this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        this.dataGridViewTextBoxColumn2.ReadOnly = true;
        this.dataGridViewTextBoxColumn2.Width = 125;
        // 
        // dataGridViewTextBoxColumn3
        // 
        this.dataGridViewTextBoxColumn3.DataPropertyName = "MaxWeight";
        this.dataGridViewTextBoxColumn3.HeaderText = "MaxWeight";
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
        this.dataGridViewTextBoxColumn4.Width = 200;
        // 
        // dataGridViewTextBoxColumn5
        // 
        this.dataGridViewTextBoxColumn5.DataPropertyName = "CreatedDate";
        this.dataGridViewTextBoxColumn5.HeaderText = "CreatedDate";
        this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        this.dataGridViewTextBoxColumn5.ReadOnly = true;
        this.dataGridViewTextBoxColumn5.Width = 200;
        // 
        // dataGridViewTextBoxColumn6
        // 
        this.dataGridViewTextBoxColumn6.DataPropertyName = "LastUpdated";
        this.dataGridViewTextBoxColumn6.HeaderText = "LastUpdated";
        this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        this.dataGridViewTextBoxColumn6.ReadOnly = true;
        this.dataGridViewTextBoxColumn6.Width = 200;
        // 
        // TemplatesForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1093, 764);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(typeLabel);
        this.Controls.Add(this.typeTextBox);
        this.Controls.Add(minWeightLabel);
        this.Controls.Add(this.minWeightTextBox);
        this.Controls.Add(maxWeightLabel);
        this.Controls.Add(this.maxWeightTextBox);
        this.Controls.Add(notesLabel);
        this.Controls.Add(this.notesTextBox);
        this.Controls.Add(createdDateLabel);
        this.Controls.Add(this.createdDateDateTimePicker);
        this.Controls.Add(lastUpdatedLabel);
        this.Controls.Add(this.lastUpdatedDateTimePicker);
        this.Controls.Add(this.templatesDataGridView);
        this.Controls.Add(this.templatesBindingNavigator);
        this.Name = "TemplatesForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "TemplatesForm";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TemplatesForm_FormClosing);
        this.Load += new System.EventHandler(this.TemplatesForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.cSCDTeam6DataSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.templatesBindingSource)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.templatesBindingNavigator)).EndInit();
        this.templatesBindingNavigator.ResumeLayout(false);
        this.templatesBindingNavigator.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.templatesDataGridView)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private CSCDTeam6DataSet cSCDTeam6DataSet;
    private System.Windows.Forms.BindingSource templatesBindingSource;
    private CSCDTeam6DataSetTableAdapters.TemplatesTableAdapter templatesTableAdapter;
    private CSCDTeam6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator templatesBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton templatesBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView templatesDataGridView;
    private System.Windows.Forms.ToolStripButton openToolStripButton;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripButton copyToolStripButton;
    private System.Windows.Forms.ToolStripButton pasteToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton helpToolStripButton;
    private System.Windows.Forms.TextBox typeTextBox;
    private System.Windows.Forms.TextBox minWeightTextBox;
    private System.Windows.Forms.TextBox maxWeightTextBox;
    private System.Windows.Forms.TextBox notesTextBox;
    private System.Windows.Forms.DateTimePicker createdDateDateTimePicker;
    private System.Windows.Forms.DateTimePicker lastUpdatedDateTimePicker;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.ToolStripButton toolStripButtonClear;
    private System.Windows.Forms.ToolStripTextBox toolStripTextSearchBox;
    private System.Windows.Forms.ToolStripComboBox cmbDropDownList;
    private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    private System.Windows.Forms.ToolStripMenuItem specimensToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem goToMainMenuToolStripMenuItem;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
}