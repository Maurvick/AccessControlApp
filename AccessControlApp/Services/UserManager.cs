using AccessControlApp.Models;
using AccessControlApp.Services;

namespace AccessControlApp.Access
{
    internal class UserManager
    {
        public const string USERS_FILE_PATH = "./Logs/nameuser.txt";

        // Initialize the list to avoid CS8618 warning
        private List<User> users = new List<User>();

        UserActivityLogger _logger = UserActivityLogger.Instance;

        public List<User> Users
        {
            get
            { 
                return users; 
            }
            set 
            { 
                users = Users;
            }
        }


        public void ReadUsersFromTextFile()
        {
            users = new List<User>();

            if (File.Exists(USERS_FILE_PATH))
            {
                string[] lines = File.ReadAllLines(USERS_FILE_PATH);

                foreach (var line in lines)
                {
                    string[] userParts = line.Split(',');
                    if (userParts.Length == 3)
                    {
                        users.Add(new User
                        {
                            Username = userParts[0],
                            Password = userParts[1],
                            AccessLevel = userParts[2]
                        });
                    }
                }
            }
        }

        public void SaveUsersToTextFile()
        {
            List<string> userLines = new List<string>();

            foreach (var user in users)
            {
                userLines.Add($"{user.Username},{user.Password},{user.AccessLevel}");
            }

            File.WriteAllLines(USERS_FILE_PATH, userLines);
        }

        public void RegisterUser(string username, string password, string AccessLevel)
        {
            ReadUsersFromTextFile();

            List<string> userLines = new List<string>();

            string encryptedPassword = RSAIncryptionHelper.Encrypt(password);

            int userCount = 0;

            if (userCount <= 10)
            {
                if (users.Exists(u => u.Username == username))
                {
                    MessageBox.Show("Такий користувач уже існує!");
                }
                else
                {
                    users.Add(new User
                    {
                        Username = username,
                        Password = encryptedPassword,
                        AccessLevel = AccessLevel
                    });

                    SaveUsersToTextFile();

                    _logger.LogActivity("admin", $"створив користувача {username}");

                    MessageBox.Show("Користувач зареєстрований!");
                }
            }
            else
            {
                MessageBox.Show("Ліміт користувачів вичепарно.");
            }
        }

        public void LoginUser(string username, string password, string encryptedPassword)
        {
            ReadUsersFromTextFile();

            if (encryptedPassword != null)
            {
                // Decrypt the stored encrypted password
                string decryptedPassword = RSAIncryptionHelper.Decrypt(encryptedPassword);

                // Compare the decrypted password with the entered password
                if (password == decryptedPassword)
                {
                    _logger.LogActivity(username, "авторизувався в додатку");
                    MessageBox.Show("Успішна авторизація в систему!");
                    ControlPanelForm dashboard = new ControlPanelForm();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Неправильний пароль або ім'я.");
                }
            }
            else
            {
                MessageBox.Show("Такого користувача не існує.");
            }

            SaveUsersToTextFile();
        }

        public bool AuthenticateUser(string username, string password)
        {
            var user = users.Find(u => u.Username == username && u.Password == password);

            // Check if user is not null before accessing properties
            return user != null;
        }

        public void UserAccessValidationTimer()
        {

        }
    }
}
