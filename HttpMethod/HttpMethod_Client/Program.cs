using HttpMethod_Client;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;


var ip = IPAddress.Loopback;
var port = 27001;

var client = new TcpClient();
client.Connect(ip, port);
var stream = client.GetStream();
var br = new BinaryReader(stream);
var bw = new BinaryWriter(stream);
Command command = null;
string responce = null;

while (true)
{
    Console.WriteLine("Select command or type \"help\": ");
    var str = Console.ReadLine();
    if (str == "help")
    {
        Console.WriteLine();
        Console.WriteLine("\tCommand list:");
        Console.WriteLine($"1.Type \"{Command.GET}\"  to see all cars");
        Console.WriteLine($"2.Type \"{Command.POST}\" to add new car");
        Console.WriteLine($"3.Type \"{Command.PUT}\"  to update car information");
        Console.WriteLine($"3.Type \"{Command.DELETE}\"  to delete car");
        Console.WriteLine($"4.Type \"help\" to get help");
        Console.ReadKey();
        Console.Clear();
        continue;
    }
    var input = str.Split(' ');
    switch (input[0])
    {
        case Command.GET:
            command = new Command { Text = input[0] };
            bw.Write(JsonSerializer.Serialize(command));
            responce = br.ReadString();
            var CarList = JsonSerializer.Deserialize<List<Car>>(responce);
            foreach (var car in CarList)
            {
                Console.WriteLine(car);
            }
            Console.ReadKey();
            Console.Clear();
            break;

        case Command.POST:
            Console.Write("Enter the car ID: ");
            int idd = int.Parse(Console.ReadLine());
            Console.Write("Enter the car model: ");
            string modell = Console.ReadLine();
            Console.Write("Enter the car mark: ");
            string markk = Console.ReadLine();
            Console.Write("Enter the car year: ");
            int yearr = int.Parse(Console.ReadLine());
            Car newCar = new Car(id: idd, model: modell, mark:markk, year:yearr);
            string json = JsonSerializer.Serialize(newCar);
            command = new Command { Text = input[0], Param = json };
            bw.Write(JsonSerializer.Serialize(command));
            responce = br.ReadString();
            Console.WriteLine(responce);
            break;

        case Command.PUT:
            int check = 0;
            Console.Write("Enter the car ID you want to update: ");
            int idUpdate = int.Parse(Console.ReadLine());
            Console.Write("Enter the car new model: ");
            string newModel = Console.ReadLine();
            Console.Write("Enter the car new mark: ");
            string newMark = Console.ReadLine();
            Console.Write("Enter the car new year: ");
            int newYear = int.Parse(Console.ReadLine());
            Car carUpdate = new Car(id: idUpdate, model: newModel, mark: newMark, year: newYear);
            string jsonUpdate = JsonSerializer.Serialize(carUpdate);
            command = new Command { Text = input[0], Param = jsonUpdate };
            bw.Write(JsonSerializer.Serialize(command));
            responce = br.ReadString();
            Console.WriteLine(responce);
            break;

        case Command.DELETE:
            Console.Write("Enter the car ID you want to delete: ");
            string iddelete = Console.ReadLine();
            command = new Command { Text = input[0], Param = iddelete};
            bw.Write(JsonSerializer.Serialize(command));
            responce = br.ReadString();
            Console.WriteLine(responce);
            break;

    }


}