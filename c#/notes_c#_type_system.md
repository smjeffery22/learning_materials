# C# Type System

- C# is a strongly typed language
  - Every variable has a type
  - Used to store information
  - Expressions will return a value of a specified type

- Specifying the data type for a variable
  - Size and location in memory
  - Data type will decide where the data will be stored
  - Depending on data type, some are stored in heap and some in stack

- Data Types in C#
  - Pre-defined types
  - User-defined types

## Pre-defined Data Types

- bool
- int
- float
- double
- decimal
- char

- byte (8-bit integers; 0 to 255)
- short

- object
- string

## Converting Between Data Types

- *Implicit* conversion

```C#
int a = 123456789;
long l = a;
```

- *Explicit* conversion (Casting)

```C#
double d = 123456789.0;
int a = (int) d;
```

- *Helpers*

```C#
double d = 12345.0;
int a = (int)Convert.ChangeType(d, typeof(int));
```

## Implicit and Explicit Typing

- Implicit typing uses `var` keyword to auto-assign data type upon compilation
  - Type is inferred
  - Not as readable

- Explicit typing manually assigns data type (i.e. int, bool, double, etc.)

##  Strings

- String contains text, stored as collection of char objects

- Surround with double quotes "string"

- Reference type, but still primitive type

- Strings are *immutable*
  - Every operation (i.e. method) performed on a string will *result in a new string* being created
  - `StringBuilder` can be used to append to the existing string instead of creating a new one

### Escaping Text

- `\` is an escape character in string
  - `\n` new line
  - `\t` space

- `@` (verbatim strings) is used to prevent the use of `\\`
  - Ex. when writing filepath

```C#
string displayName = $"Welcome! \n{firstName}\t{lastName}";
//string invalidFilePath = "C:\data\employeelist.xlsx";
string validFilePath = "C:\\data\\employeelist.xlsx";
string marketingTagLine = "Baking the \"best pies\" ever";

string verbatimFilePath = @"C:\data\employeelist.xlsx";
```

### Parsing from Strings to Other Types

- Strings can be parsed into other types using `.Parse()` operation

```C#
string s = Console.ReadLine();
double wage = double.Parse(s);
bool active = bool.Parse("true");
```

## Methods

```C#
<access modifier> <return type> MethodName (Parameters)
{
  // method statements
}
```

- `<access modifier>` to indicate from where this method can be invoked
  - Ex. only from within this class or publicly

- `<return type>` must match the data type of what is being returned from the method
  - `void` return type if the method does not return anything

### Method Overloading

- Methods with the same name can be created, but each of them needs to have:
  - Different parameters
  - Different number of parameters
  - Different data type

```C#
public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
    if (numberOfMonthsWorked == 12)
    {
        return monthlyWage * (numberOfMonthsWorked + 1);
    }

    return monthlyWage * numberOfMonthsWorked;
}

public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
{
    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");

    return monthlyWage * numberOfMonthsWorked + bonus;
}
```

### Passing Parameters

- *By value:* default if nothing else is specified
  - Default way of passing parameters
  - A copy is created for the method
  - Value in caller stays the same
  - Copy of parameters are created within the method and processed

```C#
int a = 33;
int b = 44;

AddTwoNumbers(a, b);

public int AddTwoNumbers(int a, int b)
{
  b += 10;
  int sum = a + b;
  return sum;
}
```

- *By reference:* require use of ref keyword on parameters
  - A reference to the value is passed
  - No copy is made
  - Changes made in method *affect the original values*
  - `ref` keyword is used

```C#
int a = 33;
int b = 44;

AddTwoNumbers(a, ref b);

public int AddTwoNumbers(int a, ref int b)
{
  b += 10;
  int sum = a + b;
  return sum;
}
```

- `ref` keyword ensures the variable is *initialized*

- `out` keyword allows to pass in *uninitialized* variable
  - When you want the method to *return multiple values*
  - No need to assign values to parameters
  - Value can be assigned inside the method
  - Include `out` keyword in front of data type for both when creating and calling methods

```C#
private static void UsingOutParameters()
{
    int monthlyWage1 = 1800;
    int months1 = 12;
    int bonus;

    //int yearlyWage = CalculateYearlyWage(monthlyWage, months);

    int yearlyWageForEmployee1 = CalculateYearlyWageWithOut(monthlyWage1, months1, out bonus);
    Console.WriteLine($"Yearly wage for Employee 1: {yearlyWageForEmployee1}");
}

public static int CalculateYearlyWageWithOut(int monthlyWage, int numberOfMonthsWorked, out int bonus)
{
    bonus = new Random().Next(1000); // generate random number smaller than 1000

    if (bonus < 500)
    {
        bonus *= 2;
    }

    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
    Console.WriteLine($"The employee got a bonus of {bonus}");

    return monthlyWage * numberOfMonthsWorked + bonus;
}
```

### Params

- Represents an array to capture multiple parameters
  - To avoid writing multiple parameters

```C#
public int AddNumbers(params int[] values)
{
  for (int i = 0; i< values.Length>; i++)
  {
    // add values to calculate total
  }
}
```

### Optional Parameters

- Specify default value for one or more parameters
  - Caller can omit the optional ones

```C#
AddNumbers(10, 20);
AddNumbers(10, 20, 30);

public int AddNumbers(int a, int b, int c = 100)
{
  int sum = a + b + c;

  return sum;
}
```

### Named Arguments

- Not required to follow order of parameters
  - One or more parameters can have a name defined when invoking the method

```C#
AddNumbers(b: 10, a: 20);

public int AddNumbers(int a, int b, int c = 100)
{
  ...
}
```