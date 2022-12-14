namespace ProjectManagement
{
    partial class Task_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task_Details));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.taskNamet = new System.Windows.Forms.TextBox();
            this.taskCommentrt = new System.Windows.Forms.RichTextBox();
            this.taskNamel = new System.Windows.Forms.Label();
            this.taskCommentl = new System.Windows.Forms.Label();
            this.taskDescl = new System.Windows.Forms.Label();
            this.taskProgresst = new System.Windows.Forms.MaskedTextBox();
            this.taskResultl = new System.Windows.Forms.Label();
            this.taskProgressl = new System.Windows.Forms.Label();
            this.taskResultcb = new System.Windows.Forms.ComboBox();
            this.taskPrioritycb = new System.Windows.Forms.ComboBox();
            this.taskPriorityl = new System.Windows.Forms.Label();
            this.taskHourst = new System.Windows.Forms.MaskedTextBox();
            this.taskDescrt = new System.Windows.Forms.RichTextBox();
            this.taskTimedt = new System.Windows.Forms.DateTimePicker();
            this.taskTimel = new System.Windows.Forms.Label();
            this.taskHoursl = new System.Windows.Forms.Label();
            this.taskStatuscb = new System.Windows.Forms.ComboBox();
            this.taskStatusl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pROJECT_TASKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECT_TASKSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.pROJECT_TASKSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pROJECT_TASKSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            this.pROJECTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingNavigator)).BeginInit();
            this.pROJECT_TASKSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 590);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.taskNamet);
            this.tabPage1.Controls.Add(this.taskCommentrt);
            this.tabPage1.Controls.Add(this.taskNamel);
            this.tabPage1.Controls.Add(this.taskCommentl);
            this.tabPage1.Controls.Add(this.taskDescl);
            this.tabPage1.Controls.Add(this.taskProgresst);
            this.tabPage1.Controls.Add(this.taskResultl);
            this.tabPage1.Controls.Add(this.taskProgressl);
            this.tabPage1.Controls.Add(this.taskResultcb);
            this.tabPage1.Controls.Add(this.taskPrioritycb);
            this.tabPage1.Controls.Add(this.taskPriorityl);
            this.tabPage1.Controls.Add(this.taskHourst);
            this.tabPage1.Controls.Add(this.taskDescrt);
            this.tabPage1.Controls.Add(this.taskTimedt);
            this.tabPage1.Controls.Add(this.taskTimel);
            this.tabPage1.Controls.Add(this.taskHoursl);
            this.tabPage1.Controls.Add(this.taskStatuscb);
            this.tabPage1.Controls.Add(this.taskStatusl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Project Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // taskNamet
            // 
            this.taskNamet.Location = new System.Drawing.Point(61, 29);
            this.taskNamet.Name = "taskNamet";
            this.taskNamet.Size = new System.Drawing.Size(260, 20);
            this.taskNamet.TabIndex = 21;
            // 
            // taskCommentrt
            // 
            this.taskCommentrt.Location = new System.Drawing.Point(61, 442);
            this.taskCommentrt.Name = "taskCommentrt";
            this.taskCommentrt.Size = new System.Drawing.Size(260, 96);
            this.taskCommentrt.TabIndex = 38;
            this.taskCommentrt.Text = "";
            // 
            // taskNamel
            // 
            this.taskNamel.AutoSize = true;
            this.taskNamel.Location = new System.Drawing.Point(58, 13);
            this.taskNamel.Name = "taskNamel";
            this.taskNamel.Size = new System.Drawing.Size(27, 13);
            this.taskNamel.TabIndex = 22;
            this.taskNamel.Text = "Title";
            // 
            // taskCommentl
            // 
            this.taskCommentl.AutoSize = true;
            this.taskCommentl.Location = new System.Drawing.Point(59, 422);
            this.taskCommentl.Name = "taskCommentl";
            this.taskCommentl.Size = new System.Drawing.Size(78, 13);
            this.taskCommentl.TabIndex = 37;
            this.taskCommentl.Text = "Task Comment";
            // 
            // taskDescl
            // 
            this.taskDescl.AutoSize = true;
            this.taskDescl.Location = new System.Drawing.Point(58, 58);
            this.taskDescl.Name = "taskDescl";
            this.taskDescl.Size = new System.Drawing.Size(60, 13);
            this.taskDescl.TabIndex = 23;
            this.taskDescl.Text = "Description";
            // 
            // taskProgresst
            // 
            this.taskProgresst.Location = new System.Drawing.Point(61, 385);
            this.taskProgresst.Name = "taskProgresst";
            this.taskProgresst.Size = new System.Drawing.Size(111, 20);
            this.taskProgresst.TabIndex = 34;
            // 
            // taskResultl
            // 
            this.taskResultl.AutoSize = true;
            this.taskResultl.Location = new System.Drawing.Point(61, 240);
            this.taskResultl.Name = "taskResultl";
            this.taskResultl.Size = new System.Drawing.Size(120, 13);
            this.taskResultl.TabIndex = 25;
            this.taskResultl.Text = "Expected Result Format";
            // 
            // taskProgressl
            // 
            this.taskProgressl.AutoSize = true;
            this.taskProgressl.Location = new System.Drawing.Point(61, 365);
            this.taskProgressl.Name = "taskProgressl";
            this.taskProgressl.Size = new System.Drawing.Size(75, 13);
            this.taskProgressl.TabIndex = 33;
            this.taskProgressl.Text = "Task Progress";
            // 
            // taskResultcb
            // 
            this.taskResultcb.FormattingEnabled = true;
            this.taskResultcb.Location = new System.Drawing.Point(61, 265);
            this.taskResultcb.Name = "taskResultcb";
            this.taskResultcb.Size = new System.Drawing.Size(260, 21);
            this.taskResultcb.TabIndex = 26;
            // 
            // taskPrioritycb
            // 
            this.taskPrioritycb.FormattingEnabled = true;
            this.taskPrioritycb.Location = new System.Drawing.Point(215, 205);
            this.taskPrioritycb.Name = "taskPrioritycb";
            this.taskPrioritycb.Size = new System.Drawing.Size(106, 21);
            this.taskPrioritycb.TabIndex = 30;
            // 
            // taskPriorityl
            // 
            this.taskPriorityl.AutoSize = true;
            this.taskPriorityl.Location = new System.Drawing.Point(212, 182);
            this.taskPriorityl.Name = "taskPriorityl";
            this.taskPriorityl.Size = new System.Drawing.Size(38, 13);
            this.taskPriorityl.TabIndex = 29;
            this.taskPriorityl.Text = "Priority";
            // 
            // taskHourst
            // 
            this.taskHourst.Location = new System.Drawing.Point(215, 329);
            this.taskHourst.Name = "taskHourst";
            this.taskHourst.Size = new System.Drawing.Size(106, 20);
            this.taskHourst.TabIndex = 36;
            // 
            // taskDescrt
            // 
            this.taskDescrt.Location = new System.Drawing.Point(61, 74);
            this.taskDescrt.Name = "taskDescrt";
            this.taskDescrt.Size = new System.Drawing.Size(260, 96);
            this.taskDescrt.TabIndex = 24;
            this.taskDescrt.Text = "";
            // 
            // taskTimedt
            // 
            this.taskTimedt.Location = new System.Drawing.Point(61, 326);
            this.taskTimedt.Name = "taskTimedt";
            this.taskTimedt.Size = new System.Drawing.Size(111, 20);
            this.taskTimedt.TabIndex = 28;
            // 
            // taskTimel
            // 
            this.taskTimel.AutoSize = true;
            this.taskTimel.Location = new System.Drawing.Point(60, 304);
            this.taskTimel.Name = "taskTimel";
            this.taskTimel.Size = new System.Drawing.Size(72, 13);
            this.taskTimel.TabIndex = 27;
            this.taskTimel.Text = "Creation Date";
            // 
            // taskHoursl
            // 
            this.taskHoursl.AutoSize = true;
            this.taskHoursl.Location = new System.Drawing.Point(212, 304);
            this.taskHoursl.Name = "taskHoursl";
            this.taskHoursl.Size = new System.Drawing.Size(78, 13);
            this.taskHoursl.TabIndex = 35;
            this.taskHoursl.Text = "Estimate Hours";
            this.taskHoursl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taskStatuscb
            // 
            this.taskStatuscb.FormattingEnabled = true;
            this.taskStatuscb.Location = new System.Drawing.Point(61, 205);
            this.taskStatuscb.Name = "taskStatuscb";
            this.taskStatuscb.Size = new System.Drawing.Size(113, 21);
            this.taskStatuscb.TabIndex = 32;
            // 
            // taskStatusl
            // 
            this.taskStatusl.AutoSize = true;
            this.taskStatusl.Location = new System.Drawing.Point(58, 182);
            this.taskStatusl.Name = "taskStatusl";
            this.taskStatusl.Size = new System.Drawing.Size(64, 13);
            this.taskStatusl.TabIndex = 31;
            this.taskStatusl.Text = "Task Status";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.pROJECTSDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(944, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Project Realted Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pROJECT_TASKSBindingSource
            // 
            this.pROJECT_TASKSBindingSource.DataMember = "PROJECT_TASKS";
            this.pROJECT_TASKSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // projectManagementDBDataSet
            // 
            this.projectManagementDBDataSet.DataSetName = "ProjectManagementDBDataSet";
            this.projectManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJECT_TASKSTableAdapter
            // 
            this.pROJECT_TASKSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXPERTSTableAdapter = null;
            this.tableAdapterManager.PROJECT_STATUSTableAdapter = null;
            this.tableAdapterManager.PROJECT_TASKSTableAdapter = this.pROJECT_TASKSTableAdapter;
            this.tableAdapterManager.PROJECTSTableAdapter = null;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROJECT_TASKSBindingNavigator
            // 
            this.pROJECT_TASKSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pROJECT_TASKSBindingNavigator.BindingSource = this.pROJECT_TASKSBindingSource;
            this.pROJECT_TASKSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pROJECT_TASKSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pROJECT_TASKSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pROJECT_TASKSBindingNavigatorSaveItem});
            this.pROJECT_TASKSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pROJECT_TASKSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pROJECT_TASKSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pROJECT_TASKSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pROJECT_TASKSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pROJECT_TASKSBindingNavigator.Name = "pROJECT_TASKSBindingNavigator";
            this.pROJECT_TASKSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pROJECT_TASKSBindingNavigator.Size = new System.Drawing.Size(1307, 25);
            this.pROJECT_TASKSBindingNavigator.TabIndex = 1;
            this.pROJECT_TASKSBindingNavigator.Text = "bindingNavigator1";
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
            // pROJECT_TASKSBindingNavigatorSaveItem
            // 
            this.pROJECT_TASKSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pROJECT_TASKSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pROJECT_TASKSBindingNavigatorSaveItem.Image")));
            this.pROJECT_TASKSBindingNavigatorSaveItem.Name = "pROJECT_TASKSBindingNavigatorSaveItem";
            this.pROJECT_TASKSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pROJECT_TASKSBindingNavigatorSaveItem.Text = "Save Data";
            this.pROJECT_TASKSBindingNavigatorSaveItem.Click += new System.EventHandler(this.pROJECT_TASKSBindingNavigatorSaveItem_Click);
            // 
            // pROJECTSBindingSource
            // 
            this.pROJECTSBindingSource.DataMember = "PROJECTS";
            this.pROJECTSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // pROJECTSTableAdapter
            // 
            this.pROJECTSTableAdapter.ClearBeforeFill = true;
            // 
            // pROJECTSDataGridView
            // 
            this.pROJECTSDataGridView.AutoGenerateColumns = false;
            this.pROJECTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pROJECTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Task});
            this.pROJECTSDataGridView.DataSource = this.pROJECTSBindingSource;
            this.pROJECTSDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pROJECTSDataGridView.Name = "pROJECTSDataGridView";
            this.pROJECTSDataGridView.Size = new System.Drawing.Size(943, 564);
            this.pROJECTSDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PROJECT_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Project Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PROJECT_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PROJECT_DESCRIPTION";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PROJECT_CLIENT";
            this.dataGridViewTextBoxColumn4.HeaderText = "Client";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PROJECT_BEGIN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PROJECT_END";
            this.dataGridViewTextBoxColumn6.HeaderText = "End Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PROJECT_STATUS";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PROJECT_PAY_PER_HOUR";
            this.dataGridViewTextBoxColumn8.HeaderText = "Pay Per Hour";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Task
            // 
            this.Task.DataPropertyName = "PROJECT_ID";
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            // 
            // Task_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 641);
            this.Controls.Add(this.pROJECT_TASKSBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "Task_Details";
            this.Text = "Task_Details";
            this.Load += new System.EventHandler(this.Task_Details_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingNavigator)).EndInit();
            this.pROJECT_TASKSBindingNavigator.ResumeLayout(false);
            this.pROJECT_TASKSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox taskNamet;
        private System.Windows.Forms.RichTextBox taskCommentrt;
        private System.Windows.Forms.Label taskNamel;
        private System.Windows.Forms.Label taskCommentl;
        private System.Windows.Forms.Label taskDescl;
        private System.Windows.Forms.MaskedTextBox taskProgresst;
        private System.Windows.Forms.Label taskResultl;
        private System.Windows.Forms.Label taskProgressl;
        private System.Windows.Forms.ComboBox taskResultcb;
        private System.Windows.Forms.ComboBox taskPrioritycb;
        private System.Windows.Forms.Label taskPriorityl;
        private System.Windows.Forms.MaskedTextBox taskHourst;
        private System.Windows.Forms.RichTextBox taskDescrt;
        private System.Windows.Forms.DateTimePicker taskTimedt;
        private System.Windows.Forms.Label taskTimel;
        private System.Windows.Forms.Label taskHoursl;
        private System.Windows.Forms.ComboBox taskStatuscb;
        private System.Windows.Forms.Label taskStatusl;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECT_TASKSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter pROJECT_TASKSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pROJECT_TASKSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pROJECT_TASKSBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private System.Windows.Forms.DataGridView pROJECTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
    }
}