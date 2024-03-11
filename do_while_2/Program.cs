// Continue the challenge

// 1. 3 input
// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);

// 2. validate integer input (using TryParse())
// string? readInput;
// int numericvalue;
// bool validity = false;
// Console.Write("Input a value between 5 and 10: ");
// do{
//     readInput =  Console.ReadLine();
//     bool checkInput = int.TryParse(readInput, out numericvalue);
//     if(checkInput == !validity && numericvalue >=5 && numericvalue <=10){
//         validity = true;
//     }
//     else if(checkInput == !validity && numericvalue < 5){
//         Console.WriteLine($"You entered {readInput}. Please enter a number between 5 and 10");
//     }
//     else{
//         Console.WriteLine("Sorry you entered invalid number, try again");
//     }
// } while(validity == false);
//Console.WriteLine("Your input has been accepted");

// 3. validate string input
// Console.Write("Enter your role (Administrator, Manager, or User): "); // Administrator, Manager, User pick one
// bool stringValidity = false;
// do{
//     readInput = Console.ReadLine().Trim().ToLower();
//     if(readInput == "administrator" || readInput == "manager" || readInput == "user"){
//         stringValidity = true;
//     }
//     else{
//         Console.Write($"The role name that you entered, {readInput} is not valid. Enter your role name:");
//     }

// } while(stringValidity == false);
//Console.Write($"Your input {readInput} has been accepted.");

// challenge 3
string[] myArray = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation; // this will search . in the string Array

