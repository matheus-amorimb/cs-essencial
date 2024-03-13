namespace ExerciseInheritance;

public class Account
{
    public string Name;
    public Guid AccountId = Guid.NewGuid();
    public Account(string name)
    {
        Name = name;
    }
    
    private double _balance = 0;

    protected virtual double DepositFee { get;} = 0;
    protected virtual double WithdrawFee { get;} = 0;
    
    public double Balance
    {
        get { return _balance; }
    }
    
    public void DisplayBalance()
    {
        Console.WriteLine($"Current balance: ${Balance}");
    }

    public void Deposit(double value)
    {
        this._balance += value + _balance * (DepositFee);
        Console.WriteLine("\n#########################################");
        Console.WriteLine("Transaction Completed Successfully");
        Console.WriteLine("Info:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Account Id: {AccountId}");
        DisplayBalance();
        Console.WriteLine($"Deposit Fee: {DepositFee}");
        Console.WriteLine("#########################################");
    }

    public void Withdraw(double value)
    {
        double balanceAfterWithdraw = _balance - value;
        if (balanceAfterWithdraw < 0)
        {
            Console.WriteLine("\n#########################################");
            Console.WriteLine("Transaction denied: Insufficient Balance");
            DisplayBalance();
            Console.WriteLine("#########################################");
        }
        else
        {
            this._balance -= value - _balance * (WithdrawFee);
            Console.WriteLine("\n#########################################");
            Console.WriteLine("Transaction Completed Successfully");
            Console.WriteLine("Info:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Account Id: {AccountId}");
            DisplayBalance();
            Console.WriteLine($"Withdraw Fee: {WithdrawFee}");
            Console.WriteLine("#########################################");
        }
    }    
}