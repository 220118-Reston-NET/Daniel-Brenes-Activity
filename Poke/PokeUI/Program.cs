//using PokeModel;
global using Serilog;
using PokeUI;
using PokeBL;
using PokeDL;
using Microsoft.Extensions.Configuration;
//global using will implicitly import that namespace to the rest of your C# files inside of this project

// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Ability ab = new Ability();
// ab.PP = -1;



Log.Logger = new LoggerConfiguration()
                    .WriteTo.File("./logs/user.text")//We configure our logger to save in this file
                        .CreateLogger();

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string _connectionString = configuration.GetConnectionString("Reference2DB");

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    Console.Clear();
    
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "GetPokeAbility":
            menu = new GetPokeAbility(new PokemonBL ( new Repository()));
            
        case "SearchPokemon":
        
            Log.Information("Displaying SearchPokemon menu to user");
            menu = new SearchPokemonMenu(new PokemonBL(new Repository()));
            break;
        case "AddPokemon":
        

            Log.Information("Displaying AddPokemon menu to user");
            menu = new AddPokeMenu(new PokemonBL(new Repository()));
            break;
        case "MainMenu":
            Log.Information("Displaying MainMenu to user");
            menu = new MainMenu();
            break;
        case "Exit":
        
            Log.Information("Exiting application");
            Log.CloseAndFlush(); // To close our logger resource
            repeat = false;
            break;
        default:
            Console.WriteLine("Page does not exist!");
            Console.WriteLine("Please press Enter to continue");
            Console.ReadLine();
            break;
    }
}