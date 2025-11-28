using System.Net.Http.Json;
using System.Text.Json;
using Responce;


class UserService
{
    static readonly HttpClient provider = new();
    public static async Task<T> GetByUrl<T>(string url)
    {
        var data= await provider.GetFromJsonAsync<T>(url);
        if (data != null)
        {
            return  data;
        }
        throw new HttpRequestException("The request returned no data.");
    }

    public static void WriteToFile(string path, List<User>users)
    {
        File.WriteAllLines(path, users.Select(user => $"{user.Id} {user.UserName}"));
    }
    public static void WriteToFIleJson(string path, List<User> users)
    {
        var usersJson = JsonSerializer.Serialize<List<User>>(users);
        File.WriteAllText(path, usersJson);
    }

    public static List<User>ReadFromFileJson(string path)
    {
        var usersData = File.ReadAllText(path);
        if (usersData != null)
        {
            return JsonSerializer.Deserialize<List<User>>(usersData);
        }
        return [];
    }

}

