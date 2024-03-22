namespace _13CompositionAggreggation;

internal class Department
{
    public string? Name { get; set; }
    private List<Teacher>? Teachers { get; set; }
    
    public Department(string? name)
    {
        Name = name;
        Teachers = new List<Teacher>();
    }

    public void AddTeacher(Teacher teacher)
    {
        Teachers?.Add(teacher);
    }

    public void DisplayTeachers()
    {
        Console.WriteLine($"\nDepartamento de {Name}");

        foreach (var teacher in Teachers)
        {
            Console.WriteLine($"{teacher.Name} -> {teacher.Subject}");
        }
    }
}