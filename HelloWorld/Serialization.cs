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

            string jsonString = JsonSerializer.Serialize(listOfCars, new JsonSerializerOptions { WriteIndented = true});
            Console.WriteLine(jsonString);

            
            File.WriteAllText(_filepath, jsonString);

            Console.WriteLine("=Converting JSON to object=");
            
            //File.ReadAllText() static method will read our JSON file and store it in our jsonString2
            

            //Try block is used to have lines of code that you might expect to run into some
            try
            {
                string jsonString2 = File.ReadAllText(_filepath);

                Car car2 = JsonSerializer.Deserialize<Car>(jsonString2);
                Console.WriteLine(car2.Color);
                Console.WriteLine(car2.Fuel);
                Console.WriteLine(car2.Owner);

            }
            //Catch block will execute if it did run into that specific exception
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                List<Car> genericList = new List<Car>();

                genericList.Add(new Car());

                string jsonString3 = JsonSerializer.Serialize(genericList);
                File.WriteAllText(_filepath, jsonString3);

                jsonString3 = File.ReadAllText(_filepath);

                List<Car> car2 = JsonSerializer.Deserialize<List<Car>>(jsonString3);

                Console.WriteLine(car2[0].Color);
                Console.WriteLine(car2[0].Fuel);
                Console.WriteLine(car2[0].Owner);

            }
            catch (System.Exception)
            {

            }
            finally
            {
                Console.WriteLine("All exceptions handled");

            }
            
            


        }
    }
}