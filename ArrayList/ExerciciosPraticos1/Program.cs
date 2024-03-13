//Exercise 1
string[] fruits = new string[]
{
    "Apple", "Banana", "Orange", "Grape", "Mango", "Pear", "Papaya", "Blackberries"
};

Console.WriteLine("\n### Fruits");
foreach (var fruit in fruits)
{
    Console.Write($"{fruit} ");
}

Console.WriteLine($"\n\n### The collection fruits contains: {fruits.Length} fruits");

int lastButOne = fruits.Length - 2;
Console.WriteLine("\n### 2nd and last but one fruit");
Console.WriteLine($"{fruits[1]}, {fruits[lastButOne]}");

fruits[1] = "Kiwi";
fruits[fruits.Length - 1] = "Persimmon";
Console.WriteLine("\n### 2nd and last but one fruit modified");
Console.WriteLine($"{fruits[1]}, {fruits[fruits.Length - 1]}");

Console.WriteLine("\n### Collection fruits ordered ASC by name");
Array.Sort(fruits);
foreach (var fruit in fruits)
{
    Console.Write($"{fruit} ");
}

Console.WriteLine("\n\n### Collection fruits ordered DESC by name");
Array.Reverse(fruits);
foreach (var fruit in fruits)
{
    Console.Write($"{fruit} ");
}