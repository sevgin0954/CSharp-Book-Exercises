using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int mostFrequenNum = 0;
        int bestNumCount = 0;
        for (int a = 0; a < arr.Length; a++)
        {
            int count = 0;
            for (int b = 0; b < arr.Length; b++)
            {
                if (arr[a] == arr[b])
                {
                    count++;
                    if (count > bestNumCount)
                    {
                        bestNumCount = count;
                        mostFrequenNum = arr[a];
                    }
                }
            }
        }

        Console.Write($"{mostFrequenNum} -> {bestNumCount} times");
    }
}