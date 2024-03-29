using _04CustomExceptions;

try
{
    Account account1 = new Account(1806, "Matheus", 1250);

    Console.WriteLine(account1.ToString());

    account1.Deposit(750);
    Console.WriteLine(account1.ToString());

    account1.Withdraw(450);
    Console.WriteLine(account1.ToString());

    account1.Withdraw(2500);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
    // Console.WriteLine(e.StackTrace);
}

