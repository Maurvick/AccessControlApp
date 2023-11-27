﻿using AccessControlApp.Models;

namespace AccessControlApp.Access
{
    public partial class Dashboard : Form
    {
        private const string usersFilePath = "nameuser.txt";
        private const string logFilePath = "us_book.txt";
        private List<User>? users;

        UserManager manager = new UserManager();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            register.Show();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Очистити попередні дані на формі
            lstUsers.Items.Clear();

            // Додати нові дані на форму
            foreach (var user in users)
            {
                lstUsers.Items.Add($"{user.Username} - {user.AccessRights}");
            }
        }

        //private string PromptForCredentials()
        //{
        //    // Попросити ввести ім'я користувача та пароль
        //    Login loginForm = new Login();

        //    DialogResult result = loginForm.ShowDialog();

        //    if (result == DialogResult.OK)
        //    {
        //        return loginForm.Username;
        //    }
        //    else
        //    {
        //        Close();
        //        return null;
        //    }
        //}

        //private void DashboardForm_Load(object sender, EventArgs e)
        //{
        //    // Перевірка доступу користувача при завантаженні форми
        //    string username = PromptForCredentials();

        //    User currentUser = users.Find(u => u.Username == username);

        //    if (currentUser != null && HasSufficientAccess(currentUser.AccessRights))
        //    {
        //        // Завантаження користувачів та відображення їх на формі
        //        manager.LoadUsers();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Недостатні права доступу. Закриття програми.");
        //        Close();
        //    }
        //}

        //    private void btnRegister_Click(object sender, EventArgs e)
        //    {
        //        // Логіка реєстрації користувача
        //        string username = txtUsername.Text;
        //        string password = txtPassword.Text;
        //        string accessRights = cmbAccessRights.SelectedItem.ToString();

        //        // Перевірка на довжину імені користувача та паролю
        //        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        //        {
        //            MessageBox.Show("Введіть ім'я користувача та пароль.");
        //            return;
        //        }

        //        // Перевірка безпеки паролю
        //        if (!IsPasswordSecure(password))
        //        {
        //            MessageBox.Show("Пароль не відповідає вимогам безпеки.");
        //            return;
        //        }

        //        // Перевірка на існування користувача з таким іменем
        //        if (users.Any(u => u.Username == username))
        //        {
        //            MessageBox.Show("Користувач з таким іменем вже існує.");
        //            return;
        //        }

        //        users.Add(new User(username, password, accessRights));

        //        manager.SaveUsers();

        //        MessageBox.Show("Користувач зареєстрований!");
        //    }

        //    private void btnDelete_Click(object sender, EventArgs e)
        //    {
        //        // Логіка видалення користувача
        //        string username = txtUsername.Text;

        //        // Перевірка на довжину імені користувача
        //        if (string.IsNullOrWhiteSpace(username))
        //        {
        //            MessageBox.Show("Введіть ім'я користувача для видалення.");
        //            return;
        //        }

        //        User userToDelete = users.FirstOrDefault(u => u.Username == username);

        //        if (userToDelete != null)
        //        {
        //            users.Remove(userToDelete);
        //            manager.SaveUsers();
        //            MessageBox.Show("Користувач видалений.");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Користувача з таким іменем не знайдено.");
        //        }
        //    }

        //    private void btnGrantAccess_Click(object sender, EventArgs e)
        //    {
        //        // Надання прав обраному користувачеві
        //        if (lstUsers.SelectedIndex != -1)
        //        {
        //            string selectedUsername = lstUsers.SelectedItem.ToString().Split(' ')[0];
        //            User selectedUser = users.Find(u => u.Username == selectedUsername);

        //            // Перевірка на дозвіл користувача на надання прав
        //            if (HasSufficientAccess(selectedUser.AccessRights))
        //            {
        //                // Логіка надання прав
        //                // ...

        //                SaveUsers();
        //                DisplayUsers();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Недостатні права доступу для надання прав користувачеві.");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Виберіть користувача для надання прав.");
        //        }
        //    }

        //    private void btnDeleteUser_Click(object sender, EventArgs e)
        //    {
        //        // Видалення обраного користувача
        //        if (lstUsers.SelectedIndex != -1)
        //        {
        //            string selectedUsername = lstUsers.SelectedItem.ToString().Split(' ')[0];
        //            User selectedUser = users.Find(u => u.Username == selectedUsername);

        //            // Перевірка на дозвіл користувача на видалення
        //            if (HasSufficientAccess(selectedUser.AccessRights))
        //            {
        //                // Логіка видалення користувача
        //                manager.SaveUsers();
        //                manager.DisplayUsers();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Недостатні права доступу для видалення користувача.");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Виберіть користувача для видалення.");
        //        }
        //    }
    }
}