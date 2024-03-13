

Client client1 = new Client("matheus", "mbatista@", 25);
Client client2 = new Client("lucas", "lucasbatista@", 15);

client1.DisplayInfo(client1.Name, client1.Email, client1.Age);
client2.DisplayInfo(client2.Name, client2.Email);
public struct Client
{
    public string Name;
    public string Email;
    private int _age;

    public int Age
    {
        get {return _age;}

        set { _age = value < 18 ? 18 : value; }
    }

    public Client(string name, string email, int age)
    {
        Name = name;
        Email = email;
        Age = age;
    }

    public void DisplayInfo(string name, string email, int age = 18)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Age: {age}");
    }
}