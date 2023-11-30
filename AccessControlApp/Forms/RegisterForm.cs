using AccessControlApp.Access;

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

            manager.RegisterUser(username, password, accessLevel);

            Hide();
        }
    }
}
