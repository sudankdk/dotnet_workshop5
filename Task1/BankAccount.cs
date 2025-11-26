using System.Reflection.Emit;

namespace Task1;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber, decimal balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                throw new ArgumentException("Balance must be positive.");
            }
        }
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");
        
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");

        if (amount > 0)
        {
             Balance -= amount;
        }
    }
}