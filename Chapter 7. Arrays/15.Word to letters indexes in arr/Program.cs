using System;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        for (int a = 0; a < word.Length; a++)
        {
            for (int b = 0; b < letters.Length; b++)
            {
                if (letters[b] == word[a])
                {
                    Console.Write(b);
                    break;
                }
            }
        }
    }
}