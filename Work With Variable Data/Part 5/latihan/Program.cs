using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

// Get all the string inside the brackets
string sentence = "I have 3 [pets], they are (dog), (cat), and (turtle) they are very {tame} and {energetic}";
char[] anySymbols  = {'[', '(', '{'};
int closingPosition = 0;
while(true){
    int openingPosition;
    string currentSymbol;
    char matchingSymbol = ' ';
    // string[] 
    
    // get the position of symbol
    openingPosition = sentence.IndexOfAny(anySymbols, closingPosition);
    if(openingPosition == -1 ) break; // break the loop if there's no symbol left
    currentSymbol = sentence.Substring(openingPosition, 1); // get 1 symbol
    switch(currentSymbol){ // got the matchingSymbol
        case "[": 
            matchingSymbol = ']';
            break;
        case "(": 
            matchingSymbol = ')';
            break;
        case "{": 
            matchingSymbol  = '}';
            break;
    }
    openingPosition += 1; // to retrieve whats inside bracket, so add +1
    closingPosition = sentence.IndexOf(matchingSymbol, openingPosition);
    int lengthItem = closingPosition - openingPosition;
    Console.WriteLine(sentence.Substring(openingPosition, lengthItem));
}
