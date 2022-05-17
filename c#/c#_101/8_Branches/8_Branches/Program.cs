var numbers = new int[] { 1, 2, 3, 4, 5 };
var type = numbers.GetType();

var strings = "Hello";
var type2 = strings.GetType();

Console.WriteLine(type.FullName);
Console.WriteLine(type2);