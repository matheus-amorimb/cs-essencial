
using System.Text.Json;
using _02XmlSerialize;

Student student = new Student(10, "Lohana", "lohana@gmail.com", 30);

var filePath = "/home/matheus/matheus-dev/code/cs/cs-fundamentals/LINQ/04JsonSerialize/Serializados/StudentSerialized.json";

using (FileStream stream = new FileStream(
           filePath, 
           FileMode.OpenOrCreate, 
           FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, student);
    
    
}