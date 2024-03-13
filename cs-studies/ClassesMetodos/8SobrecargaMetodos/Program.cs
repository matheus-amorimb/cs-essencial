
Email email = new Email();

email.Send("mbatista1@");
Console.WriteLine("-----");
email.Send("mbatista1@", "buying a new office chair");
Console.WriteLine("-----");
email.Send("mbatista1@", 10000);
Console.WriteLine("-----");
email.Send(10000, "mbatista1@");

public class Email
{
    public void Send(string address)
    {
        Console.WriteLine($"{address}");
        Console.WriteLine("Default Subject");
    }

    public void Send(string address, string subject)
    {
        Console.WriteLine($"{address}");
        Console.WriteLine($"{subject}");
    }    
    
    public void Send(string address, decimal value)
    {
        Console.WriteLine($"{address}");
        Console.WriteLine("Commercial Proposal");
        Console.WriteLine($"{value}");
    }    
    
    public void Send(decimal value, string address)
    {
        Console.WriteLine($"{address}");
        Console.WriteLine("Supplier Payment");
        Console.WriteLine($"{value}");
    }
}