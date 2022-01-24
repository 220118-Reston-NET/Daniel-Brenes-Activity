using CarFunction;
using System.Text.Json;
namespace SerializationFunction
{
    /*
        Serialization is the process of converting your C# objects into a JSON file or 110001101 (stream of bytes) or other formats
        We will be using JSON because it is the most commonly used file format when comes to transferring/storing data
        Main reason why is because collection memory is temporary and you might need to save that data later on to be used

    */

    public class Serialization
    {
        //The period on the file path means to auto put the entire filepath of where this current file is at in your hard drive
        private static string _filepath = "./Database/Car.json";
        
        public static void SerialMain()
        {
            List<Car> listOfCars = new List<Car>();
            Console.WriteLine("===Serialization Demo===");
            Console.WriteLine("Converting object to JSON=");

            Car car1 = new Car()
            {
                Color = "Silver",
                Fuel = 50,
                Owner = "Stephen"
            };
            listOfCars.Add(car1);
            listOfCars.Add(car1);

            string jsonString = JsonSerializer.Serialize(car1, new JsonSerializerOptions { WriteIndented = true});
            Console.WriteLine(jsonString);

            File.WriteAllText(_filepath, jsonString);

            Console.WriteLine("=Converting JSON to object=");
            string jsonString2 = File.ReadAllText(_filepath);

            Car car2 = JsonSerializer.Deserialize<Car>(jsonString2);
            Console.WriteLine(car2.Color);
            Console.WriteLine(car2.Fuel);
            Console.WriteLine(car2.Owner);


        }
    }
}