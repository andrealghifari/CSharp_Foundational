//Console.WriteLine("Hello World!");
//Console.WriteLine("a" == "A"); //true
//Console.WriteLine("    a    ".Trim() == "a".ToUpper()); //false
//Console.WriteLine("    a    ".Trim().ToLower() == " a".Trim().ToLower()); //true

// string phrases  = "the quick brown fox jump over a lazy dog";
// Console.WriteLine( "Is phrases contain fox? "+ phrases.Contains("fox"));
//Console.WriteLine( "Is phrases contain cow? "+ phrases.Contains("cow"));

// Negation
//Console.WriteLine( "is phrases not contain lion?  "+ !phrases.Contains("lion"));

// Conditional Operator (Ternary Operator)
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");
int savings = 0;
Console.WriteLine($"Do you have any savings? {(savings > 0 ? "yes" : "no")}");

// Challenge
// write code to display the result of a coin flip
Random flipCoin = new();
int flippedCoin = flipCoin.Next(0, 2);
Console.WriteLine($"Coin flipped, result: {(flippedCoin == 1 ? "heads" : "tails")}");

// Another Challenge
string permission = "Manager";
int level = 50;

if(permission.Contains("Admin")){
    if(level > 55){
        Console.WriteLine("Welcome, Super Admin user");
    }
    else if(level <= 55){
        Console.WriteLine("Wecome, Admin user");
    }
}
else{
    if(level >= 20){
        Console.WriteLine("Contact an Admin for access");
    }
    else {
        Console.WriteLine("You don't have sufficient privileges");
    }
}