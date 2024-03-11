// // Sort and Reverse Array
// string[] pallets = {"B14", "A11", "B12", "A13"};
// Console.WriteLine("Sorting Array...");
// Array.Sort(pallets);    
// foreach(string pallet in pallets){
//     Console.WriteLine($"--{pallet}");
// }
// Console.WriteLine();
// Array.Reverse(pallets);
// foreach(string pallet in pallets){
//     Console.WriteLine($"--{pallet}");
// }

// //Clean and Resize Array
// Array.Clear(pallets,0,2);

// Console.WriteLine($"Cleaning 2... count: {pallets.Length}");
// foreach(string pallet in pallets){
//     Console.WriteLine($"--{pallet}");
// }
// Console.WriteLine();
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing... count: {pallets.Length}");
// pallets[4] = "C01";
// pallets[5] = "C02";
// foreach(string pallet in pallets){
//     Console.WriteLine($"--{pallet}");
// }

using System.Runtime.CompilerServices;

string value = "12345";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray); // construct string result and each element separated by ,
// Console.WriteLine(result);

string[] items = result.Split(",");
// foreach(string item in items){
//     Console.WriteLine(item);
// }

// EXERCISE
// Reverse each word in a string
string pangram = "The quick brown fox jumps over the lazy dog";
string[] arrayStringPangram = pangram.Split(" ");

// an empty string that will contain reversed words on the end
string[] reverseWords = new String[arrayStringPangram.Length];

for(int i = 0; i < arrayStringPangram.Length ; i ++){
    char[] valueElement = arrayStringPangram[i].ToCharArray();
    Array.Reverse(valueElement);
    reverseWords[i] = new string(valueElement);
}
string finalResult = String.Join(" ", reverseWords);




// Parse a string of orders, sort the orders, and tag the possible errors
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(",");
Array.Sort(orders);
// String sortedOrders = String.Join(",", orders);

foreach(string element in orders){
    if(element.Length != 4){
        Console.WriteLine($"{element}\t- Error");
    }
    else{
        Console.WriteLine($"{element}");
    }
}