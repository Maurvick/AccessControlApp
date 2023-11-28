using AccessControlApp.Models;

namespace AccessControlApp.Access
{
    internal class UserManager
    {
        private List<User>? users;

        const string usersFilePath = "../../../nameuser.txt";

        public void LoadUsers()
        {
            users = new List<User>();

            if (File.Exists(usersFilePath))
            {
                string[] lines = File.ReadAllLines(usersFilePath);

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

            File.WriteAllLines(usersFilePath, userLines);
        }

        public void RegisterUser(string username, string password, string AccessLevel)
        {
            users.Add(new User
            {
                Username = username,
                Password = password,
                AccessLevel = AccessLevel
            });

            SaveUsers();
        }

        public bool AuthenticateUser(string username, string password)
        {
            User user = users.Find(u => u.Username == username && u.Password == password);

            return user.Username != null;
        }

        public string ReadUserPasswordFromFile(string username)
        {
            // Read the encrypted password from the file based on the username
            string[] lines = File.ReadAllLines("../../../nameuser.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 3 && parts[0] == username)
                {
                    return parts[1]; // Return the encrypted password
                }
            }

            return null; // User not found
        }
    }
}
