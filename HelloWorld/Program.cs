using CarFunction;
using CollectionFunction;
using ConversionFunction;
using SerializationFunction;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // NameOfClass NameOfVariable = new NameOfClass();
// Car car1 = new Car(100);
// Console.WriteLine(car1.Color);
// car1.Color = "Red";
// Console.WriteLine(car1.Color);
// car1.Fuel = 10;
// Console.WriteLine(car1.Fuel);
// car1.Start();
// car1.Start(100);

// Car car2 = new Car()
// {   
//     Color = "Yellow",
//     Fuel = 1000,
//     Owner = "Stephen"

// };

// Console.WriteLine("Welcome to programming!");
// Console.WriteLine("Please tell me your name");
// string name = Console.ReadLine();
// Console.WriteLine($"Hello {name}, what do you want to do today?");
// Console.WriteLine("[1] - Add two numbers");
// Console.WriteLine("[2] - Exit");
// string userInput = Console.ReadLine();
// if (userInput == "1")
// {
//     Console.WriteLine("Please give me two numbers");
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     int num2 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine($"The sum is: {num2+num1}");
// }
// else if (userInput == 2)

// Initialized Collection class
Collection collect = new Collection();
collect.CollectionMain();

Conversion.ConversionMain();
Conversion._num = 10;
Conversion conv1 = new Conversion();
Conversion conv2 = new Conversion();

Console.WriteLine(conv1.GiveMeNumber());
Console.WriteLine(conv2.GiveMeNumber());

Serialization.SerialMain();