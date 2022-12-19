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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstnamel
            // 
            this.firstnamel.AutoSize = true;
            this.firstnamel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnamel.ForeColor = System.Drawing.Color.White;
            this.firstnamel.Location = new System.Drawing.Point(110, 71);
            this.firstnamel.Name = "firstnamel";
            this.firstnamel.Size = new System.Drawing.Size(64, 17);
            this.firstnamel.TabIndex = 3;
            this.firstnamel.Text = "Firstname";
            // 
            // firstnamet
            // 
            this.firstnamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.firstnamet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnamet.ForeColor = System.Drawing.Color.White;
            this.firstnamet.Location = new System.Drawing.Point(113, 95);
            this.firstnamet.Multiline = true;
            this.firstnamet.Name = "firstnamet";
            this.firstnamet.Size = new System.Drawing.Size(164, 24);
            this.firstnamet.TabIndex = 2;
            // 
            // surnamel
            // 
            this.surnamel.AutoSize = true;
            this.surnamel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnamel.ForeColor = System.Drawing.Color.White;
            this.surnamel.Location = new System.Drawing.Point(110, 132);
            this.surnamel.Name = "surnamel";
            this.surnamel.Size = new System.Drawing.Size(59, 17);
            this.surnamel.TabIndex = 5;
            this.surnamel.Text = "Surname";
            // 
            // surnamet
            // 
            this.surnamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.surnamet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnamet.ForeColor = System.Drawing.Color.White;
            this.surnamet.Location = new System.Drawing.Point(113, 156);
            this.surnamet.Multiline = true;
            this.surnamet.Name = "surnamet";
            this.surnamet.Size = new System.Drawing.Size(162, 24);
            this.surnamet.TabIndex = 4;
            // 
            // lastnamel
            // 
            this.lastnamel.AutoSize = true;
            this.lastnamel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnamel.ForeColor = System.Drawing.Color.White;
            this.lastnamel.Location = new System.Drawing.Point(110, 193);
            this.lastnamel.Name = "lastnamel";
            this.lastnamel.Size = new System.Drawing.Size(63, 17);
            this.lastnamel.TabIndex = 7;
            this.lastnamel.Text = "Lastname";
            this.lastnamel.Click += new System.EventHandler(this.lastnamel_Click);
            // 
            // lastnamet
            // 
            this.lastnamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lastnamet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnamet.ForeColor = System.Drawing.Color.White;
            this.lastnamet.Location = new System.Drawing.Point(113, 216);
            this.lastnamet.Multiline = true;
            this.lastnamet.Name = "lastnamet";
            this.lastnamet.Size = new System.Drawing.Size(162, 24);
            this.lastnamet.TabIndex = 6;
            this.lastnamet.TextChanged += new System.EventHandler(this.lastnamet_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(144, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 24;
            this.button1.Text = "Create User";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(110, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "User Creation";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(387, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstnamet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstnamel);
            this.Controls.Add(this.lastnamet);
            this.Controls.Add(this.surnamet);
            this.Controls.Add(this.surnamel);
            this.Controls.Add(this.lastnamel);
            this.Name = "User";
            this.Text = "Create User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnamel;
        private System.Windows.Forms.TextBox firstnamet;
        private System.Windows.Forms.Label surnamel;
        private System.Windows.Forms.TextBox surnamet;
        private System.Windows.Forms.Label lastnamel;
        private System.Windows.Forms.TextBox lastnamet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}