using AccessControlApp.Access;
using AccessControlApp.Services;

namespace AccessControlApp
{
    public partial class RegisterForm : Form
    {
        UserManager manager = new UserManager();

        public RegisterForm()
        {
            InitializeComponent();

            // Set preferred index to show as default value
            comboAccessLevel.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string accessLevel = comboAccessLevel.Text;

           // Encrypt the password
            var encryptedPassword = RSAIncryptionHelper.Encrypt(password);

            manager.RegisterUser(username, encryptedPassword, accessLevel);

            Hide();
        }
    }
}
