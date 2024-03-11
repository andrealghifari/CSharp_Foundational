using System.Globalization;
using System.Xml;
CultureInfo.CurrentCulture = new CultureInfo("en-US");
/*
OBJECTIVES
-Merge string templates with variables using composite formatting.
-Use various format specifiers to properly display percentages, currency, and numbers.
-Use padding methods to properly align string values to the right and left.

*/

// Composite Formatting (uses numbered placeholders within a string)
// string first = "Hello";
// string second = "World";
// Console.WriteLine("{0} {0}!", first, second); //Hello Hello!
// Console.WriteLine("{1} {0}!", first, second); //World Hello!

// String Interpolation >> A convenient way to simplify Composite Formatting
// Console.WriteLine($"{first} {second}!");

// Formatting Currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
//Price: $123.45 (Save $50.00)

// Formatting Units
//N numeric format display delineate for thousands,millions, billions and so on
Console.WriteLine($"Current stock {123456.768948m:N} units");
//Current stock 123,456.769 units

// Formatting Percentages
decimal tax = .36782m;
Console.WriteLine($"Discount Product: {tax:P2}");
//Discount Product: 36.78%


