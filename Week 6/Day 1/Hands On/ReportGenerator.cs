using System;
using System.Threading;
using System.Threading.Tasks;

public class ReportGenerator
{
    public void GenerateSalesReport()
    {
        Console.WriteLine("Sales Report Started");
        Thread.Sleep(2000);
        Console.WriteLine("Sales Report Completed");
    }

    public void GenerateInventoryReport()
    {
        Console.WriteLine("Inventory Report Started");
        Thread.Sleep(3000);
        Console.WriteLine("Inventory Report Completed");
    }

    public void GenerateCustomerReport()
    {
        Console.WriteLine("Customer Report Started");
        Thread.Sleep(1500);
        Console.WriteLine("Customer Report Completed");
    }

    public void RunProblem3()
    {
        Task t1 = Task.Run(() => GenerateSalesReport());
        Task t2 = Task.Run(() => GenerateInventoryReport());
        Task t3 = Task.Run(() => GenerateCustomerReport());

        Task.WaitAll(t1, t2, t3);

        Console.WriteLine("All Reports Generated");
    }
}