using AccessControlApp.Access;

namespace AccessControlApp
{
    public partial class Login : Form
    {
        UserManager manager = new UserManager();
        
        public Login()
        {
            InitializeComponent();
            manager.LoadUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (manager.AuthenticateUser(username, password))
            {
                MessageBox.Show("Вхід виконано успішно!");

                Dashboard dashboard = new Dashboard();

                dashboard.Show();

                Hide();
            }
            else
            {
                MessageBox.Show("Невірне ім'я користувача або пароль!");
            }
        }
    }
}
