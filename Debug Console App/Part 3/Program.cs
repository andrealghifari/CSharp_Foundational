/* 
Compiler Generted Exception
1. ArrayMismatchException (an Exception that throws when the type of element doesn't match with the actual type of array)
2. DivideByZeroException (Exception that occurs when trying to divide integral value by Zero)
3. FormatException (Throw when format of an argument is invalid)
4. IndexOutOfRangeException (Throw when an attempt is made to access the index of less than zero or out ouf bounds of the array)
5. InvalidCastException (Throw when an attempt to do conversion from a base type to an interface, or to derived type fails at the runtime)
6. NullReferenceException (Throw when an attempt to reference an object which has null value )
7. OverflowException (Thrown when an arithmetic operation exceeding bounds of data type that being used)

===========Props of Exception==========
Data: The Data property holds arbitrary data in key-value pairs.
HelpLink: The HelpLink property can be used to hold a URL (or URN) to a help file that provides extensive information about the cause of an exception.
HResult: The HResult property can be used to access to a coded numerical value that's assigned to a specific exception.
InnerException: The InnerException property can be used to create and preserve a series of exceptions during exception handling.
Message: The Message property provides details about the cause of an exception.
Source: The Source property can be used to access the name of the application or the object that causes the error.
StackTrace: The StackTrace property contains a stack trace that can be used to determine where an error occurred.
TargetSite: The TargetSite property can be used to get the method that throws the current exception.


// ArrayMismatchException
try
{
    string[] names = { "Dog", "Cat", "Fish" };
    Object[] objs = (Object[])names;

    Object obj = (Object)13;
    objs[2] = obj; // ArrayTypeMismatchException occurs
}
catch (System.Exception ex)
{
    Console.WriteLine(ex);
}
Console.WriteLine();

// DivideByZeroException
try
{
   int number1 = 1000, zero = 0;
   Console.WriteLine(number1/zero);
}
catch (System.Exception ex)
{
    Console.WriteLine(ex);
}
Console.WriteLine();

// FormatException
int enteredIntValue;
string inputValue = "Andre"; 
enteredIntValue = int.Parse(inputValue);

Console.WriteLine();

// IndexOutOfRangeException
int[] values = new int[7] { 3, 6, 9, 12, 15, 18, 21 };
int value8 = values[8];
// Console.WriteLine();

// InvalidCastException
object check = "This is a string";
int value = (int)check;

//NullReferenceException
string? lowercaseWord = null;
Console.WriteLine(lowercaseWord.ToUpper());

// OverflowException
decimal x = 400;
byte i;

i = (byte)x; // OverflowException occurs
Console.WriteLine(i);
*/


// Challenge - catch spesific exception type
// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[]{"three", "9999999999", "0", "2"};

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException )
    {   
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException )
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}