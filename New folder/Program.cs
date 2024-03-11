string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "Z789"; this will throw IndexOutOfRangeException
// Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Length of the Array: {fraudulentOrderIDs.Length}");

// Looping an array
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    // Console.WriteLine(name);
}

int[] inventory = {200, 450, 700, 175, 1000};
int sum = 0 ;
foreach(int item in inventory){
    sum +=item;
}
Console.WriteLine($"We have {sum} items in inventory");

// Challenge
// Find orders that starts with spesific char
string[] orderID = {"B123","C234","A345","C15","B177",
                    "G300","C235","B179"};
foreach (string item in orderID)
{
    if(item.StartsWith('B')){
        Console.WriteLine(item);
    }
}

// Challenge 2 Code Readability

/**
    This code below will convert a string message into char, 
    reverse the message and then count the spesific character appears,
    finally it will convert back the message into string and print the message
**/
string originalMessage = "The quick brown fox jumps over the lazy dog.";
char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;
foreach (char letter  in message)
{
    if(letter  == 'o'){
        letterCount++;
    }    
}
string convertedMessage = new string(message);

Console.WriteLine(convertedMessage);
Console.WriteLine($"'o' appears {letterCount} times.");