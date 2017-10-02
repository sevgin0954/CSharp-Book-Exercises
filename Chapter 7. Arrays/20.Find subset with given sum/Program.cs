using System;
using System.Linq;

class Program
{
    static int[] arr;
    static bool isFind = false;

    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int searchedSum = int.Parse(Console.ReadLine());
        int loopsCount = 2;
        while (loopsCount <= nums.Length)
        {
            arr = new int[loopsCount];
            FindSubsetSum(nums, searchedSum);
            if (isFind)
            {
                Print(arr);
                return;
            }
            loopsCount++;
        }
        Console.WriteLine("Not Found");
    }

    static void FindSubsetSum(int[] nums, int searchedSum, int start = 0, int currentLoop = 1)
    {
        if (currentLoop > arr.Length || isFind == true)
        {
            int sum = arr.Sum();
            if (sum == searchedSum)
            {
                isFind = true;
                return;
            }
            return;
        }

        for (int a = start; a < nums.Length; a++)
        {
            if (isFind)
            {
                return;
            }
            arr[currentLoop - 1] = nums[a];
            FindSubsetSum(nums, searchedSum, a + 1, currentLoop + 1);
        }

        return;
    }

    static void Print(int[] arr)
    {
        for (int a = 0; a < arr.Length; a++)
        {
            Console.Write(arr[a] + " ");
        }
    }
}