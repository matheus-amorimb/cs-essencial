Order order = new Order();

//Subscribe subscribers
order.OnCreateOrder += Email.Send;
order.OnCreateOrder += Message.Send;

order.CreateOrder();

delegate void OrderEventHandler();

//Publisher
class Order
{
    public event EventHandler? OnCreateOrder;
    public void CreateOrder()
    {
        Console.WriteLine("============================");
        Console.WriteLine("Order created");
        Console.WriteLine("============================");
        if (OnCreateOrder != null)
        {
            Console.WriteLine("\n============================");
            Console.WriteLine("Event");
            Console.WriteLine("============================");
            OnCreateOrder(this, EventArgs.Empty);
        }
    }
    
}

//Subscribers
class Email
{
    public static void Send(object? sender, EventArgs eventArgs)
    {
        Console.WriteLine("Sending a email");
    }
}

class Message
{
    public static void Send(object? sender, EventArgs eventArgs)
    {
        Console.WriteLine("Sending a message");
    }
}