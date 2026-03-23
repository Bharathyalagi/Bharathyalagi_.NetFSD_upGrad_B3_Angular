using System;
using System.Threading.Tasks;

public class OrderProcessing
{
    public async Task VerifyPaymentAsync()
    {
        Console.WriteLine("Payment Verification Started");
        await Task.Delay(1000);
        Console.WriteLine("Payment Verified");
    }

    public async Task CheckInventoryAsync()
    {
        Console.WriteLine("Inventory Check Started");
        await Task.Delay(1000);
        Console.WriteLine("Inventory Available");
    }

    public async Task ConfirmOrderAsync()
    {
        Console.WriteLine("Order Confirmation Started");
        await Task.Delay(1000);
        Console.WriteLine("Order Confirmed");
    }

    public async Task RunProblem4()
    {
        await VerifyPaymentAsync();
        await CheckInventoryAsync();
        await ConfirmOrderAsync();

        Console.WriteLine("Order Processing Completed");
    }
}