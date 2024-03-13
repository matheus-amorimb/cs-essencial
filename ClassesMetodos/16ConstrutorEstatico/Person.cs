namespace _16ConstrutorEstatico;

public class Person
{
    public static int MinimumAge;

    public int Age;
    public string? Name;

    public Person(int age, string? name)
    {
        Console.WriteLine("Executando o construtor parametrizado");
        Age = age;
        Name = name;
    }

    public Person()
    {
    }

    static Person()
    {
        Console.WriteLine("Executando o construtor estático");
        Console.WriteLine("Inicializando o campo MinimumAge");
        MinimumAge = 18;
    }
}   
