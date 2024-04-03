
using _01Delegates;

CalculatorDelegate calculatorDelegate = new CalculatorDelegate(Calculator.Add);
var result1 = calculatorDelegate.Invoke(20, 30);
Console.WriteLine($"Add = {result1}");

CalculatorDelegate calculatorDelegate2 = Calculator.Subtract;
var result2 = calculatorDelegate.Invoke(20, 30);
Console.WriteLine($"Subtract = {result2}");

CalculatorDelegate calculatorDelegate3 = (double a, double b) => Calculator.Multiply(a, b);
var result3 = calculatorDelegate.Invoke(20, 30);
Console.WriteLine($"Subtract = {result3}");

public delegate double CalculatorDelegate(double a, double b);