using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Select Problem (1-5): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                var logger = new AsyncLogger();
                await logger.RunProblem1();
                break;

            case 2:
                var discount = new DiscountCalculator();
                discount.RunProblem2();
                break;

            case 3:
                var report = new ReportGenerator();
                report.RunProblem3();
                break;

            case 4:
                var order = new OrderProcessing();
                await order.RunProblem4();
                break;

            case 5:
                var trace = new OrderTracing();
                trace.RunProblem5();
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}