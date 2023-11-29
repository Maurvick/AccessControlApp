namespace AccessControlApp
{
    partial class RegisterForm
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
            lblUsername = new Label();
            lblPassword = new Label();
            btnRegister = new Button();
            comboAccessLevel = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblAccessLevel = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(159, 105);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(453, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(159, 189);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(453, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(159, 82);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(159, 152);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(257, 355);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(262, 30);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // comboAccessLevel
            // 
            comboAccessLevel.FormattingEnabled = true;
            comboAccessLevel.Items.AddRange(new object[] { "E", "A" });
            comboAccessLevel.Location = new Point(159, 273);
            comboAccessLevel.Name = "comboAccessLevel";
            comboAccessLevel.Size = new Size(453, 28);
            comboAccessLevel.TabIndex = 5;
            // 
            // lblAccessLevel
            // 
            lblAccessLevel.AutoSize = true;
            lblAccessLevel.Location = new Point(159, 237);
            lblAccessLevel.Name = "lblAccessLevel";
            lblAccessLevel.Size = new Size(91, 20);
            lblAccessLevel.TabIndex = 6;
            lblAccessLevel.Text = "Access Level";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAccessLevel);
            Controls.Add(comboAccessLevel);
            Controls.Add(btnRegister);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnRegister;
        private ComboBox comboAccessLevel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblAccessLevel;
    }
}
