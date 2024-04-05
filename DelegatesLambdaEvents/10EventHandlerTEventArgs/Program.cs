Order order = new Order();

//Subscribe subscribers
order.OnCreateOrder += Email.Send;
order.OnCreateOrder += Message.Send;

order.CreateOrder("mabatista@", "(27)98888-8888");

class OrderEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Message { get; set; }
}

//Publisher
class Order
{
    public event EventHandler<OrderEventArgs> OnCreateOrder;
    public void CreateOrder(string email, string message)
    {
        Console.WriteLine("============================");
        Console.WriteLine("Order created");
        Console.WriteLine("============================");
        if (OnCreateOrder != null)
        {
            Console.WriteLine("\n============================");
            Console.WriteLine("Event");
            Console.WriteLine("============================");
            OnCreateOrder(this, new OrderEventArgs(){Email = email, Message = message});
        }
    }
}

//Subscribers
class Email
{
    public static void Send(object? sender, OrderEventArgs eventArgs)
    {
        Console.WriteLine($"Sending a email to {eventArgs.Email}");
    }
}

class Message
{
    public static void Send(object? sender, OrderEventArgs eventArgs)
    {
        Console.WriteLine($"Sending a message to {eventArgs.Message}");
    }
}



