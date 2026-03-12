using System;

class CalculatorProblem
{
    public static void Run()
    {
        Calculator c = new Calculator();

        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int add = c.Add(a, b);
        int sub = c.Subtract(a, b);

        Console.WriteLine("Addition = " + add);
        Console.WriteLine("Subtraction = " + sub);
        Console.WriteLine();
    }
}

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}