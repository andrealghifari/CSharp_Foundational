using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");
/*
Methods that add blank spaces for formatting purposes 
(PadLeft(), PadRight())

Methods that compare two strings or facilitate comparison 
(Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)

Methods that help you determine what's inside of a string, or even retrieve just a part of the string 
(Contains(), StartsWith(), EndsWith(), Substring())

Methods that change the content of the string by replacing, inserting, or removing parts
 (Replace(), Insert(), Remove())

Methods that turn a string into an array of strings or characters
 (Split(), ToCharArray())

*/

// string input = "Padding";
// Console.WriteLine(input.PadLeft(15, '-'));
// Console.WriteLine(input.PadRight(15, '-'));

// Exercisee!

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;
// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.Write($"As a cusomer of our {currentProduct} offering we are excited to tell you");
Console.WriteLine(" about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} at a return of {currentReturn:P2}.\n");
Console.Write($"Our new product, {newProduct} offers a return of {newReturn:P2}");
Console.WriteLine($" Given your current volume, your potential profit would be {newProfit:C2}\n");
Console.WriteLine("Here's a quick comparison:\n");

// Console.WriteLine($"{currentProduct.PadRight(19)}" + $"{currentReturn.ToString("P2").PadRight(10)}" + $"{currentProfit.ToString("C2").PadLeft(10)}");
// Simplified version below
Console.WriteLine($"{currentProduct.PadRight(19)}" + $"{currentReturn, -10:P2}" + $"{currentProfit, 10:C2}");

// Console.WriteLine($"{newProduct.PadRight(19)}" + $"{newReturn.ToString("P2").PadRight(10)}" + $"{newProfit.ToString("C2").PadLeft(10)}");
// Simplified version below
Console.WriteLine($"{newProduct.PadRight(19)}" + $"{newReturn, -10:P2}" + $"{newProfit, 10:C2}");
// string comparisonMessage = "";

// Your logic here

// Console.WriteLine(comparisonMessage);