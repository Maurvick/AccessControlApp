using AccessControlApp.Models;
using AccessControlApp.Services;

namespace AccessControlApp.Access
{
    internal class UserManager
    {
        private List<User> users;
        UserActivityLogger logger = UserActivityLogger.Instance;

        public const string USERS_FILE_PATH = "nameuser.txt";

        public void LoadUsers()
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

        public void SaveUsers()
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
            if (users.Count() == 10)
            {
                User user = users.Find(u => u.Username == username && u.Password == password);

                if (user == null)
                {
                    users.Add(new User
                    {
                        Username = username,
                        Password = password,
                        AccessLevel = AccessLevel
                    });

                    SaveUsers();

                    logger.LogActivity("admin", $"створив користувача {username}");

                    MessageBox.Show("Користувач зареєстрований!");
                }
                else
                {
                    MessageBox.Show("Такий користувач уже існує!");
                }
            }
            else
            {
                MessageBox.Show("Ліміт користувачів вичепарно.");
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            User user = users.Find(u => u.Username == username && u.Password == password);

            return user.Username != null;
        }

        public void UserAccessValidationTimer()
        {

        }
    }
}
