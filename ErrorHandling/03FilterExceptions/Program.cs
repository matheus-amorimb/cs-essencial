try
{
    Console.WriteLine("Insert the dividend");
    int dividend = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInsert the denominator");
    int denominator = Convert.ToInt32(Console.ReadLine());

    double quotient = dividend / denominator;

    Console.WriteLine($"\nThe result of division {dividend}/{denominator} is: {quotient}");

}
catch (DivideByZeroException) when (DayOfWeek.Friday == DayOfWeek.Friday)
{
    Console.WriteLine("\nIt's not possible to divide a number by zero, but do not worry. " +
                      "It's friday, baby. Let's celebrate!!!");
}
catch (Exception e) when (e.Message.Contains("format"))
{
    Console.WriteLine("Filter with format exception:");
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}