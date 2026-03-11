using System;

class Problem3
{
    static void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter Experience: ");
        int exp = int.Parse(Console.ReadLine());

        if (salary < 0 || exp < 0)
        {
            Console.WriteLine("Error: salary and exp can't be negative.");
        }
        else
        {
            double rate;

            if (exp < 2)
                rate = 0.05;
            else if (exp <= 5)
                rate = 0.10;
            else
                rate = 0.15;

            double bonus = salary * rate;
            double finalSalary = salary + bonus;

            Console.WriteLine("Employee: " + name);
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Final Salary: " + finalSalary);
        }
        
    }
}