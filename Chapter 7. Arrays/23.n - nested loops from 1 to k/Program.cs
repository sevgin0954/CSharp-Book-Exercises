using System;

class Program
{
    static int[] arr;

    static void Main()
    {

        Console.Write("loops count = ");
        int loopsCount = int.Parse(Console.ReadLine());
        Console.Write("loops len = ");
        int len = int.Parse(Console.ReadLine());
        arr = new int[loopsCount];
        NestedLoops(loopsCount, len);
    }

    static void NestedLoops(int loopsCount, int len, int currentLoop = 0)
    {
        if (currentLoop == loopsCount)
        {
            Print(arr);
            Console.WriteLine();
            return;
        }

        for (int a = 1; a <= len; a++)
        {
            arr[currentLoop] = a;
            NestedLoops(loopsCount, len, currentLoop + 1);
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