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
            int menuInput  = Convert.ToInt32(Console.ReadLine());
            
            switch(menuInput)
            {
            case 1:
                Console.WriteLine("Please enter two numbers to add");
                int num11 = Convert.ToInt32(Console.ReadLine());
                int num22 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The sum of {num11} and {num22} is {num11+num22}");
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();
                break;

            case 2:
            
                Console.WriteLine("Enter a starting number");
                int num10 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number to subtract from the first number");
                int num20 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"When you subtract {num20} from {num10} the result is {num10-num20}");
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();
                break;

            case 3:
            
                Console.WriteLine("Enter two numbers to multiply together");
                int num13 = Convert.ToInt32(Console.ReadLine());
                int num23 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{num13} * {num23} is {num13*num23}");
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();
                break;

            
            case 4:
            
                Console.WriteLine("Enter a string to add to Collection");
                string str = Console.ReadLine();
                data1.AddStrings(str);
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();

                break;

            case 5:
            
                data1.ShowStrings();
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();
                break;
            
            case 6:
            
                data1.RemoveStrings();
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();
                break;
            
            case 7:
            
                data1.SearchStrings();
                break;
            
            case 8:
            
                repeat = false;
                Console.WriteLine("Goodbye");
                break;

            default:
            
                Console.WriteLine("Invalid input, try again");
                Console.WriteLine("Press enter key to go back and try again");
                Console.ReadLine();
                break;

            };
            }
        }
    }
}