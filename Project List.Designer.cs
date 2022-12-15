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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.projectNameSearchl = new System.Windows.Forms.Label();
            this.projectNameSearcht = new System.Windows.Forms.TextBox();
            this.projectIDSearchl = new System.Windows.Forms.Label();
            this.projectIDSearcht = new System.Windows.Forms.TextBox();
            this.searchProjectbtn = new System.Windows.Forms.Button();
            this.projectUserSearchl = new System.Windows.Forms.Label();
            this.projectStartDateSearchl = new System.Windows.Forms.Label();
            this.projectStartDateSearcht = new System.Windows.Forms.TextBox();
            this.projectStatusSearchl = new System.Windows.Forms.Label();
            this.projectEndDatel = new System.Windows.Forms.Label();
            this.projectEndDateSearcht = new System.Windows.Forms.TextBox();
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.projectStatusSearchcb = new System.Windows.Forms.ComboBox();
            this.projectUserSearchcb = new System.Windows.Forms.ComboBox();
            this.pROJECTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter();
            this.eXPERTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.editProjectStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTBEGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectListGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).BeginInit();
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
            // projectNameSearchl
            // 
            this.projectNameSearchl.AutoSize = true;
            this.projectNameSearchl.Location = new System.Drawing.Point(180, 25);
            this.projectNameSearchl.Name = "projectNameSearchl";
            this.projectNameSearchl.Size = new System.Drawing.Size(35, 13);
            this.projectNameSearchl.TabIndex = 7;
            this.projectNameSearchl.Text = "Name";
            // 
            // projectNameSearcht
            // 
            this.projectNameSearcht.Location = new System.Drawing.Point(183, 49);
            this.projectNameSearcht.Name = "projectNameSearcht";
            this.projectNameSearcht.Size = new System.Drawing.Size(96, 20);
            this.projectNameSearcht.TabIndex = 6;
            // 
            // projectIDSearchl
            // 
            this.projectIDSearchl.AutoSize = true;
            this.projectIDSearchl.Location = new System.Drawing.Point(27, 25);
            this.projectIDSearchl.Name = "projectIDSearchl";
            this.projectIDSearchl.Size = new System.Drawing.Size(68, 13);
            this.projectIDSearchl.TabIndex = 5;
            this.projectIDSearchl.Text = "Project Code";
            // 
            // projectIDSearcht
            // 
            this.projectIDSearcht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.projectIDSearcht.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.projectIDSearcht.Location = new System.Drawing.Point(30, 49);
            this.projectIDSearcht.Name = "projectIDSearcht";
            this.projectIDSearcht.Size = new System.Drawing.Size(103, 20);
            this.projectIDSearcht.TabIndex = 4;
            // 
            // searchProjectbtn
            // 
            this.searchProjectbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchProjectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProjectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProjectbtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchProjectbtn.Location = new System.Drawing.Point(30, 205);
            this.searchProjectbtn.Name = "searchProjectbtn";
            this.searchProjectbtn.Size = new System.Drawing.Size(103, 25);
            this.searchProjectbtn.TabIndex = 8;
            this.searchProjectbtn.Text = "Search Projects";
            this.searchProjectbtn.UseVisualStyleBackColor = false;
            this.searchProjectbtn.Click += new System.EventHandler(this.searchProjectbtn_Click);
            // 
            // projectUserSearchl
            // 
            this.projectUserSearchl.AutoSize = true;
            this.projectUserSearchl.Location = new System.Drawing.Point(180, 83);
            this.projectUserSearchl.Name = "projectUserSearchl";
            this.projectUserSearchl.Size = new System.Drawing.Size(83, 13);
            this.projectUserSearchl.TabIndex = 10;
            this.projectUserSearchl.Text = "Assinged Expert";
            // 
            // projectStartDateSearchl
            // 
            this.projectStartDateSearchl.AutoSize = true;
            this.projectStartDateSearchl.Location = new System.Drawing.Point(27, 142);
            this.projectStartDateSearchl.Name = "projectStartDateSearchl";
            this.projectStartDateSearchl.Size = new System.Drawing.Size(58, 13);
            this.projectStartDateSearchl.TabIndex = 12;
            this.projectStartDateSearchl.Text = "Starrt Date";
            // 
            // projectStartDateSearcht
            // 
            this.projectStartDateSearcht.Location = new System.Drawing.Point(30, 164);
            this.projectStartDateSearcht.Name = "projectStartDateSearcht";
            this.projectStartDateSearcht.Size = new System.Drawing.Size(103, 20);
            this.projectStartDateSearcht.TabIndex = 11;
            // 
            // projectStatusSearchl
            // 
            this.projectStatusSearchl.AutoSize = true;
            this.projectStatusSearchl.Location = new System.Drawing.Point(28, 83);
            this.projectStatusSearchl.Name = "projectStatusSearchl";
            this.projectStatusSearchl.Size = new System.Drawing.Size(37, 13);
            this.projectStatusSearchl.TabIndex = 14;
            this.projectStatusSearchl.Text = "Status";
            // 
            // projectEndDatel
            // 
            this.projectEndDatel.AutoSize = true;
            this.projectEndDatel.Location = new System.Drawing.Point(180, 142);
            this.projectEndDatel.Name = "projectEndDatel";
            this.projectEndDatel.Size = new System.Drawing.Size(52, 13);
            this.projectEndDatel.TabIndex = 16;
            this.projectEndDatel.Text = "End Date";
            // 
            // projectEndDateSearcht
            // 
            this.projectEndDateSearcht.Location = new System.Drawing.Point(183, 164);
            this.projectEndDateSearcht.Name = "projectEndDateSearcht";
            this.projectEndDateSearcht.Size = new System.Drawing.Size(96, 20);
            this.projectEndDateSearcht.TabIndex = 15;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox1.Controls.Add(this.projectStatusSearchcb);
            this.groupBox1.Controls.Add(this.searchProjectbtn);
            this.groupBox1.Controls.Add(this.projectUserSearchcb);
            this.groupBox1.Controls.Add(this.projectNameSearchl);
            this.groupBox1.Controls.Add(this.projectStatusSearchl);
            this.groupBox1.Controls.Add(this.projectEndDatel);
            this.groupBox1.Controls.Add(this.projectNameSearcht);
            this.groupBox1.Controls.Add(this.projectStartDateSearchl);
            this.groupBox1.Controls.Add(this.projectEndDateSearcht);
            this.groupBox1.Controls.Add(this.projectStartDateSearcht);
            this.groupBox1.Controls.Add(this.projectUserSearchl);
            this.groupBox1.Controls.Add(this.projectIDSearchl);
            this.groupBox1.Controls.Add(this.projectIDSearcht);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(868, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 249);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Projects";
            // 
            // projectStatusSearchcb
            // 
            this.projectStatusSearchcb.FormattingEnabled = true;
            this.projectStatusSearchcb.Location = new System.Drawing.Point(30, 102);
            this.projectStatusSearchcb.Name = "projectStatusSearchcb";
            this.projectStatusSearchcb.Size = new System.Drawing.Size(103, 21);
            this.projectStatusSearchcb.TabIndex = 18;
            // 
            // projectUserSearchcb
            // 
            this.projectUserSearchcb.FormattingEnabled = true;
            this.projectUserSearchcb.Location = new System.Drawing.Point(183, 103);
            this.projectUserSearchcb.Name = "projectUserSearchcb";
            this.projectUserSearchcb.Size = new System.Drawing.Size(96, 21);
            this.projectUserSearchcb.TabIndex = 17;
            // 
            // pROJECTSBindingSource1
            // 
            this.pROJECTSBindingSource1.DataMember = "PROJECTS";
            this.pROJECTSBindingSource1.DataSource = this.projectManagementDBDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(30, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Create Project";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(30, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Edit Project";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button3.Location = new System.Drawing.Point(183, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete Project";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(868, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 114);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configure Projects";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(183, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Project Details";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // editProjectStatus
            // 
            this.editProjectStatus.DataPropertyName = "PROJECT_STATUS";
            this.editProjectStatus.HeaderText = "Edit Project Status";
            this.editProjectStatus.Name = "editProjectStatus";
            this.editProjectStatus.Visible = false;
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
            // pROJECTIDDataGridViewTextBoxColumn
            // 
            this.pROJECTIDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.HeaderText = "Project Code";
            this.pROJECTIDDataGridViewTextBoxColumn.Name = "pROJECTIDDataGridViewTextBoxColumn";
            // 
            // projectListGrid
            // 
            this.projectListGrid.AutoGenerateColumns = false;
            this.projectListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.projectListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.projectListGrid.ColumnHeadersHeight = 35;
            this.projectListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.projectListGrid.EnableHeadersVisualStyles = false;
            this.projectListGrid.GridColor = System.Drawing.Color.SteelBlue;
            this.projectListGrid.Location = new System.Drawing.Point(27, 18);
            this.projectListGrid.Name = "projectListGrid";
            this.projectListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.projectListGrid.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.projectListGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.projectListGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.projectListGrid.Size = new System.Drawing.Size(801, 384);
            this.projectListGrid.TabIndex = 0;
            this.projectListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectListGrid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Location = new System.Drawing.Point(846, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 437);
            this.panel1.TabIndex = 22;
            // 
            // Project_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1204, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectListGrid);
            this.Controls.Add(this.panel1);
            this.Name = "Project_List";
            this.Text = "Project_List";
            this.Load += new System.EventHandler(this.Project_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label projectNameSearchl;
        private System.Windows.Forms.TextBox projectNameSearcht;
        private System.Windows.Forms.Label projectIDSearchl;
        private System.Windows.Forms.TextBox projectIDSearcht;
        private System.Windows.Forms.Button searchProjectbtn;
        private System.Windows.Forms.Label projectUserSearchl;
        private System.Windows.Forms.Label projectStartDateSearchl;
        private System.Windows.Forms.TextBox projectStartDateSearcht;
        private System.Windows.Forms.Label projectStatusSearchl;
        private System.Windows.Forms.Label projectEndDatel;
        private System.Windows.Forms.TextBox projectEndDateSearcht;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox projectStatusSearchcb;
        private System.Windows.Forms.ComboBox projectUserSearchcb;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter eXPERTSTableAdapter;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource1;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource2;
        private System.Windows.Forms.DataGridViewButtonColumn editProjectStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTPAYPERHOURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTBEGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView projectListGrid;
        private System.Windows.Forms.Panel panel1;
    }
}