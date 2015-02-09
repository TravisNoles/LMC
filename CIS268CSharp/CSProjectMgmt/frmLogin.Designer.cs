namespace CSProjectMgmt
{
    partial class frmLogin
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTimeSheetTitle = new System.Windows.Forms.Label();
            this.cmd_login = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(16, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(156, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(16, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            // 
            // lblTimeSheetTitle
            // 
            this.lblTimeSheetTitle.AutoSize = true;
            this.lblTimeSheetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSheetTitle.Location = new System.Drawing.Point(23, 9);
            this.lblTimeSheetTitle.Name = "lblTimeSheetTitle";
            this.lblTimeSheetTitle.Size = new System.Drawing.Size(149, 20);
            this.lblTimeSheetTitle.TabIndex = 4;
            this.lblTimeSheetTitle.Text = "Time Sheet Login";
            // 
            // cmd_login
            // 
            this.cmd_login.Location = new System.Drawing.Point(16, 117);
            this.cmd_login.Name = "cmd_login";
            this.cmd_login.Size = new System.Drawing.Size(75, 23);
            this.cmd_login.TabIndex = 5;
            this.cmd_login.Text = "Login";
            this.cmd_login.UseVisualStyleBackColor = true;
            this.cmd_login.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Forgot?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 185);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmd_login);
            this.Controls.Add(this.lblTimeSheetTitle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLogin";
            this.Text = "TimeSheet - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTimeSheetTitle;
        private System.Windows.Forms.Button cmd_login;
        private System.Windows.Forms.Button button2;
    }
}

