class BaseClass
{
    protected virtual void Method1()
    {
        Console.WriteLine("BaseClass.Method1()");
    }
    
    protected virtual void Method2()
    {
        Console.WriteLine("BaseClass.Method2()");
    }
}

class Class1: BaseClass
{
    sealed protected override void Method1()
    {
        Console.WriteLine("Class1.Method1()");
    }
    
    protected override void Method2()
    {
        Console.WriteLine("Class1.Method2()");
    }
}

class Class2: Class1
{
    // protected override void Method1()
    // {
    //     Console.WriteLine("Class2.Method1()");
    // }
    
    protected override void Method2()
    {
        Console.WriteLine("Class2.Method2()");
    }
}