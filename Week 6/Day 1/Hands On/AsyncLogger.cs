using System;
using System.Threading.Tasks;

public class AsyncLogger
{
    public async Task WriteLogAsync(string message)
    {
        Console.WriteLine($"Start Writing Log: {message}");

        await Task.Delay(1000);

        Console.WriteLine($"Completed Writing Log: {message}");
    }

    public async Task RunProblem1()
    {
        var task1 = WriteLogAsync("User Logged In");
        var task2 = WriteLogAsync("Order Placed");
        var task3 = WriteLogAsync("Payment Done");

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("All logs written successfully");
    }
}