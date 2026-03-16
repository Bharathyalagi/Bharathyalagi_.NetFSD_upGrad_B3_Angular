using System;
class BankAccount
{
    private int accountNumber;
    private double balance;
    public int AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public double Balance
    {
        get { return balance; }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Initial Balance = {balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount");
        }
    }
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Current Balance = " + balance);
        }
    }
}