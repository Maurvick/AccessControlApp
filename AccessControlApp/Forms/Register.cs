using AccessControlApp.Access;

namespace AccessControlApp
{
    public partial class Register : Form
    {
        UserManager manager = new UserManager();

        public Register()
        {
            InitializeComponent();
            manager.LoadUsers();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string accessRights = "E"; 

            manager.RegisterUser(username, password, accessRights);

            MessageBox.Show("Користувач зареєстрований!");
            
            Hide();
        }
    }
}
