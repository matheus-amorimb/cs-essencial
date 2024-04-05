
using System.Xml.Serialization;
using _02XmlSerialize;

try
{
    Student student1 = new Student(id: 101, name: "Matheus", email: "mabatista@", age: 25);

    string filePath =
        "/home/matheus/matheus-dev/code/cs/cs-fundamentals/LINQ/02XmlSerialize/Serializados/StudentSerialized.xml";

    //Create a XmlSerializer for the type Student
    XmlSerializer serializer = new XmlSerializer(typeof(Student));

    using (StreamWriter writer = new StreamWriter(filePath))
    {
        serializer.Serialize(writer, student1);
    }

    Console.WriteLine("===============================");
    Console.WriteLine("Object serialized successfully");
    Console.WriteLine("===============================");
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