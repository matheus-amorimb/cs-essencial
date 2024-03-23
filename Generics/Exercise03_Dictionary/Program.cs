Dictionary<int, Student> students = new Dictionary<int, Student>();

students.Add(0, new Student("Maria", 7));
students.Add(1, new Student("Eric", 8));
students.Add(2, new Student("Ana", 9));
students.Add(3, new Student("Alex", 6));
students.Add(4, new Student("Diná", 5));

PrintStudents("students and grades", students);

var mariaStudent = students.Where(item => item.Value.Name == "Maria").ToList();
var mariaKey = mariaStudent[0].Key;
students[mariaKey].Grade = 10;

PrintStudents("Maria grade modified", students);

var dinaStudent = students.Where(item => item.Value.Name == "Diná").ToList();
var dinaKey = dinaStudent[0].Key;
students.Remove(dinaKey);

PrintStudents("Dina removed", students);

students.Add(5, new Student("Vilma", 7));

PrintStudents("Vilma inserted", students);

var studentsOrderedByName = students.OrderBy(item => item.Value.Name).ToDictionary();

PrintStudents("Dictionary ordered by name", studentsOrderedByName);

students.Clear();

PrintStudents("Dictionary cleaned up", students);

static void PrintStudents(string message, Dictionary<int, Student> students)
{
    Console.WriteLine($"\n######## {message} ########");
    foreach (var student in students)
    {
        Console.WriteLine($"student: {student.Value.Name}; grade: {student.Value.Grade} ");
    }
    Console.WriteLine("#####################################\n");
}
public class Student(string name, int grade)
{
    public string? Name { get; set; } = name;
    public int Grade { get; set; } = grade;
    
}

