using System;

class Program
{
    static void Main()
    {
        RunStudent();
        //RunCalculator();
        //RunBank();

        Console.ReadLine();
    }

    static void RunStudent()
    {
        StudentApp app = new StudentApp();
        app.Run();
    }

    static void RunCalculator()
    {
        Calculator c = new Calculator();
        c.Run();
    }

    static void RunBank()
    {
        BankApp b = new BankApp();
        b.Run();
    }
}