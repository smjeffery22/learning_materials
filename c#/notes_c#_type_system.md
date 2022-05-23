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

## Common Type System (CTS)

- .NET specific

- Defines a framework/standard that languages can rely on to be able to interact with one another

- Defines how type definitions and values are handled in memory

- Shared across multiple languages including C#

### Type Hierarchy

- At the top of the hierarchy, there is the *Object* type
  - Every other type will be derived (inherited) from the Object type

### Five Categories of Types

1. Enumeration (value types)
2. Struct (value types)
3. Class (reference types)
4. Interface (reference types)
5. Delegate (reference types)

### Types in .NET and C#

- *Value data types*
  - Data stored on the *stack*
  - Predefined data types
    - Integer
    - Boolean
  - User defined types
    - Enumeration
    - Struct

- *Reference data types*
  - Data stored on the *heap*
  - Predefined data types
    - String
    - Array
  - User defined types
    - Class
    - Interface

## Custom Types

- In .NET, there is the *Base Class Library (BCL)*
  - Large library used to write C# applications
  - Contains a huge number of custom types (mostly classes)

- Classes are grouped in *namespaces*
  - Way to organize types while in groups
  - Can have multiple types with the same name, as long as they live in a different namespace

- *using* keyword only brings the types within the specified namespace, not the ones in nested namespaces

```C#
using System

System
  - System.Web
  - System.IO
  - System.Windows
  - System.Data
    - System.Data.Common
    - System.Data.SqlTypes
```

### Class

- Reference type and most commonly used
  - Struct is similar, but not used as often because it is a value type

- To create an empty class in Visual Studio
  - Right Click File - Add - New File - Empty Class

- *Object* is an instance of a class
  - Process of creating an object is called *instantiation*
  - Created using `new` keyword

- Variable contains a reference to the object (*pointer*)

- *Constructor* is automatically called when an object is instantiated
  - Same name as the class name
  - Default or custom
  - Used to set initial values
  - Typically comes after variable initialization

- If a variable is assigned to another variable, they both point to the same object in memory
  - Two references pointing to the same object
  - Changing data in one changes the data in both variables

#### Access Modifiers

- *Public* methods are part of public API of the class
  - Can be used outside the class
  - Can be invoked on objects of the class

- *Private* methods/fields are only accessible from within the class
  - For methods that you don't want anyone to use directly

- *Protected:* functionality is available for the class and its inheritance

#### Properties

- Properties are members of a class, like methods
  - Wraps data (fields) of a class
  - Hide implementation
  - Define *get* and *set* implementation

- Can include logic such as validating if the passed value is valid
  - Both for getting access to the actual value, as well as for setting the value
  - Hidden and internally works 

- Properties are typically public
  - Same type as the field it is wrapping
    - Field typically private
      - Need to use set in property to change data
  - Typically the same name as the field in PascalCase
    - Use this PascalCase name throughout

#### Custom Namespaces

- Folders can be created and contain files with custom namespaces
  - `NamespaceName.FolderName`
  - Dot notation to create namespace within namespace
  - Include `using NamespaceName.FolderName` to import namespace in another namespace

#### Static

- Values defined with *static* keyword will not be instantiated
  - Defined on the *class level*
  - Shared for all objects of the given type
  - If the value is changed, it is changed for all objects
  - Cannot be accessed through objects, only through class

- Inside static methods, only static data can be used

- Constant variables can be created using `const` keyword
  - Value must be initialized upon variable initialization

#### Null

- When a variable is created using class, but an object is not instantiated, the variable is *null*
  - Variable declared on Stack, but not pointing to an object on Heap
  - Cannot call any methods (runtime error)

- Nullable value types can be created using `?` in data type
  - `int? a = null`

- `Null coalescing operator` allows to set default value for a null variable
  - `hourlyRate = rate ?? 10;` sets rate as 10 if rate is null
  - `double wageBeforeTax = numberOfHoursWorked * hourlyRate.Value;` .Value allows to use the value of nullable variable

#### Garbage Collection

- When an object is created and set to null:
  - Object still exists in memory without any reference pointing to it
    - Memory wasted
  - Link it broken

- Garbage collection is a process that runs in the background (.NET feature)
  - Runs through the memory and looks for objects with no reference
    - Considered unreachable and removed from memory automatically

- Common Language Runtime (CLR) will automatically run garbage collection when the memory is low

```C#
// Left side: create variable
//  Employee: variable type
//  employee: variable name
// Right side: create object
//  Employee: class
//  ("Jeffery", 29): constructor arguments
Employee employee = new Employee("Jeffery", 29); // Instantiating the object
employee.PerformWork(); // Invoking a method
employee.firstName = "Jeff"; // Changing a field
int wage = employee.ReceiveWage(); // Returning a value from a method

////////////////////////////////////////////////

Employee employee = new Employee();
employee.FirstName = "Jeffery" // Setting a value through a property
int empFirstName = employee.FirstName; // Getting the value through a property

public class Employee
{
    public string firstName;
    public string lastName;
    public int age;

    // Constructor
    public Employee(string firstName, int ageValue)
    {
      firstName = firstName;
      age = ageValue;
    }

    ////////////////////////////////////////////////

    private string firstName;
    public string FirstName
    {
      get { return firstName };
      set
      {
        firstName = value;
      }
    }
}
```

### Struct

- Value type and similar to Class with a few specific properties

- Allows to create a custom data structure
  - For lightweight structures (limited amount of data)

- Can contain methods and other members 

- `Field` is a variable defined on the struct root level

```C#
struct Employee
{
  public string Name;
  public string Department;
  public void GetPaid()
  {
    // Code to pay out wage
  }
}

Employee employee (strcut name - variable name)
employee.Name = "Bethany"; // Name field
employee.Department = "Sales"; // Department field
```

### Enumeration

- Named constants for improved readability

- Created using `enum` keyword
  - Name of the enum becomes a custom type

```C#
static void Main(string[] args)
{
    UsingEnumerations(); 
}

private static void UsingEnumerations()
{
    EmployeeType employeeType = EmployeeType.Manager;
    StoreType storeType = StoreType.FullPieRestaurant;

    int baseWage = 1000;

    CalculateWage(baseWage, employeeType, storeType);
}

// Using custom-created types in parameters
private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
{
    int calculatedWage = 0;

    if (employeeType == EmployeeType.Manager)
    {
        calculatedWage = baseWage * 3;
    }   else
    {
        calculatedWage *= 2;
    }

    if (storeType == StoreType.FullPieRestaurant)
    {
        calculatedWage += 500;
    }

    Console.WriteLine($"The calculated wage is {calculatedWage}.");
}

// default values start from 0    
enum EmployeeType
{
    Sales, // 0
    Manager, // 1
    Research, // 2
    StoreManager // 3
}

// values can be assinged
enum StoreType
{
    PieCorner = 10,
    Seating = 20,
    FullPieRestaurant = 100,
    Undefined = 99
}
```

## Inheritance

- Object gets data and functionality from parent
  - Reusability of code
  - Can inherit multiple levels deep

- Parent (base) class contains the shared functionality

- Derived (child) class adds specific functionality

- Members defined as private on the base class are not accessible (internal to the class)
  - Cannot be accessed by inheriting types
  - Public and private members are accessible by inheriting types

### Sealed Class

- `sealed` keyword is used to prevent a class from being inherited

```C#
public sealed class Developer : Employee
{
  ...
}

// Error: JuniorDeveloper cannot derive from sealed type Developer
public class JuniorDeveloper : Developer
{
  ...
}
```

### Abstract Class

- Used to model a concept, something abstract
  - Ex. to group common functionality, but not allowing to instantiate

- Missing complete implementation

- Cannot be instantiated, but can be inherited

- Abstract method must be overridden in the inherited class to provide implementation
  - Abstract method cannot contain a body (i.e. code)
  - If implementation is not provided, cannto build

```C#
public abstract class Employee
{
  public abstract void ReceiveWage();
}

public class Manager : Employee
{
  public override void ReceiveWage()
  {
    ...
  }
}
```

## Polymorphism

- Override a base class method with a new implementation
  - Allows to give different forms to the same method

- Uses `virtual` and `override` keywords
  - Use virtual keyword in base class to specify that the method can be overridden
  - Use override keyword in inherited class to override the method

```C#
public class Employee
{
  public virtual void PerformWork()
  {
    ...
  }
}

public class Manager : Employee
{
  public override void PerformWork()
  {
    ...
  }
}
```

## Interfaces

- Define a contract that must be implemented by classes that use it

- Uses `interface` keyword

- Typically contain no implementation code
  - Up to implementing classes to provide it
  - Interfaces can provide default implementation that will be used if the class does not provide one

- Cannot be instantiated, similar to abstract

- Interface name typically starts with `I`

```C#
public interface IEmployee
{
  void PerformWork(); // no implementation code
}

public void Manager: IEmployee
{
  public void PerformWork()
  {
    ... // implementation code provided
  }
}
```

- Implementing an interface is similar to inheriting from base class
  - Manager class implements the contract (IEmployee or interface)
  - Class is assigning the contract
    - An implementation must be provided for every method without an implementation in the interface

- Abstract classes: only single inheritance is permitted

- Interface: possible to implement more than one interface on a single class

### Commonly Used Interfaces in C#

- `IComparable` interface defines a method that is typically used to compare two objects of a certain type with each other

- `IEquatable` interface is used to provide a functionality to check equality between two objects

- `ICloneable` interface is used to provide a method that clones an object

- `IEnumerable` provides a way to enumerate the items in a list

- `IList` interface is related to IEnumerable; implemented by collection classes that allow accessing elements using an index

- `IDisposable` interface is used to provide a way to dispose of unmanaged resources