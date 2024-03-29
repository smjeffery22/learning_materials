﻿void WorkWithIntegers()
{
  int a = 18;
  int b = 6;
  int c = a + b;
  Console.WriteLine($"sum: {c}");

  c = a - b;
  Console.WriteLine($"subtraction: {c}");

  c = a * b;
  Console.WriteLine($"multiplication: {c}");

  c = a / b;
  Console.WriteLine($"division: {c}");
}

WorkWithIntegers();
Console.WriteLine("---------------------------");

void OrderPrecedence()
{
  int a = 5;
  int b = 4;
  int c = 2;
  int d = a + b * c;
  Console.WriteLine(d);

  d = (a + b) * c;
  Console.WriteLine(d);

  d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
  Console.WriteLine(d);

  int e = 7;
  int f = 4;
  int g = 3;
  int h = (e + f) / g;
  Console.WriteLine(h);
}

OrderPrecedence();
Console.WriteLine("---------------------------");