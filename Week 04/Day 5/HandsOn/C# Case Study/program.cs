
using System;

namespace HRsystem

{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Bharath yalagi", 30000, 24);
            emp.ShowDetails();
            Console.WriteLine("----------------------");

            emp.GiveRaise(13);
            emp.ShowDetails();
            Console.WriteLine("----------------------");

            bool result = emp.DeductPenalty(500);
            Console.WriteLine($"penalty Applied: {result}");
            emp.ShowDetails();

        }
    }
}
