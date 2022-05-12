class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The Name Game");

        Console.Write("What's your first name>? ");
        string firstName = Console.ReadLine();

        Console.Write("What's your last name? ");
        string lastName = Console.ReadLine();

        Console.Write("In what city were you born? ");
        string city = Console.ReadLine();

        //    char[] firstNameArray = firstName.ToCharArray();
        //    Array.Reverse(firstNameArray);

        //    char[] lastNameArray = lastName.ToCharArray();
        //    Array.Reverse(lastNameArray);

        //    char[] cityArray = city.ToCharArray();
        //    Array.Reverse(cityArray);

        //    string result = "";

        //    foreach (char item in firstNameArray)
        //    {
        //        result += item;
        //    }

        //    result += " ";

        //    foreach (char item in lastNameArray)
        //    {
        //        result += item;
        //    }

        //    result += " ";

        //    foreach (char item in cityArray)
        //    {
        //        result += item;
        //    }

        //    Console.WriteLine("Results: " + result);


        string reversedFirstName = ReverseString(firstName);
        string reversedLastName = ReverseString(lastName);
        string reversedCity = ReverseString(city);
        string message = reversedFirstName + " " + reversedLastName + " " + reversedCity;

        DisplayResult(reversedFirstName, reversedLastName, reversedCity);
        Console.WriteLine();
        DisplayResult(message);
    }


    // using string instead of void makes this method return something at the end
    private static string ReverseString(string message)
    {
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);

        return String.Concat(messageArray);
    }

    private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
    {
        Console.Write("Results: ");
        Console.Write($"{reversedFirstName} {reversedLastName} {reversedCity}");
    }


    // same method name can be used if the intake parameters are different
    //  accepting different types
    private static void DisplayResult(string message)
    {
        Console.Write("Results: ");
        Console.Write($"{message}");
    }
}

//foreach (char item in messageArray)
//{
//    Console.Write(item);
//}
//Console.Write(" ");