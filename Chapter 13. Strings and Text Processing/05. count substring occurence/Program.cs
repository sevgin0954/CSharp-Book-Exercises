using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string searchedSubstring = Console.ReadLine().ToLower();

        int occurenceCout = 0;

        for (int a = 0; a < input.Length - (searchedSubstring.Length - 1); a++)
        {
            if (input[a] == searchedSubstring[0])
            {
                int inputIndex = a + 1;
                int searchedIndex = 1;
                bool isSame = true;

                for (int b = searchedIndex; b < searchedSubstring.Length; b++, inputIndex++)
                {
                    if (input[inputIndex] != searchedSubstring[b])
                    {
                        isSame = false;
                        break;
                    }
                }

                if (isSame)
                {
                    occurenceCout++;
                }
            }
        }

        Console.WriteLine(occurenceCout);
    }
}