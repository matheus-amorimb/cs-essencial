Dictionary<string, int> dictionary = new Dictionary<string, int>();

dictionary.Add("Matheus", 25);
dictionary.Add("Lohana", 29);
dictionary.Add("Luan", 27);

Console.WriteLine("#### Dictionary ####");
foreach (var item in dictionary)
{
    Console.WriteLine($"key: {item.Key}; value: {item.Value}");
}

string message = dictionary.TryGetValue("Arthur", out int arthurAge) ? 
   $"Arthur's age is {arthurAge} years old." : 
   $"Arthur's age not found in the dictionary.";

Console.WriteLine("\n##### Searching for a key in the dictionary #####");
Console.WriteLine(message);

Console.WriteLine("\n#### Dictionary Ordered####");
var orderedDict = dictionary.OrderBy(item => item.Key);
foreach (var item in orderedDict)
{
    Console.WriteLine($"key: {item.Key}; value: {item.Value}");
}