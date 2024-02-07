using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter some words separated by commas (,):");
        string input = Console.ReadLine();
        string[] words = input.Split(',');

        Console.WriteLine("Enter a character to look for:");
        char searchChar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        bool charExistsInAllWords = CheckForCharacterInAllWords(words, searchChar);
        Console.WriteLine($"The character '{searchChar}' exists in all words: {charExistsInAllWords}");
    }

    static bool CheckForCharacterInAllWords(string[] words, char searchChar)
    {
        foreach (string word in words)
        {
            if (!word.Contains(searchChar))
            {
                return false;
            }
        }
        return true;
    }
}