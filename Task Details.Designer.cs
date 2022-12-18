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
            this.taskNamet = new System.Windows.Forms.TextBox();
            this.taskCommentrt = new System.Windows.Forms.RichTextBox();
            this.taskNamel = new System.Windows.Forms.Label();
            this.taskCommentl = new System.Windows.Forms.Label();
            this.taskDescl = new System.Windows.Forms.Label();
            this.taskProgresst = new System.Windows.Forms.MaskedTextBox();
            this.taskResultl = new System.Windows.Forms.Label();
            this.taskProgressl = new System.Windows.Forms.Label();
            this.taskResultcb = new System.Windows.Forms.ComboBox();
            this.taskPrioritycb = new System.Windows.Forms.ComboBox();
            this.taskPriorityl = new System.Windows.Forms.Label();
            this.taskHourst = new System.Windows.Forms.MaskedTextBox();
            this.taskDescrt = new System.Windows.Forms.RichTextBox();
            this.taskTimedt = new System.Windows.Forms.DateTimePicker();
            this.taskTimel = new System.Windows.Forms.Label();
            this.taskHoursl = new System.Windows.Forms.Label();
            this.taskStatuscb = new System.Windows.Forms.ComboBox();
            this.taskStatusl = new System.Windows.Forms.Label();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECT_TASKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECT_TASKSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // taskNamet
            // 
            this.taskNamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.taskNamet.ForeColor = System.Drawing.Color.White;
            this.taskNamet.Location = new System.Drawing.Point(72, 50);
            this.taskNamet.Multiline = true;
            this.taskNamet.Name = "taskNamet";
            this.taskNamet.Size = new System.Drawing.Size(269, 20);
            this.taskNamet.TabIndex = 21;
            // 
            // taskCommentrt
            // 
            this.taskCommentrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.taskCommentrt.ForeColor = System.Drawing.Color.White;
            this.taskCommentrt.Location = new System.Drawing.Point(72, 478);
            this.taskCommentrt.Name = "taskCommentrt";
            this.taskCommentrt.Size = new System.Drawing.Size(260, 96);
            this.taskCommentrt.TabIndex = 38;
            this.taskCommentrt.Text = "";
            // 
            // taskNamel
            // 
            this.taskNamel.AutoSize = true;
            this.taskNamel.ForeColor = System.Drawing.Color.White;
            this.taskNamel.Location = new System.Drawing.Point(69, 34);
            this.taskNamel.Name = "taskNamel";
            this.taskNamel.Size = new System.Drawing.Size(27, 13);
            this.taskNamel.TabIndex = 22;
            this.taskNamel.Text = "Title";
            // 
            // taskCommentl
            // 
            this.taskCommentl.AutoSize = true;
            this.taskCommentl.ForeColor = System.Drawing.Color.White;
            this.taskCommentl.Location = new System.Drawing.Point(70, 462);
            this.taskCommentl.Name = "taskCommentl";
            this.taskCommentl.Size = new System.Drawing.Size(78, 13);
            this.taskCommentl.TabIndex = 37;
            this.taskCommentl.Text = "Task Comment";
            // 
            // taskDescl
            // 
            this.taskDescl.AutoSize = true;
            this.taskDescl.ForeColor = System.Drawing.Color.White;
            this.taskDescl.Location = new System.Drawing.Point(69, 84);
            this.taskDescl.Name = "taskDescl";
            this.taskDescl.Size = new System.Drawing.Size(60, 13);
            this.taskDescl.TabIndex = 23;
            this.taskDescl.Text = "Description";
            // 
            // taskProgresst
            // 
            this.taskProgresst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.taskProgresst.ForeColor = System.Drawing.Color.White;
            this.taskProgresst.Location = new System.Drawing.Point(72, 425);
            this.taskProgresst.MinimumSize = new System.Drawing.Size(100, 20);
            this.taskProgresst.Name = "taskProgresst";
            this.taskProgresst.Size = new System.Drawing.Size(120, 20);
            this.taskProgresst.TabIndex = 34;
            // 
            // taskResultl
            // 
            this.taskResultl.AutoSize = true;
            this.taskResultl.ForeColor = System.Drawing.Color.White;
            this.taskResultl.Location = new System.Drawing.Point(72, 271);
            this.taskResultl.Name = "taskResultl";
            this.taskResultl.Size = new System.Drawing.Size(120, 13);
            this.taskResultl.TabIndex = 25;
            this.taskResultl.Text = "Expected Result Format";
            // 
            // taskProgressl
            // 
            this.taskProgressl.AutoSize = true;
            this.taskProgressl.ForeColor = System.Drawing.Color.White;
            this.taskProgressl.Location = new System.Drawing.Point(72, 405);
            this.taskProgressl.Name = "taskProgressl";
            this.taskProgressl.Size = new System.Drawing.Size(75, 13);
            this.taskProgressl.TabIndex = 33;
            this.taskProgressl.Text = "Task Progress";
            // 
            // taskResultcb
            // 
            this.taskResultcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.taskResultcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskResultcb.FormattingEnabled = true;
            this.taskResultcb.Location = new System.Drawing.Point(72, 293);
            this.taskResultcb.Name = "taskResultcb";
            this.taskResultcb.Size = new System.Drawing.Size(269, 21);
            this.taskResultcb.TabIndex = 26;
            // 
            // taskPrioritycb
            // 
            this.taskPrioritycb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.taskPrioritycb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskPrioritycb.ForeColor = System.Drawing.Color.White;
            this.taskPrioritycb.FormattingEnabled = true;
            this.taskPrioritycb.Location = new System.Drawing.Point(226, 233);
            this.taskPrioritycb.Name = "taskPrioritycb";
            this.taskPrioritycb.Size = new System.Drawing.Size(115, 21);
            this.taskPrioritycb.TabIndex = 30;
            // 
            // taskPriorityl
            // 
            this.taskPriorityl.AutoSize = true;
            this.taskPriorityl.ForeColor = System.Drawing.Color.White;
            this.taskPriorityl.Location = new System.Drawing.Point(223, 210);
            this.taskPriorityl.Name = "taskPriorityl";
            this.taskPriorityl.Size = new System.Drawing.Size(38, 13);
            this.taskPriorityl.TabIndex = 29;
            this.taskPriorityl.Text = "Priority";
            // 
            // taskHourst
            // 
            this.taskHourst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.taskHourst.ForeColor = System.Drawing.Color.White;
            this.taskHourst.Location = new System.Drawing.Point(226, 360);
            this.taskHourst.MaximumSize = new System.Drawing.Size(120, 20);
            this.taskHourst.MinimumSize = new System.Drawing.Size(100, 20);
            this.taskHourst.Name = "taskHourst";
            this.taskHourst.Size = new System.Drawing.Size(115, 20);
            this.taskHourst.TabIndex = 36;
            // 
            // taskDescrt
            // 
            this.taskDescrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.taskDescrt.ForeColor = System.Drawing.Color.White;
            this.taskDescrt.Location = new System.Drawing.Point(72, 100);
            this.taskDescrt.Name = "taskDescrt";
            this.taskDescrt.Size = new System.Drawing.Size(269, 96);
            this.taskDescrt.TabIndex = 24;
            this.taskDescrt.Text = "";
            // 
            // taskTimedt
            // 
            this.taskTimedt.CalendarForeColor = System.Drawing.Color.White;
            this.taskTimedt.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskTimedt.CalendarTitleBackColor = System.Drawing.Color.Aqua;
            this.taskTimedt.CalendarTitleForeColor = System.Drawing.Color.White;
            this.taskTimedt.CalendarTrailingForeColor = System.Drawing.Color.DodgerBlue;
            this.taskTimedt.Location = new System.Drawing.Point(72, 360);
            this.taskTimedt.Name = "taskTimedt";
            this.taskTimedt.Size = new System.Drawing.Size(120, 20);
            this.taskTimedt.TabIndex = 28;
            // 
            // taskTimel
            // 
            this.taskTimel.AutoSize = true;
            this.taskTimel.ForeColor = System.Drawing.Color.White;
            this.taskTimel.Location = new System.Drawing.Point(72, 332);
            this.taskTimel.Name = "taskTimel";
            this.taskTimel.Size = new System.Drawing.Size(72, 13);
            this.taskTimel.TabIndex = 27;
            this.taskTimel.Text = "Creation Date";
            // 
            // taskHoursl
            // 
            this.taskHoursl.AutoSize = true;
            this.taskHoursl.ForeColor = System.Drawing.Color.White;
            this.taskHoursl.Location = new System.Drawing.Point(223, 332);
            this.taskHoursl.Name = "taskHoursl";
            this.taskHoursl.Size = new System.Drawing.Size(78, 13);
            this.taskHoursl.TabIndex = 35;
            this.taskHoursl.Text = "Estimate Hours";
            this.taskHoursl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taskStatuscb
            // 
            this.taskStatuscb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.taskStatuscb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskStatuscb.ForeColor = System.Drawing.Color.White;
            this.taskStatuscb.FormattingEnabled = true;
            this.taskStatuscb.Location = new System.Drawing.Point(73, 233);
            this.taskStatuscb.Name = "taskStatuscb";
            this.taskStatuscb.Size = new System.Drawing.Size(119, 21);
            this.taskStatuscb.TabIndex = 32;
            // 
            // taskStatusl
            // 
            this.taskStatusl.AutoSize = true;
            this.taskStatusl.ForeColor = System.Drawing.Color.White;
            this.taskStatusl.Location = new System.Drawing.Point(69, 210);
            this.taskStatusl.Name = "taskStatusl";
            this.taskStatusl.Size = new System.Drawing.Size(64, 13);
            this.taskStatusl.TabIndex = 31;
            this.taskStatusl.Text = "Task Status";
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
            // Task_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(415, 629);
            this.Controls.Add(this.taskNamet);
            this.Controls.Add(this.taskCommentrt);
            this.Controls.Add(this.taskNamel);
            this.Controls.Add(this.taskCommentl);
            this.Controls.Add(this.taskStatusl);
            this.Controls.Add(this.taskDescl);
            this.Controls.Add(this.taskStatuscb);
            this.Controls.Add(this.taskProgresst);
            this.Controls.Add(this.taskHoursl);
            this.Controls.Add(this.taskResultl);
            this.Controls.Add(this.taskTimel);
            this.Controls.Add(this.taskProgressl);
            this.Controls.Add(this.taskTimedt);
            this.Controls.Add(this.taskResultcb);
            this.Controls.Add(this.taskDescrt);
            this.Controls.Add(this.taskPrioritycb);
            this.Controls.Add(this.taskHourst);
            this.Controls.Add(this.taskPriorityl);
            this.Name = "Task_Details";
            this.Text = "Task_Details";
            this.Load += new System.EventHandler(this.Task_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox taskNamet;
        private System.Windows.Forms.RichTextBox taskCommentrt;
        private System.Windows.Forms.Label taskNamel;
        private System.Windows.Forms.Label taskCommentl;
        private System.Windows.Forms.Label taskDescl;
        private System.Windows.Forms.MaskedTextBox taskProgresst;
        private System.Windows.Forms.Label taskResultl;
        private System.Windows.Forms.Label taskProgressl;
        private System.Windows.Forms.ComboBox taskResultcb;
        private System.Windows.Forms.ComboBox taskPrioritycb;
        private System.Windows.Forms.Label taskPriorityl;
        private System.Windows.Forms.MaskedTextBox taskHourst;
        private System.Windows.Forms.RichTextBox taskDescrt;
        private System.Windows.Forms.DateTimePicker taskTimedt;
        private System.Windows.Forms.Label taskTimel;
        private System.Windows.Forms.Label taskHoursl;
        private System.Windows.Forms.ComboBox taskStatuscb;
        private System.Windows.Forms.Label taskStatusl;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECT_TASKSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter pROJECT_TASKSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
    }
}