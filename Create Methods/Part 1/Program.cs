using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");


// Exercise Reusable Method

// int[] times = { 800, 1200, 1600, 2000 };
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTime();
// }
// else
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTime();

// }

// Console.WriteLine("New Medicine Schedule:");
// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine();

// void DisplayTimes()
// {
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
// }
// void AdjustTime()
// {
//     for (int i = 0; i < times.Length; i++)
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

// Exercise Build Code with Method

// =====pseudo-code=====
/* if IP Address  consist of 4 numbers 
    and
     if each IP Address doesn't contain leading zero (0x)
     and
     if each IP Address in range 0-255
     and
     then IP valid
        else IP invalid
*/

// Exercise IP Address

// string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
// bool validLength = false;
// bool validRange = false;
// bool validZero = false;

// string[] ipv4Address = { };

// foreach (string ip in ipv4Input)
// {
//     ipv4Address = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); ValidateRange(); ValidateZero();
//     if (validLength && validRange && validZero)
//     {
//         Console.WriteLine($"IP {ip} is a valid IPV4 address");
//     }
//     else
//     {
//         Console.WriteLine($"IP {ip} is an invalid IPV4 address");
//     }
// }



// void ValidateLength()
// {
//     validLength = ipv4Address.Length == 4; //valid
// }

// void ValidateZero()
// {
//     foreach (string element in ipv4Address)
//     {
//         if (element.Length > 1 && element.StartsWith('0'))
//         {
//             validZero = false; //not valid
//         }
//         else { validZero = true; }
//     }
// }
// void ValidateRange()
// {
//     foreach (string element in ipv4Address)
//     {
//         int parseElement = int.Parse(element);
//         if (parseElement >= 0 && parseElement <= 255)
//         {
//             validRange = true;
//             return;
//         }

//     }
// }

Random random = new Random();
int luck = random.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

TellFortune();
luck = random.Next(100);
TellFortune();

void TellFortune()
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
    Console.WriteLine();
}


