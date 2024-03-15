namespace _10InheritanceIsAs;

public class Shape
{
    protected int Xpos, Ypos;
    
    public Shape(){}

    public Shape(int x, int y)
    {
        Xpos = x;
        Ypos = y;
    }

    public virtual void Draw()
    {
        Console.WriteLine($"Draw shape at position: ({Xpos}, {Ypos})");
    }
    
}