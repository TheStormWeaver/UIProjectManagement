namespace ProjectManagement
{
    partial class User_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userListGrid = new System.Windows.Forms.DataGridView();
            this.eXPRETIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.eXPERTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.searchProjectbtn = new System.Windows.Forms.Button();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            this.pROJECT_TASKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECT_TASKSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.projectManagementDBDataSet1 = new ProjectManagement.ProjectManagementDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnamet = new System.Windows.Forms.TextBox();
            this.firstnamel = new System.Windows.Forms.Label();
            this.lastnamet = new System.Windows.Forms.TextBox();
            this.surnamet = new System.Windows.Forms.TextBox();
            this.surnamel = new System.Windows.Forms.Label();
            this.lastnamel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typecb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userListGrid
            // 
            this.userListGrid.AutoGenerateColumns = false;
            this.userListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.userListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userListGrid.ColumnHeadersHeight = 32;
            this.userListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eXPRETIDDataGridViewTextBoxColumn,
            this.eXPERTNAMEDataGridViewTextBoxColumn,
            this.eXPERTSURNAMEDataGridViewTextBoxColumn,
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn,
            this.eXPERTTYPEDataGridViewTextBoxColumn,
            this.Details,
            this.Edit,
            this.Delete});
            this.userListGrid.DataSource = this.eXPERTSBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userListGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.userListGrid.EnableHeadersVisualStyles = false;
            this.userListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.userListGrid.Location = new System.Drawing.Point(260, 82);
            this.userListGrid.Name = "userListGrid";
            this.userListGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userListGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow;
            this.userListGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.userListGrid.RowTemplate.DividerHeight = 3;
            this.userListGrid.RowTemplate.Height = 30;
            this.userListGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userListGrid.Size = new System.Drawing.Size(744, 305);
            this.userListGrid.TabIndex = 0;
            // 
            // eXPRETIDDataGridViewTextBoxColumn
            // 
            this.eXPRETIDDataGridViewTextBoxColumn.DataPropertyName = "EXPRET_ID";
            this.eXPRETIDDataGridViewTextBoxColumn.HeaderText = "EXPRET_ID";
            this.eXPRETIDDataGridViewTextBoxColumn.Name = "eXPRETIDDataGridViewTextBoxColumn";
            this.eXPRETIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // eXPERTNAMEDataGridViewTextBoxColumn
            // 
            this.eXPERTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_NAME";
            this.eXPERTNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.eXPERTNAMEDataGridViewTextBoxColumn.Name = "eXPERTNAMEDataGridViewTextBoxColumn";
            this.eXPERTNAMEDataGridViewTextBoxColumn.Width = 110;
            // 
            // eXPERTSURNAMEDataGridViewTextBoxColumn
            // 
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_SURNAME";
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.Name = "eXPERTSURNAMEDataGridViewTextBoxColumn";
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.Width = 112;
            // 
            // eXPERTLASTNAMEDataGridViewTextBoxColumn
            // 
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_LASTNAME";
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.Name = "eXPERTLASTNAMEDataGridViewTextBoxColumn";
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.Width = 110;
            // 
            // eXPERTTYPEDataGridViewTextBoxColumn
            // 
            this.eXPERTTYPEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_TYPE";
            this.eXPERTTYPEDataGridViewTextBoxColumn.HeaderText = "Type";
            this.eXPERTTYPEDataGridViewTextBoxColumn.Name = "eXPERTTYPEDataGridViewTextBoxColumn";
            this.eXPERTTYPEDataGridViewTextBoxColumn.Width = 111;
            // 
            // Details
            // 
            this.Details.DataPropertyName = "EXPRET_ID";
            this.Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Details.Text = "Details";
            this.Details.ToolTipText = "Details";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "EXPRET_ID";
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "EXPRET_ID";
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
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
            this.tableAdapterManager.PROJECTSTableAdapter = null;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // searchProjectbtn
            // 
            this.searchProjectbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.searchProjectbtn.FlatAppearance.BorderSize = 0;
            this.searchProjectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProjectbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProjectbtn.ForeColor = System.Drawing.Color.White;
            this.searchProjectbtn.Location = new System.Drawing.Point(55, 323);
            this.searchProjectbtn.Name = "searchProjectbtn";
            this.searchProjectbtn.Size = new System.Drawing.Size(103, 28);
            this.searchProjectbtn.TabIndex = 13;
            this.searchProjectbtn.Text = "Search";
            this.searchProjectbtn.UseVisualStyleBackColor = false;
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
            // pROJECT_TASKSBindingSource
            // 
            this.pROJECT_TASKSBindingSource.DataMember = "FK_PROJECT__REFERENCE_PROJECTS";
            this.pROJECT_TASKSBindingSource.DataSource = this.pROJECTSBindingSource;
            // 
            // pROJECT_TASKSTableAdapter
            // 
            this.pROJECT_TASKSTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(894, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Create User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // projectManagementDBDataSet1
            // 
            this.projectManagementDBDataSet1.DataSetName = "ProjectManagementDBDataSet";
            this.projectManagementDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(256, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "List of Users";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.typecb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.firstnamet);
            this.panel1.Controls.Add(this.firstnamel);
            this.panel1.Controls.Add(this.lastnamet);
            this.panel1.Controls.Add(this.surnamet);
            this.panel1.Controls.Add(this.surnamel);
            this.panel1.Controls.Add(this.lastnamel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.searchProjectbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 416);
            this.panel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(41, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search Users";
            // 
            // firstnamet
            // 
            this.firstnamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.firstnamet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnamet.ForeColor = System.Drawing.Color.White;
            this.firstnamet.Location = new System.Drawing.Point(29, 96);
            this.firstnamet.Multiline = true;
            this.firstnamet.Name = "firstnamet";
            this.firstnamet.Size = new System.Drawing.Size(162, 23);
            this.firstnamet.TabIndex = 27;
            // 
            // firstnamel
            // 
            this.firstnamel.AutoSize = true;
            this.firstnamel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnamel.ForeColor = System.Drawing.Color.White;
            this.firstnamel.Location = new System.Drawing.Point(26, 72);
            this.firstnamel.Name = "firstnamel";
            this.firstnamel.Size = new System.Drawing.Size(64, 17);
            this.firstnamel.TabIndex = 28;
            this.firstnamel.Text = "Firstname";
            // 
            // lastnamet
            // 
            this.lastnamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lastnamet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnamet.ForeColor = System.Drawing.Color.White;
            this.lastnamet.Location = new System.Drawing.Point(29, 217);
            this.lastnamet.Multiline = true;
            this.lastnamet.Name = "lastnamet";
            this.lastnamet.Size = new System.Drawing.Size(162, 23);
            this.lastnamet.TabIndex = 31;
            // 
            // surnamet
            // 
            this.surnamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.surnamet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnamet.ForeColor = System.Drawing.Color.White;
            this.surnamet.Location = new System.Drawing.Point(29, 157);
            this.surnamet.Multiline = true;
            this.surnamet.Name = "surnamet";
            this.surnamet.Size = new System.Drawing.Size(162, 23);
            this.surnamet.TabIndex = 29;
            // 
            // surnamel
            // 
            this.surnamel.AutoSize = true;
            this.surnamel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnamel.ForeColor = System.Drawing.Color.White;
            this.surnamel.Location = new System.Drawing.Point(26, 133);
            this.surnamel.Name = "surnamel";
            this.surnamel.Size = new System.Drawing.Size(59, 17);
            this.surnamel.TabIndex = 30;
            this.surnamel.Text = "Surname";
            // 
            // lastnamel
            // 
            this.lastnamel.AutoSize = true;
            this.lastnamel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnamel.ForeColor = System.Drawing.Color.White;
            this.lastnamel.Location = new System.Drawing.Point(26, 194);
            this.lastnamel.Name = "lastnamel";
            this.lastnamel.Size = new System.Drawing.Size(63, 17);
            this.lastnamel.TabIndex = 32;
            this.lastnamel.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Type";
            // 
            // typecb
            // 
            this.typecb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.typecb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typecb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typecb.ForeColor = System.Drawing.Color.White;
            this.typecb.FormattingEnabled = true;
            this.typecb.Location = new System.Drawing.Point(29, 278);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(162, 23);
            this.typecb.TabIndex = 35;
            // 
            // User_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1036, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userListGrid);
            this.Name = "User_List";
            this.Text = "User_List";
            this.Load += new System.EventHandler(this.User_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userListGrid;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter eXPERTSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button searchProjectbtn;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private System.Windows.Forms.BindingSource pROJECT_TASKSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter pROJECT_TASKSTableAdapter;
        private System.Windows.Forms.Button button1;
        private ProjectManagementDBDataSet projectManagementDBDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPRETIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTLASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstnamet;
        private System.Windows.Forms.Label firstnamel;
        private System.Windows.Forms.TextBox lastnamet;
        private System.Windows.Forms.TextBox surnamet;
        private System.Windows.Forms.Label surnamel;
        private System.Windows.Forms.Label lastnamel;
        private System.Windows.Forms.ComboBox typecb;
    }
}