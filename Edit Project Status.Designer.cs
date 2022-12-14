namespace ProjectManagement
{
    partial class Edit_Project_Status
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
            System.Windows.Forms.Label pSTATUS_IDLabel;
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECT_STATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECT_STATUSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECT_STATUSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.projectStatusSavebtn = new System.Windows.Forms.Button();
            this.projectStatusCancelbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            pSTATUS_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_STATUSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectManagementDBDataSet
            // 
            this.projectManagementDBDataSet.DataSetName = "ProjectManagementDBDataSet";
            this.projectManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJECT_STATUSBindingSource
            // 
            this.pROJECT_STATUSBindingSource.DataMember = "PROJECT_STATUS";
            this.pROJECT_STATUSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // pROJECT_STATUSTableAdapter
            // 
            this.pROJECT_STATUSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXPERTSTableAdapter = null;
            this.tableAdapterManager.PROJECT_STATUSTableAdapter = this.pROJECT_STATUSTableAdapter;
            this.tableAdapterManager.PROJECT_TASKSTableAdapter = null;
            this.tableAdapterManager.PROJECTSTableAdapter = null;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // projectStatusSavebtn
            // 
            this.projectStatusSavebtn.Location = new System.Drawing.Point(22, 75);
            this.projectStatusSavebtn.Name = "projectStatusSavebtn";
            this.projectStatusSavebtn.Size = new System.Drawing.Size(70, 23);
            this.projectStatusSavebtn.TabIndex = 5;
            this.projectStatusSavebtn.Text = "Save";
            this.projectStatusSavebtn.UseVisualStyleBackColor = true;
            this.projectStatusSavebtn.Click += new System.EventHandler(this.projectStatusSavebtn_Click);
            // 
            // projectStatusCancelbtn
            // 
            this.projectStatusCancelbtn.Location = new System.Drawing.Point(109, 75);
            this.projectStatusCancelbtn.Name = "projectStatusCancelbtn";
            this.projectStatusCancelbtn.Size = new System.Drawing.Size(70, 23);
            this.projectStatusCancelbtn.TabIndex = 6;
            this.projectStatusCancelbtn.Text = "Cancel";
            this.projectStatusCancelbtn.UseVisualStyleBackColor = true;
            this.projectStatusCancelbtn.Click += new System.EventHandler(this.projectStatusCancelbtn_Click);
            // 
            // pSTATUS_IDLabel
            // 
            pSTATUS_IDLabel.AutoSize = true;
            pSTATUS_IDLabel.Location = new System.Drawing.Point(19, 18);
            pSTATUS_IDLabel.Name = "pSTATUS_IDLabel";
            pSTATUS_IDLabel.Size = new System.Drawing.Size(73, 13);
            pSTATUS_IDLabel.TabIndex = 1;
            pSTATUS_IDLabel.Text = "Project Status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Edit_Project_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 120);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(pSTATUS_IDLabel);
            this.Controls.Add(this.projectStatusCancelbtn);
            this.Controls.Add(this.projectStatusSavebtn);
            this.Name = "Edit_Project_Status";
            this.Text = "Edit_Project_Status";
            this.Load += new System.EventHandler(this.Edit_Project_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_STATUSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECT_STATUSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECT_STATUSTableAdapter pROJECT_STATUSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button projectStatusSavebtn;
        private System.Windows.Forms.Button projectStatusCancelbtn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}