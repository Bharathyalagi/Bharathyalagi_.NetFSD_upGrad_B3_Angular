using System;

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string msg) : base(msg) { }
}

public class BankApp
{
    public void Run()
    {
        Console.Write("Enter Balance: ");
        double bal = double.Parse(Console.ReadLine());

        Console.Write("Enter Withdraw Amount: ");
        double amt = double.Parse(Console.ReadLine());

        try
        {
            if (amt > bal)
            {
                throw new InsufficientBalanceException("Withdrawal amount exceeds available balance");
            }

            bal -= amt;
            Console.WriteLine("Withdrawal successful. Remaining Balance: " + bal);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed");
        }
    }
}