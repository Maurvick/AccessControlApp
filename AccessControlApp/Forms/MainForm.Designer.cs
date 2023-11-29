namespace AccessControlApp.Forms
{
    partial class MainForm
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
            btnLogin = new Button();
            btnRegister = new Button();
            btnDashboard = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(26, 194);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 38);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(217, 194);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(165, 38);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(403, 194);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(165, 38);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Control Panel";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnControlPanel_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(584, 194);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(165, 38);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogOut);
            Controls.Add(btnDashboard);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private Button btnDashboard;
        private Button btnLogOut;
    }
}