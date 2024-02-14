Console.WriteLine(Calculator.Addition(10, 20));
Console.WriteLine(Calculator.Subtraction(10, 20));
Console.WriteLine(Calculator.Multiplication(10, 20));
Console.WriteLine(Calculator.Division(10, 20));
public class Calculator
{
    public static float Addition(int num1, int num2)
    {
        return num1 + num2;
    }
    
    public static float Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }    
        
    public static float Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }    
    
    public static float Division(int num1, int num2)
    {
        return (float) num1 / num2;
    }    
    
}