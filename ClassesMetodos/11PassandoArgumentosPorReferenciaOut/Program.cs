double radius = 10;

Circle circle = new Circle();
circle.CircumferenceSquare(radius, out double circumference, out double square);

Console.WriteLine($"Perimeter: {circumference}");
Console.WriteLine($"Square: {square}");
public class Circle
{
    public void CircumferenceSquare(double radius, out double circumference, out double square)
    {
        circumference = 2 * Math.PI * radius;
        square = Math.PI * Math.Pow(radius, 2);
    }
}