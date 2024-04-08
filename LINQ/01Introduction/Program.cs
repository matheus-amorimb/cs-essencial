IList<string> fruits = new List<string>(){"Banana", "Apple", "Orange", "Grape"};

//QUERY SYNTAX
var result = from f in fruits
    where f.Contains('e')
    select f;

var result2 = fruits.Where(fruit => fruit.Contains('e'));

Console.WriteLine("QUERY SYNTAX");
foreach (var fruit in result)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("\nMETHOD SYNTAX");
foreach (var fruit in result2)
{
    Console.WriteLine(fruit);
}