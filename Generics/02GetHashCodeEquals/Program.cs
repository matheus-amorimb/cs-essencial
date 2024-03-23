string a = "Matheus";
string b = "Matheus";

int x = 100;
int y = 100;

Person person1 = new Person(a, x);
Person person2 = new Person(b, y);

Console.WriteLine("##### Equals #####");
Console.WriteLine("Person1 and Person2 are equal?");
Console.WriteLine(person1.Equals(person2));

Console.WriteLine("\n##### GetHashCode #####");
Console.WriteLine($"Person1: {person1.GetHashCode()}");
Console.WriteLine($"Person2: {person2.GetHashCode()}");
public class Person(string name, int id)
{
    public string Name { get; set; } = name;
    public int Id { get; set; } = id;

    public override bool Equals(object? obj)
    {
        var person = (Person)obj;
        return (this.Name == person.Name && this.Id == person.Id);
    }
}