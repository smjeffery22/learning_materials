class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Make = "Honda";
        myCar.Model = "Accord";
        myCar.Year = 2012;
        myCar.Color = "White";

        Console.WriteLine($"{myCar.Make} {myCar.Model}, {myCar.Year}, {myCar.Color}");

        //decimal value = DetermineMarketValue(myCar);
        //Console.WriteLine(value);

        Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
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

    public decimal DetermineMarketValue()
    {
        decimal carValue;

        if (Year > 2000)
            carValue = 10000;
        else
            carValue = 2000;

        return carValue;
    }
}