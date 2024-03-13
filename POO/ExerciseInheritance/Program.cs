InvestmentAccount investmentAccount = new InvestmentAccount("Matheus");

investmentAccount.Deposit(12500);

class Account
{
    public string Name;
    public Guid AccountId = new Guid();
    public Account(string name)
    {
        Name = name;
    }
    private double _balance = 0;
    private double _depositFee = 0;
    public virtual double DepositFee
    {
        get { return _depositFee; }
        set { _depositFee = value; }
    }
    
    private double _withdrawFee = 0;
    public virtual double WithdrawFee
    {
        get { return _withdrawFee; }
        set { _withdrawFee = value;  }
    }
    public double Balance
    {
        get { return _balance; }
    }
    
    public void DisplayBalance()
    {
        Console.WriteLine($"Your current balance: ${Balance}");
    }

    public void Deposit(double value)
    {
        this._balance += value * (1 + DepositFee);
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
            this._balance -= value * (1 + WithdrawFee);
            DisplayBalance();
        }
    }
    
}
class TransactionAccount : Account
{
    public TransactionAccount(string name) : base(name)
    {
    }
}

class SavingsAccount : Account
{
    private double _depositFee = 0.005;
    private double _withdrawFee = 0;
    public override double DepositFee
    {
        get { return _depositFee; }
        set { _depositFee = value; }
    }
    
    public override double WithdrawFee
    {
        get { return _withdrawFee; }
        set { _withdrawFee = value;  }
    }

    public SavingsAccount(string name) : base(name)
    {
    }
}

class InvestmentAccount : Account
{
    private double _depositFee = 0.009;
    private double _withdrawFee = 0.001;
    
    public override double DepositFee
    {
        get { return _depositFee; }
        set { _depositFee = value; }
    }
    
    public override double WithdrawFee
    {
        get { return _withdrawFee; }
        set { _withdrawFee = value;  }
    }

    public InvestmentAccount(string name) : base(name)
    {
    }
}

