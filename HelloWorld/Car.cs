//Namespace is a great way to organize your code
namespace CarFunction
{//This is how you create a class by using the class keyword
// Public is just there to make the class visible for everyone else

public class Car
{
    //Field
    //It is just a variable, holds information
    // used to define the current state of the object when you first make it
    // private means only the car class can use it.
    private string _color = "Blue";
    private string _owner = "";
    private int _gallonPerMile = 0;
    //private int _fuel = 0;
   // private var nameOfVar = ""; 

    //Property
    //They are in PascalCase ThisIsHowPascalCaseWillMakeASentence
    public string Color
    {
        get {return "The color is " + _color;}
        set {_color = value;}
    } 
  //  public string Owner
    //{

    //     get { return myVar; }
     //   set { myVar = value; }
  //  }
    public int Fuel {get ; set ; }

    // A method will run multiple lines of code to do some sort of operation/behavior/function
    //void this method will return/give back nothing
    //We can change void into another datatype if you want the method to give information back
    public void Start()
    {
        Console.WriteLine("The car is starting right now!");
        Console.WriteLine($"Current fuel: {Fuel}");

    }

    // You can add parameters to a method to pass in data to be used inside method
    // Make sure the parameter has a datatype and then a name
    public void Start(int p_fuel)
    {
        Fuel = p_fuel;
        Console.WriteLine("The car is starting right now!");
        Console.WriteLine($"Current fuel: {Fuel}");
    }
    public double TotalDistance()
    {
        return (double)Fuel/_gallonPerMile;
    }

    public Car(int p_fuel)
    {
        _color = "Blue";
        _gallonPerMile = 10;
        _owner = "No Owner";
        Fuel = 100;
        Console.WriteLine("Creating a car!");

    }
    
}
}