namespace ProjectManagement
{
    partial class User_Details
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
            System.Windows.Forms.Label eXPERT_TYPELabel;
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            this.expertsTableAdapter1 = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter();
            this.typet = new System.Windows.Forms.TextBox();
            this.firstnamet = new System.Windows.Forms.TextBox();
            this.firstnamel = new System.Windows.Forms.Label();
            this.lastnamet = new System.Windows.Forms.TextBox();
            this.surnamet = new System.Windows.Forms.TextBox();
            this.surnamel = new System.Windows.Forms.Label();
            this.lastnamel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            eXPERT_TYPELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eXPERT_TYPELabel
            // 
            eXPERT_TYPELabel.AutoSize = true;
            eXPERT_TYPELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            eXPERT_TYPELabel.Location = new System.Drawing.Point(106, 260);
            eXPERT_TYPELabel.Name = "eXPERT_TYPELabel";
            eXPERT_TYPELabel.Size = new System.Drawing.Size(31, 13);
            eXPERT_TYPELabel.TabIndex = 2;
            eXPERT_TYPELabel.Text = "Type";
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
            // pROJECTSBindingSource
            // 
            this.pROJECTSBindingSource.DataMember = "PROJECTS";
            this.pROJECTSBindingSource.DataSource = this.projectManagementDBDataSet;
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
            this.tableAdapterManager.PROJECTSTableAdapter = this.pROJECTSTableAdapter;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROJECTSTableAdapter
            // 
            this.pROJECTSTableAdapter.ClearBeforeFill = true;
            // 
            // expertsTableAdapter1
            // 
            this.expertsTableAdapter1.ClearBeforeFill = true;
            // 
            // typet
            // 
            this.typet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.typet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_TYPE", true));
            this.typet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.typet.ForeColor = System.Drawing.Color.White;
            this.typet.Location = new System.Drawing.Point(109, 280);
            this.typet.Multiline = true;
            this.typet.Name = "typet";
            this.typet.ReadOnly = true;
            this.typet.Size = new System.Drawing.Size(199, 24);
            this.typet.TabIndex = 3;
            // 
            // firstnamet
            // 
            this.firstnamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.firstnamet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnamet.ForeColor = System.Drawing.Color.White;
            this.firstnamet.Location = new System.Drawing.Point(109, 102);
            this.firstnamet.Multiline = true;
            this.firstnamet.Name = "firstnamet";
            this.firstnamet.ReadOnly = true;
            this.firstnamet.Size = new System.Drawing.Size(199, 24);
            this.firstnamet.TabIndex = 12;
            // 
            // firstnamel
            // 
            this.firstnamel.AutoSize = true;
            this.firstnamel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnamel.ForeColor = System.Drawing.Color.White;
            this.firstnamel.Location = new System.Drawing.Point(106, 78);
            this.firstnamel.Name = "firstnamel";
            this.firstnamel.Size = new System.Drawing.Size(64, 17);
            this.firstnamel.TabIndex = 13;
            this.firstnamel.Text = "Firstname";
            // 
            // lastnamet
            // 
            this.lastnamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lastnamet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnamet.ForeColor = System.Drawing.Color.White;
            this.lastnamet.Location = new System.Drawing.Point(109, 223);
            this.lastnamet.Multiline = true;
            this.lastnamet.Name = "lastnamet";
            this.lastnamet.ReadOnly = true;
            this.lastnamet.Size = new System.Drawing.Size(199, 24);
            this.lastnamet.TabIndex = 16;
            // 
            // surnamet
            // 
            this.surnamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.surnamet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnamet.ForeColor = System.Drawing.Color.White;
            this.surnamet.Location = new System.Drawing.Point(109, 163);
            this.surnamet.Multiline = true;
            this.surnamet.Name = "surnamet";
            this.surnamet.ReadOnly = true;
            this.surnamet.Size = new System.Drawing.Size(199, 24);
            this.surnamet.TabIndex = 14;
            // 
            // surnamel
            // 
            this.surnamel.AutoSize = true;
            this.surnamel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnamel.ForeColor = System.Drawing.Color.White;
            this.surnamel.Location = new System.Drawing.Point(106, 139);
            this.surnamel.Name = "surnamel";
            this.surnamel.Size = new System.Drawing.Size(59, 17);
            this.surnamel.TabIndex = 15;
            this.surnamel.Text = "Surname";
            // 
            // lastnamel
            // 
            this.lastnamel.AutoSize = true;
            this.lastnamel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnamel.ForeColor = System.Drawing.Color.White;
            this.lastnamel.Location = new System.Drawing.Point(106, 200);
            this.lastnamel.Name = "lastnamel";
            this.lastnamel.Size = new System.Drawing.Size(63, 17);
            this.lastnamel.TabIndex = 17;
            this.lastnamel.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(132, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "User Details";
            // 
            // User_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(405, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstnamet);
            this.Controls.Add(this.firstnamel);
            this.Controls.Add(this.lastnamet);
            this.Controls.Add(this.surnamet);
            this.Controls.Add(this.surnamel);
            this.Controls.Add(this.lastnamel);
            this.Controls.Add(eXPERT_TYPELabel);
            this.Controls.Add(this.typet);
            this.Name = "User_Details";
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.User_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter eXPERTSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter expertsTableAdapter1;
        private System.Windows.Forms.TextBox typet;
        private System.Windows.Forms.TextBox firstnamet;
        private System.Windows.Forms.Label firstnamel;
        private System.Windows.Forms.TextBox lastnamet;
        private System.Windows.Forms.TextBox surnamet;
        private System.Windows.Forms.Label surnamel;
        private System.Windows.Forms.Label lastnamel;
        private System.Windows.Forms.Label label3;
    }
}