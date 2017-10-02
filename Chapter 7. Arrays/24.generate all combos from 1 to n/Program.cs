using System;

class Program
{
    static int[] arr;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        arr = new int[k];
        PrintNestedLoops(n, k);
    }

    static void PrintNestedLoops(int maxNum, int loopsCount, int currentLoop = 0, int start = 1)
    {
        if (currentLoop == loopsCount)
        {
            Print(arr);
            Console.WriteLine();
            return;
        }

        for (int a = start; a <= maxNum; a++)
        {
            arr[currentLoop] = a;
            PrintNestedLoops(maxNum, loopsCount, currentLoop + 1, a + 1);
        }
    }

    static void Print(int[] arr)
    {
        for (int a = 0; a < arr.Length; a++)
        {
            Console.Write(arr[a] + " ");
        }
    }
}