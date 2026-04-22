using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        int n = int.Parse(Console.ReadLine());

        int even = 0;
        int odd = 0;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;

            if (i % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine("Even Count: " + even);
        Console.WriteLine("Odd Count: " + odd);
        Console.WriteLine("Sum: " + sum);
    }
}