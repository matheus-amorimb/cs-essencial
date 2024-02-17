var names = Array.Empty<string>();
var grades =Array.Empty<double>();

Console.WriteLine("Enter the names and grades:");
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Enter name and grade {i+1}");
    Array.Resize(ref names, names.Length + 1);
    names[i] = Console.ReadLine();
    
    string grade = Console.ReadLine();
    Array.Resize(ref grades, grades.Length + 1);
    grades[i] = Convert.ToDouble(grade);

}

Console.WriteLine("\nNames: ");
foreach (var name in names)
{
    Console.WriteLine($"name");
}

Console.WriteLine("\nGrades");
foreach (var grade in grades)
{
    Console.WriteLine(grade);
}

Console.WriteLine(names.Length);

Console.WriteLine("\nAverage of grades");
Console.WriteLine($"{grades.Average()}");
