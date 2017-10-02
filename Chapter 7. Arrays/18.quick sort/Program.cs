using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] nums = { 9, 8, 7, 6, 4, 5, 4, 3, 2, 1, 0, -1, 100 };
        QuickSort(nums, 0, nums.Length - 1);
        Console.Write(string.Join(" ", nums));
    }

    static void QuickSort(int[] arr, int start, int end)
    {
        if (start >= end)
        {
            return;
        }
        int pivotIndex = start + (end - start) / 2;
        List<int> smallerThanPivot = new List<int>();
        List<int> bigerThanPivot = new List<int>();
        int startIndex = start;
        for (int a = 0; a < arr.Length; a++)
        {
            if (a != pivotIndex)
            {
                if (arr[a] < arr[pivotIndex])
                {
                    smallerThanPivot.Add(arr[a]);
                }
                else
                {
                    bigerThanPivot.Add(arr[a]);
                }
            }
        }
        smallerThanPivot.Add(arr[pivotIndex]);
        int[] tempArr = smallerThanPivot.Concat(bigerThanPivot).ToArray();
        for (int a = 0; a < arr.Length; a++)
        {
            arr[a] = tempArr[a];
        }

        QuickSort(arr, start, pivotIndex);
        QuickSort(arr, pivotIndex + 1, end);
    }
}