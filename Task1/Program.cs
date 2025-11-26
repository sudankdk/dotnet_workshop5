namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        BankAccount bankAccount = new("abc1234",200);
        Console.WriteLine(bankAccount.AccountNumber);
        Console.WriteLine(bankAccount.Balance);
        bankAccount.Deposit(500);
        Console.WriteLine(bankAccount.Balance);
        bankAccount.Withdraw(500);
        Console.WriteLine(bankAccount.Balance);

    }
}