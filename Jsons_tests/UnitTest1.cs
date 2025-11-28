using System.Text.Json;
using UserJson;

namespace Jsons_tests
{
    public class JsonTest
    {
        [Fact]
        public void MainTest()
        {
            var data = @"
            {
                ""Users"": [
                    {
                        ""Name"": ""John Doe"",
                        ""Age"": 30,
                        ""Gender"": ""Male"",
                        ""Email"": ""john.doe@example.com""
                    },
                    {
                        ""Name"": ""Jane Smith"",
                        ""Age"": 25,
                        ""Gender"": ""Female"",
                        ""Email"": ""jane.smith@example.com""
                    },
                    {
                        ""Name"": ""Alex Johnson"",
                        ""Age"": 40,
                        ""Gender"": null,
                        ""Email"": null
                    }
                ]
            }";

            var users = JsonSerializer.Deserialize<UsersData>(data);
            var age = UserService.AllUsersAge(users.Users);
            Assert.Equal(95, age);
        }
    }

}