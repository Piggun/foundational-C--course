Console.WriteLine("Enter an integer value between 5 and 10:");
bool validEntry = false;
string? readResult;
int numericValue = 0;

do
{
    readResult = Console.ReadLine();
    bool validNumber = int.TryParse(readResult, out numericValue);
    if (validNumber)
    {
        if (numericValue >= 5 && numericValue <= 10)
            validEntry = true;
        else
            Console.WriteLine($"You entered {readResult}. Please ensure the number is between 5 and 10");
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({numericValue}) has been accepted!");