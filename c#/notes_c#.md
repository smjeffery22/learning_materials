# C#

## Console Type

- `Console` is a type that represents the console window
- `WriteLine` is a method of the Console type that prints a line of text to that text console

```C#
Console.WriteLine("Hello World!");
```

## String Type

- Declare a variable with texts using `string` type
- `Console.WriteLine()` method to print messages
- Use `$` and `{ }` for *string interpolation*

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

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

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

### 