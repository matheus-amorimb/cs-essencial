Developer juniorDeveloper = new Developer();

juniorDeveloper.Name = "Matheus";
juniorDeveloper.Class = "Electrical Engineering";
juniorDeveloper.ProgrammingLanguage = "C#, Python, Angular";

juniorDeveloper.DisplayInfo();
class Person
{
    public string Name;
}
class Student : Person
{
    public string Class;
}

class Developer : Student
{
    public string? ProgrammingLanguage;

    public void DisplayInfo()
    {
        Console.WriteLine("################## Information ##################");
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Class: {this.Class}");
        Console.WriteLine($"Programming Language: {this.ProgrammingLanguage}");
    }
}
