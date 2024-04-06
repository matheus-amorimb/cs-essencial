using System.Text.Json.Serialization;

namespace _02XmlSerialize;

public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    
    [JsonIgnore]
    public int Age { get; set; }
    
    public Student(){}

    public Student(int id, string name, string email, int age)
    {
        Id = id;
        Name = name;
        Email = email;
        Age = age;
    }
}