using System.Text;


namespace UserJson
{
    public class User
    {
        public required string Name { get; set; }

        public required int Age { get; set; }

        public string? Gender { get; set; }

        public string? Email { get; set; }
    }

    public class UsersData
    {
        public List<User>? Users { get; set; }

        public List<string> GetAllEmails()
        {
            if (Users == null)
            {
                return [];
            }
            var users = new List<string>();
            foreach (var user in Users)
            {
                if (user.Email != null) { users.Add(user.Email); }

            }
            return users;
        }
    }

    public class UserService
    {
        private static readonly HashSet<string> ValidGenders = new() { "Male", "Female", "Other", "Prefer not to say" };        public static int AllUsersAge(List<User> users)
        {

            if (users == null || users.Count == 0)
            {
                return 0;
            }
            var result = 0;
            foreach (var user in users)
            {
                result += user.Age;
            }
            return result;
        }

        public static string AllComaSeperatedEmails(List<string> usersEmails)
        {
            var emails = new StringBuilder();
            return emails.AppendJoin(',', usersEmails).ToString();
        }

        public static List<string> GetAllEmails(List<User> users)
        {
            if (users == null)
            {
                return [];
            }
            var usersEmails = new List<string>();
            foreach (var user in users)
            {
                if (user.Email != null) { usersEmails.Add(user.Email); }

            }
            return usersEmails;
        }

        public static string CreateNames(List<User> users)
        {
            var names = new StringBuilder();
            foreach (var user in users)
            {
                names.AppendFormat($"Name: {user.Name} \n");
            }

            return $"{names}";
        }

        public static int CalucateYears(List<User> users)
        {
            var sumYears = 0;
            foreach (var user in users)
            {
                sumYears += (int)user.Age;
            }
            return sumYears;
        }

        public static bool ValdateAllEmails(List<User> users)
        {
            foreach (var user in users)
            {
                if (user.Email != null & user.Email.Contains('@'))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ValidateEmail(User user)
        {
            if (user == null || !user.Email.Contains('@'))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidAge(User user)
        {
            if (user.Age < 1 || user.Age > 170)
            {
                return false;
            }
            return true;
        }

        public static bool IsValidGender(List<User> users)
        {
            foreach (var user in users)
            {
                if (user.Gender != null && !ValidGenders.Contains(user.Gender))
                {
                    return false;
                }
            }
            return true;
        } 
    }
}