int n = 0;
while (n <= 0)
{
    // form validation
    Console.WriteLine("Please enter integer value greater than zero.");
    n = Int32.Parse(Console.ReadLine());
}
string?[] words = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter word {i + 1}");
    string newWord = Console.ReadLine();
    if (newWord.Length > 0 && newWord.Contains(' '))
    {
        words[i] = newWord.ToLower();
    }
    else
    {
        Console.WriteLine("Sorry but you must enter at least one character.");
        i--;
    }
}
char charToCount = ' ';
while (!Char.IsLetter(charToCount))
{
    Console.WriteLine("Please enter a character to count.");
    charToCount = Char.ToLower(Console.ReadKey().KeyChar);
}
Console.WriteLine($"\nYou entered the character {charToCount}");
double charCount = 0;
double totalArrLength = 0;
foreach (string word in words)
{
    char[] chars = word.ToCharArray();
    totalArrLength += word.Length;
    foreach (char c in chars)
    {
        if (c == charToCount)
        {
            charCount++;
        }
    }
}
double percentage = charCount / totalArrLength;
if (percentage >= 0.25)
{
    Console.WriteLine($"“The letter ‘{charToCount}’ appears {charCount} times in the array. This letter makes up more than 25% of the total number of characters.”");
}
else
{
    Console.WriteLine($"“The letter ‘{charToCount}’ appears {charCount} times in the array.");
}
