// // Code project 1

// Console.WriteLine("Enter an integer value between 5 and 10:");
// bool validEntry = false;
// string? readResult;
// int numericValue = 0;

// do
// {
//     readResult = Console.ReadLine();
//     bool validNumber = int.TryParse(readResult, out numericValue);
//     if (validNumber)
//     {
//         if (numericValue >= 5 && numericValue <= 10)
//             validEntry = true;
//         else
//             Console.WriteLine($"You entered {readResult}. Please ensure the number is between 5 and 10");
//     }
//     else
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }

// } while (validEntry == false);

// Console.WriteLine($"Your input value ({numericValue}) has been accepted!");


// // Code project 2

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// bool validEntry = false;
// string? readResult;

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult is not null)
//     {
//         string transformedResult = readResult.Trim().ToLower();
//         if ((new[] { "administrator", "manager", "user" }).Contains(transformedResult))
//         {
//             Console.WriteLine($"Your input value ({readResult.Trim()}) has been accepted.");
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//         }
//     }
// } while (validEntry == false);


// Code project 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;
string myString = "";

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string sentence;

    while (periodLocation != -1)
    {
        sentence = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation + 1);
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf(".");
        Console.WriteLine(sentence);
    }

    sentence = myString.Trim();
    Console.WriteLine(sentence);
}