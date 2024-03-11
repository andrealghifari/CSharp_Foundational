// do while
Random randomNumber = new Random();
int current  = randomNumber.Next(1, 11);

// int current
// do{
//     current  = randomNumber.Next(1,11);
//     if(current >= 8){
//         Console.WriteLine($"hidden value: {current}");
//         continue;
//     }
//     Console.WriteLine("current value: "+  current);
// }
// while (current != 7);

// while statement when a randNumber in certain condition
// while(current >= 3){
//     Console.WriteLine(current);
//     current = randomNumber.Next(1,8);
// } 
// Console.WriteLine($"Last number is {current}");

// Game Challenge
// Role Play Battle Game

int heroHealth = 10;
int monsterHealth = 10;
int monsterAttack , heroAttack;



do{
    if(heroHealth > 0){
        heroAttack = randomNumber.Next(1,10);
        monsterHealth -= heroAttack;      
        Console.WriteLine($"Monster was damaged and lost {heroAttack} HP and now has {monsterHealth} HP.");
    }
    if(monsterHealth > 0){
        monsterAttack =  randomNumber.Next(1,10);
        heroHealth -= monsterAttack;
        Console.WriteLine($"Hero was damaged and lost {monsterAttack} HP and now has {heroHealth} HP.");
    }
  
}
while(monsterHealth > 0 && heroHealth > 0);

string result = heroHealth > monsterHealth ? "Hero Wins!" : "Monster Wins!";
Console.WriteLine(result);
