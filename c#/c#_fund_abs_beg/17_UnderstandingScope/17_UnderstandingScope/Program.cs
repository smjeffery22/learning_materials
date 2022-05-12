namespace UnderstandingScope
{
    class Program
    {
        // private is private in nature
        //  but available to all members of this class
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l); // not accessible outside if statement
            }
            //Console.WriteLine(i); // i is outside the for loop scope and not accessible
            Console.WriteLine($"Outside of for loop j {j}");
            Console.WriteLine($"Outside of for loop k: {k}");

            HelperMethod();

            Car myCar = new Car(); // helperMethod not accessible
            myCar.DoSomething();
        }

        static void HelperMethod()
        {
            Console.WriteLine($"Value of k from the HelperMethod(): {k}");
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World!";
        }
    }
}