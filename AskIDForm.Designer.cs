namespace ProjectManagement
{
    partial class AskIDForm
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
            this.askIDt = new System.Windows.Forms.TextBox();
            this.askIDl = new System.Windows.Forms.Label();
            this.askIDOkbtn = new System.Windows.Forms.Button();
            this.askIDCancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // askIDt
            // 
            this.askIDt.Location = new System.Drawing.Point(89, 33);
            this.askIDt.Name = "askIDt";
            this.askIDt.Size = new System.Drawing.Size(100, 20);
            this.askIDt.TabIndex = 0;
            // 
            // askIDl
            // 
            this.askIDl.AutoSize = true;
            this.askIDl.Location = new System.Drawing.Point(51, 36);
            this.askIDl.Name = "askIDl";
            this.askIDl.Size = new System.Drawing.Size(18, 13);
            this.askIDl.TabIndex = 1;
            this.askIDl.Text = "ID";
            // 
            // askIDOkbtn
            // 
            this.askIDOkbtn.Location = new System.Drawing.Point(227, 33);
            this.askIDOkbtn.Name = "askIDOkbtn";
            this.askIDOkbtn.Size = new System.Drawing.Size(75, 23);
            this.askIDOkbtn.TabIndex = 2;
            this.askIDOkbtn.Text = "OK";
            this.askIDOkbtn.UseVisualStyleBackColor = true;
            this.askIDOkbtn.Click += new System.EventHandler(this.askIDOkbtn_Click);
            // 
            // askIDCancelbtn
            // 
            this.askIDCancelbtn.Location = new System.Drawing.Point(322, 33);
            this.askIDCancelbtn.Name = "askIDCancelbtn";
            this.askIDCancelbtn.Size = new System.Drawing.Size(75, 23);
            this.askIDCancelbtn.TabIndex = 3;
            this.askIDCancelbtn.Text = "Cancel";
            this.askIDCancelbtn.UseVisualStyleBackColor = true;
            this.askIDCancelbtn.Click += new System.EventHandler(this.askIDCancelbtn_Click);
            // 
            // AskIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 83);
            this.Controls.Add(this.askIDCancelbtn);
            this.Controls.Add(this.askIDOkbtn);
            this.Controls.Add(this.askIDl);
            this.Controls.Add(this.askIDt);
            this.Name = "AskIDForm";
            this.Text = "AskIDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox askIDt;
        private System.Windows.Forms.Label askIDl;
        private System.Windows.Forms.Button askIDOkbtn;
        private System.Windows.Forms.Button askIDCancelbtn;
    }
}