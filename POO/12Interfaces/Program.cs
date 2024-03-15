using _12Interfaces;

public class Demo : IController, IGraph
{
    public string Name { get; set; }

    public void Draw()
    {
        Console.WriteLine("Drawing...");
    }

    public void Paint()
    {
        Console.WriteLine("Painting...");
    }
}