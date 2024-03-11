string sentences = "My name is Andre , i'm  24 years old. Im a software engineer. I love basketball";
string? readLine;

readLine = Console.ReadLine();
if (readLine != null)
{
    bool allPresent = false;
    readLine = readLine.Trim().ToLower();
    string[] data = readLine.Split(',');
    foreach (string element in data)
    {
        if (sentences.Contains(element))
        {
            allPresent = true;
            break;
        }
    }
    if(allPresent == true){
        Console.WriteLine("All data has been matched");
    }
    else{
        Console.WriteLine("None of data has matched, try again");
    }
}
else { Console.WriteLine("Data can't be null"); }


