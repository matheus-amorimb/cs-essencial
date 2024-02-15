BankAccount c1 = new BankAccount(1015, "Matheus");
BankAccount c2 = new BankAccount(1020, "Beatriz");

Console.WriteLine($"{BankAccount.Interest}");

public class BankAccount
{
    public int Account;
    public string? Name;
    public static float Interest = 15;

    public BankAccount(int account, string name)
    {
        Account = account;
        Name = name;
    }
    
    public float AnnualInterest()
    {
        return Interest * 12;
    }
    
}

