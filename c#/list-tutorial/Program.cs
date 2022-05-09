// List with Strings
// WorkWithString();

void WorkWithString()
{
  var names = new List<string> { "Jeffery", "Ana", "Felipe" };

  foreach (var name in names)
  {
    Console.WriteLine($"Hello {name.ToUpper()}!");
  }

  Console.WriteLine();

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

  Console.WriteLine();

  // Search
  var index = names.IndexOf("Felipe");

  if (index == -1)
  {
    Console.WriteLine($"When an item is not found, IndexOf returnd {index}");
  }
  else
  {
    Console.WriteLine($"The name {names[index]} is at index {index}");
  }

  index = names.IndexOf("Not Found");

  if (index == -1)
  {
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
  }
  else
  {
    Console.WriteLine($"The name {names[index]} is at index {index}");
  }

  // Sort
  names.Sort();

  Console.WriteLine();

  foreach (var name in names)
  {
    Console.WriteLine($"Hello {name.ToUpper()}!");
  }
}

// List with Numbers
var fibonacciNumbers = new List<int> { 1, 1 };

// Challenge
for (int index = 2; index < 20; index++)
{
  var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
  var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

  fibonacciNumbers.Add(previous + previous2);
}

foreach (var item in fibonacciNumbers)
{
  Console.WriteLine(item);
}