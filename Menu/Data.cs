namespace DataFunction
{
    public class Data
    {
        private List<string> _strings = new List<string>();

        public void AddStrings(string inputVal)
        {
            _strings.Add(inputVal);

        }
        public void ShowStrings()
        {
            foreach(var item in _strings)
            {
                Console.WriteLine(item);
            }
        }
        public void RemoveStrings()
        {
            Console.WriteLine("Which item would you like to remove?");

            for (int i =0; i < _strings.Count; i++)
            {
                Console.WriteLine(i + ":" + _strings[i]) ;
            }
            Console.WriteLine("Enter an integer");
            int inputVal = Convert.ToInt32(Console.ReadLine());

            if (inputVal >= 0 && inputVal < _strings.Count)
            {
                _strings.Remove(_strings[inputVal]);
                Console.WriteLine("Succussful Removal");
            }

        }
        public void SearchStrings()
        {
            Console.WriteLine("Enter the string you are looking for");
            string inputVal = Console.ReadLine();

            if (_strings.Contains(inputVal))
            {
                Console.WriteLine("String Found");
            }
            else
            {    
                Console.WriteLine("String not found");
            }
        }
    }
}