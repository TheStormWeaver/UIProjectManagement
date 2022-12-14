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
            this.userListGrid = new System.Windows.Forms.DataGridView();
            this.eXPRETIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.eXPERTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchProjectbtn = new System.Windows.Forms.Button();
            this.firstnamet = new System.Windows.Forms.TextBox();
            this.typecb = new System.Windows.Forms.ComboBox();
            this.firstnamel = new System.Windows.Forms.Label();
            this.typel = new System.Windows.Forms.Label();
            this.surnamet = new System.Windows.Forms.TextBox();
            this.lastnamel = new System.Windows.Forms.Label();
            this.surnamel = new System.Windows.Forms.Label();
            this.lastnamet = new System.Windows.Forms.TextBox();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            this.pROJECT_TASKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECT_TASKSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userListGrid
            // 
            this.userListGrid.AutoGenerateColumns = false;
            this.userListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eXPRETIDDataGridViewTextBoxColumn,
            this.eXPERTNAMEDataGridViewTextBoxColumn,
            this.eXPERTSURNAMEDataGridViewTextBoxColumn,
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn,
            this.eXPERTTYPEDataGridViewTextBoxColumn});
            this.userListGrid.DataSource = this.eXPERTSBindingSource;
            this.userListGrid.Location = new System.Drawing.Point(12, 20);
            this.userListGrid.Name = "userListGrid";
            this.userListGrid.Size = new System.Drawing.Size(445, 305);
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
            // 
            // eXPERTSURNAMEDataGridViewTextBoxColumn
            // 
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_SURNAME";
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.Name = "eXPERTSURNAMEDataGridViewTextBoxColumn";
            // 
            // eXPERTLASTNAMEDataGridViewTextBoxColumn
            // 
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_LASTNAME";
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.Name = "eXPERTLASTNAMEDataGridViewTextBoxColumn";
            // 
            // eXPERTTYPEDataGridViewTextBoxColumn
            // 
            this.eXPERTTYPEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_TYPE";
            this.eXPERTTYPEDataGridViewTextBoxColumn.HeaderText = "Type";
            this.eXPERTTYPEDataGridViewTextBoxColumn.Name = "eXPERTTYPEDataGridViewTextBoxColumn";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchProjectbtn);
            this.groupBox1.Controls.Add(this.firstnamet);
            this.groupBox1.Controls.Add(this.typecb);
            this.groupBox1.Controls.Add(this.firstnamel);
            this.groupBox1.Controls.Add(this.typel);
            this.groupBox1.Controls.Add(this.surnamet);
            this.groupBox1.Controls.Add(this.lastnamel);
            this.groupBox1.Controls.Add(this.surnamel);
            this.groupBox1.Controls.Add(this.lastnamet);
            this.groupBox1.Location = new System.Drawing.Point(481, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 178);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Users";
            // 
            // searchProjectbtn
            // 
            this.searchProjectbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchProjectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProjectbtn.ForeColor = System.Drawing.Color.Black;
            this.searchProjectbtn.Location = new System.Drawing.Point(26, 136);
            this.searchProjectbtn.Name = "searchProjectbtn";
            this.searchProjectbtn.Size = new System.Drawing.Size(103, 27);
            this.searchProjectbtn.TabIndex = 13;
            this.searchProjectbtn.Text = "Search For Users";
            this.searchProjectbtn.UseVisualStyleBackColor = false;
            // 
            // firstnamet
            // 
            this.firstnamet.Location = new System.Drawing.Point(26, 46);
            this.firstnamet.Name = "firstnamet";
            this.firstnamet.Size = new System.Drawing.Size(103, 20);
            this.firstnamet.TabIndex = 2;
            // 
            // typecb
            // 
            this.typecb.FormattingEnabled = true;
            this.typecb.Location = new System.Drawing.Point(164, 98);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(103, 21);
            this.typecb.TabIndex = 10;
            // 
            // firstnamel
            // 
            this.firstnamel.AutoSize = true;
            this.firstnamel.Location = new System.Drawing.Point(23, 27);
            this.firstnamel.Name = "firstnamel";
            this.firstnamel.Size = new System.Drawing.Size(52, 13);
            this.firstnamel.TabIndex = 3;
            this.firstnamel.Text = "Firstname";
            // 
            // typel
            // 
            this.typel.AutoSize = true;
            this.typel.Location = new System.Drawing.Point(161, 78);
            this.typel.Name = "typel";
            this.typel.Size = new System.Drawing.Size(31, 13);
            this.typel.TabIndex = 9;
            this.typel.Text = "Type";
            // 
            // surnamet
            // 
            this.surnamet.Location = new System.Drawing.Point(164, 45);
            this.surnamet.Name = "surnamet";
            this.surnamet.Size = new System.Drawing.Size(103, 20);
            this.surnamet.TabIndex = 4;
            // 
            // lastnamel
            // 
            this.lastnamel.AutoSize = true;
            this.lastnamel.Location = new System.Drawing.Point(23, 78);
            this.lastnamel.Name = "lastnamel";
            this.lastnamel.Size = new System.Drawing.Size(53, 13);
            this.lastnamel.TabIndex = 7;
            this.lastnamel.Text = "Lastname";
            // 
            // surnamel
            // 
            this.surnamel.AutoSize = true;
            this.surnamel.Location = new System.Drawing.Point(161, 27);
            this.surnamel.Name = "surnamel";
            this.surnamel.Size = new System.Drawing.Size(49, 13);
            this.surnamel.TabIndex = 5;
            this.surnamel.Text = "Surname";
            // 
            // lastnamet
            // 
            this.lastnamet.Location = new System.Drawing.Point(26, 97);
            this.lastnamet.Name = "lastnamet";
            this.lastnamet.Size = new System.Drawing.Size(103, 20);
            this.lastnamet.TabIndex = 6;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(481, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 114);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configure Users";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "User Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Create Users";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete Users";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Edit Users";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // User_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userListGrid);
            this.Name = "User_List";
            this.Text = "User_List";
            this.Load += new System.EventHandler(this.User_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userListGrid;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter eXPERTSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox firstnamet;
        private System.Windows.Forms.ComboBox typecb;
        private System.Windows.Forms.Label firstnamel;
        private System.Windows.Forms.Label typel;
        private System.Windows.Forms.TextBox surnamet;
        private System.Windows.Forms.Label lastnamel;
        private System.Windows.Forms.Label surnamel;
        private System.Windows.Forms.TextBox lastnamet;
        private System.Windows.Forms.Button searchProjectbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPRETIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTLASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private System.Windows.Forms.BindingSource pROJECT_TASKSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter pROJECT_TASKSTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}