using System.Collections.ObjectModel;

var planets = new List<string>(){"Earth", "Mars", "Mercury", "Jupiter"};

ReadOnlyCollection<string> planetsList = new ReadOnlyCollection<string>(planets);
var newPlanetsList = planets.AsReadOnly();

foreach (var planet in planetsList)
{
    Console.Write($"{planet}; ");
}

Console.WriteLine($"\n\nNumber os planets in the collection: {planetsList.Count}");
Console.WriteLine($"\nFirst planet in the collection: {planetsList[0]}");
Console.Write($"\nIs Jupiter in the collection? ");
Console.WriteLine(planetsList.Contains("Jupiter") ? "Yes" : "No");
Console.WriteLine($"\nIndex of planet Earth: {planetsList.IndexOf("Earth")}");
Console.WriteLine($"\nCopying the elements from collection to unidimensional array");
string[] planetsArray = new string[planetsList.Count + 2];
planetsList.CopyTo(planetsArray, 1);
foreach (var planet in planetsArray)
{
    Console.WriteLine($"\"{planet}\"");
}