Person p1 = new Person();

p1.Display();
public struct Person
{
    public string Name;
    public int Age { get; set;}

    public void Display()
    {
        Console.WriteLine("Struct");
    }
}