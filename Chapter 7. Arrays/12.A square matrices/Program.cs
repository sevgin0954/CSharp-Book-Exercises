using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int firstNumInRow = 1; firstNumInRow <= n; firstNumInRow++)
        {
            for (int col = firstNumInRow; col <= n * n; col += n)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}