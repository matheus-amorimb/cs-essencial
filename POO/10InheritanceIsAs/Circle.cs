namespace _10InheritanceIsAs;

public class Circle : Shape
{
    
    public Circle() {}
    
    public Circle(int x, int y) : base(x, y){}

    public override void Draw()
    {
        Console.WriteLine($"Draw circle at position: ({Xpos}, {Ypos})");
    }

    public void PaintCircle()
    {
        Console.WriteLine("Paint circle");
    }
    
}