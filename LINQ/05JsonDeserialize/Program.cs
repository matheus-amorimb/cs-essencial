

using System.Text.Json;
using _02XmlSerialize;

var filePath = "/home/matheus/matheus-dev/code/cs/cs-fundamentals/LINQ/04JsonSerialize/Serializados/StudentSerialized.json";

string jsonContent = File.ReadAllText(filePath);

var student = JsonSerializer.Deserialize<Student>(jsonContent);

string messageDefault = $"Deserialized JSON Student";
string message = $"Id: {student.Id}\n" +
                 $"Name: {student.Name}\n" +
                 $"Email: {student.Email}";
int length = messageDefault.Length;
string a = new string('=', length);
Console.WriteLine(a);
Console.WriteLine(messageDefault);
Console.WriteLine(a);
Console.WriteLine(message);
Console.WriteLine(a);
