namespace ProjectManagement
{
    partial class Task_Details
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
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECT_TASKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECT_TASKSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.projectNames = new System.Windows.Forms.ComboBox();
            this.taskExpertcb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taskNamet = new System.Windows.Forms.TextBox();
            this.taskCommentrt = new System.Windows.Forms.RichTextBox();
            this.taskNamel = new System.Windows.Forms.Label();
            this.taskStatusl = new System.Windows.Forms.Label();
            this.taskDescl = new System.Windows.Forms.Label();
            this.taskStatuscb = new System.Windows.Forms.ComboBox();
            this.taskProgresst = new System.Windows.Forms.MaskedTextBox();
            this.taskHoursl = new System.Windows.Forms.Label();
            this.taskResultl = new System.Windows.Forms.Label();
            this.taskTimel = new System.Windows.Forms.Label();
            this.taskProgressl = new System.Windows.Forms.Label();
            this.taskDescrt = new System.Windows.Forms.RichTextBox();
            this.taskPrioritycb = new System.Windows.Forms.ComboBox();
            this.taskHourst = new System.Windows.Forms.MaskedTextBox();
            this.taskPriorityl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).BeginInit();
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
            // pROJECT_TASKSBindingSource
            // 
            this.pROJECT_TASKSBindingSource.DataMember = "PROJECT_TASKS";
            this.pROJECT_TASKSBindingSource.DataSource = this.projectManagementDBDataSet;
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
            // pROJECTSTableAdapter
            // 
            this.pROJECTSTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(126, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 39;
            this.label3.Text = "Task Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "Start Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(67, 509);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(117, 20);
            this.txtStartDate.TabIndex = 59;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(216, 509);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(113, 20);
            this.txtEndDate.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "End Date";
            // 
            // projectNames
            // 
            this.projectNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.projectNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectNames.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectNames.ForeColor = System.Drawing.Color.White;
            this.projectNames.FormattingEnabled = true;
            this.projectNames.Location = new System.Drawing.Point(215, 447);
            this.projectNames.MaximumSize = new System.Drawing.Size(112, 0);
            this.projectNames.MinimumSize = new System.Drawing.Size(112, 0);
            this.projectNames.Name = "projectNames";
            this.projectNames.Size = new System.Drawing.Size(112, 23);
            this.projectNames.TabIndex = 57;
            // 
            // taskExpertcb
            // 
            this.taskExpertcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskExpertcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskExpertcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskExpertcb.ForeColor = System.Drawing.SystemColors.Window;
            this.taskExpertcb.FormattingEnabled = true;
            this.taskExpertcb.Location = new System.Drawing.Point(67, 388);
            this.taskExpertcb.Name = "taskExpertcb";
            this.taskExpertcb.Size = new System.Drawing.Size(112, 21);
            this.taskExpertcb.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Expert";
            // 
            // taskNamet
            // 
            this.taskNamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskNamet.ForeColor = System.Drawing.SystemColors.Window;
            this.taskNamet.Location = new System.Drawing.Point(67, 87);
            this.taskNamet.Multiline = true;
            this.taskNamet.Name = "taskNamet";
            this.taskNamet.ReadOnly = true;
            this.taskNamet.Size = new System.Drawing.Size(260, 23);
            this.taskNamet.TabIndex = 40;
            // 
            // taskCommentrt
            // 
            this.taskCommentrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskCommentrt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskCommentrt.ForeColor = System.Drawing.SystemColors.Window;
            this.taskCommentrt.Location = new System.Drawing.Point(67, 316);
            this.taskCommentrt.Name = "taskCommentrt";
            this.taskCommentrt.ReadOnly = true;
            this.taskCommentrt.Size = new System.Drawing.Size(260, 38);
            this.taskCommentrt.TabIndex = 54;
            this.taskCommentrt.Text = "";
            // 
            // taskNamel
            // 
            this.taskNamel.AutoSize = true;
            this.taskNamel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskNamel.ForeColor = System.Drawing.Color.White;
            this.taskNamel.Location = new System.Drawing.Point(64, 63);
            this.taskNamel.Name = "taskNamel";
            this.taskNamel.Size = new System.Drawing.Size(32, 17);
            this.taskNamel.TabIndex = 41;
            this.taskNamel.Text = "Title";
            // 
            // taskStatusl
            // 
            this.taskStatusl.AutoSize = true;
            this.taskStatusl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskStatusl.ForeColor = System.Drawing.Color.White;
            this.taskStatusl.Location = new System.Drawing.Point(64, 235);
            this.taskStatusl.Name = "taskStatusl";
            this.taskStatusl.Size = new System.Drawing.Size(72, 17);
            this.taskStatusl.TabIndex = 48;
            this.taskStatusl.Text = "Task Status";
            // 
            // taskDescl
            // 
            this.taskDescl.AutoSize = true;
            this.taskDescl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskDescl.ForeColor = System.Drawing.Color.White;
            this.taskDescl.Location = new System.Drawing.Point(64, 120);
            this.taskDescl.Name = "taskDescl";
            this.taskDescl.Size = new System.Drawing.Size(74, 17);
            this.taskDescl.TabIndex = 42;
            this.taskDescl.Text = "Description";
            // 
            // taskStatuscb
            // 
            this.taskStatuscb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskStatuscb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskStatuscb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskStatuscb.ForeColor = System.Drawing.SystemColors.Window;
            this.taskStatuscb.FormattingEnabled = true;
            this.taskStatuscb.Location = new System.Drawing.Point(67, 257);
            this.taskStatuscb.Name = "taskStatuscb";
            this.taskStatuscb.Size = new System.Drawing.Size(113, 21);
            this.taskStatuscb.TabIndex = 49;
            // 
            // taskProgresst
            // 
            this.taskProgresst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskProgresst.ForeColor = System.Drawing.SystemColors.Window;
            this.taskProgresst.Location = new System.Drawing.Point(67, 447);
            this.taskProgresst.MaximumSize = new System.Drawing.Size(150, 21);
            this.taskProgresst.MinimumSize = new System.Drawing.Size(112, 21);
            this.taskProgresst.Name = "taskProgresst";
            this.taskProgresst.ReadOnly = true;
            this.taskProgresst.Size = new System.Drawing.Size(112, 21);
            this.taskProgresst.TabIndex = 51;
            // 
            // taskHoursl
            // 
            this.taskHoursl.AutoSize = true;
            this.taskHoursl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskHoursl.ForeColor = System.Drawing.Color.White;
            this.taskHoursl.Location = new System.Drawing.Point(212, 366);
            this.taskHoursl.Name = "taskHoursl";
            this.taskHoursl.Size = new System.Drawing.Size(96, 17);
            this.taskHoursl.TabIndex = 52;
            this.taskHoursl.Text = "Estimate Hours";
            this.taskHoursl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taskResultl
            // 
            this.taskResultl.AutoSize = true;
            this.taskResultl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskResultl.ForeColor = System.Drawing.Color.White;
            this.taskResultl.Location = new System.Drawing.Point(64, 296);
            this.taskResultl.Name = "taskResultl";
            this.taskResultl.Size = new System.Drawing.Size(145, 17);
            this.taskResultl.TabIndex = 44;
            this.taskResultl.Text = "Expected Result Format";
            // 
            // taskTimel
            // 
            this.taskTimel.AutoSize = true;
            this.taskTimel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskTimel.ForeColor = System.Drawing.Color.White;
            this.taskTimel.Location = new System.Drawing.Point(213, 425);
            this.taskTimel.Name = "taskTimel";
            this.taskTimel.Size = new System.Drawing.Size(48, 17);
            this.taskTimel.TabIndex = 45;
            this.taskTimel.Text = "Project";
            // 
            // taskProgressl
            // 
            this.taskProgressl.AutoSize = true;
            this.taskProgressl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskProgressl.ForeColor = System.Drawing.Color.White;
            this.taskProgressl.Location = new System.Drawing.Point(64, 425);
            this.taskProgressl.Name = "taskProgressl";
            this.taskProgressl.Size = new System.Drawing.Size(89, 17);
            this.taskProgressl.TabIndex = 50;
            this.taskProgressl.Text = "Task Progress";
            // 
            // taskDescrt
            // 
            this.taskDescrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskDescrt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskDescrt.ForeColor = System.Drawing.Color.White;
            this.taskDescrt.Location = new System.Drawing.Point(67, 142);
            this.taskDescrt.Name = "taskDescrt";
            this.taskDescrt.ReadOnly = true;
            this.taskDescrt.Size = new System.Drawing.Size(260, 80);
            this.taskDescrt.TabIndex = 43;
            this.taskDescrt.Text = "";
            // 
            // taskPrioritycb
            // 
            this.taskPrioritycb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskPrioritycb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskPrioritycb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskPrioritycb.ForeColor = System.Drawing.SystemColors.Window;
            this.taskPrioritycb.FormattingEnabled = true;
            this.taskPrioritycb.Location = new System.Drawing.Point(215, 257);
            this.taskPrioritycb.Name = "taskPrioritycb";
            this.taskPrioritycb.Size = new System.Drawing.Size(112, 21);
            this.taskPrioritycb.TabIndex = 47;
            // 
            // taskHourst
            // 
            this.taskHourst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskHourst.ForeColor = System.Drawing.SystemColors.Window;
            this.taskHourst.Location = new System.Drawing.Point(215, 387);
            this.taskHourst.MaximumSize = new System.Drawing.Size(152, 21);
            this.taskHourst.MinimumSize = new System.Drawing.Size(112, 21);
            this.taskHourst.Name = "taskHourst";
            this.taskHourst.ReadOnly = true;
            this.taskHourst.Size = new System.Drawing.Size(112, 21);
            this.taskHourst.TabIndex = 53;
            // 
            // taskPriorityl
            // 
            this.taskPriorityl.AutoSize = true;
            this.taskPriorityl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskPriorityl.ForeColor = System.Drawing.Color.White;
            this.taskPriorityl.Location = new System.Drawing.Point(212, 235);
            this.taskPriorityl.Name = "taskPriorityl";
            this.taskPriorityl.Size = new System.Drawing.Size(49, 17);
            this.taskPriorityl.TabIndex = 46;
            this.taskPriorityl.Text = "Priority";
            // 
            // Task_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(393, 582);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.projectNames);
            this.Controls.Add(this.taskExpertcb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskNamet);
            this.Controls.Add(this.taskCommentrt);
            this.Controls.Add(this.taskNamel);
            this.Controls.Add(this.taskStatusl);
            this.Controls.Add(this.taskDescl);
            this.Controls.Add(this.taskStatuscb);
            this.Controls.Add(this.taskProgresst);
            this.Controls.Add(this.taskHoursl);
            this.Controls.Add(this.taskResultl);
            this.Controls.Add(this.taskTimel);
            this.Controls.Add(this.taskProgressl);
            this.Controls.Add(this.taskDescrt);
            this.Controls.Add(this.taskPrioritycb);
            this.Controls.Add(this.taskHourst);
            this.Controls.Add(this.taskPriorityl);
            this.Controls.Add(this.label3);
            this.Name = "Task_Details";
            this.Text = "Task Details";
            this.Load += new System.EventHandler(this.Task_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECT_TASKSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter pROJECT_TASKSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox projectNames;
        private System.Windows.Forms.ComboBox taskExpertcb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskNamet;
        private System.Windows.Forms.RichTextBox taskCommentrt;
        private System.Windows.Forms.Label taskNamel;
        private System.Windows.Forms.Label taskStatusl;
        private System.Windows.Forms.Label taskDescl;
        private System.Windows.Forms.ComboBox taskStatuscb;
        private System.Windows.Forms.MaskedTextBox taskProgresst;
        private System.Windows.Forms.Label taskHoursl;
        private System.Windows.Forms.Label taskResultl;
        private System.Windows.Forms.Label taskTimel;
        private System.Windows.Forms.Label taskProgressl;
        private System.Windows.Forms.RichTextBox taskDescrt;
        private System.Windows.Forms.ComboBox taskPrioritycb;
        private System.Windows.Forms.MaskedTextBox taskHourst;
        private System.Windows.Forms.Label taskPriorityl;
    }
}