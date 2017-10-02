using System;
using System.Linq;

class Program
{
    static int[] arr;
    static bool isFind = false;

    static void Main()
    {
        int[] nums = { 3, 1, 2, 4, 9, 6 };
        Console.Write("searched sum = ");
        int searchedSum = int.Parse(Console.ReadLine());
        Console.Write("loops count = ");
        int loopsCount = int.Parse(Console.ReadLine());
        arr = new int[loopsCount];
        FindSubsetSum(nums, searchedSum, loopsCount);
        if (isFind)
        {
            Print(arr);
        }
        else
        {
            Console.WriteLine("Not Found");
        }
    }

    static void FindSubsetSum(int[] nums, int searchedSum, int loopsCount, int start = 0, int currentLoop = 0)
    {
        if (currentLoop == loopsCount || isFind)
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
            arr[currentLoop] = nums[a];
            FindSubsetSum(nums, searchedSum, loopsCount, a + 1, currentLoop + 1);
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