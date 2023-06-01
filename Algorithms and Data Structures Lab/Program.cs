using System;
using System.Text;

public sealed class Lab02
{
    static void Main()
    {
        // Program 1
        /*string example1 = "Programmatic Python";
        int count = 0;
        string example1Words = "";
        for (int i = 0; i < example1.Length; i++)
        {
            for (int j = i + 1; j < example1.Length; j++)
            {
                if (example1[i] == example1[j] && Char.IsLetter(example1[i]) && example1[i] != ' ' && !example1Words.Contains(example1[i]))
                {
                    count++;
                    example1Words += example1[j];
                }
            }
        }
        StringBuilder savedArray = new StringBuilder("", count);
        for (int i = 0; i < count; i++)
        {
            savedArray.Append(example1Words[i]);
        }
        Console.WriteLine("[" + string.Join(",", savedArray) + "]");
        */
        // Program 2

        string sortedWords = "";
        string example2 = "To be or not to be";
        int len = 0;
        string words = "";
        int temp = 0;
        for (int i = 0; i < example2.Length; i++)
        {
            len++;
            if (example2[i] == ' ')
            {
                words = example2.Substring(temp, len);
                temp = len;
                len = 0;
                Console.WriteLine(words);   
                if (!sortedWords.Contains(words))
                {
                    sortedWords += words;
                }
            }
        }
        
    }
}