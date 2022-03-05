
namespace AHAFit_UI
{
    partial class LoginForm
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
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.LinkLabel();
            this.txtLoginFormEmail = new System.Windows.Forms.TextBox();
            this.txtLoginFormPassword = new System.Windows.Forms.TextBox();
            this.btnLoginFormLogIn = new System.Windows.Forms.Button();
            this.chkLoginFormShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Location = new System.Drawing.Point(37, 72);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(43, 15);
            this.lblLoginEmail.TabIndex = 0;
            this.lblLoginEmail.Text = "E-Mail";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(37, 119);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(61, 15);
            this.lblLoginPassword.TabIndex = 1;
            this.lblLoginPassword.Text = "Password";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Location = new System.Drawing.Point(37, 186);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(51, 15);
            this.lblSignUp.TabIndex = 2;
            this.lblSignUp.TabStop = true;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSignUp_LinkClicked);
            // 
            // txtLoginFormEmail
            // 
            this.txtLoginFormEmail.Location = new System.Drawing.Point(142, 72);
            this.txtLoginFormEmail.Name = "txtLoginFormEmail";
            this.txtLoginFormEmail.Size = new System.Drawing.Size(133, 20);
            this.txtLoginFormEmail.TabIndex = 3;
            // 
            // txtLoginFormPassword
            // 
            this.txtLoginFormPassword.Location = new System.Drawing.Point(142, 119);
            this.txtLoginFormPassword.Name = "txtLoginFormPassword";
            this.txtLoginFormPassword.PasswordChar = '*';
            this.txtLoginFormPassword.Size = new System.Drawing.Size(133, 20);
            this.txtLoginFormPassword.TabIndex = 4;
            // 
            // btnLoginFormLogIn
            // 
            this.btnLoginFormLogIn.Location = new System.Drawing.Point(200, 181);
            this.btnLoginFormLogIn.Name = "btnLoginFormLogIn";
            this.btnLoginFormLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLoginFormLogIn.TabIndex = 5;
            this.btnLoginFormLogIn.Text = "Log In";
            this.btnLoginFormLogIn.UseVisualStyleBackColor = true;
            this.btnLoginFormLogIn.Click += new System.EventHandler(this.btnLoginFormLogIn_Click);
            // 
            // chkLoginFormShowPassword
            // 
            this.chkLoginFormShowPassword.AutoSize = true;
            this.chkLoginFormShowPassword.Location = new System.Drawing.Point(142, 148);
            this.chkLoginFormShowPassword.Name = "chkLoginFormShowPassword";
            this.chkLoginFormShowPassword.Size = new System.Drawing.Size(114, 19);
            this.chkLoginFormShowPassword.TabIndex = 6;
            this.chkLoginFormShowPassword.Text = "Show Password";
            this.chkLoginFormShowPassword.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 298);
            this.Controls.Add(this.chkLoginFormShowPassword);
            this.Controls.Add(this.btnLoginFormLogIn);
            this.Controls.Add(this.txtLoginFormPassword);
            this.Controls.Add(this.txtLoginFormEmail);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginEmail);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.LinkLabel lblSignUp;
        private System.Windows.Forms.TextBox txtLoginFormEmail;
        private System.Windows.Forms.TextBox txtLoginFormPassword;
        private System.Windows.Forms.Button btnLoginFormLogIn;
        private System.Windows.Forms.CheckBox chkLoginFormShowPassword;
    }
}