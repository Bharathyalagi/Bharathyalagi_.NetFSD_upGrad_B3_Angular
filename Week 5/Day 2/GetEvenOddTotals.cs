using System;
class Program
{
    static void Main()
    {
        Console.Write("Eneter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter elemnts: ");
        for (int i = 0; i<n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int[] result = GetEvenOddTotals(arr);
        Console.WriteLine("Even Count = " + result[0]);
        Console.WriteLine("Odd Count = " + result[1]);
        Console.WriteLine("Even Sum = " + result[2]);
        Console.WriteLine("Odd Sum = " + result[3]);
    }

    static int[] GetEvenOddTotals(int[] ar)
    {
        int evenCount = 0, oddCount = 0;
        int evenSum = 0, oddSum = 0;

        foreach (int num in ar)
        {
            if (num % 2 == 0)
            {
                evenCount++;
                evenSum += num;
            }
            else
            {
                oddCount++;
                oddSum += num;
            }
        }

        return new int[] { evenCount, oddCount, evenSum, oddSum };


    }
}