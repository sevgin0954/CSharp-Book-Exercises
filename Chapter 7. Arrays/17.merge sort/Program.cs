using System;

class Program
{
    static void Main()
    {
        int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, -1 };
        MergeSort(arr, 0, arr.Length - 1);

        for (int a = 0; a < arr.Length; a++)
        {
            Console.Write(arr[a] + " ");
        }
    }

    static void MergeSort(int[] arr, int startIndex, int endIndex)
    {
        if (startIndex >= endIndex)
        {
            return;
        }
        int mid = startIndex + (endIndex - startIndex) / 2;
        MergeSort(arr, startIndex, mid);
        MergeSort(arr, mid + 1, endIndex);
        
        CompareAndSort(arr, startIndex, mid, endIndex);
    }

    static void CompareAndSort(int[] arr, int startIndex, int mid, int endIndex)
    {
        int[] sortedArr = new int[endIndex - startIndex + 1];
        int currentIndex = 0;
        int leftIndex = startIndex;
        int rightIndex = mid + 1;
        while (leftIndex <= mid && rightIndex <= endIndex)
        {
            if (arr[leftIndex] > arr[rightIndex])
            {
                sortedArr[currentIndex++] = arr[rightIndex++];
            }
            else
            {
                sortedArr[currentIndex++] = arr[leftIndex++];
            }
        }
        if (currentIndex != sortedArr.Length)
        {
            while (leftIndex <= mid)
            {
                sortedArr[currentIndex++] = arr[leftIndex++];
            }
            while (rightIndex <= endIndex)
            {
                sortedArr[currentIndex++] = arr[rightIndex++];
            }
        }

        currentIndex = 0;
        for (int a = startIndex; a <= endIndex; a++)
        {
            arr[a] = sortedArr[currentIndex++];
        }   
    }
}