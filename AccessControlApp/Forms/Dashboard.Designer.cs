namespace AccessControlApp.Access
{
    partial class Dashboard
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
            lstUsers = new ListView();
            btnRegister = new Button();
            btnDelete = new Button();
            btnGrantAccess = new Button();
            lblUserSettings = new Label();
            lblUserList = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lstUsers
            // 
            lstUsers.Location = new Point(15, 32);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(241, 406);
            lstUsers.TabIndex = 0;
            lstUsers.UseCompatibleStateImageBehavior = false;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(534, 84);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(147, 29);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(534, 119);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnGrantAccess
            // 
            btnGrantAccess.Location = new Point(534, 154);
            btnGrantAccess.Name = "btnGrantAccess";
            btnGrantAccess.Size = new Size(147, 29);
            btnGrantAccess.TabIndex = 3;
            btnGrantAccess.Text = "Grant access";
            btnGrantAccess.UseVisualStyleBackColor = true;
            // 
            // lblUserSettings
            // 
            lblUserSettings.AutoSize = true;
            lblUserSettings.Location = new Point(535, 53);
            lblUserSettings.Name = "lblUserSettings";
            lblUserSettings.Size = new Size(93, 20);
            lblUserSettings.TabIndex = 4;
            lblUserSettings.Text = "User settings";
            // 
            // lblUserList
            // 
            lblUserList.AutoSize = true;
            lblUserList.Location = new Point(15, 9);
            lblUserList.Name = "lblUserList";
            lblUserList.Size = new Size(61, 20);
            lblUserList.TabIndex = 5;
            lblUserList.Text = "User list";
            // 
            // button1
            // 
            button1.Location = new Point(534, 189);
            button1.Name = "button1";
            button1.Size = new Size(147, 29);
            button1.TabIndex = 6;
            button1.Text = "Journal";
            button1.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblUserList);
            Controls.Add(lblUserSettings);
            Controls.Add(btnGrantAccess);
            Controls.Add(btnDelete);
            Controls.Add(btnRegister);
            Controls.Add(lstUsers);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstUsers;
        private Button btnRegister;
        private Button btnDelete;
        private Button btnGrantAccess;
        private Label lblUserSettings;
        private Label lblUserList;
        private Button button1;
    }
}