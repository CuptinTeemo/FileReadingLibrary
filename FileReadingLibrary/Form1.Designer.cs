namespace FileReadingLibrary
{
    partial class Form1
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
            this.OpenFile = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Encrypted = new System.Windows.Forms.CheckBox();
            this.RoleBasedSecurityContext = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(24, 12);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFileEvent);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(24, 41);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(752, 388);
            this.Output.TabIndex = 2;
            this.Output.Text = "";
            // 
            // Encrypted
            // 
            this.Encrypted.AutoSize = true;
            this.Encrypted.Location = new System.Drawing.Point(131, 16);
            this.Encrypted.Name = "Encrypted";
            this.Encrypted.Size = new System.Drawing.Size(74, 17);
            this.Encrypted.TabIndex = 3;
            this.Encrypted.Text = "Encrypted";
            this.Encrypted.UseVisualStyleBackColor = true;
            this.Encrypted.CheckedChanged += new System.EventHandler(this.Encrypted_CheckedChanged);
            // 
            // RoleBasedSecurityContext
            // 
            this.RoleBasedSecurityContext.AutoSize = true;
            this.RoleBasedSecurityContext.Location = new System.Drawing.Point(240, 16);
            this.RoleBasedSecurityContext.Name = "RoleBasedSecurityContext";
            this.RoleBasedSecurityContext.Size = new System.Drawing.Size(161, 17);
            this.RoleBasedSecurityContext.TabIndex = 4;
            this.RoleBasedSecurityContext.Text = "Role Based Security Context";
            this.RoleBasedSecurityContext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RoleBasedSecurityContext.UseVisualStyleBackColor = true;
            this.RoleBasedSecurityContext.CheckedChanged += new System.EventHandler(this.RoleBasedSecurityContext_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoleBasedSecurityContext);
            this.Controls.Add(this.Encrypted);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.OpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.CheckBox Encrypted;
        private System.Windows.Forms.CheckBox RoleBasedSecurityContext;
    }
}

