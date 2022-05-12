using System.Collections;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.VIN = "A1";
            car1.Make = "Honda";
            car1.Model = "Accord";

            Car car2 = new Car();
            car2.VIN = "B2";
            car2.Make = "Lexus";
            car2.Model = "RX360";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */

            /*
            // ArrayLists are dynamically sized,
            // cool features sorting, remove items
            // Problem with ArrayLists is that it is not strongly typed
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
           
            // error when trying to print the value of b1
            // because foreach loop is strongly typed
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            // List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1); // cannot be added since List<T> is strongly typed

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            /*
            // Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["A1"]); // WorkingWithCollections.Car
            Console.WriteLine(myDictionary["A1"].Make);
            Console.WriteLine(myDictionary["B2"].Make);
            */

            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            // Object initializer syntax
            // no need for a Constructor
            Car car1 = new Car() { Make = "BMW", Model = "i8", VIN = "C3" };
            Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };

            // Collection initializer
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Honda", Model = "Accord", VIN = "E5" },
                new Car { Make = "Lexus", Model = "RX360", VIN = "F6" },
            };
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}