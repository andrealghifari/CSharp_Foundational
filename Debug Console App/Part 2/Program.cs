using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string grade = "A", result = "";
result = grade switch 
{
    "A" => "Outstanding",
    "B" => "GOod",
    _ => "Need Improvement"
};
Console.WriteLine($"Final Result: {result}");

// CHALLENGE
/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

var changeValue = ChangeValue(x);

Console.WriteLine(changeValue);

int ChangeValue(int value) 
{
    return value = 10;
}