namespace ProjectManagement
{
    partial class Task_List
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
            this.taskListGrid = new System.Windows.Forms.DataGridView();
            this.tASKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPRETIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASDELIVERABLESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKBEGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKPRIORITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKREADYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKHOURSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECT_TASKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECT_TASKSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.taskCommentl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.taskCommentrt = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskListGrid
            // 
            this.taskListGrid.AutoGenerateColumns = false;
            this.taskListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tASKIDDataGridViewTextBoxColumn,
            this.pROJECTIDDataGridViewTextBoxColumn,
            this.eXPRETIDDataGridViewTextBoxColumn,
            this.tASKNAMEDataGridViewTextBoxColumn,
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn,
            this.tASDELIVERABLESDataGridViewTextBoxColumn,
            this.tASKBEGINDataGridViewTextBoxColumn,
            this.tASKENDDataGridViewTextBoxColumn,
            this.tASKPRIORITYDataGridViewTextBoxColumn,
            this.tASKSTATUSDataGridViewTextBoxColumn,
            this.tASKREADYDataGridViewTextBoxColumn,
            this.tASKHOURSDataGridViewTextBoxColumn});
            this.taskListGrid.DataSource = this.pROJECT_TASKSBindingSource;
            this.taskListGrid.Location = new System.Drawing.Point(31, 19);
            this.taskListGrid.Name = "taskListGrid";
            this.taskListGrid.Size = new System.Drawing.Size(943, 416);
            this.taskListGrid.TabIndex = 0;
            // 
            // tASKIDDataGridViewTextBoxColumn
            // 
            this.tASKIDDataGridViewTextBoxColumn.DataPropertyName = "TASK_ID";
            this.tASKIDDataGridViewTextBoxColumn.HeaderText = "TASK_ID";
            this.tASKIDDataGridViewTextBoxColumn.Name = "tASKIDDataGridViewTextBoxColumn";
            this.tASKIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROJECTIDDataGridViewTextBoxColumn
            // 
            this.pROJECTIDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.HeaderText = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.Name = "pROJECTIDDataGridViewTextBoxColumn";
            this.pROJECTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // eXPRETIDDataGridViewTextBoxColumn
            // 
            this.eXPRETIDDataGridViewTextBoxColumn.DataPropertyName = "EXPRET_ID";
            this.eXPRETIDDataGridViewTextBoxColumn.HeaderText = "EXPRET_ID";
            this.eXPRETIDDataGridViewTextBoxColumn.Name = "eXPRETIDDataGridViewTextBoxColumn";
            this.eXPRETIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tASKNAMEDataGridViewTextBoxColumn
            // 
            this.tASKNAMEDataGridViewTextBoxColumn.DataPropertyName = "TASK_NAME";
            this.tASKNAMEDataGridViewTextBoxColumn.HeaderText = "Task Name";
            this.tASKNAMEDataGridViewTextBoxColumn.Name = "tASKNAMEDataGridViewTextBoxColumn";
            // 
            // tASKDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "TASK_DESCRIPTION";
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Task Description";
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn.Name = "tASKDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // tASDELIVERABLESDataGridViewTextBoxColumn
            // 
            this.tASDELIVERABLESDataGridViewTextBoxColumn.DataPropertyName = "TAS_DELIVERABLES";
            this.tASDELIVERABLESDataGridViewTextBoxColumn.HeaderText = "Result Format";
            this.tASDELIVERABLESDataGridViewTextBoxColumn.Name = "tASDELIVERABLESDataGridViewTextBoxColumn";
            // 
            // tASKBEGINDataGridViewTextBoxColumn
            // 
            this.tASKBEGINDataGridViewTextBoxColumn.DataPropertyName = "TASK_BEGIN";
            this.tASKBEGINDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.tASKBEGINDataGridViewTextBoxColumn.Name = "tASKBEGINDataGridViewTextBoxColumn";
            // 
            // tASKENDDataGridViewTextBoxColumn
            // 
            this.tASKENDDataGridViewTextBoxColumn.DataPropertyName = "TASK_END";
            this.tASKENDDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.tASKENDDataGridViewTextBoxColumn.Name = "tASKENDDataGridViewTextBoxColumn";
            // 
            // tASKPRIORITYDataGridViewTextBoxColumn
            // 
            this.tASKPRIORITYDataGridViewTextBoxColumn.DataPropertyName = "TASK_PRIORITY";
            this.tASKPRIORITYDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.tASKPRIORITYDataGridViewTextBoxColumn.Name = "tASKPRIORITYDataGridViewTextBoxColumn";
            // 
            // tASKSTATUSDataGridViewTextBoxColumn
            // 
            this.tASKSTATUSDataGridViewTextBoxColumn.DataPropertyName = "TASK_STATUS";
            this.tASKSTATUSDataGridViewTextBoxColumn.HeaderText = "Status";
            this.tASKSTATUSDataGridViewTextBoxColumn.Name = "tASKSTATUSDataGridViewTextBoxColumn";
            // 
            // tASKREADYDataGridViewTextBoxColumn
            // 
            this.tASKREADYDataGridViewTextBoxColumn.DataPropertyName = "TASK_READY";
            this.tASKREADYDataGridViewTextBoxColumn.HeaderText = "Progress";
            this.tASKREADYDataGridViewTextBoxColumn.Name = "tASKREADYDataGridViewTextBoxColumn";
            // 
            // tASKHOURSDataGridViewTextBoxColumn
            // 
            this.tASKHOURSDataGridViewTextBoxColumn.DataPropertyName = "TASK_HOURS";
            this.tASKHOURSDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.tASKHOURSDataGridViewTextBoxColumn.Name = "tASKHOURSDataGridViewTextBoxColumn";
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
            // taskCommentl
            // 
            this.taskCommentl.AutoSize = true;
            this.taskCommentl.Location = new System.Drawing.Point(23, 149);
            this.taskCommentl.Name = "taskCommentl";
            this.taskCommentl.Size = new System.Drawing.Size(51, 13);
            this.taskCommentl.TabIndex = 21;
            this.taskCommentl.Text = "Comment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.taskCommentl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.taskCommentrt);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Location = new System.Drawing.Point(1002, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 285);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Task";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Contributor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taskCommentrt
            // 
            this.taskCommentrt.Location = new System.Drawing.Point(26, 173);
            this.taskCommentrt.Name = "taskCommentrt";
            this.taskCommentrt.Size = new System.Drawing.Size(241, 96);
            this.taskCommentrt.TabIndex = 22;
            this.taskCommentrt.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Number Of Tasks";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(30, 116);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(99, 21);
            this.comboBox4.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(1002, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 114);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configure Tasks";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Task Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Create Tasks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete Tasks";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Edit Tasks";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Task_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.taskListGrid);
            this.Name = "Task_List";
            this.Text = "Task_List";
            this.Load += new System.EventHandler(this.Task_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView taskListGrid;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECT_TASKSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter pROJECT_TASKSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label taskCommentl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPRETIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASDELIVERABLESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKBEGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKPRIORITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKREADYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKHOURSDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox taskCommentrt;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}