using System;

class Program
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        SimNNestedLoops(n, arr);
    }

    static void SimNNestedLoops(int n, int[] arr, int currentLoop = 0)
    {
        if (n == currentLoop)
        {
            Print(arr);
            return;
        }

        for (int a = 1; a <= n; a++)
        {
            arr[currentLoop] = a;
            SimNNestedLoops(n, arr, currentLoop + 1);
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