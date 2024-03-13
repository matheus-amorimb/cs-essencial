

Calculator calculator = new Calculator();

Console.WriteLine("Basic operations with 10 and 20");
Console.WriteLine($"Addition: {calculator.Addition(10, 20)}");
Console.WriteLine($"Subtraction: {calculator.Subtraction(10, 20)}");
Console.WriteLine($"Multiplication: {calculator.Multiplication(10, 20)}");
Console.WriteLine($"Division: {calculator.Division(10, 20)}");

public class Calculator
{

    public float Addition(int num1, int num2)
    {
        return num1 + num2;
    }
    
    public float Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }    
        
    public float Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }    
    
    public float Division(int num1, int num2)
    {
        return (float) num1 / num2;
    }    
    
}