# C#

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