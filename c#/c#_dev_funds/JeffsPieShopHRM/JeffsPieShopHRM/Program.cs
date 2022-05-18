using System;
using System.Text;

namespace JeffsPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthlyWage = 1234;
            int months = 12, bonus = 1000;

            bool isActive = true;
            double rating = 99.25;

            //byte numberOfEmployees = 300; // error
            //monthlyWage = true; // error

            double ratePerHour = 12.34;
            int numberOfHoursWorked = 165;

            double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;

            Console.WriteLine(currentMonthWage);

            ratePerHour += 3;

            if (currentMonthWage > 2000)
            {
                Console.WriteLine("Top paid employee!");
            }
                        
            int numberOfEmployees = 15;
            numberOfEmployees--;

            Console.WriteLine();

            //bool a; // default value of false
            //int b; // default value of 0

            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;
            double doubleMaxValue = double.MaxValue;

            Console.WriteLine(intMaxValue);
            Console.WriteLine(intMinValue);
            Console.WriteLine(doubleMaxValue);

            Console.WriteLine();

            char myChar = 'a';
            bool isLetter = char.IsLetter(myChar);
            bool isWhiteSpace = char.IsWhiteSpace(myChar);
            bool isDigit = char.IsDigit(myChar);
            bool isPunctuation = char.IsPunctuation(myChar);

            Console.WriteLine(isLetter);
            Console.WriteLine(isWhiteSpace);
            Console.WriteLine(isDigit);
            Console.WriteLine(isPunctuation);

            Console.WriteLine();

            DateTime hireDate = new DateTime(2021, 03, 28, 14, 30, 0);
            DateTime exitDate = new DateTime(2021, 12, 11);
            //DateTime invalidDate = new DateTime(2021, 15, 11); // not valid month
            DateTime startDate = hireDate.AddDays(15);
            DateTime currentDate = DateTime.Now;
            bool areWeInDst = currentDate.IsDaylightSavingTime();

            Console.WriteLine(hireDate);
            Console.WriteLine(exitDate);
            //Console.WriteLine(invalidDate);
            Console.WriteLine(startDate);
            Console.WriteLine(currentDate);
            Console.WriteLine(areWeInDst);

            Console.WriteLine();

            DateTime startHour = DateTime.Now;
            TimeSpan workTime = new TimeSpan(8, 35, 0); // 8 hr 35 mins 0 sec
            DateTime endHour = startHour.Add(workTime); // adds 8 hr 35 mins 0 sec

            Console.WriteLine(startHour);
            Console.WriteLine(workTime);
            Console.WriteLine(endHour);

            Console.WriteLine(startHour.ToLongDateString()); // Tuesday, May 17, 2022
            Console.WriteLine(endHour.ToShortTimeString()); // 11:06 PM

            Console.WriteLine();

            int z = 123456789;
            long y = z;

            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine("--");

            double x = 123456789.0;
            int w = (int)x;

            Console.WriteLine(x);
            Console.WriteLine(w);
            Console.WriteLine("--");

            double v = 12345.0;
            int u = (int)Convert.ChangeType(v, typeof(int));

            Console.WriteLine(v);
            Console.WriteLine(v.GetType().FullName);
            Console.WriteLine(u);
            Console.WriteLine(u.GetType().FullName);

            Console.WriteLine();

            string s1 = string.Empty;
            string s2 = null;

            Console.WriteLine("--");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine("--");

            Console.WriteLine();

            string firstName = "Jeffery";
            string lastName = "Park";
            string fullName = firstName + " " + lastName;
            string employeeIdentification = string.Concat(firstName, lastName);

            string empId = firstName.ToLower() + "-" + lastName.ToLower();

            int length = empId.Length;

            if (fullName.Contains("Jeff") || fullName.Contains("jeff"))
            {
                Console.WriteLine("It's Jeffery!");
            }

            string subString = fullName.Substring(0, 4);
            Console.WriteLine("Characters 1 to 4 of fullName are " + subString);

            string nameUsingInterpolation = $"{firstName.ToUpper()}-{lastName.ToUpper()}";
            string greeting = $"Hello, {firstName}.";

            Console.WriteLine();

            string displayName = $"Welcome! \n{firstName}\t{lastName}";

            Console.WriteLine(displayName);

            //string invalidFilePath = "C:\data\employeelist.xlsx";
            string validFilePath = "C:\\data\\employeelist.xlsx";
            string verbatimFilePath = @"C:\data\employeelist.xlsx";

            string marketingTagLine = "Baking the \"best pies\" ever";

            Console.WriteLine($"Equal? ({firstName == lastName})");

            Console.WriteLine();

            string a = "Hello";
            string b;

            b = a;
            b += " world";

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine();

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Employee list");
            stringBuilder.AppendLine("Bethany Smith");
            stringBuilder.AppendLine("George Jones");
            stringBuilder.AppendLine("Gill Cleeren");
            Console.WriteLine($"stringBuilder: {stringBuilder}");

            string list = stringBuilder.ToString();
            Console.WriteLine($"list: {list}");

            Console.WriteLine();

            string name = "Jeffery";
            string anotherName = name;

            name += " Park"; // a new string is created and name is pointed to that new string

            Console.WriteLine("name: " + name);
            Console.WriteLine("anotherName: " + anotherName); // still pointing to the original name

            // does not touch the original string
            // returns a copy of the original srting with lowercase
            string lowerCaseName = name.ToLower();

            // for loop will create 2500 different strings and take up memory, but typical
            // use of StringBuilder could be beneficial
            string indexes = string.Empty;
            for (int i = 0; i < 2500; i++)
            {
                indexes += i.ToString();
            }

            Console.WriteLine();

            StringBuilder builder = new StringBuilder();

            builder.Append("Last name: ");
            builder.AppendLine(lastName);
            builder.Append("First name: ");
            builder.Append(firstName);
                        
            string result = builder.ToString();

            Console.WriteLine(result);

            Console.WriteLine();

            string s = "22";
            Console.WriteLine(s);


            double wage = double.Parse(s);
            Console.WriteLine(wage);

            bool active = bool.Parse("true");
            Console.WriteLine(active);

            Console.WriteLine();

            Console.WriteLine("Enter the wage:");
            string myWage = Console.ReadLine();

            //int wageValue = int.Parse(myWage);
            int wageValue;

            // pass in myWage and see if it can be parsed into wageValue type
            if (int.TryParse(myWage, out wageValue))
            {
                Console.WriteLine("Parsing success: " + wageValue);
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }

            Console.WriteLine();

            string hireDateString = "12/12/2020";
            DateTime myHireDate = DateTime.Parse(hireDateString);
            Console.WriteLine("Parsed date: " + myHireDate);


            //Console.ReadLine();
        }
    }
}
