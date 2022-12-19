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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            pSTATUS_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_STATUSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pSTATUS_IDLabel
            // 
            pSTATUS_IDLabel.AutoSize = true;
            pSTATUS_IDLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            pSTATUS_IDLabel.ForeColor = System.Drawing.Color.White;
            pSTATUS_IDLabel.Location = new System.Drawing.Point(45, 82);
            pSTATUS_IDLabel.Name = "pSTATUS_IDLabel";
            pSTATUS_IDLabel.Size = new System.Drawing.Size(87, 17);
            pSTATUS_IDLabel.TabIndex = 1;
            pSTATUS_IDLabel.Text = "Project Status";
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
            this.projectStatusSavebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.projectStatusSavebtn.FlatAppearance.BorderSize = 0;
            this.projectStatusSavebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectStatusSavebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectStatusSavebtn.ForeColor = System.Drawing.Color.White;
            this.projectStatusSavebtn.Location = new System.Drawing.Point(113, 154);
            this.projectStatusSavebtn.Name = "projectStatusSavebtn";
            this.projectStatusSavebtn.Size = new System.Drawing.Size(70, 29);
            this.projectStatusSavebtn.TabIndex = 5;
            this.projectStatusSavebtn.Text = "Save";
            this.projectStatusSavebtn.UseVisualStyleBackColor = false;
            this.projectStatusSavebtn.Click += new System.EventHandler(this.projectStatusSavebtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(46, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Edit Project Status";
            // 
            // Edit_Project_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(303, 224);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(pSTATUS_IDLabel);
            this.Controls.Add(this.projectStatusSavebtn);
            this.Name = "Edit_Project_Status";
            this.Text = "Edit Project Status";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}