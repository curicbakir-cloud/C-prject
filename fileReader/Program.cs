using FileReaderApp;
using Responce;


var fileLines = FileReader.ConvertFileToList(@"C:\Users\Bakir\Desktop\C#-full-project\files\pets.txt");
var firstColumn = FileReader.GetSpecificColumn(fileLines, 0);
Console.WriteLine($"file column: {firstColumn}");

var users = await UserService.GetByUrl<List<User>>("https://jsonplaceholder.typicode.com/users");

foreach (var user in users)
{
    Console.WriteLine($"Id: {user.Id}, Name: {user.UserName}, Email: {user.Email}");
}

UserService.WriteToFile(@"C:\Users\Bakir\Desktop\C#-full-project\files\users.txt", users);
UserService.WriteToFIleJson(@"C:\Users\Bakir\Desktop\C#-full-project\files\users.json", users);
var usersList = UserService.ReadFromFileJson(@"C:\Users\Bakir\Desktop\C#-full-project\files\users.json");
Console.WriteLine($"Users: {string.Join(", ", usersList.Select(u=>u.UserName))}");