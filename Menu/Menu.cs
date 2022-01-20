using DataFunction;
namespace MenuFunction
{
    public class Menu
    {
        public static void MenuMain()
        {
            Data data1 = new Data();
            bool repeat = true;

            while(repeat)
            {
            Console.WriteLine("------- Basic Menu  -------");
            
            Console.WriteLine("1. Add two numbers");
            Console.WriteLine("2. Subtract two numbers");
            Console.WriteLine("3. Multiply two numbers");
            Console.WriteLine("4. Add strings to Collection");
            Console.WriteLine("5. Show all strings in Collection");
            Console.WriteLine("6. Remove strings from Collection");
            Console.WriteLine("7. Enter a string to search in Collection");
            Console.WriteLine("8. Exit Menu");
            string? userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Please enter two numbers to add");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The sum of {num1} and {num2} is {num1+num2}");
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();
            }

            else if (userInput == "2")
            {
                Console.WriteLine("Enter a starting number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number to subtract from the first number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"When you subtract {num2} from {num1} the result is {num1-num2}");
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();
            }

            else if (userInput == "3")
            {
                Console.WriteLine("Enter two numbers to multiply together");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{num1} * {num2} is {num1*num2}");
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();


            }
            else if (userInput == "4")
            {
                Console.WriteLine("Enter a string to add to Collection");
                string str = Console.ReadLine();
                data1.AddStrings(str);
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();

            }
            else if (userInput == "5")
            {
                data1.ShowStrings();
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();
                
            }
            else if (userInput == "6")
            {
                data1.RemoveStrings();
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();

            }
            else if (userInput == 7)
            {
                
            }
            
            else if (userInput == "8")
            {
                repeat = false;
                Console.WriteLine("Goodbye");
            }

            else {
                Console.WriteLine("Invalid input, try again");
                Console.WriteLine("Press enter key to go back and try again");
                Console.ReadLine();
            };

            };

        }
    }
}