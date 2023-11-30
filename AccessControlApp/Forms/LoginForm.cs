using AccessControlApp.Access;

namespace AccessControlApp
{
    public partial class LoginForm : Form
    {
        UserManager userManager = new UserManager();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string encryptedPassword = ReadUserPasswordFromFile(username);

            userManager.LoginUser(username, password, encryptedPassword);

            Hide();
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

            // Return an empty string or throw an exception, depending on your application logic
            // or throw new InvalidOperationException("Username not found");
            return string.Empty; 
        }
    }
}
