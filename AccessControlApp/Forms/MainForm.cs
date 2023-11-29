using AccessControlApp.Access;
using AccessControlApp.Services;

namespace AccessControlApp.Forms
{
    public partial class MainForm : Form
    {
        UserManager manager = new UserManager();

        public MainForm()
        {
            InitializeComponent();
            RSAIncryptionHelper.ReadKeys();
            manager.LoadUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();

            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();

            register.Show();
        }

        private void btnControlPanel_Click(object sender, EventArgs e)
        {
            ControlPanelForm panel = new ControlPanelForm();

            panel.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
