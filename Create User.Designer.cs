namespace ProjectManagement
{
    partial class User
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
            this.firstnamel = new System.Windows.Forms.Label();
            this.firstnamet = new System.Windows.Forms.TextBox();
            this.surnamel = new System.Windows.Forms.Label();
            this.surnamet = new System.Windows.Forms.TextBox();
            this.lastnamel = new System.Windows.Forms.Label();
            this.lastnamet = new System.Windows.Forms.TextBox();
            this.typel = new System.Windows.Forms.Label();
            this.typecb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // firstnamet
            // 
            this.firstnamet.Location = new System.Drawing.Point(26, 46);
            this.firstnamet.Name = "firstnamet";
            this.firstnamet.Size = new System.Drawing.Size(86, 20);
            this.firstnamet.TabIndex = 2;
            // 
            // surnamel
            // 
            this.surnamel.AutoSize = true;
            this.surnamel.Location = new System.Drawing.Point(128, 24);
            this.surnamel.Name = "surnamel";
            this.surnamel.Size = new System.Drawing.Size(49, 13);
            this.surnamel.TabIndex = 5;
            this.surnamel.Text = "Surname";
            // 
            // surnamet
            // 
            this.surnamet.Location = new System.Drawing.Point(131, 45);
            this.surnamet.Name = "surnamet";
            this.surnamet.Size = new System.Drawing.Size(84, 20);
            this.surnamet.TabIndex = 4;
            // 
            // lastnamel
            // 
            this.lastnamel.AutoSize = true;
            this.lastnamel.Location = new System.Drawing.Point(232, 27);
            this.lastnamel.Name = "lastnamel";
            this.lastnamel.Size = new System.Drawing.Size(53, 13);
            this.lastnamel.TabIndex = 7;
            this.lastnamel.Text = "Lastname";
            this.lastnamel.Click += new System.EventHandler(this.lastnamel_Click);
            // 
            // lastnamet
            // 
            this.lastnamet.Location = new System.Drawing.Point(235, 45);
            this.lastnamet.Name = "lastnamet";
            this.lastnamet.Size = new System.Drawing.Size(78, 20);
            this.lastnamet.TabIndex = 6;
            this.lastnamet.TextChanged += new System.EventHandler(this.lastnamet_TextChanged);
            // 
            // typel
            // 
            this.typel.AutoSize = true;
            this.typel.Location = new System.Drawing.Point(23, 85);
            this.typel.Name = "typel";
            this.typel.Size = new System.Drawing.Size(31, 13);
            this.typel.TabIndex = 9;
            this.typel.Text = "Type";
            this.typel.Click += new System.EventHandler(this.typel_Click);
            // 
            // typecb
            // 
            this.typecb.FormattingEnabled = true;
            this.typecb.Location = new System.Drawing.Point(26, 106);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(86, 21);
            this.typecb.TabIndex = 10;
            this.typecb.SelectedIndexChanged += new System.EventHandler(this.typecb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstnamet);
            this.groupBox1.Controls.Add(this.typecb);
            this.groupBox1.Controls.Add(this.firstnamel);
            this.groupBox1.Controls.Add(this.typel);
            this.groupBox1.Controls.Add(this.surnamet);
            this.groupBox1.Controls.Add(this.lastnamel);
            this.groupBox1.Controls.Add(this.surnamel);
            this.groupBox1.Controls.Add(this.lastnamet);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 148);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Creation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Create User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "User";
            this.Text = "User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label firstnamel;
        private System.Windows.Forms.TextBox firstnamet;
        private System.Windows.Forms.Label surnamel;
        private System.Windows.Forms.TextBox surnamet;
        private System.Windows.Forms.Label lastnamel;
        private System.Windows.Forms.TextBox lastnamet;
        private System.Windows.Forms.Label typel;
        private System.Windows.Forms.ComboBox typecb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}