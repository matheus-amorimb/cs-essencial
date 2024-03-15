namespace _11InheritanceAbstract;

public abstract class Shape
{
    public string? Colour { get; set; }  
    public double? Area { get; set; }  
    public double? Perimeter { get; set; } 
    
    //abstract methods
    public abstract void CalculateArea();
    public abstract void CalculatePerimeter();
    
    //method
    public string Description()
    {
        return "Abstract Class Shape";
    }
}