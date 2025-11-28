using Data;


var (usaUsers, europeUsers) = await UserData.GetEuUsUsers("https://jsonplaceholder.typicode.com/users","https://dummyjson.com/users");
// Console.WriteLine(usaUsers);
// Console.WriteLine(europeUsers);

var user = UserData.GetUserByPosition(0);
Console.WriteLine($"User: {user.Id}" );