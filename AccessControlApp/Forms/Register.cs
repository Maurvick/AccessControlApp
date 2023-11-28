using AccessControlApp.Access;
using AccessControlApp.Services;

namespace AccessControlApp
{
    public partial class Register : Form
    {
        UserManager manager = new UserManager();
        UserActivityLogger logger = UserActivityLogger.Instance;

        public Register()
        {
            InitializeComponent();
            manager.LoadUsers();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string accessLevel = comboAccessLevel.SelectedIndex.ToString();
            string publicKey = File.ReadAllText("../../../publicKey.xml");
            string encryptedPassword = RsaIncryptionHelper.Decrypt(password, publicKey);

            manager.RegisterUser(username, encryptedPassword, accessLevel);

            logger.LogActivity("admin", $"створив користувача {username}");

            MessageBox.Show("Користувач зареєстрований!");

            Hide();
        }
    }
}
