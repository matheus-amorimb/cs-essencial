


class Client
{
    public string ClientName { get; set;}
    public Guid Guid { get;} = new Guid();
}

class Account
{
    private double _balance = 0;
    private double fees;
    public double Balance
    {
        get { return _balance}
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Your current balance: ${Balance}");
    }

    public void Deposit(double value)
    {
        this._balance += value * (1 + fees);
        DisplayBalance();
    }

    public void Withdraw(double value)
    {
        double balanceAfterWithdraw = _balance - value;
        if (balanceAfterWithdraw < 0)
        {
            Console.WriteLine("Transaction denied: Insufficient Balance");
        }
        else
        {
            this._balance -= value * (1 + fees);
            DisplayBalance();
        }
    }
    
}
class TransactionAccount
{
    
}

class SavingsAccount
{
    
}

class InvestmentAccount
{
    
}

