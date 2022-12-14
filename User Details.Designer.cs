namespace ProjectManagement
{
    partial class User_Details
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
            System.Windows.Forms.Label eXPERT_TYPELabel;
            System.Windows.Forms.Label eXPERT_NAMELabel;
            System.Windows.Forms.Label eXPERT_SURNAMELabel;
            System.Windows.Forms.Label eXPERT_LASTNAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Details));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.eXPERT_TYPETextBox = new System.Windows.Forms.TextBox();
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.eXPERT_NAMETextBox = new System.Windows.Forms.TextBox();
            this.eXPERT_SURNAMETextBox = new System.Windows.Forms.TextBox();
            this.eXPERT_LASTNAMETextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.projectListGrid = new System.Windows.Forms.DataGridView();
            this.pROJECTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTBEGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editProjectStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            this.eXPERTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eXPERTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.expertsTableAdapter1 = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter();
            eXPERT_TYPELabel = new System.Windows.Forms.Label();
            eXPERT_NAMELabel = new System.Windows.Forms.Label();
            eXPERT_SURNAMELabel = new System.Windows.Forms.Label();
            eXPERT_LASTNAMELabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingNavigator)).BeginInit();
            this.eXPERTSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // eXPERT_TYPELabel
            // 
            eXPERT_TYPELabel.AutoSize = true;
            eXPERT_TYPELabel.Location = new System.Drawing.Point(49, 86);
            eXPERT_TYPELabel.Name = "eXPERT_TYPELabel";
            eXPERT_TYPELabel.Size = new System.Drawing.Size(31, 13);
            eXPERT_TYPELabel.TabIndex = 2;
            eXPERT_TYPELabel.Text = "Type";
            // 
            // eXPERT_NAMELabel
            // 
            eXPERT_NAMELabel.AutoSize = true;
            eXPERT_NAMELabel.Location = new System.Drawing.Point(49, 28);
            eXPERT_NAMELabel.Name = "eXPERT_NAMELabel";
            eXPERT_NAMELabel.Size = new System.Drawing.Size(52, 13);
            eXPERT_NAMELabel.TabIndex = 4;
            eXPERT_NAMELabel.Text = "Firstname";
            // 
            // eXPERT_SURNAMELabel
            // 
            eXPERT_SURNAMELabel.AutoSize = true;
            eXPERT_SURNAMELabel.Location = new System.Drawing.Point(190, 28);
            eXPERT_SURNAMELabel.Name = "eXPERT_SURNAMELabel";
            eXPERT_SURNAMELabel.Size = new System.Drawing.Size(64, 13);
            eXPERT_SURNAMELabel.TabIndex = 6;
            eXPERT_SURNAMELabel.Text = "Middlename";
            // 
            // eXPERT_LASTNAMELabel
            // 
            eXPERT_LASTNAMELabel.AutoSize = true;
            eXPERT_LASTNAMELabel.Location = new System.Drawing.Point(330, 28);
            eXPERT_LASTNAMELabel.Name = "eXPERT_LASTNAMELabel";
            eXPERT_LASTNAMELabel.Size = new System.Drawing.Size(53, 13);
            eXPERT_LASTNAMELabel.TabIndex = 8;
            eXPERT_LASTNAMELabel.Text = "Lastname";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 187);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(eXPERT_TYPELabel);
            this.tabPage1.Controls.Add(this.eXPERT_TYPETextBox);
            this.tabPage1.Controls.Add(eXPERT_NAMELabel);
            this.tabPage1.Controls.Add(this.eXPERT_NAMETextBox);
            this.tabPage1.Controls.Add(eXPERT_SURNAMELabel);
            this.tabPage1.Controls.Add(this.eXPERT_SURNAMETextBox);
            this.tabPage1.Controls.Add(eXPERT_LASTNAMELabel);
            this.tabPage1.Controls.Add(this.eXPERT_LASTNAMETextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // eXPERT_TYPETextBox
            // 
            this.eXPERT_TYPETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_TYPE", true));
            this.eXPERT_TYPETextBox.Location = new System.Drawing.Point(52, 111);
            this.eXPERT_TYPETextBox.Name = "eXPERT_TYPETextBox";
            this.eXPERT_TYPETextBox.Size = new System.Drawing.Size(100, 20);
            this.eXPERT_TYPETextBox.TabIndex = 3;
            // 
            // eXPERTSBindingSource
            // 
            this.eXPERTSBindingSource.DataMember = "EXPERTS";
            this.eXPERTSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // projectManagementDBDataSet
            // 
            this.projectManagementDBDataSet.DataSetName = "ProjectManagementDBDataSet";
            this.projectManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXPERT_NAMETextBox
            // 
            this.eXPERT_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_NAME", true));
            this.eXPERT_NAMETextBox.Location = new System.Drawing.Point(52, 53);
            this.eXPERT_NAMETextBox.Name = "eXPERT_NAMETextBox";
            this.eXPERT_NAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.eXPERT_NAMETextBox.TabIndex = 5;
            // 
            // eXPERT_SURNAMETextBox
            // 
            this.eXPERT_SURNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_SURNAME", true));
            this.eXPERT_SURNAMETextBox.Location = new System.Drawing.Point(193, 53);
            this.eXPERT_SURNAMETextBox.Name = "eXPERT_SURNAMETextBox";
            this.eXPERT_SURNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.eXPERT_SURNAMETextBox.TabIndex = 7;
            // 
            // eXPERT_LASTNAMETextBox
            // 
            this.eXPERT_LASTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_LASTNAME", true));
            this.eXPERT_LASTNAMETextBox.Location = new System.Drawing.Point(333, 53);
            this.eXPERT_LASTNAMETextBox.Name = "eXPERT_LASTNAMETextBox";
            this.eXPERT_LASTNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.eXPERT_LASTNAMETextBox.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.projectListGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Assigned Tasks to Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // projectListGrid
            // 
            this.projectListGrid.AutoGenerateColumns = false;
            this.projectListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pROJECTIDDataGridViewTextBoxColumn,
            this.pROJECTNAMEDataGridViewTextBoxColumn,
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn,
            this.pROJECTCLIENTDataGridViewTextBoxColumn,
            this.pROJECTBEGINDataGridViewTextBoxColumn,
            this.pROJECTENDDataGridViewTextBoxColumn,
            this.pROJECTSTATUSDataGridViewTextBoxColumn,
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn,
            this.editProjectStatus});
            this.projectListGrid.DataSource = this.pROJECTSBindingSource;
            this.projectListGrid.Location = new System.Drawing.Point(3, 6);
            this.projectListGrid.Name = "projectListGrid";
            this.projectListGrid.Size = new System.Drawing.Size(841, 313);
            this.projectListGrid.TabIndex = 1;
            // 
            // pROJECTIDDataGridViewTextBoxColumn
            // 
            this.pROJECTIDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.HeaderText = "Project Code";
            this.pROJECTIDDataGridViewTextBoxColumn.Name = "pROJECTIDDataGridViewTextBoxColumn";
            // 
            // pROJECTNAMEDataGridViewTextBoxColumn
            // 
            this.pROJECTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_NAME";
            this.pROJECTNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pROJECTNAMEDataGridViewTextBoxColumn.Name = "pROJECTNAMEDataGridViewTextBoxColumn";
            // 
            // pROJECTDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_DESCRIPTION";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Description";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.Name = "pROJECTDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // pROJECTCLIENTDataGridViewTextBoxColumn
            // 
            this.pROJECTCLIENTDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_CLIENT";
            this.pROJECTCLIENTDataGridViewTextBoxColumn.HeaderText = "Client";
            this.pROJECTCLIENTDataGridViewTextBoxColumn.Name = "pROJECTCLIENTDataGridViewTextBoxColumn";
            // 
            // pROJECTBEGINDataGridViewTextBoxColumn
            // 
            this.pROJECTBEGINDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_BEGIN";
            this.pROJECTBEGINDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.pROJECTBEGINDataGridViewTextBoxColumn.Name = "pROJECTBEGINDataGridViewTextBoxColumn";
            // 
            // pROJECTENDDataGridViewTextBoxColumn
            // 
            this.pROJECTENDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_END";
            this.pROJECTENDDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.pROJECTENDDataGridViewTextBoxColumn.Name = "pROJECTENDDataGridViewTextBoxColumn";
            // 
            // pROJECTSTATUSDataGridViewTextBoxColumn
            // 
            this.pROJECTSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_STATUS";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.HeaderText = "Status";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.Name = "pROJECTSTATUSDataGridViewTextBoxColumn";
            // 
            // pROJECTPAYPERHOURDataGridViewTextBoxColumn
            // 
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_PAY_PER_HOUR";
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.HeaderText = "Pay Per Hour";
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.Name = "pROJECTPAYPERHOURDataGridViewTextBoxColumn";
            // 
            // editProjectStatus
            // 
            this.editProjectStatus.DataPropertyName = "PROJECT_STATUS";
            this.editProjectStatus.HeaderText = "Edit Project Status";
            this.editProjectStatus.Name = "editProjectStatus";
            this.editProjectStatus.Visible = false;
            // 
            // pROJECTSBindingSource
            // 
            this.pROJECTSBindingSource.DataMember = "PROJECTS";
            this.pROJECTSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // eXPERTSTableAdapter
            // 
            this.eXPERTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXPERTSTableAdapter = this.eXPERTSTableAdapter;
            this.tableAdapterManager.PROJECT_STATUSTableAdapter = null;
            this.tableAdapterManager.PROJECT_TASKSTableAdapter = null;
            this.tableAdapterManager.PROJECTSTableAdapter = this.pROJECTSTableAdapter;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROJECTSTableAdapter
            // 
            this.pROJECTSTableAdapter.ClearBeforeFill = true;
            // 
            // eXPERTSBindingNavigator
            // 
            this.eXPERTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eXPERTSBindingNavigator.BindingSource = this.eXPERTSBindingSource;
            this.eXPERTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eXPERTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eXPERTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eXPERTSBindingNavigatorSaveItem});
            this.eXPERTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eXPERTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eXPERTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eXPERTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eXPERTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eXPERTSBindingNavigator.Name = "eXPERTSBindingNavigator";
            this.eXPERTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eXPERTSBindingNavigator.Size = new System.Drawing.Size(1099, 25);
            this.eXPERTSBindingNavigator.TabIndex = 1;
            this.eXPERTSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // eXPERTSBindingNavigatorSaveItem
            // 
            this.eXPERTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eXPERTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eXPERTSBindingNavigatorSaveItem.Image")));
            this.eXPERTSBindingNavigatorSaveItem.Name = "eXPERTSBindingNavigatorSaveItem";
            this.eXPERTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eXPERTSBindingNavigatorSaveItem.Text = "Save Data";
            this.eXPERTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.eXPERTSBindingNavigatorSaveItem_Click);
            // 
            // expertsTableAdapter1
            // 
            this.expertsTableAdapter1.ClearBeforeFill = true;
            // 
            // User_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 259);
            this.Controls.Add(this.eXPERTSBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "User_Details";
            this.Text = "User_Details";
            this.Load += new System.EventHandler(this.User_Details_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingNavigator)).EndInit();
            this.eXPERTSBindingNavigator.ResumeLayout(false);
            this.eXPERTSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter eXPERTSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eXPERTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eXPERTSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox eXPERT_TYPETextBox;
        private System.Windows.Forms.TextBox eXPERT_NAMETextBox;
        private System.Windows.Forms.TextBox eXPERT_SURNAMETextBox;
        private System.Windows.Forms.TextBox eXPERT_LASTNAMETextBox;
        private ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private System.Windows.Forms.DataGridView projectListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTBEGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTPAYPERHOURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editProjectStatus;
        private ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter expertsTableAdapter1;
    }
}