﻿namespace AccessControlApp.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? AccessLevel { get; set; }
    }
}
