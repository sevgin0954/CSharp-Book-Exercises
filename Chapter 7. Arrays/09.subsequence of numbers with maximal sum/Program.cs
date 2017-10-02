using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int bestSum = 0;
        int len = 0;
        int lastIndex = 0;
        for (int a = 0; a < arr.Length; a++)
        {
            int sum = arr[a];
            int tempLen = 1;
            for (int b = a + 1; b < arr.Length; b++)
            {
                tempLen++;
                sum += arr[b];
                if (sum <= 0)
                {
                    break;
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    len = tempLen;
                    lastIndex = b;
                }
            }
        }
        bool isFirst = true;
        for (int a = lastIndex - len + 1; a <= lastIndex; a++)
        {
            if (isFirst == false)
            {
                Console.Write(", ");
            }
            isFirst = false;
            Console.Write(arr[a]);
        }
        Console.WriteLine("    Sum == " + bestSum);
    }
}