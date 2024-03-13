Console.WriteLine("### Herança ###");

Employee employee = new Employee();
employee.Name = "Matheus";
employee.Email = "mabatista1@gmail.com";
employee.Company = "ihm stefanini";
employee.Wage = 4999.99;

Console.WriteLine("\nEmployee:");
employee.Identify();
Console.WriteLine(employee.Company);
Console.WriteLine(employee.Wage);

Student student = new Student();
student.Name = "Manu";
student.Email = "manu@gmail.com";
student.Class = "Philosophy";
student.Grade = 9.8;

Console.WriteLine("\nStudent:");
student.Identify();
Console.WriteLine(student.Class);
Console.WriteLine(student.Grade);

public class Person
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public void Identify()
    {
        Console.WriteLine($"{Name} - {Email}");
    }
}

public class Employee : Person
{
    public string Company { get; set; }
    public double Wage { get; set; }
}

public class Student : Person
{
    public string Class { get; set; }
    public double Grade { get; set; }
}