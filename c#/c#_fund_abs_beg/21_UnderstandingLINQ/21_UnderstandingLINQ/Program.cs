namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            // LINQ Query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
            */

            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */

            // LINQ Method
            // var means C# lets the compiler figure out what the data type will be
            /*
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            
            foreach (var car in bmws)
            {
                Console.WriteLine($"{car.Model} {car.Make}");
            }
            */

            /*
            var orderedCars = myCars.OrderByDescending(p => p.Year);
                        
            foreach (var car in orderedCars)
            {
                Console.WriteLine($"{car.Year} {car.Model}");
            }
            */

            /*
            var firstBMW = myCars.First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN); // A1

            var firstBMW2 = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW2.VIN); // E5
            */

            /*
            // checks if all cars are made after year 2012
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));
            Console.WriteLine(myCars.TrueForAll(p => p.Year >= 2008));
            */

            /*
            myCars.ForEach(p => Console.WriteLine($"{p.VIN} {p.StickerPrice:C}"));
            myCars.ForEach(p => p.StickerPrice -= 3000); // subtracts 3000 from each StickerPrice
            myCars.ForEach(p => Console.WriteLine($"{p.VIN} {p.StickerPrice:C}"));
            */

            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));
            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            Console.WriteLine(myCars.GetType()); // System.Collections.Generic.List`1[UnderstandingLINQ.Car]
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType()); // System.Linq.OrderedEnumerable`2[UnderstandingLINQ.Car,System.Int32]

            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            Console.WriteLine(bmws.GetType()); // System.Linq.Enumerable+WhereListIterator`1[UnderstandingLINQ.Car]

            var newCars = from car in myCars
                          where car.Make == "BMW"
                          && car.Year >= 2009
                          select new { car.Make, car.Model };
            // System.Linq.Enumerable+WhereSelectListIterator`2[UnderstandingLINQ.Car,<>f__AnonymousType0`2[System.String,System.String]]
            //  two attributes [System.String,System.String]
            Console.WriteLine(newCars.GetType());

            foreach (var car in newCars)
            {
                Console.WriteLine(car);
            }
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}