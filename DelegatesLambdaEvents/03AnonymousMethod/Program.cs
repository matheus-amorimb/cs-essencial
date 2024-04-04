// Print print = delegate(int value)
// {
//     Console.WriteLine("Anonymous Method");
//     Console.WriteLine($"value: {value}");
// };
//
// print(1250);
//
//
// public delegate void Print(int value);

List<string> names = new List<string>();
names.Add("Matheus");
names.Add("Pedro");
names.Add("João");

string result = names.Find(delegate(string name)
{
    return name.Equals("Matheus");
});

Console.WriteLine($"{result}");