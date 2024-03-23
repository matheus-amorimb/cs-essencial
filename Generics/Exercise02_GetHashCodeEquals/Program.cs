var person1 = new Person("Matheus","999.999.999-99");
var person2 = new Person("Matheus","999.999.999-99");
var person3 = new Person("Matheus","888.888.888-88");

Console.WriteLine("##### Equals #####");
Console.Write($"Person1 and Person2 are equal? {person1.Equals(person2)}");
Console.Write($"\nPerson2 and Person3 are equal? {person2.Equals(person3)}");

Console.WriteLine("\n\n##### GetHashCode #####");
Console.WriteLine($"Person1: {person1.GetHashCode()}");
Console.WriteLine($"Person2: {person2.GetHashCode()}");
Console.WriteLine($"Person3 {person3.GetHashCode()}");

public class Person(string name, string cpf)
{
    public string Name { get; set; } = name;
    public string CPF { get; set; } = cpf;

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (obj is not Person)
        {
            return false;
        }
        
        var person = (Person)obj;
        return (this.Name == person.Name && this.CPF == person.CPF);
    }

    public override int GetHashCode()
    {
        return this.CPF.GetHashCode();
    }
}