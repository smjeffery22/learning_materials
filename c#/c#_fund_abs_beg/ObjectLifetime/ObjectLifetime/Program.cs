class Program
{
    static void Main()
    {
        // in scope within the Main method
        Car myCar = new Car();
        //myCar.Make = "Honda";
        //myCar.Model = "Accord";
        //myCar.Year = 2012;
        //myCar.Color = "White";

        Car myThirdCar = new Car("Lexus", "RX360", 2010, "Lightblue");

        Car myOtherCar;
        // two references to the same object in memory
        myOtherCar = myCar;

        Console.WriteLine($"myOtherCar: {myOtherCar.Make} {myOtherCar.Model}, {myOtherCar.Year}, {myOtherCar.Color}");
        Console.WriteLine($"myCar: {myCar.Make} {myCar.Model}, {myCar.Year}, {myCar.Color}");
        Console.WriteLine($"myThirdCar: {myThirdCar.Make} {myThirdCar.Model}, {myThirdCar.Year}, {myThirdCar.Color}");

        // updates BOTH myCar and myOtherCar because they are pointing to the same 
        //myOtherCar.Year = 2022;

        //Console.WriteLine($"myOtherCar - updated: {myOtherCar.Make} {myOtherCar.Model}, {myOtherCar.Year}, {myOtherCar.Color}");
        //Console.WriteLine($"myCar - updated: {myCar.Make} {myCar.Model}, {myCar.Year}, {myCar.Color}");

        // reference to myCar object is lost
        // myOtherCar no longer points to any object in memory
        //myOtherCar = null;

        //Console.WriteLine($"myOtherCar - null: {myOtherCar.Make} {myOtherCar.Model}, {myOtherCar.Year}, {myOtherCar.Color}");

        // MyMethod method can be called without creating an instance of Car class
        Car.MyMethod();
    }

    private static decimal DetermineMarketValue(Car car)
    {
        decimal carValue = 100.00M;

        return carValue;
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    // constructor
    public Car()
    {
        //this.Make = "Nissan"; // 'this' is not necessary
        Make = "Nissan";
    }

    public Car(string make, string model, int year, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
    }

    // 'static' allows to call the method without creating an instance
    // can be called at any time
    public static void MyMethod()
    {
        Console.WriteLine("Called the static MyMethod");
    } 
}