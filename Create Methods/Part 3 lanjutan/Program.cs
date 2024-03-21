// Challenge Add methods to make game playable 
// Dice mini-game
Random random = new();

Console.WriteLine("Would you like to play? (Y/N)");
string? readLine = "";

readLine = Console.ReadLine();
if (readLine != null)
{
    if (ShouldPlay(readLine))
    {
        PlayGame();
    }
}


bool ShouldPlay(string decision)
{
    return decision.Trim().ToLower().Equals("y");

}

void PlayGame()
{
    var play = true;

    while (play)
    {

        Random randomNumber = new();
        int roll = randomNumber.Next(1, 6);
        int target = randomNumber.Next(1, 5);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        readLine = Console.ReadLine();

        if (readLine != null)
        {
            play = ShouldPlay(readLine);
        }
    }
}
string WinOrLose(int target, int roll)
{
    if (roll > target)
        return "You Win!";
    else
        return "You Lose!";
}