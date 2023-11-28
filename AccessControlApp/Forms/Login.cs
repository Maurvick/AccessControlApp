using AccessControlApp.Access;
using AccessControlApp.Models;
using AccessControlApp.Services;

namespace AccessControlApp
{
    public partial class Login : Form
    {
        private List<User>? users;

        UserManager manager = new UserManager();
        UserActivityLogger logger = UserActivityLogger.Instance;

        public Login()
        {
            InitializeComponent();
            manager.LoadUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string privateKey = File.ReadAllText("../../../privateKey.xml");
            string usernamePassword = manager.ReadUserPasswordFromFile(username);

            if (usernamePassword != null)
            {
                // Decrypt the stored encrypted password
                string decryptedPassword = RsaIncryptionHelper.Decrypt(usernamePassword, privateKey);

                // Compare the decrypted password with the entered password
                if (password == decryptedPassword)
                {
                    logger.LogActivity(username, "авторизувався в додатку");
                    MessageBox.Show("Login successful!");
                    Dashboard dashboard = new Dashboard();
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
    }
}
