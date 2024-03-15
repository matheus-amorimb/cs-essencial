Shape circle = new Circle(); //upcasting
circle.Draw(); //do not have acess to PaintCircle

Circle circle2 = new Circle();
Shape shape = circle2; //implicity upcasting
Circle c = (Circle)shape; //explicity downcasting

c.Draw();
c.PaintCircle();

public class Shape
{
    protected int xpos, ypos;
    
    public Shape(){}

    public Shape(int x, int y)
    {
        xpos = x;
        ypos = y;
    }

    public virtual void Draw()
    {
        Console.WriteLine($"Draw shape at position: ({xpos}, {ypos})");
    }
    
}

public class Circle : Shape
{
    
    public Circle() {}
    
    public Circle(int x, int y) : base(x, y){}

    public override void Draw()
    {
        Console.WriteLine($"Draw circle at position: ({xpos}, {ypos})");
    }

    public void PaintCircle()
    {
        Console.WriteLine("Paint circle");
    }
    
}
