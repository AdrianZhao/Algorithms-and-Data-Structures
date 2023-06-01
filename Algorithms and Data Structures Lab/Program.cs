using System;
using System.Text;

public sealed class Lab02
{
    static void Main()
    {
        string example1 = "Programmatic Python";
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

        string input = "Programmatic Python";
        List<char> result = new List<char>();

        foreach (char c in input.ToLower())
        {
            if (Char.IsLower(c) && !result.Contains(c))
            {
                result.Add(c);
            }
        }

        char[] arrayResult = result.ToArray();

        Console.WriteLine("[\"" + string.Join("\", \"", result) + "\"]");

        string typeString = "in";
        string example2 = "Insured in that field";
        int len = 0;
        string words = "";
        int temp = 0;
        for (int i = 0; i < example2.Length; i++)
        {
            len++;
            if (example2[i] == ' ')
            {
                if (len - 1 == typeString.Length)
                {
                    words = example2.Substring(temp, len - 1);
                    Console.WriteLine(words);
                    if (words == typeString)
                    {
                        words = example2.Substring(temp, example2.Length - i + 2);
                    }
                }
                else
                {
                    temp = i + 1;
                    len = 0;
                }
            }
        }
        Console.WriteLine(words);
    }
}