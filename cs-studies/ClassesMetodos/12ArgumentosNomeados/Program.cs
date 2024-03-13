Email email = new Email();

email.Send(title: "Daily", recipient:"mabatista1@email.com", subject:"Set the tasks for the nwe project");

public class Email
{
    public void Send(string recipient, string title, string subject)
    {
        Console.WriteLine($"{recipient}, {title}, {subject}");
    }
}