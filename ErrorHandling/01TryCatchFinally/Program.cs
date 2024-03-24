try
{
    Console.WriteLine("Insert the dividend");
    int dividend = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInsert the denominator");
    int denominator = Convert.ToInt32(Console.ReadLine());

    double quotient = dividend / denominator;

    Console.WriteLine($"\nThe result of division {dividend}/{denominator} is: {quotient}");

}
catch (FormatException)
{
    Console.WriteLine("\nInsert a integer number");
}
catch (OverflowException)
{
    Console.WriteLine("\nInsert a number between 1 and 999999");
}
catch (DivideByZeroException)
{
    Console.WriteLine("\nIt isn't possible divide a number by zero");
}
catch (Exception e)
{
    Console.WriteLine($"\n{e.GetType()} informs: {e.Message}");
}