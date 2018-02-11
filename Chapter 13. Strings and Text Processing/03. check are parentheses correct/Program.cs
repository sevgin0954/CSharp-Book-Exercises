using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int closingParenthnessCount = 0;
        int openingParenthnessCount = 0;

        for (int a = 0; a < input.Length; a++)
        {
            if (input[a] == '(')
            {
                openingParenthnessCount++;
            }
            else if (input[a] == ')')
            {
                closingParenthnessCount++;
            }
        }

        Console.WriteLine(closingParenthnessCount == openingParenthnessCount ? true : false);
    }
}