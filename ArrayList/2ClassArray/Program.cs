var names = new string[5]{"Ana", "Maria", "Marta", "Paulo", "Carlos"};

Console.WriteLine("Displaying original array");
DisplayArray(names);

Console.WriteLine("\n \nReversing the array");
Array.Reverse(names);
DisplayArray(names);

Console.WriteLine("\n \nOrdering the array");
Array.Sort(names);
DisplayArray(names);

Console.WriteLine("\n \nLooking up for a item in the array");
var index = Array.BinarySearch(names, "Maria");
Console.WriteLine(index);

static void DisplayArray(string[] names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}
