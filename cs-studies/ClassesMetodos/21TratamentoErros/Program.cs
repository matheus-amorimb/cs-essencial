Console.WriteLine("Calculate the division of x by y");

Console.WriteLine("\nInsert the value of x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInsert the value of y");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch
{
    Console.WriteLine("\nCannot divide by 0");
}
finally
{
    Console.WriteLine("\n Processing is done");
}