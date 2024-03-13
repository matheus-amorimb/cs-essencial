namespace ExerciseInheritance;

class SavingsAccount : Account
{
    private double _depositFee = 0.005;
    private double _withdrawFee = 0;
    protected override double DepositFee
    {
        get { return _depositFee; }
    }
    
    protected override double WithdrawFee
    {
        get { return _withdrawFee; }
    }

    public SavingsAccount(string name) : base(name)
    { }
}