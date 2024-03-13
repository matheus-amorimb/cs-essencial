Student student = new Student();
student.Name = "Matheus";
student.Class = "Software Engineering";
Console.WriteLine(student.Greeting());
class Person
{
    public string? Name { get; set; }
    public string Greeting() => $"Hey, I'm {Name}";
}

class Student : Person
{
    public string? Class { get; set; }
    public new string Greeting() => $"Hey, I'm {Name} and I take {Class} classes";
}