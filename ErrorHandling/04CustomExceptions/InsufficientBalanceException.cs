namespace _04CustomExceptions;

public class InsufficientBalanceException :  Exception
{
    public InsufficientBalanceException(){}
    public InsufficientBalanceException(string message) : base(message) {}

    public InsufficientBalanceException(string message, Exception? innerException) : base(message, innerException) {}

    public InsufficientBalanceException(decimal withdraw, decimal balance) : base(
        $"\nException: Withdraw value {withdraw} is greater than balance {balance}"){}
}