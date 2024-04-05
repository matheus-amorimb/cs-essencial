
using System.Xml.Serialization;
using _02XmlSerialize;

try
{
    string filePath = 
        "/home/matheus/matheus-dev/code/cs/cs-fundamentals/LINQ/03XmlDeserialize/Serializados/StudentSerialized.xml";

    XmlSerializer serializer = new XmlSerializer(typeof(Student));

    using (StreamReader reader = new StreamReader(filePath))
    {
        Student student = (Student)serializer.Deserialize(reader);
        string messageDefault = $"Deserialized XML Student";
        string message = $"Id: {student.Id}\n" +
                         $"Name: {student.Name}\n" +
                         $"Email: {student.Email}\n" +
                         $"Age: {student.Age}";
        int length = messageDefault.Length;
        string a = new string('=', length);
        Console.WriteLine(a);
        Console.WriteLine(messageDefault);
        Console.WriteLine(a);
        Console.WriteLine(message);
        Console.WriteLine(a);
    }
}
catch(Exception e)
{
    string message = $"Exception: {e.Message}";
    int length = message.Length;
    string a = new string('=', length);
    
    Console.WriteLine(a);
    Console.WriteLine(message);
    Console.WriteLine(a);
}