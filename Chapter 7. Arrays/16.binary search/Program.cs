using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int searchedNum = int.Parse(Console.ReadLine());
        Console.Write(BinarySearch(arr, searchedNum));
    }

    static int BinarySearch(int[] arr, int searchedNum)
    {
        int searchedNumIndex = -1;
        int startIndex = 0;
        int endIndex = arr.Length - 1;
        while (startIndex <= endIndex)
        {
            int mid = startIndex + (endIndex - startIndex) / 2;
            if (arr[mid] == searchedNum)
            {
                searchedNumIndex = mid;
                break;
            }
            if (arr[mid] > searchedNum)
            {
                endIndex = mid - 1;
            }
            else
            {
                startIndex = mid + 1;
            }
        }
        return searchedNumIndex;
    }
}