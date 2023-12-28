using Listener_;
using System.Net;
using System.Text.Json;

List<User> users = new List<User>()
{
    new User(id:1, name:"Farid", surname:"Dibirov"),
    new User(id:2, name:"Elon", surname:"Musk"),
    new User(id:3, name:"Bill", surname:"Gates")
};

var listener = new HttpListener();
listener.Prefixes.Add("http://localhost:27001/");

while (true)
{
    listener.Start();
    var context = listener.GetContext();
    var request = context.Request;
    var response = context.Response;
    StreamWriter sw = new StreamWriter(response.OutputStream);
    switch (request.HttpMethod)
    {
        case "GET":
            sw.WriteAsync(JsonSerializer.Serialize(users));
            Console.WriteLine("GET");
            break;
        case "POST":
            int check = 0;
            var json = new StreamReader(request.InputStream).ReadToEnd();
            var newUser = JsonSerializer.Deserialize<User>(json);
            foreach (var item in users)
            {
                if (newUser.Id == item.Id)
                    check++;
            }
            if (check == 0)
            {
                users.Add(newUser);
                response.StatusCode = 200;
                response.Close();
            }

            else
            {
                response.StatusCode = 401;
                response.Close();

            }
            Console.WriteLine("POST");
            break;
        case "PUT":
            int check2 = 0;
            var jsonUpdate = new StreamReader(request.InputStream).ReadToEnd();
            var userUpdate = JsonSerializer.Deserialize<User>(jsonUpdate);
            foreach (var item in users)
            {
                if (userUpdate.Id == item.Id)
                {
                    item.Name = userUpdate.Name;
                    item.Surname = userUpdate.Surname;
                    check2++;
                }
            }
            if (check2 > 0)
            {
                response.StatusCode = 200;
                response.Close();
            }

            else
            {
                response.StatusCode = 401;
                response.Close();

            }
            Console.WriteLine("PUT");
            break;
        case "DELETE":
 
            var jsonDelete = new StreamReader(request.InputStream).ReadToEnd();
            var IdDel = JsonSerializer.Deserialize<int>(jsonDelete);
            var deleteUser = users.Find(c => c.Id == IdDel);
            if (deleteUser != null)
            {
                users.Remove(deleteUser);
                response.StatusCode = 200;
                response.Close();
            }
            else
            {
                response.StatusCode = 401;
                response.Close();

            }
            Console.WriteLine("DELETE");
            break;
    }

    sw.Close();
}
