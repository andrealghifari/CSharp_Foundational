Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// Lesson 2
// Implement a method from Math class that return the larger
// of two numbers
int firstValue = 550;
int secondValue = 1;
int largestValue = Math.Max(firstValue, secondValue);

// Console.WriteLine($"Largest value between {firstValue} and {secondValue} is {largestValue}");

// Lesson 3 Conditional Statement
Random Dice = new();

int rolling1 = Dice.Next(1, 7);
int rolling2 = Dice.Next(1, 7);
int rolling3 = Dice.Next(1, 7);
int total = rolling1 + rolling2 + rolling3;

// Console.WriteLine($"Dice roll: {rolling1} + {rolling2} + {rolling3} = {total}");

if(rolling1 == rolling2 || rolling2 == rolling3 || rolling1==rolling3){
    if(rolling1 == rolling2 && rolling2 == rolling3){
        total+=6;
        // Console.WriteLine("You rolled triples!, +6 bonus in total");
    }
    else{
        total+=2;
        // Console.WriteLine("You rolled doubles! +2 bonus in total");
    }
    // Console.WriteLine($"Your total including bonus: {total}");
}

if(total >=16){
    // Console.WriteLine("You win a Car!");
}
else if(total >= 10){
    // Console.WriteLine("You win a new Laptop!");
}
else if(total == 7){
    // Console.WriteLine("You win a Trip for two!");
}
else{
    // Console.WriteLine("You win a kitten!");
}

// Challenge 

// Improve renewal rate of subscriptions
Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
daysUntilExpiration = 10;
Console.WriteLine($"Remaining day left to renewal:{daysUntilExpiration}");
if(daysUntilExpiration == 11){
    Console.WriteLine("");
}
else if(daysUntilExpiration >= 6 && daysUntilExpiration <=10 ){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if(daysUntilExpiration > 1 && daysUntilExpiration <=5){
    discountPercentage = 10;
    Console.WriteLine($@"Your subcription expires in {daysUntilExpiration} days.
    Renew now and save {discountPercentage}%");
}
else if(daysUntilExpiration == 1){
    discountPercentage = 20;
    Console.WriteLine($@"Your subcription will expire within a day!
    Renew now and save {discountPercentage}");
}
else{
    Console.WriteLine("Your subscription has expired");
}






// public class Calculator{
//     public int Add(int a, int b){
//         return a + b;
//     }
//     public int Add(int a, int b, int c){
//         return a + b +c;
//     }
//     public double Add(double a, double b){
//         return a + b;
//     }
// }

// class Program{
//     static void Main(string[] args){
//         Calculator calculate = new();
//         int result1 = calculate.Add(3,5);
//         int result2 = calculate.Add(3,5,100);
//         double result3 = calculate.Add(3.59, 7.57);
//         Console.WriteLine($"Result of adding 2 integers: {result1}");
//         Console.WriteLine($"Result of adding 3 integers: {result2}");
//         Console.Write($"Result of adding 2 doubles: {result3}");
//     }
// }