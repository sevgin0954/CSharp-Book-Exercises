using System;

class Program
{

    static void Main()
    {
        int loopsCount = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[loopsCount];
        SimNNestedLoops(loopsCount, k, arr);
    }

    static void SimNNestedLoops(int loopsCount, int k, int[] arr, int currentLoop = 0)
    {
        if (loopsCount == currentLoop)
        {
            Print(arr);
            return;
        }

        for (int a = 1; a <= k; a++)
        {
            arr[currentLoop] = a;
            SimNNestedLoops(loopsCount, k, arr, currentLoop + 1);
        }
    }

    static void Print(int[] arr)
    {
        for (int a = 0; a < arr.Length; a++)
        {
            Console.Write(arr[a] + " ");
        }
        Console.WriteLine();
    }
}