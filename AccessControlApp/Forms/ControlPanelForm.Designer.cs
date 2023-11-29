namespace AccessControlApp.Access
{
    partial class ControlPanelForm
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
            btnUserLog = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // lstUsers
            // 
            lstUsers.Location = new Point(392, 117);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(380, 259);
            lstUsers.TabIndex = 0;
            lstUsers.UseCompatibleStateImageBehavior = false;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 117);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(166, 47);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 170);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 47);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnGrantAccess
            // 
            btnGrantAccess.Location = new Point(12, 276);
            btnGrantAccess.Name = "btnGrantAccess";
            btnGrantAccess.Size = new Size(166, 47);
            btnGrantAccess.TabIndex = 3;
            btnGrantAccess.Text = "Grant access";
            btnGrantAccess.UseVisualStyleBackColor = true;
            // 
            // lblUserSettings
            // 
            lblUserSettings.AutoSize = true;
            lblUserSettings.Location = new Point(12, 94);
            lblUserSettings.Name = "lblUserSettings";
            lblUserSettings.Size = new Size(93, 20);
            lblUserSettings.TabIndex = 4;
            lblUserSettings.Text = "User settings";
            // 
            // lblUserList
            // 
            lblUserList.AutoSize = true;
            lblUserList.Location = new Point(392, 94);
            lblUserList.Name = "lblUserList";
            lblUserList.Size = new Size(61, 20);
            lblUserList.TabIndex = 5;
            lblUserList.Text = "User list";
            // 
            // btnUserLog
            // 
            btnUserLog.Location = new Point(12, 223);
            btnUserLog.Name = "btnUserLog";
            btnUserLog.Size = new Size(166, 47);
            btnUserLog.TabIndex = 6;
            btnUserLog.Text = "User Log";
            btnUserLog.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(12, 377);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(166, 47);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // ControlPanelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(btnUserLog);
            Controls.Add(lblUserList);
            Controls.Add(lblUserSettings);
            Controls.Add(btnGrantAccess);
            Controls.Add(btnDelete);
            Controls.Add(btnRegister);
            Controls.Add(lstUsers);
            Name = "ControlPanelForm";
            Text = "ControlPanel";
            Load += Dashboard_Load;
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
        private Button btnUserLog;
        private Button btnReturn;
    }
}