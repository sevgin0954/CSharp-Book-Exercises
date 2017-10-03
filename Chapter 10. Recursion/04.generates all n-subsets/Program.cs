using System;


class Program
{
    static int[] arr;

    static void Main()
    {
        string[] words = { "test", "rock", "fun" };
        int loopsCount = int.Parse(Console.ReadLine());
        arr = new int[loopsCount];
        PrintAllCombos(loopsCount, words);
    }

    static void PrintAllCombos(int loopsCount, string[] words, int start = 0, int currentLoop = 0)
    {
        if (currentLoop == loopsCount)
        {
            Print(arr, words);
            return;
        }

        for (int a = start; a < words.Length; a++)
        {
            arr[currentLoop] = a;
            PrintAllCombos(loopsCount, words, a + 1, currentLoop + 1);
        }
    }

    static void Print(int[] indexesToPrint, string[] words)
    {
        for (int a = 0; a < arr.Length; a++)
        {
            int index = indexesToPrint[a];
            Console.Write(words[index] + " ");
        }
        Console.WriteLine();
    }
}