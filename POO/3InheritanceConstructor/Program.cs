Student student1 = new Student("Manu");  
Student student2 = new Student("Matheus", 25);  
  
class Person  
{  
    public Person(string name)  
    {  
        Console.WriteLine("\n######################################################");  
        Console.WriteLine("Constructor Person Class with Parameter Name");  
        Console.WriteLine($"Person Name: {name}");  
    }  
    public Person(string name, int age)  
    {  
        Console.WriteLine("\n######################################################");  
        Console.WriteLine("Constructor Person Class with Parameter Name and Age");  
        Console.WriteLine($"Person Name: {name}");  
        Console.WriteLine($"Person Age: {age}");  
    }  
}  
  
class Student : Person  
{  
    public Student(string name) : base(name)  
    {  
        Console.WriteLine("Constructor Student Class with Name");  
        Console.WriteLine("######################################################");  
    }  

    public Student(string name, int age) : base(name, age)  
    {  
        Console.WriteLine("Constructor Student Class with Name and Age");  
        Console.WriteLine("######################################################");  
    }  
}