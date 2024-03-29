using System.Reflection.Metadata;

namespace _04CustomExceptions;

public class Account(int number, string? owner, decimal balance)
{
    public int Number { get; set; } = number;
    public string? Owner { get; set; } = owner;
    public decimal Balance { get; set; } = balance;

    public decimal Deposit(decimal value)
    {
        Balance += value;
        Console.WriteLine($"Deposited: {value}");
        return Balance;
    }
    
    public decimal Withdraw(decimal value)
    {
        Console.WriteLine($"Withdrew: {value}");
        if (Balance < value)
        {
            throw new InsufficientBalanceException(value, Balance);
        }

        Balance -= value;
        return Balance;
    }

    public override string ToString()
    {
        return $"\n##################" +
               $"\nAccount: {Number} " +
               $"\nOwner: {Owner}" +
               $"\nBalance: {Balance}" +
               $"\n##################\n";
    }
}