using UserJson;
using System.Text.Json;



var data = File.ReadAllText(@"C:\Users\Bakir\Desktop\C#-full-project\Jsons\files\users.json");
var users = JsonSerializer.Deserialize<UsersData>(data);
var age = UserService.AllUsersAge(users.Users);
var userEmails = UserService.GetAllEmails(users.Users);
var emails = UserService.AllComaSeperatedEmails(userEmails);
var names = UserService.CreateNames(users.Users);
var sumYears = UserService.CalucateYears(users.Users);
var isValdEmails = UserService.ValdateAllEmails(users.Users);

Console.WriteLine(age);
Console.WriteLine(emails);
Console.WriteLine(names);
Console.WriteLine(sumYears);
Console.WriteLine(isValdEmails);
