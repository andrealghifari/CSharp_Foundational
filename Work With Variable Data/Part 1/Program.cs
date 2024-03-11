// OBJECTIVES

// -Learn the fundamental differences between value types and reference types.
// -Describe the properties of many new numeric data types, including new integral types and floating point types.
// -Write code that returns the maximum and minimum values that numeric data types can store.
// -Use the new keyword to create new instances of a reference type.
// -Determine which data type you should choose for a given application.


// INTEGRAL TYPES VALUE
// >>  a simple value that represents whole numbers without fractions
// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


// An unsigned type only use its bytes to represent ONLY positive numbers
// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// // Floating Types
// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


// REFERENCES TYPE VALUES
/*
    References types include array, string, and classes

*/
int[] data = new int[3] {1,2,3}; //new operator is used to allocate memory on the heap for ref type
// data  = [1,2,3];
Console.WriteLine(data);