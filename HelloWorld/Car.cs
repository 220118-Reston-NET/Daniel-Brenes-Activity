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
    private string _owner;
    private int _fuel;
    private var nameOfVar = ""; 

    //Property
    //They are in PascalCase ThisIsHowPascalCaseWillMakeASentence
    public string Color
    {
        get {return "The color is " + _color;}
        set {_color = value;}
    } 
    public string Owner
    {

         get { return myVar; }
        set { myVar = value; }
    }

    
}
}