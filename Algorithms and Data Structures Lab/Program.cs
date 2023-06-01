using System;
using System.Text;

public sealed class Lab02
{
    static void Main()
    {
        string test = "Programmatic Pythonasrbsn gggggggg43563 gg";
        int count = 0;
        string words = "";
        for (int i = 0; i < test.Length; i++)
        {
            for (int j = i + 1; j < test.Length; j++)
            {
                if (test[i] == test[j] && Char.IsLetter(test[i]) && test[i] != ' ' && !words.Contains(test[i]))
                {
                    count++;
                    words += test[j];
                }
            }
        }
        StringBuilder savedArray = new StringBuilder("", count);
        for (int i = 0; i < count; i++)
        {
            savedArray.Append(words[i]);
        }
        Console.WriteLine(savedArray);
    }
}