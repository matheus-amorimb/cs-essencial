Email email = new Email();

email.Send(title: "Daily", recipient: "mabatista1@email.com");
public class Email
{
    public void Send(string recipient, string title, string subject = "Set new tasks")
    {
        Console.WriteLine($"{recipient}, {title}, {subject}");
    }
}