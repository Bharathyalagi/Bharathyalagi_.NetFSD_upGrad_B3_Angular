using System;
using System.Diagnostics;

public class OrderTracing
{
    public void RunProblem5()
    {
        Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
        Trace.AutoFlush = true;

        Trace.WriteLine("Order Validation Started");
        Trace.TraceInformation("Order Validated");

        Trace.WriteLine("Payment Processing Started");
        Trace.TraceInformation("Payment Successful");

        Trace.WriteLine("Inventory Update Started");
        Trace.TraceInformation("Inventory Updated");

        Trace.WriteLine("Invoice Generation Started");
        Trace.TraceInformation("Invoice Generated");

        Trace.WriteLine("Order Processing Completed");

        Console.WriteLine("Tracing Completed. Check log.txt file.");
    }
}