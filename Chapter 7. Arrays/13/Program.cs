using System;

class Program
{
    static void Main()
    {
        Console.Write("rows = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("cols = ");
        int cols = int.Parse(Console.ReadLine());
        Console.Write("rows of subMatrix = ");
        int subRows = int.Parse(Console.ReadLine());
        Console.Write("cols of subMatrix = ");
        int subCols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        // Read matrix
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("Matrix[{0},{1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        // Main Logic
        int bestSum = int.MinValue;
        int bestStartRowIndex = -1;
        int bestStartColIndex = -1;
        for (int row = 0; row <= rows - subRows; row++)
        {
            int sum = 0;
            for (int col = 0; col <= cols - subCols; col++)
            {
                sum = SumSubMatrix(matrix, row, col, subRows, subCols);
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestStartRowIndex = row;
                    bestStartColIndex = col;
                }
            }
        }

        Console.WriteLine("Sum == " + bestSum);
        //Print bigest part in matrix
        for (int row = bestStartRowIndex; row < bestStartRowIndex + subRows; row++)
        {
            for (int col = bestStartColIndex; col < bestStartColIndex + subCols; col++)
            {
                Console.Write("{0, -2}|", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static int SumSubMatrix(int[,] matrix, int startRow, int startCol, int subRowsCount, int subColsCount)
    {
        int sum = 0;
        for (int row = startRow; row < startRow + subRowsCount; row++)
        {
            for (int col = startCol; col < startCol + subColsCount; col++)
            {
                sum += matrix[row, col];
            }
        }
        return sum;
    }

}