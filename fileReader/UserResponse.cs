using System.Text.Json.Serialization;

namespace Responce
{   public class UsersResponce
    {   [JsonPropertyName("")]
        public List<User>? Users {get; set;}
    }
    public class User
    {
        [JsonPropertyName("id")]
        public required int Id{get; set;}
        public required string UserName{get; set;}
        public required string Email{get; set;}
        public Address? Address{get; set;}
    }

    public class Address
    {
        public string? Street{get; set;}
        public string? Suite{get; set;}
        public string? City{get; set;}
        [JsonPropertyName("zipcode")]
        public string? Code{get; set;}
    }
}