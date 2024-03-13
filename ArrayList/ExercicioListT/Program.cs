var students = new List<Student>()
{
    new Student {Name = "Maria", Grade = 8.75},
    new Student {Name = "Manoel", Grade = 6.95},
    new Student {Name = "Amanda", Grade = 7.25},
    new Student {Name = "Carlos", Grade = 6.55},
    new Student {Name = "Jaime", Grade = 8.50},
    new Student {Name = "Debora", Grade = 5.95},
    new Student {Name = "Alicia", Grade = 9.25},
    new Student {Name = "Sandra", Grade = 5.55},
    new Student {Name = "Marta", Grade = 7.85},
    new Student {Name = "Sueli", Grade = 9.15},
    
};

Console.WriteLine("\n####INSERTING NEW STUDENTS");
students.Add(new Student(){Name = "Bia", Grade = 7.75});
students.Add(new Student(){Name = "Mario", Grade = 8.95});
Student.displayInfo(students);

Console.WriteLine("\n####REMOVING STUDENT AMANDA");
students.RemoveAll(student => student.Name == "Amanda");
Student.displayInfo(students);

Console.WriteLine("\n####ORDERING STUDENTS LIST BY NAME");
var listOrderedByName = students.OrderBy(student => student.Name).ToList();
Student.displayInfo(listOrderedByName);

Console.WriteLine("\n####STUDENTS GRADE HIGHER OR EQUAL THAN 8");
var listHighGrades = students.Where(student => student.Grade >= 8.00 ).ToList();
Student.displayInfo(listHighGrades);
public class Student
{
    public string? Name { get; set; }
    public double Grade { get; set; }

    public static void displayInfo(List<Student> students)
    {
        Console.WriteLine("\n### List of Students");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name}: {student.Grade}");
        }

        Console.WriteLine("\n### Grade Average");
        double averageGrade = students.Average(student => student.Grade);
        Console.WriteLine(averageGrade);
        
        Console.WriteLine("\n### Number of Students");
        var numberStudents = students.Count;
        Console.WriteLine(numberStudents);
        
    }
    
}