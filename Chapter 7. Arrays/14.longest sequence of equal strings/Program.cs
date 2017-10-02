using System;

class Program
{
    static void Main()
    {
        string[,] matrix =
        {
            { "a", "a", "a", "a" },
            { "a", "a", "a", "a" },
            { "a", "a", "a", "a"}
        };
        string searchedWord = Console.ReadLine();
        int bestSeqCount = CountLongestSeq(matrix, searchedWord);
        // Print the longest seq
        for (int a = 0; a < bestSeqCount; a++)
        {
            Console.Write(searchedWord + " ");
        }
    }

    static int CountLongestSeq(string[,] matrix, string searchedWord)
    {
        int bestCount = 0;
        int currentCount = CountLongestSeqDiagonal(matrix, searchedWord);
        if (currentCount > bestCount)
        {
            bestCount = currentCount;
        }
        currentCount = CountLongestSeqHorizontal(matrix, searchedWord);
        if (currentCount > bestCount)
        {
            bestCount = currentCount;
        }
        currentCount = CountLongestSeqVertical(matrix, searchedWord);
        if (currentCount > bestCount)
        {
            bestCount = currentCount;
        }

        return bestCount;
    }

    static int CountLongestSeqDiagonal(string[,] matrix, string searchedWord)
    {
        int bestCount = 0;

        // check to right
        for (int startRow = 0; startRow < matrix.GetLength(0); startRow++)
        {
            for (int startCol = 0; startCol < matrix.GetLength(1) - 1; startCol++)
            {
                int count = 0;
                if (matrix[startRow, startCol] == searchedWord)
                {
                    int currentRow = startRow;
                    int currentCol = startCol;
                    while (currentRow < matrix.GetLength(0) && currentCol < matrix.GetLength(1))
                    {
                        if (matrix[currentRow, currentCol] == searchedWord)
                        {
                            count++;
                            currentCol++;
                            currentRow++;
                            if (count > bestCount)
                            {
                                bestCount = count;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        // check to left
        for (int startRow = 0; startRow < matrix.GetLength(0); startRow++)
        {
            for (int startCol = matrix.GetLength(1) - 1; startCol > 0; startCol--)
            {
                int count = 0;
                if (matrix[startRow, startCol] == searchedWord)
                {
                    int currentRow = startRow;
                    int currentCol = startCol;
                    while (currentRow < matrix.GetLength(0) && currentCol >= 0)
                    {
                        if (matrix[currentRow, currentCol] == searchedWord)
                        {
                            count++;
                            currentCol--;
                            currentRow++;
                            if (count > bestCount)
                            {
                                bestCount = count;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        return bestCount;
    }

    static int CountLongestSeqHorizontal(string[,] matrix, string searchedWord)
    {
        int bestCount = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int count = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == searchedWord)
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
        }

        return bestCount;
    }

    static int CountLongestSeqVertical(string[,] matrix, string searchedWord)
    {
        int bestCount = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] == searchedWord)
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
        }

        return bestCount;
    }
}