namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        //Car and assigning values
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black - MS";
        myCar.year = 2020;

        //The starter code
        myCar.Display();
        Console.WriteLine("Car has 55 miles on the spedometer");
        Console.WriteLine("---");

        // Problem 1: Call Start()
        myCar.Start();
        Console.WriteLine("---");

        // Problem 2: Call Drive()
        myCar.Drive(55); // I hated how this sounded on the ran out put so I wrote it out differently above in a console writeline. - Hope thats OK
        Console.WriteLine("---");

        // Problem 3: GetDescription()
        string description = myCar.GetDescription();
        Console.WriteLine(description); // print 2020 Black Civic
        Console.WriteLine("---");

        // Problem 4: Call Repaint()
        myCar.Repaint("Matte Silver - MS");
        Console.WriteLine("New color is: " + myCar.color); //  print "New color is: MS"
    }
}
class Car
{
    public string model;
    public string color;
    public int year;

    //  car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }
    // Problem 1:Method with No Parameters
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Problem 2:Method with Parameters
    public void Drive(int miles)
    {
        Console.WriteLine("The car drove " + miles + " miles.");
    }

    // Problem 3:Method with a Return Value
    public string GetDescription()
    {
        return $"{year} {color} {model}";
        //: return year + " " + color + " " + model;
    }

    // Problem 4: Adding Method 
    public void Repaint(string newColor)
    {
        this.color = newColor; 
        Console.WriteLine("The car has been repainted to " + newColor + ".");
    }
}
