using AccessControlApp.Forms;
using AccessControlApp.Models;

namespace AccessControlApp.Access
{
    public partial class ControlPanelForm : Form
    {
        UserManager userManager = new UserManager();

        public ControlPanelForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();

            register.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            foreach (var user in userManager.Users)
            {
                lstUsers.Items.Add(user.Username);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();

            main.Show();

            Hide();
        }
    }
}
