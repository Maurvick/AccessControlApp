using AccessControlApp.Access;

namespace AccessControlApp
{
    public partial class LoginForm : Form
    {
        UserManager manager = new UserManager();

        public LoginForm()
        {
            InitializeComponent();
        
            // ��������� ������������ � ������
            manager.LoadUsers();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // �������� ��䳿 ��� ������ ���������
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string accessRights = "E"; // �������� ����� �������

            manager.RegisterUser(username, password, accessRights);

            MessageBox.Show("���������� �������������!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // �������� ��䳿 ��� ������ �����
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (manager.AuthenticateUser(username, password))
            {
                MessageBox.Show("���� �������� ������!");

                DashboardForm dashboard = new DashboardForm();

                dashboard.Show();

                // this.Close();

                // this.Hide();
                // dashboard.ShowDialog();
                // this.Close();
            }
            else
            {
                MessageBox.Show("������ ��'� ����������� ��� ������!");
            }
        }
    }
}
