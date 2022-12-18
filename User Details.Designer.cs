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
            System.Windows.Forms.Label eXPERT_LASTNAMELabel;
            System.Windows.Forms.Label eXPERT_SURNAMELabel;
            System.Windows.Forms.Label eXPERT_NAMELabel;
            System.Windows.Forms.Label eXPERT_TYPELabel;
            System.Windows.Forms.Label label1;
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            this.expertsTableAdapter1 = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter();
            this.eXPERT_LASTNAMETextBox = new System.Windows.Forms.TextBox();
            this.eXPERT_SURNAMETextBox = new System.Windows.Forms.TextBox();
            this.eXPERT_NAMETextBox = new System.Windows.Forms.TextBox();
            this.eXPERT_TYPETextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            eXPERT_LASTNAMELabel = new System.Windows.Forms.Label();
            eXPERT_SURNAMELabel = new System.Windows.Forms.Label();
            eXPERT_NAMELabel = new System.Windows.Forms.Label();
            eXPERT_TYPELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eXPERT_LASTNAMELabel
            // 
            eXPERT_LASTNAMELabel.AutoSize = true;
            eXPERT_LASTNAMELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            eXPERT_LASTNAMELabel.Location = new System.Drawing.Point(581, 43);
            eXPERT_LASTNAMELabel.Name = "eXPERT_LASTNAMELabel";
            eXPERT_LASTNAMELabel.Size = new System.Drawing.Size(53, 13);
            eXPERT_LASTNAMELabel.TabIndex = 8;
            eXPERT_LASTNAMELabel.Text = "Lastname";
            // 
            // eXPERT_SURNAMELabel
            // 
            eXPERT_SURNAMELabel.AutoSize = true;
            eXPERT_SURNAMELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            eXPERT_SURNAMELabel.Location = new System.Drawing.Point(419, 43);
            eXPERT_SURNAMELabel.Name = "eXPERT_SURNAMELabel";
            eXPERT_SURNAMELabel.Size = new System.Drawing.Size(64, 13);
            eXPERT_SURNAMELabel.TabIndex = 6;
            eXPERT_SURNAMELabel.Text = "Middlename";
            // 
            // eXPERT_NAMELabel
            // 
            eXPERT_NAMELabel.AutoSize = true;
            eXPERT_NAMELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            eXPERT_NAMELabel.Location = new System.Drawing.Point(259, 43);
            eXPERT_NAMELabel.Name = "eXPERT_NAMELabel";
            eXPERT_NAMELabel.Size = new System.Drawing.Size(52, 13);
            eXPERT_NAMELabel.TabIndex = 4;
            eXPERT_NAMELabel.Text = "Firstname";
            // 
            // eXPERT_TYPELabel
            // 
            eXPERT_TYPELabel.AutoSize = true;
            eXPERT_TYPELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            eXPERT_TYPELabel.Location = new System.Drawing.Point(261, 110);
            eXPERT_TYPELabel.Name = "eXPERT_TYPELabel";
            eXPERT_TYPELabel.Size = new System.Drawing.Size(31, 13);
            eXPERT_TYPELabel.TabIndex = 2;
            eXPERT_TYPELabel.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(259, 181);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 13);
            label1.TabIndex = 10;
            label1.Text = "Assigned Projects";
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
            // eXPERT_LASTNAMETextBox
            // 
            this.eXPERT_LASTNAMETextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.eXPERT_LASTNAMETextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eXPERT_LASTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_LASTNAME", true));
            this.eXPERT_LASTNAMETextBox.ForeColor = System.Drawing.Color.White;
            this.eXPERT_LASTNAMETextBox.Location = new System.Drawing.Point(584, 63);
            this.eXPERT_LASTNAMETextBox.Multiline = true;
            this.eXPERT_LASTNAMETextBox.Name = "eXPERT_LASTNAMETextBox";
            this.eXPERT_LASTNAMETextBox.Size = new System.Drawing.Size(130, 20);
            this.eXPERT_LASTNAMETextBox.TabIndex = 9;
            // 
            // eXPERT_SURNAMETextBox
            // 
            this.eXPERT_SURNAMETextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.eXPERT_SURNAMETextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eXPERT_SURNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_SURNAME", true));
            this.eXPERT_SURNAMETextBox.ForeColor = System.Drawing.Color.White;
            this.eXPERT_SURNAMETextBox.Location = new System.Drawing.Point(422, 63);
            this.eXPERT_SURNAMETextBox.Multiline = true;
            this.eXPERT_SURNAMETextBox.Name = "eXPERT_SURNAMETextBox";
            this.eXPERT_SURNAMETextBox.Size = new System.Drawing.Size(130, 20);
            this.eXPERT_SURNAMETextBox.TabIndex = 7;
            // 
            // eXPERT_NAMETextBox
            // 
            this.eXPERT_NAMETextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.eXPERT_NAMETextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eXPERT_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_NAME", true));
            this.eXPERT_NAMETextBox.ForeColor = System.Drawing.Color.White;
            this.eXPERT_NAMETextBox.Location = new System.Drawing.Point(262, 63);
            this.eXPERT_NAMETextBox.Multiline = true;
            this.eXPERT_NAMETextBox.Name = "eXPERT_NAMETextBox";
            this.eXPERT_NAMETextBox.Size = new System.Drawing.Size(130, 20);
            this.eXPERT_NAMETextBox.TabIndex = 5;
            // 
            // eXPERT_TYPETextBox
            // 
            this.eXPERT_TYPETextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.eXPERT_TYPETextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eXPERT_TYPETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_TYPE", true));
            this.eXPERT_TYPETextBox.ForeColor = System.Drawing.Color.White;
            this.eXPERT_TYPETextBox.Location = new System.Drawing.Point(264, 130);
            this.eXPERT_TYPETextBox.Multiline = true;
            this.eXPERT_TYPETextBox.Name = "eXPERT_TYPETextBox";
            this.eXPERT_TYPETextBox.Size = new System.Drawing.Size(130, 20);
            this.eXPERT_TYPETextBox.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_TYPE", true));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(262, 202);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(-54, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 309);
            this.panel1.TabIndex = 12;
            // 
            // User_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(812, 272);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(eXPERT_TYPELabel);
            this.Controls.Add(this.eXPERT_TYPETextBox);
            this.Controls.Add(eXPERT_NAMELabel);
            this.Controls.Add(this.eXPERT_NAMETextBox);
            this.Controls.Add(eXPERT_LASTNAMELabel);
            this.Controls.Add(this.eXPERT_SURNAMETextBox);
            this.Controls.Add(eXPERT_SURNAMELabel);
            this.Controls.Add(this.eXPERT_LASTNAMETextBox);
            this.Name = "User_Details";
            this.Text = "User_Details";
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
        private System.Windows.Forms.TextBox eXPERT_LASTNAMETextBox;
        private System.Windows.Forms.TextBox eXPERT_SURNAMETextBox;
        private System.Windows.Forms.TextBox eXPERT_NAMETextBox;
        private System.Windows.Forms.TextBox eXPERT_TYPETextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}