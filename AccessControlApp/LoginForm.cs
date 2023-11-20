using AccessControlApp.Access;

namespace AccessControlApp
{
    public partial class LoginForm : Form
    {
        UserManager manager = new UserManager();

        public LoginForm()
        {
            InitializeComponent();
        
            // Загрузити користувачів зі списку
            manager.LoadUsers();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Обробник події для кнопки реєстрації
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string accessRights = "E"; // Початкові права доступу

            manager.RegisterUser(username, password, accessRights);

            MessageBox.Show("Користувач зареєстрований!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Обробник події для кнопки входу
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (manager.AuthenticateUser(username, password))
            {
                MessageBox.Show("Вхід виконано успішно!");

                DashboardForm dashboard = new DashboardForm();

                dashboard.Show();

                // this.Close();

                // this.Hide();
                // dashboard.ShowDialog();
                // this.Close();
            }
            else
            {
                MessageBox.Show("Невірне ім'я користувача або пароль!");
            }
        }
    }
}
