namespace ExerciseInheritance;

class InvestmentAccount : Account
{
    private double _depositFee = 0.009;
    private double _withdrawFee = 0.001;
    
    protected override double DepositFee
    {
        get { return _depositFee; }
    }
    
    protected override double WithdrawFee
    {
        get { return _withdrawFee; }
     }

    public InvestmentAccount(string name) : base(name)
    {}
}