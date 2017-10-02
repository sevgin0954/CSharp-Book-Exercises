using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] isPrime = new bool[n];
        ChangeValue(isPrime, true);
        isPrime[0] = false;

        for (int a = 2; a <= n; a++)
        {
            if (isPrime[a - 1] == true)
            {
                for (int b = a + a; b <= n; b += a)
                {
                    isPrime[b - 1] = false;
                }
            }
        }

        bool isFisrt = true;
        for (int a = 0; a < isPrime.Length; a++)
        {
            if (isPrime[a])
            {
                if (!isFisrt)
                {
                    Console.Write(", ");
                }
                isFisrt = false;
                Console.Write(a + 1);
            }
        }
    }

    static void ChangeValue(bool[] arr, bool value)
    {
        for (int a = 0; a < arr.Length; a++)
        {
            arr[a] = value;
        }
    }
}