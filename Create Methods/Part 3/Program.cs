
using System.Formats.Asn1;
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

// Objectives
/*
- Understand return types
- Learn more about return  keyword in a function
- Learn more about capturing method return values
*/

// Exercise - Return numbers from method
// double usd = 23.73;
// int vnd = USDtoVND(usd);
// Console.WriteLine($"${usd} USD= ${vnd} VND");
// Console.WriteLine();
// Console.WriteLine($"{vnd} VND = ${VNDtoUSD(vnd)} USD");

// int USDtoVND(double usd){
//     int rate = 23500;
//     return (int)(rate * usd);
// }

// double VNDtoUSD(double vnd){
//     double rate = 23500;
//     return vnd / rate;
// }

// Exercise - Return strings from method
string input = "There are snakes at the zoo";

Console.WriteLine(ReverseSentence(input));
string ReverseSentence(string input)
{
    string result = "";
    string[] splitSentence = input.Split(' ');
    foreach (string word in splitSentence)
    {
        result += ReverseWords(word) + " ";
    }
    return result.Trim();
}
string ReverseWords(string word)
{

    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}

//Versi satu fungsi
// string newInput = "Andre Alghifari";
// Console.WriteLine(ReverseAllWords(newInput));

// string ReverseAllWords(string input){
//     string result = "", unit = "";
//     string[] splitWords = input.Split(" ");
//     foreach(string word in splitWords){
//         unit = "";
//         for(int i = word.Length - 1; i >= 0; i--){
//             unit += word[i];
//         }
//         result += unit + " ";
//     }
//     return result;
// }

// Exercise - Return  Boolean from method
string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};
Console.WriteLine("Is it a Palindrome? ");
foreach(string word in words){
    Console.WriteLine($"{word} : {PalindromeChecker(word)}");
}

bool PalindromeChecker(string word){
    string reverseWord = "";
    for(int i = word.Length -1 ; i >= 0; i--){
        reverseWord += word[i];
    }
    if( word == reverseWord){
        return true;
    }
    else{return false;}

}