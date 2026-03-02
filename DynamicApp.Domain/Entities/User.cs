using System;

namespace DynamicApp.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UniqueUserId { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = "User"; // 'User' or 'Admin'
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
