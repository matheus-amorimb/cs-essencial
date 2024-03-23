Dictionary<int, Student> students = new Dictionary<int, Student>();

students.Add(0, new Student("Maria", 7));
students.Add(1, new Student("Eric", 8));
students.Add(2, new Student("Ana", 9));
students.Add(3, new Student("Alex", 6));
students.Add(4, new Student("Diná", 5));

Console.WriteLine("######## Students and Grades ########");
foreach (var student in students)
{
    Console.WriteLine($"student: {student.Value.Name}; grade: {student.Value.Grade} ");
    
}



public class Student(string name, int grade)
{
    public string? Name { get; set; } = name;
    public int Grade { get; set; } = grade;
}