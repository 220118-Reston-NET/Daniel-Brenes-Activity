using System.Collections;
namespace CollectionFunction
{
    public class Collection
    {
        //Array 
        //Used to store a datatype and have a fixed size
        //Syntax: (datatype)[] (name of variable) = new (datatype)[(size of the array)];
        private int[] _nums = new int[5];
        //Generic Collection
        //They store a specific datatype and have variable size
        //Syntax: <(datatype)> 

        //List Collection
        //zero-based index
        //Used to store a datatype and has variable size
        private List<string> _strings = new List<string>();

        //Hashset Collection
        //There is no particular order to the elementsso NOT zero-based index
        //You cannot have duplicate elements 
        private HashSet<int> numCollections = new HashSet<int>();

        //Dictionary Collection
        //Stores information through key-value pairs
        //There is no particular order 
        private Dictionary<string, int> directory = new Dictionary<string, int>();

        //Non-generic Collection
        //They store any datatype and have variable size
        private ArrayList _nonGeneric = new ArrayList(); 
        public void CollectionMain()
        {
            Console.WriteLine("==== Collection Demo====");
            _nums[0] = 3;
            _nums[1] = 10;
            _nums[2] = 4;

            foreach (var item in _nums)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            for (int i = 0; i < _nums.Length; i++)
            {
                Console.WriteLine("Current value of i: " + i);
                Console.WriteLine(_nums[i]);
            }

            Console.WriteLine("===Generic Collection===");
            Console.WriteLine("==List Demo==");
            _strings.Add("First element");
            _strings.Add("Second element");
            _strings.Add("Third element");

            foreach (var item in _strings)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=HashSet Demo");
            numCollections.Add(1);
            numCollections.Add(2);
            numCollections.Add(3);
            numCollections.Add(1);
            
            foreach (var item in numCollections)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=Dictionary Demo=");
            directory.Add("Daniel", -100);
            directory.Add("Stephen", 100);
            directory.Add("Vijhan", -10000);
            directory.Add("Jonathon", 10000);

            foreach(var item in directory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---Non-generic Collection---");
            _nonGeneric.Add("Stephen");
            _nonGeneric.Add(10);
            _nonGeneric.Add(true);

        }
    }
}