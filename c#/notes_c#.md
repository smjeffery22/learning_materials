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

###

- `dotnet new console` to start with .NET application
  - `Program.cs` is the main file
  - `demos.csproj` is the settings file to compile and run program
  - `obj` folder is where the binaries are going to be contained

## Console Type

- `Console` is a type that represents the console window
- `WriteLine` is a method of the Console type that prints a line of text to that text console

```C#
Console.WriteLine("Hello World!");
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

## Numeric Types

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

- `do...while` loop executes the code first, then checks the condition

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

