using AccessControlApp.Access;
using AccessControlApp.Services;

namespace AccessControlApp
{
    public partial class LoginForm : Form
    {
        UserManager manager = new UserManager();
        UserActivityLogger logger = UserActivityLogger.Instance;

        public LoginForm()
        {
            InitializeComponent();
            manager.LoadUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string encryptedPassword = ReadUserPasswordFromFile(username);

            if (encryptedPassword != null)
            {
                // Decrypt the stored encrypted password
                string decryptedPassword = RSAIncryptionHelper.Decrypt(encryptedPassword);

                // Compare the decrypted password with the entered password
                if (password == decryptedPassword)
                {
                    logger.LogActivity(username, "авторизувався в додатку");
                    MessageBox.Show("Login successful!");
                    ControlPanelForm dashboard = new ControlPanelForm();
                    dashboard.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        public string ReadUserPasswordFromFile(string username)
        {
            // Read the encrypted password from the file based on the username
            string[] lines = File.ReadAllLines(UserManager.USERS_FILE_PATH);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 3 && parts[0] == username)
                {
                    // Return the encrypted password
                    return parts[1]; 
                }
            }

            return null;
        }
    }
}
