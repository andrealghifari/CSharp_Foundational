// OBJECTIVES
/*

Learn more about using parameters
Understand method scope
Understand pass-by-reference and pass-by-value parameter types
Learn how to use optional and named arguments

*/
// Variable scope
// Luas Lingkaran
// double pi = 3.1459;
// PrintCircleInfo(14);
// PrintCircleInfo(48);

// void PrintCircleArea(int rad)
// {
//     double area = pi * (rad * rad);
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int rad)
// {
//     double circumference = 2 * pi * rad;
//     Console.WriteLine($"Circumference = {circumference}");
// }
// void PrintCircleInfo(int rad){
//     Console.WriteLine($"Circle with radius {rad}");
//     PrintCircleArea(rad);
//     PrintCircleCircumference(rad);
//     Console.WriteLine();
// }

 // Value and  Reference Type

// //  Exercise 
// // Method with optional Param
// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;

// RSVP("Andre", 3, "Peanut", true);
// RSVP(name:"Noor", inviteOnly:false, allergies:"none", partySize:3); // within optional params
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// showRSVP();
// void RSVP(string name, int partySize, string allergies, bool inviteOnly){
//     if(inviteOnly){
//         bool found = false;
//         foreach (string guest in guestList){
//             if(guest.Equals(name)){
//                 found = true;
//                 break;
//             }
//         }
//         if(!found){
//             Console.WriteLine($"Sorry, {name} isn't found on our guest list");
//             return;
//         }
//     }
//     rsvps[count]  = $"Name: {name}, \tParty Size: {partySize} , \tAllergies: {allergies}";
//     count++;
// }
// void showRSVP(){
//     Console.WriteLine("\nTotal RSVPS: ");
//     for(int i = 0; i < count; i++){
//         Console.WriteLine(rsvps[i]);
//     }
// }

// Challenge 
// Add method to display email address  

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};
string externalDomain = "hayworth.com";
for(int i=0; i < corporate.GetLength(0); i++){
    DisplayEmail(firstName:corporate[i,0], lastName:corporate[i, 1]);
}
for(int i=0; i < external.GetLength(0); i++){
    DisplayEmail(firstName:external[i,0], lastName:external[i, 1], domain:externalDomain);
}


void DisplayEmail(string firstName, string lastName, string domain = "contoso.com"){
    string email = (firstName.Substring(0,2) + lastName).ToLower();
    Console.WriteLine($"{email}{domain}");
}