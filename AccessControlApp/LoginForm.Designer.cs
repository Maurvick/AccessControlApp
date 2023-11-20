namespace AccessControlApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lbUsername = new Label();
            lbPassword = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(159, 155);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(453, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(159, 241);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(453, 27);
            txtPassword.TabIndex = 1;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(159, 119);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 2;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(159, 209);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(159, 297);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(396, 297);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(216, 29);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lbUsername;
        private Label lbPassword;
        private Button btnLogin;
        private Button btnRegister;
    }
}
