using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[] len = new int[arr.Length];
        int[] prev = new int[arr.Length];
        int lastIndex = -1;
        int bestLen = 0;
        for (int a = 0; a < arr.Length; a++)
        {
            len[a] = 1;
            prev[a] = -1;
            for (int b = 0; b < a; b++)
            {
                if (arr[b] < arr[a])
                {
                    if (len[b] + 1 > len[a])
                    {
                        len[a] = len[b] + 1;
                        prev[a] = b;
                    }
                }
            }    
            if (len[a] > bestLen)
            {
                bestLen = len[a];
                lastIndex = a;
            }
        }
        if (lastIndex == -1)
        {
            Console.WriteLine("Not Found");
        }
        else
        {
            PrintBestIncreasingSequence(arr, prev, lastIndex, bestLen);
        }
    }

    static void PrintBestIncreasingSequence(int[] arr, int[] prev, int lastIndex, int bestLen)
    {
        int[] bestIncreasingSequence = new int[bestLen];
        int prevIndex = lastIndex;
        for (int a = bestLen - 1; a >= 0; a--)
        {
            bestIncreasingSequence[a] = arr[prevIndex];
            prevIndex = prev[prevIndex];
        }
        Console.Write(string.Join(", ", bestIncreasingSequence));
    }
}