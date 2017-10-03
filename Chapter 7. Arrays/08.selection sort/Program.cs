using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        for (int a = 0; a < arr.Length - 1; a++)
        {
            for (int b = a + 1; b < arr.Length; b++)
            {
                if (arr[a] > arr[b])
                {
                    int temp = arr[a];
                    arr[a] = arr[b];
                    arr[b] = temp;
                }
            }
        }
        Console.Write(string.Join(", ", arr));
    }
}