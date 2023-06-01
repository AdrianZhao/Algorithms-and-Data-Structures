using System;
using System.Text;

public sealed class Lab02
{
    static void Main()
    {
        // Program 1
        
        Console.WriteLine("Program 1:");
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
        
        // Program 2
        
        Console.WriteLine("Program 2:");
        string sortedWords = "";
        string example2 = "To be or not to be";
        string[] wordsArray = example2.ToLower().Split(' ');
        StringBuilder getArray = new StringBuilder("", sortedWords.Length);
        foreach (string word in wordsArray)
        {
            if (!sortedWords.Contains(word))
            {
                sortedWords += word + " ";
            }
        }
        for (int i = 0; i < sortedWords.Length; i++)
        {
            getArray.Append(sortedWords[i]);
        }
        Console.WriteLine(getArray);
        
        // Program 3
        
        Console.WriteLine("Program 3:");
        string example3 = "Hello World";
        StringBuilder reversedArray = new StringBuilder("", example3.Length);
        for (int i = example3.Length - 1; i >= 0; i--) 
        {
            reversedArray.Append(example3[i]);
        }
        Console.WriteLine(reversedArray);    
        
        // Program 4
        
        Console.WriteLine("Program 4:");
        string example4 = "Which one is the longest words in this sentence";
        string[] longestWord = example4.Split(' ');
        int length = 0;
        int position = 0;
        for (int i = 0; i < longestWord.Length - 1; i++) 
        { 
            if (longestWord[i].Length <= longestWord[i + 1].Length && length <= longestWord[i + 1].Length)
            { 
                length = longestWord[i + 1].Length;
                position = i + 1;
            }
        }
        Console.WriteLine(longestWord[position]);
    }   
}
/*
 * StringBuilder has 
 */