DerivedClass derivedClass = new DerivedClass();
derivedClass.CheckAcess();

derivedClass.privateVarProperty = 100;
Console.WriteLine($"\nPrivateVarProperty: {derivedClass.privateVarProperty}");
public class DerivedClass : BaseClass
{
    public void CheckAcess()
    {
        PublicMember();
        ProtectedMember();
        InternalMember();
        ProtectedInternalMember();
        // PrivateMember(); //Do not have acess
    }
}


public class BaseClass
{   
    //fields
    public int publicVar = 1;
    protected int protectedVar = 2;
    internal int internalVar = 3;
    private int privateVar = 4;
    
    //property
    public int privateVarProperty
    {
        get { return privateVar;}
        set { privateVar = value; }
    }

    public void PublicMember()
    {
        Console.WriteLine("BaseClass - Public Method");
    }
    protected void ProtectedMember()
    {
        Console.WriteLine("BaseClass - Protected Method");
    }
    internal void InternalMember()
    {
        Console.WriteLine("BaseClass - Internal Method");
    }
    protected internal void ProtectedInternalMember()
    {
        Console.WriteLine("BaseClass - Protected Internal Method");
    }

    private void PrivateMember()
    {
        Console.WriteLine("BaseClass - Private Method");
    }
    
}