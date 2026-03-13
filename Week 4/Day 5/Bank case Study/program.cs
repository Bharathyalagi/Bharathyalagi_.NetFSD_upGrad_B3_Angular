
using ConsoleApp8;

namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acc = new BankAccount("XXXXX54327", "Bharath", 5000);

            acc.Deposit(2300);              

            acc.Withdraw(100);             

            Console.WriteLine($"Current Balance: {acc.Balance}");
            Console.WriteLine($"Account Number: {acc.AccountNumber}");
            Console.WriteLine($"Current Balance: INR {acc.Balance}");
            

        }
    }
}
