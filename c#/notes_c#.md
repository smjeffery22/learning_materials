# C#

- Most powerful programming language for .NET
  - Object-oriented
  - Type-safe
  - Enables writing .NET applications that are secure and robust

## .NET

- General purpose platform for developing variety of applications
  - Desktop / Web / Cloud / Mobile / Gaming / IoT / AI

- Software development platform for building *Windows applications*

- 3 major components to .NET framework
  - Runtime
  - Class libraries
  - Tools

- .NET framework class library is a *collection of classes* each containing *methods filled with functionality* that we can utilize in our applications
  - These classes and methods can be used inside our applications
  - Class libraries are split into multiple code files to avoid loading the entire library into memory every time
    - Codes files are called `.NET assemblies`
     
### .NET 6.0

- Latest version of .NET and cross platform implementation of .NET

- Supported OS:
  - Windows
  - Linux
  - macOS

## Development Environments

### Visual Studio Code

- Lightweight code editor

- Cross platform (Windows, Linux, MacOS)

- Extensions for every major programming language

### Visual Studio

- Comprehensive Integrated Development Environment (IDE) for .NET and C++

- Contains full suite of tools and features

```C#
using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

- `using System` allows to use System namespace that contains class libraries

- `void` method does not return anything
  - If a method returns a value, its type must be specified

- `Main` method is where the program begins
  - When the program is run, .NET looks for the Main method and automatically calls the method
  - Methods cannot stand on its own; need a class to contain it

- `string[] args` is equivalent to command line args from JavaScript

###

- `dotnet new console` to start with .NET application
  - `Program.cs` is the main file
  - `demos.csproj` is the settings file to compile and run program
  - `obj` folder is where the binaries are going to be contained

## Namespaces

- Namespaces can be imported into each other using `using Namespace` at the top of the code

```C#
// Program.cs
using System;
using WeatherUtilities = MyUtilities.WeatherUtilities; // to import a single method
using MyUtilities;

namespace MyFirstProgram
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            // MyUtilities.WeatherUtilities.Report("Toronto", 30, 50);
            WeatherUtilities.CelsiusToFahrenheit(30);
        }
    }
}

// WeatherUtilities.cs
using System;

namespace MyUtilities
{
    class WeatherUtilities
    {
        private static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            var temperatureCelsius = temperatureFahrenheit - 32 / 1.8f;
            return temperatureCelsius;
        }

        public static float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return temperatureCelsius * 1.8f + 32;
        }
    }
}
```

- Only `public` methods can be used in other files
- `private` methods can only be accessed within the same file
- `internal` methods are only accessible within the same assembly, but not from other assemblies

## Projects and Solutions

- *Project* produces a single thing, a *single assembly*
  - Assembly is an executable file or a *.dll file*

- *Solution* includes multiple projects, each producing its own assembly

## Types and Variables

### Value Type 

- *Value type* directly contain variables data
  - Can store data values in *its own memory*
  - Data stored on the *stack*
  - Variables each have their own copy of the data
  - Operations on one variable does not affect the other

- Simple types
- Enum types
- Struct types
- Nullable value types
- Tuple value types

### Reference Type

- *Reference type* stores reference to variables data
  - Does not store its value directly; saves the address where the value is kept
    - Contains a pointer to another memory location where the data is stored
  - Data stored on the *heap*
  - Possible for two variables to reference the same object
  - Possible for operations on one variable to affect the object referenced by the other variable

- Class types
- Interface types
- Array types
- Delegate types

### Variables

- Variables are storage containers for data values
  - int
  - double
  - char
  - string
  - bool

## Console Type

- `Console` is a type that represents the console window
- `WriteLine` is a method of the Console type that prints a line of text to that text console

```C#
Console.WriteLine("Hello World!");
```

## Built-in Types

- *string:* sequences of characters
- *char:* unicode UTF-16 characters
- *bool:* booleans (true/false)

## Type Inference

- Shortcut for specifying the types using `var` keyword (optional)
  - Implicit typing
  - Type can be inferred from the context/expression
  - Still type-safe

```C#
static float FahrenheitToCelsius(float temperatureFarenheit)
{
  // var will assign float type after the conversion
  var temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;
}
```

## String Type

- A *string* is an object of type *String* whose value is text
  - Internally, the text is stored as a sequential read-only collection of *Char* objects

- Declare a variable with texts using `string` type

- `Console.WriteLine()` method to print messages

- Use `$` and `{ }` for *string interpolation*

- Use `"""` for *string literal*
  - Opening and closing """ must start on their own line
  - Every line must be dented the same amount

### String Methods

- `.Length` to return the number of characters of a string

- `.Trim()` to trim leading/trailing spaces from a string
  - `.TrimStart()` to trim leading spaces from a string
  - `.TrimEnd()` to trim trailing spaces from a string

- `.Replace("text_to_search_for", "text_to_replace"_with)` to replace a substring of a string

- `.ToUpper()` and `ToLower()` to make a string ALL CAPS and all lower case, respectively

- `.Contains("substring_to_search")` to search if a string contains a substring
  - `.StartsWith("substring_to_search")` to search if a string starts with a substring
  - `.EndsWith("substring_to_search")` to search if a string ends with a substring
  - All three methods above *return a boolean*

```C#
// Variable Declaration and String Interpolation //
string firstFriend = "John";
string secondFriend = "Dennis";
string empty = String.Empty; // to initialize as an empty string

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

// String Literal
string multiLine = """
  "Hello World!" is typically the first program someone writes.
  This is the second line of the string literal
  """;

// Trim //
string greeting = "    Hello World    ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// Replace //
string sayHello = "Hello Word!";
Console.WriteLine(sayHello);

sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

// ToUpper and ToLower //
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// Contains, StartsWith and EndsWith //
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));    // true
Console.WriteLine(songLyrics.Contains("greetings"));  // false

Console.WriteLine(songLyrics.StartsWith("You"));      // true
Console.WriteLine(songLyrics.StartsWith("I"));        // false

Console.WriteLine(songLyrics.EndsWith("hello"));      // true
Console.WriteLine(songLyrics.EndsWith("goodbye"));    // false
```

### String vs. Char

- `string` is declared with `" "` and `char` is declared using `' '`
  - string is an *immutable reference type*
  - char is a *value type*

- https://stackoverflow.com/questions/41564445/how-are-strings-vs-chars-handled-in-c-sharp-vs-javascript

### String Concatenation

- Concatenating a string using string type creates a new string every time
  - String is immutable
  - A new string is created, copies previous value then adds new value to it
  - Inefficient and requires a lot of memory management

- `StringBuilder` class represents a mutable string of characters
  - Does not create new variable
  - Use along with `.Append()` method

```C#
// string type
string myString = "";

for (int i = 0; i < 100; i++)
{
  myString += "--" + i.ToString();
}

// StringBuilder class
StringBuilder myString = new StringBuilder();

for (int i = 0; i < 100; i++)
{
  myString.Append("--");
  myString.Append(i);
}
```

## Numeric Types

- *sbyte:* 8 bits; from -128 to 127
- *short:* 16 bits; from -32,768 to 32,767
- *int:* 32 bits; from -2,147,483,648 to 2,147,483,647
- *long:* 64 bits; from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

- *float:* 32 bits; floating point (~6-9 digits)
- *double:* 64 bits; floating point (~6-9 digits)
- *decimal:* 128 bits; floating point (~6-9 digits)

### Integer

- `int` type to declare a variable with a value of positive/negative *whole number*
  - Integer division always produces an integer result (no decimal)

- int type has min and max limits (-2147483648 to 2147483647)
  - If added to the max value, it overflows and carries on to the smallest negative number

```C#
int max = int.MaxValue;
int min = int.MinValue;
// -2147483648 to 2147483647
Console.WriteLine($"The range of integers is {min} to {max}");

// -2147483646
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
```

### Double

- `double` numeric type represents a double-precision floating point number

- *Floating point* number is useful to represent non-integral numbers

- *Double precision* is a relative term that describes the numbers of binary digits used to store the value
  - Double precision number have twice the number of binary digits as single precision

- More common to use double precision than single precision numbers
  - Single precision numbers are declared using `float` keyword

```C#
double max = double.MaxValue;
double min = double.MinValue;
// -1.79769313486232E+308 to 1.79769313486232E+308
Console.WriteLine($"The range of double is {min} to {max}");
```

### Decimal

- `decimal` type has a smaller range, but greater precision than double
  - `M` suffix on the number to indicate that a constant should use the decimal type
    - Otherwise, the compiler assumes the double type

```C#
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
// -79228162514264337593543950335 to 79228162514264337593543950335
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
// 0.333333333333333
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
//0.3333333333333333333333333333 => greater precision
Console.WriteLine(c / d);
```

## Branches and Loops

### If Statement

- Combine `if` and `else` conditions enclosed within `{ }`

```C#
int a = 5;
int b = 5;
int c = 4;

if ((a + b + c > 10) && (a == b))
{
  Console.WriteLine("The answer is greater than 10.");
  Console.WriteLine("And the first number is equal to the second");
}
else
{
  Console.WriteLine("The answer is not greater than 10.");
  Console.WriteLine("And the first number is not equal to the second");
}
```

### While Statement

- `do...while` loop executes the first block of code first at least once, then checks the while condition

```C#
int counter = 0;

while (counter < 10)
{
  Console.WriteLine($"Hello World! The counter is {counter}.");
  counter++;
}

int counter = 0;
do
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
} while (counter < 10);
```

### For Loop

- Three parts that control `for` loop
  - `for initializer` declares the loop variable and sets its value
  - `for condition` declares the condition that the for loop continues to execute until
  - `for iterator` specifies how the loop variable should be modified after executing the block of code

```C#
for (int index = 0; index < 10; index++)
{
  Console.WriteLine($"Hello World! The index is {index}");
}
```

## List Collections - List<T> Type

- Create a list of collections with a specific type
  - Specify the type in `<T>`

- List<T> type enables to add/remove elements
  - `.Add()` and `.Remove()` methods

- Each element in the list can be accessed using index

- List length can be checked using `.Count` property

```C#
var names = new List<string> { "Jeffery", "Ana", "Felipe" };

names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");

foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine();

Console.WriteLine($"My name is {names[0]}");
Console.WriteLine($"I have added {names[2]} and {names[3]} to the list.");
Console.WriteLine($"Ths list has {names.Count} people in it");
```

### Search and Sort Lists

- `.IndexOf` method searches for an item in the list
  - Returns the index of the item
  - If not found, returns -1

- `.Sort()` method sorts all the items in the list in order

```C#
var index = names.IndexOf("Felipe");

if (index == -1)
{
  Console.WriteLine($"When an item is not found, IndexOf returnd {index}");
} else
{
  Console.WriteLine($"The name {names[index]} is at index {index}");
}
```

## ## List Collections - Dictionary<Tkey, Tvalue> Type

- Like a dictionary; key-value (word-definition) pair with types

```C#
class Car
{
    public string VIN { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
}

Car car1 = new Car();
car1.VIN = "A1";
car1.Make = "Honda";
car1.Model = "Accord";

Car car2 = new Car();
car2.VIN = "B2";
car2.Make = "Lexus";
car2.Model = "RX360";

Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

myDictionary.Add(car1.VIN, car1);
myDictionary.Add(car2.VIN, car2);

Console.WriteLine(myDictionary["A1"].Make);
Console.WriteLine(myDictionary["B2"].Make);
```

## Arrays

- Fixed-size sequential collection of elements of the same type
  - Collection of variables of the same type stored in contiguous memory locations

- Array is a reference type so `new` keyword is required to create an instance of the array

```C#
// declare array and assign elements separately
int[] numbers = new int[5];

numbers[0] = 4;
numbers[1] = 8;
numbers[2] = 15;
numbers[3] = 16;
numbers[4] = 23;
//numbers[5] = 42;

Console.WriteLine(numbers[1]);
Console.WriteLine(numbers.Length);

// declare and assign values at the same time
int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

for (int i = 0; i < names.Length; i++)
{
   Console.WriteLine(names[i]);
}

foreach (string name in names) 
{
   Console.WriteLine(name);
}
```

## Dates and Times

```C#
// current date and time
DateTime myValue = DateTime.Now;

Console.WriteLine(myValue.ToString()); // 2022 - 05 - 09 10:17:40 PM
Console.WriteLine(myValue.ToShortDateString()); // 2022 - 05 - 09
Console.WriteLine(myValue.ToShortTimeString()); // 10:17 PM
Console.WriteLine(myValue.ToLongDateString()); // Monday, May 9, 2022
Console.WriteLine(myValue.ToLongTimeString()); // 10:17:40 PM

Console.WriteLine(myValue.AddDays(3).ToLongDateString()); // adds 3 days to current date
Console.WriteLine(myValue.AddDays(-3).ToLongDateString()); // subtracts 3 days to current date
Console.WriteLine(myValue.AddHours(3).ToLongTimeString()); // adds 3 hours to current time

Console.WriteLine(myValue.Month); // returns the current month in integer

// specific date and time
DateTime myBirthday = new DateTime(1992, 6, 22);
//DateTime myBirthday = DateTime.Parse("06/22/1992");

Console.WriteLine(myBirthday.ToShortDateString());

TimeSpan myAge = DateTime.Now.Subtract(myBirthday); // subtracts myBirthday from the current time
Console.WriteLine(myAge.TotalDays); // converts the result from above to the total number of days
```

## Classes

- `Class` is like a data type similar to string, int, etc.
  - Allows to define additional properties and methods
  - `Instances` of the Class can be created using `new` operator
    - Object's (new instance) properties and methods can be accessed using `.` operator

### Accessibility Modifiers

- `public` and `private` keywords are both accessibility modifiers
  - Used to implement a tentative object-oriented programming called `encapsulation`

- `public` methods are exposed to anybody who needs to work with the class through that method
  - Accessible in other codes *outside the class*

- `private` methods can be called by any other methods inside the class
  - Accessible only *inside the class*
  - Not accessible from an instance of the class
  - Helper methods to public methods


```C#
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

        // Object initializer syntax
        // no need for a Constructor
        Car car1 = new Car() { Make = "BMW", Model = "i8", Year = 2022, Color = "White" };
        Car car2 = new Car() { Make = "Toyota", Model = "4Runner", Year = 2022, Color = "White" };

        // Collection initializer
        List<Car> myList = new List<Car>()
        {
            new Car { Make = "Honda", Model = "Accord", Year = 2022, Color = "White" },
            new Car { Make = "Lexus", Model = "RX360", Year = 2022, Color = "White" },
        };
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
```

## LINQ (Language Integrated Query Syntax)

- To perform filter, sort and other aggregate operations on collections of data types

- Two different styles of LINQ syntax
  - *Query syntax*
    - Resembles the SQL for querying database
  - *Method syntax*
    - 

## Blank Solution

- In Visual Studio, create `New Project` => `Blank Solution`
  - Right click solution, `Add` => `New Project`

## Program Flow

- The order and conditions under which different parts of an application execute
  - Provides structure around when and how our app takes certain actions or makes decisions, handles repetitive tasks, etc.

- *Statements* are basic instructions that C# program executes to take action
  - Written using a combination of C# *keywords* and *expressions*
    - Expressions are combination of operands and operators
    - Operator performs an action on an operand
  - Small, complete tasks that can be assembled into very complex logic
  - Order in which the statements collectively execute is called *program flow*
  - Ex. declaring variables, math calculations, console, calling methods, etc.
 
- *Selection statements* => if-else
  - if (condition) { // do something}

- *Iteration statements* => loops
  - foreach (item in list) { // do something }

- *Declaration statements* => creating variables
  - string greeting;

- *Expression statements* => perform tasks
  - int sum = 50 + 50;

- *Exception statements* => catch and address issues
  - try { // risky code } catch { // fallback }

