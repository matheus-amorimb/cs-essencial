try
{
    A.ProcessA();
}
catch (Exception e)
{
    Console.WriteLine("Handling the error in main");
    Console.WriteLine($"Exception message: {e.Message}");
}
class A
{
    public static void ProcessA()
    {
        try
        {
            B.ProcessB();
        }
        catch (Exception e)
        {
            throw;
            // Console.WriteLine("Handling the error in A");
        }
    }
}

class B
{
    public static void ProcessB()
    {
        try
        {
            C.ProcessC();
        }
        catch (Exception)
        {
            throw;
        }
    }
}

class C
{
    public static void ProcessC()
    {
        throw new NotImplementedException("Method not implemented");
    }
}