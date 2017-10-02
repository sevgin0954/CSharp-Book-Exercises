using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int bestSequenceLen = 0;
        int lastIndex = 0;
        int len = 1;
        for (int a = 1; a < arr.Length; a++)
        {
            if (arr[a - 1] < arr[a])
            {
                len++;
                if (len > bestSequenceLen)
                {
                    bestSequenceLen = len;
                    lastIndex = a;
                }
            }
            else
            {
                len = 1;
            }
        }

        int startIndex = lastIndex - bestSequenceLen + 1;
        Console.Write("{");
        for (int a = startIndex; a <= lastIndex; a++)
        {
            if (a > startIndex)
            {
                Console.Write(", ");
            }
            Console.Write(arr[a]);
        }
        Console.Write("}");
    }
}