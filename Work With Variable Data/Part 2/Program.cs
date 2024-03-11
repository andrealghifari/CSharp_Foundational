using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

// int num = 4 ;
// string alpha = "a";
// Console.WriteLine(num + alpha); this wont result error, we dont convert the result
//int result = num + alpha; will cause : Cannot implicitly convert string to int

/* 3 ways to do data conversion
1. helper method on the data type;
2. helper method on the variable;
3. using Convert class method
*/

// -- using casting operator
double myDouble = 10.2;
int converMyDouble = (int)myDouble;
Console.WriteLine(converMyDouble);

/*
Helper Methods
ToString() to convert any data type to string
Parse() to convert string to int
*/
int first = 5, second = 7;
string third = "8", fourth = "9";
Console.WriteLine(first.ToString() + second.ToString()); // 57
Console.WriteLine(int.Parse(third) + int.Parse(fourth)); // 17

// widening conversion : more information converted to  less information data type
// narrowing conversion : less information converted to more information data type

/*  Convert class has many helper methods 

    ! Convert is the best practice for converting fractional num
        into whole numbers (int) because it's always rounds up 
        the numbers (best for rounding up the number)
*/
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

/*===============================*/
// TryParse
/* This helper method do:
    1. parse the str to given numeric data type
    2. save up the result into the out parameter
    3. return bool as the result
 */
string coba = "1.78"; // (,) would be displayed but (.) won't if we using local culture setting 
decimal result = 0;
if(decimal.TryParse(coba, out result)){
    Console.WriteLine($"Measurement: {result}");
} else{
    Console.WriteLine($"Unable to parse");
}

// EXERCISE
string[] values = ["12.3", "45", "ABC", "11","DEF"];
string message = "";
double total = 0;

foreach (string element in values){
    if (double.TryParse(element, out double parsedValue))
    {
        total += parsedValue;
    }
    else{
        message += element;
    }
}
Console.WriteLine($"Message : {message}");
Console.WriteLine($"Total : {total}");

// CHALLENGE
// Output Math Operations as spesific number types
int Value1 = 12;
decimal Value2 = 6.2m;
float Value3 = 4.3f;

var result1 = Convert.ToInt32(Value1/Value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

var result2 = Value2/(decimal)Value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

var result3 = Value3 / Value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
