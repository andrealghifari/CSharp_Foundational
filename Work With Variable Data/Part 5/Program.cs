// Objectives
/*
        1 Identify a char or string inside of another string
        2 Extract values from string
        3 Remove portions of string
        4 Replace values in string with different one
*/
// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// Console.WriteLine(openingPosition);
// int closingPosition = message.IndexOf(closeSpan);
// Console.WriteLine(closingPosition);
// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// EXERCISE
// string newMessage = "(What if) there are (more than) one (set of parentheses)?";

// while(true){
//     int openingPosition = newMessage.IndexOf('(');
//     if(openingPosition == -1) break;

//     int closingPosition = newMessage.IndexOf(')');

//     openingPosition +=1; // this will flag the item position
//     int lengthItem = closingPosition - openingPosition;
//     Console.WriteLine($"{newMessage.Substring(openingPosition, lengthItem)}");

//     // overriding method to stop once the item hasn't found anymore
//     newMessage = newMessage.Substring(closingPosition + 1);
//     Console.WriteLine(newMessage);
// }

// Working with multiple symbols
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:
char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

// Remove and Replace string

// REMOVE
string data = "Andre Alghifari Chaniago";
string updatedData = data.Remove(15); // 2 args (start, length)
Console.WriteLine(updatedData);

// REPLACE
string  announcement= "We--have--big--discount--today--!";
updatedData = announcement.Replace("--", " ");
Console.WriteLine(updatedData);


// EXERCISE 
// Extrace, Replace, and Remove data from an input string
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
string openDiv = "<div>";
string closeDiv = "</div>";
int openingDiv = input.IndexOf(openDiv); //0

// remove the opening and closing tag div, and then replace a word
var removedDiv = input.Remove(openingDiv, openDiv.Length);
int closingDiv = removedDiv.IndexOf(closeDiv);

removedDiv = removedDiv.Remove(closingDiv);
removedDiv = removedDiv.Replace("trade", "reg");
output = removedDiv;

// Extract 5000
string openSpan = "<span>";
int openingSpan = removedDiv.IndexOf(openSpan);
quantity = removedDiv.Substring(openingSpan + openSpan.Length, 4);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");