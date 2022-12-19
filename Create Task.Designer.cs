namespace ProjectManagement
{
    partial class Create_Task
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
            this.taskNamet = new System.Windows.Forms.TextBox();
            this.taskNamel = new System.Windows.Forms.Label();
            this.taskDescl = new System.Windows.Forms.Label();
            this.taskDescrt = new System.Windows.Forms.RichTextBox();
            this.taskResultl = new System.Windows.Forms.Label();
            this.taskResultcb = new System.Windows.Forms.ComboBox();
            this.taskTimel = new System.Windows.Forms.Label();
            this.taskTimedt = new System.Windows.Forms.DateTimePicker();
            this.taskPrioritycb = new System.Windows.Forms.ComboBox();
            this.taskPriorityl = new System.Windows.Forms.Label();
            this.taskStatuscb = new System.Windows.Forms.ComboBox();
            this.taskStatusl = new System.Windows.Forms.Label();
            this.taskProgressl = new System.Windows.Forms.Label();
            this.taskProgresst = new System.Windows.Forms.MaskedTextBox();
            this.taskHourst = new System.Windows.Forms.MaskedTextBox();
            this.taskHoursl = new System.Windows.Forms.Label();
            this.taskCommentrt = new System.Windows.Forms.RichTextBox();
            this.taskCommentl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.taskExpertcb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskNamet
            // 
            this.taskNamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskNamet.ForeColor = System.Drawing.SystemColors.Window;
            this.taskNamet.Location = new System.Drawing.Point(85, 91);
            this.taskNamet.Multiline = true;
            this.taskNamet.Name = "taskNamet";
            this.taskNamet.Size = new System.Drawing.Size(260, 23);
            this.taskNamet.TabIndex = 0;
            this.taskNamet.TextChanged += new System.EventHandler(this.taskNamet_TextChanged);
            // 
            // taskNamel
            // 
            this.taskNamel.AutoSize = true;
            this.taskNamel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskNamel.ForeColor = System.Drawing.Color.White;
            this.taskNamel.Location = new System.Drawing.Point(82, 67);
            this.taskNamel.Name = "taskNamel";
            this.taskNamel.Size = new System.Drawing.Size(32, 17);
            this.taskNamel.TabIndex = 1;
            this.taskNamel.Text = "Title";
            // 
            // taskDescl
            // 
            this.taskDescl.AutoSize = true;
            this.taskDescl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskDescl.ForeColor = System.Drawing.Color.White;
            this.taskDescl.Location = new System.Drawing.Point(82, 124);
            this.taskDescl.Name = "taskDescl";
            this.taskDescl.Size = new System.Drawing.Size(74, 17);
            this.taskDescl.TabIndex = 3;
            this.taskDescl.Text = "Description";
            // 
            // taskDescrt
            // 
            this.taskDescrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskDescrt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskDescrt.Location = new System.Drawing.Point(85, 146);
            this.taskDescrt.Name = "taskDescrt";
            this.taskDescrt.Size = new System.Drawing.Size(260, 80);
            this.taskDescrt.TabIndex = 4;
            this.taskDescrt.Text = "";
            this.taskDescrt.TextChanged += new System.EventHandler(this.taskDescrt_TextChanged);
            // 
            // taskResultl
            // 
            this.taskResultl.AutoSize = true;
            this.taskResultl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskResultl.ForeColor = System.Drawing.Color.White;
            this.taskResultl.Location = new System.Drawing.Point(82, 300);
            this.taskResultl.Name = "taskResultl";
            this.taskResultl.Size = new System.Drawing.Size(145, 17);
            this.taskResultl.TabIndex = 6;
            this.taskResultl.Text = "Expected Result Format";
            // 
            // taskResultcb
            // 
            this.taskResultcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskResultcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskResultcb.FormattingEnabled = true;
            this.taskResultcb.Location = new System.Drawing.Point(85, 325);
            this.taskResultcb.Name = "taskResultcb";
            this.taskResultcb.Size = new System.Drawing.Size(260, 21);
            this.taskResultcb.TabIndex = 7;
            // 
            // taskTimel
            // 
            this.taskTimel.AutoSize = true;
            this.taskTimel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskTimel.ForeColor = System.Drawing.Color.White;
            this.taskTimel.Location = new System.Drawing.Point(230, 420);
            this.taskTimel.Name = "taskTimel";
            this.taskTimel.Size = new System.Drawing.Size(88, 17);
            this.taskTimel.TabIndex = 8;
            this.taskTimel.Text = "Creation Date";
            // 
            // taskTimedt
            // 
            this.taskTimedt.Location = new System.Drawing.Point(233, 441);
            this.taskTimedt.Name = "taskTimedt";
            this.taskTimedt.Size = new System.Drawing.Size(114, 20);
            this.taskTimedt.TabIndex = 10;
            // 
            // taskPrioritycb
            // 
            this.taskPrioritycb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskPrioritycb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskPrioritycb.FormattingEnabled = true;
            this.taskPrioritycb.Location = new System.Drawing.Point(233, 261);
            this.taskPrioritycb.Name = "taskPrioritycb";
            this.taskPrioritycb.Size = new System.Drawing.Size(112, 21);
            this.taskPrioritycb.TabIndex = 12;
            // 
            // taskPriorityl
            // 
            this.taskPriorityl.AutoSize = true;
            this.taskPriorityl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskPriorityl.ForeColor = System.Drawing.Color.White;
            this.taskPriorityl.Location = new System.Drawing.Point(230, 239);
            this.taskPriorityl.Name = "taskPriorityl";
            this.taskPriorityl.Size = new System.Drawing.Size(49, 17);
            this.taskPriorityl.TabIndex = 11;
            this.taskPriorityl.Text = "Priority";
            // 
            // taskStatuscb
            // 
            this.taskStatuscb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskStatuscb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskStatuscb.FormattingEnabled = true;
            this.taskStatuscb.Location = new System.Drawing.Point(85, 261);
            this.taskStatuscb.Name = "taskStatuscb";
            this.taskStatuscb.Size = new System.Drawing.Size(113, 21);
            this.taskStatuscb.TabIndex = 14;
            // 
            // taskStatusl
            // 
            this.taskStatusl.AutoSize = true;
            this.taskStatusl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskStatusl.ForeColor = System.Drawing.Color.White;
            this.taskStatusl.Location = new System.Drawing.Point(82, 239);
            this.taskStatusl.Name = "taskStatusl";
            this.taskStatusl.Size = new System.Drawing.Size(72, 17);
            this.taskStatusl.TabIndex = 13;
            this.taskStatusl.Text = "Task Status";
            // 
            // taskProgressl
            // 
            this.taskProgressl.AutoSize = true;
            this.taskProgressl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskProgressl.ForeColor = System.Drawing.Color.White;
            this.taskProgressl.Location = new System.Drawing.Point(82, 420);
            this.taskProgressl.Name = "taskProgressl";
            this.taskProgressl.Size = new System.Drawing.Size(89, 17);
            this.taskProgressl.TabIndex = 15;
            this.taskProgressl.Text = "Task Progress";
            // 
            // taskProgresst
            // 
            this.taskProgresst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskProgresst.ForeColor = System.Drawing.SystemColors.Window;
            this.taskProgresst.Location = new System.Drawing.Point(85, 442);
            this.taskProgresst.MaximumSize = new System.Drawing.Size(150, 21);
            this.taskProgresst.MinimumSize = new System.Drawing.Size(112, 21);
            this.taskProgresst.Name = "taskProgresst";
            this.taskProgresst.Size = new System.Drawing.Size(112, 20);
            this.taskProgresst.TabIndex = 16;
            // 
            // taskHourst
            // 
            this.taskHourst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskHourst.ForeColor = System.Drawing.SystemColors.Window;
            this.taskHourst.Location = new System.Drawing.Point(233, 382);
            this.taskHourst.MaximumSize = new System.Drawing.Size(152, 21);
            this.taskHourst.MinimumSize = new System.Drawing.Size(112, 21);
            this.taskHourst.Name = "taskHourst";
            this.taskHourst.Size = new System.Drawing.Size(112, 20);
            this.taskHourst.TabIndex = 18;
            // 
            // taskHoursl
            // 
            this.taskHoursl.AutoSize = true;
            this.taskHoursl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskHoursl.ForeColor = System.Drawing.Color.White;
            this.taskHoursl.Location = new System.Drawing.Point(230, 361);
            this.taskHoursl.Name = "taskHoursl";
            this.taskHoursl.Size = new System.Drawing.Size(96, 17);
            this.taskHoursl.TabIndex = 17;
            this.taskHoursl.Text = "Estimate Hours";
            this.taskHoursl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taskCommentrt
            // 
            this.taskCommentrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskCommentrt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskCommentrt.Location = new System.Drawing.Point(85, 505);
            this.taskCommentrt.Name = "taskCommentrt";
            this.taskCommentrt.Size = new System.Drawing.Size(260, 80);
            this.taskCommentrt.TabIndex = 20;
            this.taskCommentrt.Text = "";
            // 
            // taskCommentl
            // 
            this.taskCommentl.AutoSize = true;
            this.taskCommentl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskCommentl.ForeColor = System.Drawing.Color.White;
            this.taskCommentl.Location = new System.Drawing.Point(82, 480);
            this.taskCommentl.Name = "taskCommentl";
            this.taskCommentl.Size = new System.Drawing.Size(93, 17);
            this.taskCommentl.TabIndex = 19;
            this.taskCommentl.Text = "Task Comment";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(160, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Create Task";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(129, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Task Creation";
            // 
            // taskExpertcb
            // 
            this.taskExpertcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.taskExpertcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskExpertcb.FormattingEnabled = true;
            this.taskExpertcb.Location = new System.Drawing.Point(85, 383);
            this.taskExpertcb.Name = "taskExpertcb";
            this.taskExpertcb.Size = new System.Drawing.Size(112, 21);
            this.taskExpertcb.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Expert";
            // 
            // Create_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(441, 662);
            this.Controls.Add(this.taskExpertcb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskNamet);
            this.Controls.Add(this.button1);
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
            this.Name = "Create_Task";
            this.Text = "Create Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taskNamet;
        private System.Windows.Forms.Label taskNamel;
        private System.Windows.Forms.Label taskDescl;
        private System.Windows.Forms.RichTextBox taskDescrt;
        private System.Windows.Forms.Label taskResultl;
        private System.Windows.Forms.ComboBox taskResultcb;
        private System.Windows.Forms.Label taskTimel;
        private System.Windows.Forms.DateTimePicker taskTimedt;
        private System.Windows.Forms.ComboBox taskPrioritycb;
        private System.Windows.Forms.Label taskPriorityl;
        private System.Windows.Forms.ComboBox taskStatuscb;
        private System.Windows.Forms.Label taskStatusl;
        private System.Windows.Forms.Label taskProgressl;
        private System.Windows.Forms.MaskedTextBox taskProgresst;
        private System.Windows.Forms.MaskedTextBox taskHourst;
        private System.Windows.Forms.Label taskHoursl;
        private System.Windows.Forms.RichTextBox taskCommentrt;
        private System.Windows.Forms.Label taskCommentl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox taskExpertcb;
        private System.Windows.Forms.Label label1;
    }
}