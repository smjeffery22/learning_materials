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

