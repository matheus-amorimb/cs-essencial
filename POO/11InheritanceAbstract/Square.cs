namespace _11InheritanceAbstract;

public class Square : Shape
{
    public double Side { get; set; }
    
    public override void CalculateArea()
    {
        this.Area = Side * Side;
    }

    public override void CalculatePerimeter()
    {
        this.Perimeter = 4 * Side;
    }
}