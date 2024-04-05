
Order order = new Order();

//Subscribe subscribers
order.onCreateOrder += Email.Send;
order.onCreateOrder += Message.Send;

order.CreateOrder();

delegate void OrderEventHandler();

//Publisher
class Order
{
    public event OrderEventHandler? onCreateOrder;
    public void CreateOrder()
    {
        Console.WriteLine("============================");
        Console.WriteLine("Order created");
        Console.WriteLine("============================");
        if (onCreateOrder != null)
        {
            Console.WriteLine("\n============================");
            Console.WriteLine("Event");
            Console.WriteLine("============================");
            onCreateOrder();
        }
    }
    
}

//Subscribers
class Email
{
    public static void Send()
    {
        Console.WriteLine("Sending a email");
    }
}

class Message
{
    public static void Send()
    {
        Console.WriteLine("Sending a message");
    }
}