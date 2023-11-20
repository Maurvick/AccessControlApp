namespace AccessControlApp.Models
{
    internal struct User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccessRights { get; set; }
    }
}
