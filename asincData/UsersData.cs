using Users;
using System.Text.Json;

namespace Data
{
    class UserData() {

        static readonly HttpClient proivder = new();

        public static async Task<string> GetUsersByUrl(string url)
        {
           return await proivder.GetStringAsync(url);
        }
        public static async Task<(string usaUsers, string europeUsers)> GetEuUsUsers(string euUrl, string usUrl)
        {
            var usaUsers = GetUsersByUrl(euUrl);
            var europeUsers = GetUsersByUrl(usUrl);
            return (await usaUsers, await europeUsers);
        }

        public static async Task<User> GetUserByPosition(int position)
        {
            var users = await GetUsersByUrl("https://jsonplaceholder.typicode.com/users");
            var usersList = JsonSerializer.Deserialize<List<User>>(users);
            return usersList[position];
        }
    }

}