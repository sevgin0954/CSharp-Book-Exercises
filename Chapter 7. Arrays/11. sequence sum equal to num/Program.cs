using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int num = int.Parse(Console.ReadLine());
        int lastIndex = 0;
        int len = 0;
        for (int a = 0; a < arr.Length - 1; a++)
        {
            int tempLen = 1;
            int sum = arr[a];
            for (int b = a + 1; b < arr.Length; b++)
            {
                sum += arr[b];
                tempLen++;
                if (sum > num)
                {
                    break;
                }
                else if (sum == num)
                {
                    lastIndex = b;
                    len = tempLen;
                    break;
                }
            }
        }
        PrintSequence(arr, num, lastIndex, len);
    }

    static void PrintSequence(int[] arr, int num, int lastIndex, int len)
    {
        Console.Write(num + " -> ");
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
    }
}