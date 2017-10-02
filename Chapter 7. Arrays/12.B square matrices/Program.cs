using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            int colCount = 1;
            int col = row;
            while (col <= n * n && colCount <= n)
            {
                Console.Write("{0, -3}", col);
                colCount++;
                if (colCount % 2 == 1)
                {
                    col += row * 2 - 1;
                }
                else
                {
                    col += (n * 2 - (row - 1) * 2) - 1;
                }
            }
            Console.WriteLine();
        }
    }
}