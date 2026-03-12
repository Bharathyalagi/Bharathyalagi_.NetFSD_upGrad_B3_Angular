using System;

class Program
{
    static int CountVowels(string text)
    {
        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        int result = CountVowels(input);

        Console.WriteLine("Vowel Count: " + result);
    }
}