/*
    The following lines of code reverse
    a string and count the number of times
    the letter "o" appears.
*/

string initialMessage = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = initialMessage.ToCharArray();
Array.Reverse(charMessage);
int letterCount = 0;

foreach (char i in charMessage)
{
    if (i == 'o')
    {
        letterCount++;
    }
}

string reversedMessage = new String(charMessage);

Console.WriteLine(reversedMessage);
Console.WriteLine($"'o' appears {letterCount} times.");