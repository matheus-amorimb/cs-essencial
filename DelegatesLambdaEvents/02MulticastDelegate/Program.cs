
MyDelegate myDelegate = new MyDelegate(Method1);

myDelegate += Method2;
myDelegate += Method3;
myDelegate -= Method2;

myDelegate.Invoke("Multicast Delegate");

static void Method1(string message)
{
    Console.WriteLine($"Method1: {message}");
}

static void Method2(string message)
{
    Console.WriteLine($"Method2: {message}");
}

static void Method3(string message)
{
    Console.WriteLine($"Method3: {message}");
}

public delegate void MyDelegate(string message);