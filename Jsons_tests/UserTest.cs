using UserJson;

namespace Jsons_tests
{
    public class UserServiceTest
    {
        [Fact]
        public void AllUsersAgeTest()
        {
            var users = new List<User>
            {
                new() { Name = "John Doe", Age = 30, Gender = "Male", Email = "john.doe@example.com" },
                new() { Name = "Jane Smith", Age = 25, Gender = "Female", Email = "jane.smith@example.com" },
                new() { Name = "Alex Johnson", Age = 40, Gender = null, Email = null }
            };

            Assert.Equal(95, UserService.AllUsersAge(users));
        }

        [Fact]
        public void AllComaSeperatedEmailsTest()
        {
            var users = new List<User>
            {
                new() { Name = "Bakir", Age = 40, Email = "bakir.feniks@gmail.com"},
                new() { Name = "Nemanja", Age = 40, Email = "nemanjacar@gmail.com"}
            };

            Assert.Equal("bakir.feniks@gmail.com,nemanjacar@gmail.com", UserService.AllComaSeperatedEmails(UserService.GetAllEmails(users)));
        }

        [Fact]
        public void CreateNamesTest()
        {
            var users = new List<User>
            {
                new() { Name = "Bakir", Age = 40, Email = "bakir.feniks@gmail.com"},
                new() { Name = "Nemanja", Age = 40, Email = "nemanjacar@gmail.com"}
            };

            Assert.Equal("Name: Bakir \nName: Nemanja \n", UserService.CreateNames(users));
        }

        [Fact]
        public void CalculateYearsTest()
        {
            var users = new List<User>
            {
                new() { Name="TEST", Age=32, Email="" },
                new() { Name= "J", Age=32 }
            };
            Assert.Equal(64, UserService.CalucateYears(users));
        }

        [Fact]
        public void ValidateAllEmailsTest()
        {
            var users = new List<User>
            {
                new() { Name="TEST", Age=32, Email="test@example.com" },
                new() { Name= "J", Age=32, Email="user@example.com"}
            };

            Assert.True(UserService.ValdateAllEmails(users));
        }

        [Fact]
        public void ValidateEmailTest()
        {
            var user = new User { Name = "TEST", Age = 32, Email = "test@example.com" };
            Assert.True(UserService.ValidateEmail(user));
        }

        [Fact]
        public void IsValidAgeTest()
        {
            var user1 = new User { Name = "TEST", Age = 32, Email = "test@example.com" };
            var user2 = new User { Name = "TEST", Age = -32, Email = "test@example.com" };

            Assert.True(UserService.IsValidAge(user1));
            Assert.False(UserService.IsValidAge(user2));
        }
        
        [Theory]
        [InlineData("Male")]
        [InlineData("Female")]
        [InlineData("Other")]
        public void ValidateUserGenderTest(string gender)
        {
            var users = new List<User>
            {
            new() { Name = "TEST", Age = 30, Gender = gender, Email = "test@example.com" }
            };
            Assert.True(UserService.IsValidGender(users));
        }

      
    }
}
