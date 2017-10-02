using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        ReadArr(arr);
        int bestSum = int.MinValue;
        int startIndex = 0;
        for (int a = 0; a <= arr.Length - k; a++)
        {
            int sum = arr[a];
            for (int b = a + 1; b < a + k; b++)
            {
                sum += arr[b];
            }
            if (sum > bestSum)
            {
                bestSum = sum;
                startIndex = a;
            }
        }

        bool isFirst = true;
        for (int a = startIndex; a < startIndex + k; a++)
        {
            if (isFirst == false)
            {
                Console.Write(", ");
            }
            isFirst = false;
            Console.Write(arr[a]);
        }
        Console.WriteLine("    sum == " + bestSum);
    }

    static void ReadArr(int[] arr)
    {
        for (int a = 0; a < arr.Length; a++)
        {
            arr[a] = int.Parse(Console.ReadLine());
        }
    }
}