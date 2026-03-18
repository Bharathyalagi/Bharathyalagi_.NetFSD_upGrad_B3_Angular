using System;

public class Calculator
{
    public void Run()
    {
        Console.Write("Enter Numerator: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Enter Denominator: ");
        int den = int.Parse(Console.ReadLine());

        try
        {
            int result = num / den;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Operation completed safely");
        }
    }
}