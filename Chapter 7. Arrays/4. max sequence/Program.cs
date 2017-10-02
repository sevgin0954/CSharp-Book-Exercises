using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int bestSequenceCount = 1;
        int bestSequenceNum = arr[0];
        int count = 1;
        for (int a = 1; a < arr.Length; a++)
        {
            if (arr[a - 1] == arr[a])
            {
                count++;
                if (count > bestSequenceCount)
                {
                    bestSequenceCount = count;
                    bestSequenceNum = arr[a];
                }
            }
            else
            {
                count = 1;
            }
        }
        PrintNum(bestSequenceNum, bestSequenceCount);
    }

    static void PrintNum(int num, int printCount)
    {
        Console.Write("{");
        for (int a = 0; a < printCount; a++)
        {
            if (a > 0)
            {
                Console.Write(", ");
            }
            Console.Write(num);
        }
        Console.Write("}");
    }
}