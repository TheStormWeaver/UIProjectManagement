namespace ProjectManagement
{
    partial class Project_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.searchProjectbtn = new System.Windows.Forms.Button();
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.pROJECTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter();
            this.eXPERTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projectListGrid = new System.Windows.Forms.DataGridView();
            this.editProjectStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.projectStatusSearchcb = new System.Windows.Forms.ComboBox();
            this.projectUserSearchcb = new System.Windows.Forms.ComboBox();
            this.projectNameSearchl = new System.Windows.Forms.Label();
            this.projectStatusSearchl = new System.Windows.Forms.Label();
            this.projectEndDatel = new System.Windows.Forms.Label();
            this.projectNameSearcht = new System.Windows.Forms.TextBox();
            this.projectStartDateSearchl = new System.Windows.Forms.Label();
            this.projectEndDateSearcht = new System.Windows.Forms.TextBox();
            this.projectStartDateSearcht = new System.Windows.Forms.TextBox();
            this.projectUserSearchl = new System.Windows.Forms.Label();
            this.projectIDSearchl = new System.Windows.Forms.Label();
            this.projectIDSearcht = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pROJECTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTBEGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pROJECTSBindingSource
            // 
            this.pROJECTSBindingSource.DataMember = "PROJECTS";
            this.pROJECTSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // projectManagementDBDataSet
            // 
            this.projectManagementDBDataSet.DataSetName = "ProjectManagementDBDataSet";
            this.projectManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchProjectbtn
            // 
            this.searchProjectbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.searchProjectbtn.FlatAppearance.BorderSize = 0;
            this.searchProjectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProjectbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProjectbtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchProjectbtn.Location = new System.Drawing.Point(43, 274);
            this.searchProjectbtn.Name = "searchProjectbtn";
            this.searchProjectbtn.Size = new System.Drawing.Size(103, 25);
            this.searchProjectbtn.TabIndex = 8;
            this.searchProjectbtn.Text = "Search";
            this.searchProjectbtn.UseVisualStyleBackColor = false;
            this.searchProjectbtn.Click += new System.EventHandler(this.searchProjectbtn_Click);
            // 
            // pROJECTSTableAdapter
            // 
            this.pROJECTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXPERTSTableAdapter = null;
            this.tableAdapterManager.PROJECT_STATUSTableAdapter = null;
            this.tableAdapterManager.PROJECT_TASKSTableAdapter = null;
            this.tableAdapterManager.PROJECTSTableAdapter = this.pROJECTSTableAdapter;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROJECTSBindingSource1
            // 
            this.pROJECTSBindingSource1.DataMember = "PROJECTS";
            this.pROJECTSBindingSource1.DataSource = this.projectManagementDBDataSet;
            // 
            // eXPERTSBindingSource
            // 
            this.eXPERTSBindingSource.DataMember = "EXPERTS";
            this.eXPERTSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // eXPERTSTableAdapter
            // 
            this.eXPERTSTableAdapter.ClearBeforeFill = true;
            // 
            // eXPERTSBindingSource1
            // 
            this.eXPERTSBindingSource1.DataMember = "EXPERTS";
            this.eXPERTSBindingSource1.DataSource = this.projectManagementDBDataSet;
            // 
            // eXPERTSBindingSource2
            // 
            this.eXPERTSBindingSource2.DataMember = "EXPERTS";
            this.eXPERTSBindingSource2.DataSource = this.projectManagementDBDataSet;
            // 
            // projectListGrid
            // 
            this.projectListGrid.AutoGenerateColumns = false;
            this.projectListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.projectListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.projectListGrid.ColumnHeadersHeight = 36;
            this.projectListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.projectListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pROJECTIDDataGridViewTextBoxColumn,
            this.Details,
            this.Edit,
            this.Delete,
            this.pROJECTNAMEDataGridViewTextBoxColumn,
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn,
            this.pROJECTCLIENTDataGridViewTextBoxColumn,
            this.pROJECTBEGINDataGridViewTextBoxColumn,
            this.pROJECTENDDataGridViewTextBoxColumn,
            this.pROJECTSTATUSDataGridViewTextBoxColumn,
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn,
            this.editProjectStatus});
            this.projectListGrid.DataSource = this.pROJECTSBindingSource1;
            this.projectListGrid.EnableHeadersVisualStyles = false;
            this.projectListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.projectListGrid.Location = new System.Drawing.Point(387, 79);
            this.projectListGrid.Name = "projectListGrid";
            this.projectListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.projectListGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.projectListGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.projectListGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectListGrid.Size = new System.Drawing.Size(1098, 390);
            this.projectListGrid.TabIndex = 0;
            this.projectListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectListGrid_CellContentClick);
            // 
            // editProjectStatus
            // 
            this.editProjectStatus.DataPropertyName = "PROJECT_STATUS";
            this.editProjectStatus.HeaderText = "Edit Project Status";
            this.editProjectStatus.Name = "editProjectStatus";
            this.editProjectStatus.Visible = false;
            // 
            // Details
            // 
            this.Details.DataPropertyName = "PROJECT_ID";
            this.Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.Text = "Details";
            this.Details.ToolTipText = "Details";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "PROJECT_ID";
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "PROJECT_ID";
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(382, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "List of Projects";
            // 
            // projectStatusSearchcb
            // 
            this.projectStatusSearchcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.projectStatusSearchcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectStatusSearchcb.ForeColor = System.Drawing.Color.White;
            this.projectStatusSearchcb.FormattingEnabled = true;
            this.projectStatusSearchcb.Location = new System.Drawing.Point(42, 161);
            this.projectStatusSearchcb.Name = "projectStatusSearchcb";
            this.projectStatusSearchcb.Size = new System.Drawing.Size(103, 21);
            this.projectStatusSearchcb.TabIndex = 18;
            // 
            // projectUserSearchcb
            // 
            this.projectUserSearchcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.projectUserSearchcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectUserSearchcb.ForeColor = System.Drawing.Color.White;
            this.projectUserSearchcb.FormattingEnabled = true;
            this.projectUserSearchcb.Location = new System.Drawing.Point(195, 161);
            this.projectUserSearchcb.Name = "projectUserSearchcb";
            this.projectUserSearchcb.Size = new System.Drawing.Size(96, 21);
            this.projectUserSearchcb.TabIndex = 17;
            // 
            // projectNameSearchl
            // 
            this.projectNameSearchl.AutoSize = true;
            this.projectNameSearchl.ForeColor = System.Drawing.Color.White;
            this.projectNameSearchl.Location = new System.Drawing.Point(192, 77);
            this.projectNameSearchl.Name = "projectNameSearchl";
            this.projectNameSearchl.Size = new System.Drawing.Size(35, 13);
            this.projectNameSearchl.TabIndex = 7;
            this.projectNameSearchl.Text = "Name";
            // 
            // projectStatusSearchl
            // 
            this.projectStatusSearchl.AutoSize = true;
            this.projectStatusSearchl.ForeColor = System.Drawing.Color.White;
            this.projectStatusSearchl.Location = new System.Drawing.Point(40, 141);
            this.projectStatusSearchl.Name = "projectStatusSearchl";
            this.projectStatusSearchl.Size = new System.Drawing.Size(37, 13);
            this.projectStatusSearchl.TabIndex = 14;
            this.projectStatusSearchl.Text = "Status";
            // 
            // projectEndDatel
            // 
            this.projectEndDatel.AutoSize = true;
            this.projectEndDatel.ForeColor = System.Drawing.Color.White;
            this.projectEndDatel.Location = new System.Drawing.Point(192, 201);
            this.projectEndDatel.Name = "projectEndDatel";
            this.projectEndDatel.Size = new System.Drawing.Size(52, 13);
            this.projectEndDatel.TabIndex = 16;
            this.projectEndDatel.Text = "End Date";
            // 
            // projectNameSearcht
            // 
            this.projectNameSearcht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.projectNameSearcht.ForeColor = System.Drawing.Color.White;
            this.projectNameSearcht.Location = new System.Drawing.Point(195, 99);
            this.projectNameSearcht.Multiline = true;
            this.projectNameSearcht.Name = "projectNameSearcht";
            this.projectNameSearcht.Size = new System.Drawing.Size(96, 23);
            this.projectNameSearcht.TabIndex = 6;
            // 
            // projectStartDateSearchl
            // 
            this.projectStartDateSearchl.AutoSize = true;
            this.projectStartDateSearchl.ForeColor = System.Drawing.Color.White;
            this.projectStartDateSearchl.Location = new System.Drawing.Point(39, 202);
            this.projectStartDateSearchl.Name = "projectStartDateSearchl";
            this.projectStartDateSearchl.Size = new System.Drawing.Size(58, 13);
            this.projectStartDateSearchl.TabIndex = 12;
            this.projectStartDateSearchl.Text = "Starrt Date";
            // 
            // projectEndDateSearcht
            // 
            this.projectEndDateSearcht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.projectEndDateSearcht.ForeColor = System.Drawing.Color.White;
            this.projectEndDateSearcht.Location = new System.Drawing.Point(195, 223);
            this.projectEndDateSearcht.Multiline = true;
            this.projectEndDateSearcht.Name = "projectEndDateSearcht";
            this.projectEndDateSearcht.Size = new System.Drawing.Size(96, 23);
            this.projectEndDateSearcht.TabIndex = 15;
            // 
            // projectStartDateSearcht
            // 
            this.projectStartDateSearcht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.projectStartDateSearcht.ForeColor = System.Drawing.Color.White;
            this.projectStartDateSearcht.Location = new System.Drawing.Point(42, 223);
            this.projectStartDateSearcht.Multiline = true;
            this.projectStartDateSearcht.Name = "projectStartDateSearcht";
            this.projectStartDateSearcht.Size = new System.Drawing.Size(103, 23);
            this.projectStartDateSearcht.TabIndex = 11;
            // 
            // projectUserSearchl
            // 
            this.projectUserSearchl.AutoSize = true;
            this.projectUserSearchl.ForeColor = System.Drawing.Color.White;
            this.projectUserSearchl.Location = new System.Drawing.Point(192, 141);
            this.projectUserSearchl.Name = "projectUserSearchl";
            this.projectUserSearchl.Size = new System.Drawing.Size(83, 13);
            this.projectUserSearchl.TabIndex = 10;
            this.projectUserSearchl.Text = "Assinged Expert";
            // 
            // projectIDSearchl
            // 
            this.projectIDSearchl.AutoSize = true;
            this.projectIDSearchl.ForeColor = System.Drawing.Color.White;
            this.projectIDSearchl.Location = new System.Drawing.Point(39, 77);
            this.projectIDSearchl.Name = "projectIDSearchl";
            this.projectIDSearchl.Size = new System.Drawing.Size(68, 13);
            this.projectIDSearchl.TabIndex = 5;
            this.projectIDSearchl.Text = "Project Code";
            // 
            // projectIDSearcht
            // 
            this.projectIDSearcht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.projectIDSearcht.ForeColor = System.Drawing.Color.White;
            this.projectIDSearcht.Location = new System.Drawing.Point(42, 99);
            this.projectIDSearcht.Multiline = true;
            this.projectIDSearcht.Name = "projectIDSearcht";
            this.projectIDSearcht.Size = new System.Drawing.Size(103, 23);
            this.projectIDSearcht.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.searchProjectbtn);
            this.panel1.Controls.Add(this.projectStatusSearchcb);
            this.panel1.Controls.Add(this.projectUserSearchcb);
            this.panel1.Controls.Add(this.projectEndDateSearcht);
            this.panel1.Controls.Add(this.projectNameSearchl);
            this.panel1.Controls.Add(this.projectIDSearcht);
            this.panel1.Controls.Add(this.projectStatusSearchl);
            this.panel1.Controls.Add(this.projectIDSearchl);
            this.panel1.Controls.Add(this.projectEndDatel);
            this.panel1.Controls.Add(this.projectUserSearchl);
            this.panel1.Controls.Add(this.projectNameSearcht);
            this.panel1.Controls.Add(this.projectStartDateSearcht);
            this.panel1.Controls.Add(this.projectStartDateSearchl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 505);
            this.panel1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(38, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Search Projects";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1338, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add New Project";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pROJECTIDDataGridViewTextBoxColumn
            // 
            this.pROJECTIDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_ID";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.IndianRed;
            this.pROJECTIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.pROJECTIDDataGridViewTextBoxColumn.HeaderText = "Project Code";
            this.pROJECTIDDataGridViewTextBoxColumn.Name = "pROJECTIDDataGridViewTextBoxColumn";
            // 
            // pROJECTPAYPERHOURDataGridViewTextBoxColumn
            // 
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_PAY_PER_HOUR";
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.HeaderText = "Pay Per Hour";
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.Name = "pROJECTPAYPERHOURDataGridViewTextBoxColumn";
            // 
            // pROJECTSTATUSDataGridViewTextBoxColumn
            // 
            this.pROJECTSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_STATUS";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.HeaderText = "Status";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.Name = "pROJECTSTATUSDataGridViewTextBoxColumn";
            // 
            // pROJECTENDDataGridViewTextBoxColumn
            // 
            this.pROJECTENDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_END";
            this.pROJECTENDDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.pROJECTENDDataGridViewTextBoxColumn.Name = "pROJECTENDDataGridViewTextBoxColumn";
            // 
            // pROJECTBEGINDataGridViewTextBoxColumn
            // 
            this.pROJECTBEGINDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_BEGIN";
            this.pROJECTBEGINDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.pROJECTBEGINDataGridViewTextBoxColumn.Name = "pROJECTBEGINDataGridViewTextBoxColumn";
            // 
            // pROJECTCLIENTDataGridViewTextBoxColumn
            // 
            this.pROJECTCLIENTDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_CLIENT";
            this.pROJECTCLIENTDataGridViewTextBoxColumn.HeaderText = "Client";
            this.pROJECTCLIENTDataGridViewTextBoxColumn.Name = "pROJECTCLIENTDataGridViewTextBoxColumn";
            // 
            // pROJECTDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_DESCRIPTION";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Description";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.Name = "pROJECTDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // pROJECTNAMEDataGridViewTextBoxColumn
            // 
            this.pROJECTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_NAME";
            this.pROJECTNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pROJECTNAMEDataGridViewTextBoxColumn.Name = "pROJECTNAMEDataGridViewTextBoxColumn";
            // 
            // Project_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1534, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectListGrid);
            this.Controls.Add(this.panel1);
            this.Name = "Project_List";
            this.Text = "Project_List";
            this.Load += new System.EventHandler(this.Project_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button searchProjectbtn;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource1;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter eXPERTSTableAdapter;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource1;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource2;
        private System.Windows.Forms.DataGridView projectListGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox projectStatusSearchcb;
        private System.Windows.Forms.ComboBox projectUserSearchcb;
        private System.Windows.Forms.Label projectNameSearchl;
        private System.Windows.Forms.Label projectStatusSearchl;
        private System.Windows.Forms.Label projectEndDatel;
        private System.Windows.Forms.TextBox projectNameSearcht;
        private System.Windows.Forms.Label projectStartDateSearchl;
        private System.Windows.Forms.TextBox projectEndDateSearcht;
        private System.Windows.Forms.TextBox projectStartDateSearcht;
        private System.Windows.Forms.Label projectUserSearchl;
        private System.Windows.Forms.Label projectIDSearchl;
        private System.Windows.Forms.TextBox projectIDSearcht;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn editProjectStatus;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTBEGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTPAYPERHOURDataGridViewTextBoxColumn;
    }
}