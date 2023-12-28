using Client_;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

HttpClient client = new HttpClient();



while (true)
{
    var message = new HttpRequestMessage
    {
        RequestUri = new Uri("http://localhost:27001/"),
    };
    Console.WriteLine("1-GET");
    Console.WriteLine("2-POST");
    Console.WriteLine("3-PUT");
    Console.WriteLine("4-DELETE");
    Int32.TryParse(Console.ReadLine(), out int choice);
    switch (choice)
    {
        case (int)methods.GET:
            message.Method = HttpMethod.Get;
            var users = await GetUsers(message);
            foreach (var user in users!)
            {
                Console.WriteLine($"    {user}");
            }
            break;
        case (int)methods.POST:
            Console.Write("Enter the user ID: ");
            int idd = int.Parse(Console.ReadLine());
            Console.Write("Enter the user name: ");
            string namee = Console.ReadLine();
            Console.Write("Enter the user surname: ");
            string surnamee = Console.ReadLine();
            User newUser = new User { Id=idd, Name=namee, Surname=surnamee };
            string json2 = JsonSerializer.Serialize(newUser);

            var message2 = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(@"http://localhost:27001/"),
                Content = new StringContent(json2, Encoding.UTF8, "application/json")
            };
            var response2 = await client.SendAsync(message2);
            if (response2.IsSuccessStatusCode)
            {
                Console.WriteLine("\nUser added successfully.");
            }
            else
            {
                Console.WriteLine("\nFailed to add user. User with this id already exist");
            }
            break;
        case (int)methods.PUT:
            int check = 0;
            Console.Write("Enter the user ID you want to update: ");
            int idUpdate = int.Parse(Console.ReadLine());
            Console.Write("Enter the user new name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter the user new surname: ");
            string newSurname = Console.ReadLine();
            User userUpdate = new User { Id=idUpdate, Name=newName, Surname=newSurname };
            string jsonUpdate = JsonSerializer.Serialize(userUpdate);
            message.Method = HttpMethod.Put;
            message.Content = new StringContent(jsonUpdate, Encoding.UTF8, "application/json");
            var responsePut = await client.SendAsync(message);
            if (responsePut.IsSuccessStatusCode)
            {
                Console.WriteLine("\nUser info updated successfully.");
            }
            else
            {
                Console.WriteLine("\nFailed to update user info. User with this id doesn't  exist");
            }
            break;
        case (int)methods.DELETE:
            Console.Write("Enter the user ID you want to delete: ");
            int iddelete = Int32.Parse(Console.ReadLine());
            string jsonDelete = JsonSerializer.Serialize(iddelete);
            message.Method = HttpMethod.Delete;
            message.Content = new StringContent(jsonDelete, Encoding.UTF8, "application/json");
            var responseDelete = await client.SendAsync(message);
            if (responseDelete.IsSuccessStatusCode)
            {
                Console.WriteLine("\nUser deleted successfully.");
            }
            else
            {
                Console.WriteLine("\nFailed to delete user. User with this id doesn't  exist");
            }
            break;
        default:
            break;
    }
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadLine();
    Console.Clear();
}

async Task<List<User>> GetUsers(HttpRequestMessage message)
{
    var response = await client.SendAsync(message);
    var json = await response.Content.ReadAsStringAsync();
    var users = JsonSerializer.Deserialize<List<User>>(json);
    return users;
}


