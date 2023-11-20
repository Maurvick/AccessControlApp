using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessControlApp.Models;

namespace AccessControlApp.Access
{
    internal class UserManager
    {
        private List<User> users;

        string usersFilePath = "../../../nameuser.txt";

        public void LoadUsers()
        {
            // Зчитування користувачів з файлу nameuser.txt
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
                            AccessRights = userParts[2]
                        });
                    }
                }
            }
        }

        public void SaveUsers()
        {
            // Збереження користувачів у файл nameuser.txt
            List<string> userLines = new List<string>();

            foreach (var user in users)
            {
                userLines.Add($"{user.Username},{user.Password},{user.AccessRights}");
            }

            File.WriteAllLines(usersFilePath, userLines);
        }

        public void RegisterUser(string username, string password, string accessRights)
        {
            // Реєстрація нового користувача
            users.Add(new User
            {
                Username = username,
                Password = password,
                AccessRights = accessRights
            });

            SaveUsers();
        }

        public bool AuthenticateUser(string username, string password)
        {
            // Аутентифікація користувача за паролем
            User user = users.Find(u => u.Username == username && u.Password == password);

            // Якщо знайдено користувача, повертаємо true
            return user.Username != null;
        }
    }
}
