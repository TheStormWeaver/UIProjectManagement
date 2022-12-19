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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pROJECT_TASKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECT_TASKSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // taskListGrid
            // 
            this.taskListGrid.AutoGenerateColumns = false;
            this.taskListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.taskListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.taskListGrid.ColumnHeadersHeight = 42;
            this.taskListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.tASKHOURSDataGridViewTextBoxColumn,
            this.Details,
            this.Edit,
            this.Delete});
            this.taskListGrid.DataSource = this.pROJECT_TASKSBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.taskListGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.taskListGrid.EnableHeadersVisualStyles = false;
            this.taskListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.taskListGrid.Location = new System.Drawing.Point(33, 79);
            this.taskListGrid.Name = "taskListGrid";
            this.taskListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.taskListGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.taskListGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.taskListGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.taskListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskListGrid.Size = new System.Drawing.Size(1201, 317);
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
            // Details
            // 
            this.Details.DataPropertyName = "TASK_ID";
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
            this.Edit.DataPropertyName = "TASK_ID";
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
            this.Delete.DataPropertyName = "TASK_ID";
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1131, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Create Task";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "List of Tasks";
            // 
            // Task_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1260, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.taskListGrid);
            this.Name = "Task_List";
            this.Text = "Task List";
            this.Load += new System.EventHandler(this.Task_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView taskListGrid;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECT_TASKSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter pROJECT_TASKSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}