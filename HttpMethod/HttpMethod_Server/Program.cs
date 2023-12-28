using HttpMethod_Server;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Text.Json;
using Microsoft.VisualBasic;

var ip = IPAddress.Loopback;
var port = 27001;

var listener = new TcpListener(ip, port);


List<Car> cars = new List<Car>()
{
  new Car(1, "Mercedes", "C180", 1998),
    new Car(2, "Hyundai", "SantaFe", 2008),
    new Car(3, "Ford", "Mustang", 2018)
};



listener.Start();

while (true)
{
    var client = listener.AcceptTcpClient();
    var stream = client.GetStream();
    var br = new BinaryReader(stream);
    var bw = new BinaryWriter(stream);
    string response = string.Empty;

    while (true)
    {
        var input = br.ReadString();
        var command = JsonSerializer.Deserialize<Command>(input);
        if (command == null) continue;

        switch (command.Text)
        {
            case Command.GET:
                var carlist = JsonSerializer.Serialize(cars);
               
                bw.Write(carlist);
                break;

            case Command.POST:
                var newCar = JsonSerializer.Deserialize<Car>(command.Param);
                int check = 0;
                string message;
                foreach (var item in cars)
                {
                    if(item.ID==newCar.ID)
                 check++;
                }
                if (check == 0)
                {
                    cars.Add(newCar);
                    message = "Car added succesfully";
                }

                else message = "Car with this id already exist";

                bw.Write(message);

                break;
            case Command.PUT:
                int check3 = 0;
                string message3;
                var updatedCar = JsonSerializer.Deserialize<Car>(command.Param);
                foreach (var item in cars)
                {
                    if (item.ID == updatedCar.ID)
                    {
                        item.Mark = updatedCar.Mark;
                        item.Model = updatedCar.Model;
                        item.Year = updatedCar.Year;
                        check3++;
                    }
                }
                if (check3 > 0) message3 = "Car information was updated successfully";

                else message3 = "Car with this id doesn't exist";

                bw.Write(message3);

                break;

            case Command.DELETE:
                int check2 = 0;
                string message2;
                var carIdDelete = int.Parse(command.Param);
                var carDelete = cars.Find(c => c.ID == carIdDelete);
                if (carDelete != null)
                {
                    cars.Remove(carDelete);
                    message2 = "Car deleted succesfully";
                }

                else message2 = "Car with this id doesn't exist";
                bw.Write(message2);
                break;

            default:
                break;
        }

    }
}
