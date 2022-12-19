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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.pROJECTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTBEGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editProjectStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.searchProjectbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchProjectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProjectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProjectbtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchProjectbtn.Location = new System.Drawing.Point(714, 77);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            this.editProjectStatus,
            this.Details,
            this.Edit,
            this.Delete});
            this.projectListGrid.DataSource = this.pROJECTSBindingSource;
            this.projectListGrid.EnableHeadersVisualStyles = false;
            this.projectListGrid.GridColor = System.Drawing.Color.SteelBlue;
            this.projectListGrid.Location = new System.Drawing.Point(24, 216);
            this.projectListGrid.Name = "projectListGrid";
            this.projectListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.projectListGrid.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.projectListGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.projectListGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.projectListGrid.Size = new System.Drawing.Size(1098, 390);
            this.projectListGrid.TabIndex = 0;
            this.projectListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectListGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "List of Projects";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(589, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(369, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(96, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(477, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(587, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(255, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "End Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(139, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Starrt Date";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(366, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Assinged Expert";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Project Code";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(24, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox1.Controls.Add(this.projectStatusSearchcb);
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
            this.groupBox1.Location = new System.Drawing.Point(20, 36);
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
            // projectNameSearchl
            // 
            this.projectNameSearchl.AutoSize = true;
            this.projectNameSearchl.Location = new System.Drawing.Point(180, 25);
            this.projectNameSearchl.Name = "projectNameSearchl";
            this.projectNameSearchl.Size = new System.Drawing.Size(35, 13);
            this.projectNameSearchl.TabIndex = 7;
            this.projectNameSearchl.Text = "Name";
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
            // projectNameSearcht
            // 
            this.projectNameSearcht.Location = new System.Drawing.Point(183, 49);
            this.projectNameSearcht.Name = "projectNameSearcht";
            this.projectNameSearcht.Size = new System.Drawing.Size(96, 20);
            this.projectNameSearcht.TabIndex = 6;
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
            // projectEndDateSearcht
            // 
            this.projectEndDateSearcht.Location = new System.Drawing.Point(183, 164);
            this.projectEndDateSearcht.Name = "projectEndDateSearcht";
            this.projectEndDateSearcht.Size = new System.Drawing.Size(96, 20);
            this.projectEndDateSearcht.TabIndex = 15;
            // 
            // projectStartDateSearcht
            // 
            this.projectStartDateSearcht.Location = new System.Drawing.Point(30, 164);
            this.projectStartDateSearcht.Name = "projectStartDateSearcht";
            this.projectStartDateSearcht.Size = new System.Drawing.Size(103, 20);
            this.projectStartDateSearcht.TabIndex = 11;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1128, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 636);
            this.panel1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(997, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add New Project";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Details
            // 
            this.Details.DataPropertyName = "PROJECT_ID";
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.Text = "Edit";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "PROJECT_ID";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "PROJECT_ID";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // Project_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1480, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchProjectbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.projectListGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTBEGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTPAYPERHOURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editProjectStatus;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}