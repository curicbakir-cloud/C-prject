using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace Users
{
    public class User
    {
        public required int Id { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public required string Email { get; set; }
        public Dictionary<string, string>? Address { get; set; }
        public Dictionary<string, string>? Company { get; set; }
    }
}