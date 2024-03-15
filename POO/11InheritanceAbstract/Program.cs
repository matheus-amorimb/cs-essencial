using _11InheritanceAbstract;

Square square = new Square();
square.Side = 16;

square.CalculateArea();
square.CalculatePerimeter();

Console.WriteLine("########### SQUARE ##############");
Console.WriteLine($"Side: {square.Side}");
Console.WriteLine($"Area: {square.Area}");
Console.WriteLine($"Perimiter: {square.Perimeter}");