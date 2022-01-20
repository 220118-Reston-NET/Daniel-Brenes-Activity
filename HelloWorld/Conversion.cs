namespace ConversionFunction
{
    public class Conversion
    {
        public static int _num;
        public static void ConversionMain()
        {
            //Implicit - just means something is done automatically (mostly it is the compiler)
            //Explicit - just means you have to write something to do it (essentially tell the compiler to do it anyway)
            Console.WriteLine("===Conversion Demo===");
            int x = 10;
            double y = 85.29;
            string str = "Hello World";

            //Implicit
            //The general rule is if you are going from a datatype to another datatype without losing information
            double anotherDouble = x;
            Console.WriteLine(anotherDouble);

            //Explicit conversion
            //The general rule is if you are going to lose information if you are trying to convert something
            //The compiler won't do it for you

            int anotherInt = (int)y;
            Console.WriteLine(anotherInt);

            //Another way of explicit conversion
           // double anotherDouble2 = Convert.ToDouble(str);



        }

        public int GiveMeNumber()
        {
            return _num;
        }
    }
}