using System.Runtime.ConstrainedExecution;
class Program
{
    static void Main()
    {
        RunBankAccount();
    }
    static void RunBankAccount()
    {
        BankAccount account = new BankAccount();
        account.AccountNumber = 7771001;
        account.Deposit(5000);
        account.Withdraw(2000);
    }
    static void RunEmployeeSalary()
    {
        Employee manager = new Manager();
        manager.BaseSalary = 50000;

        Employee developer = new Developer();
        developer.BaseSalary = 50000;

        Console.WriteLine($"Manager Salary = {manager.CalculateSalary()}");
        Console.WriteLine($"Developer Salary = {developer.CalculateSalary()}");
    }
    static void RunShoppingCart()
    {
        Product product = new Electronics();
        product.Price = 20000;

        Console.WriteLine("Final Price = " + product.CalculateDiscount());
    }
}