using System;

namespace MindfulnessApp
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public User(string username, string email)
        {
            Username = username;
            Email = email;
        }

        public override string ToString() => $"{Username} - {Email}";

        public string ToFileFormat() => $"{Username}|{Email}";

        public static User? FromFileFormat(string line)
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
                return new User(parts[0], parts[1]);
            return null;
        }
    }
}
