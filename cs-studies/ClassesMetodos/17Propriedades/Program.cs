Product p1 = new Product();

p1.Name = "CADERNO";
p1.Price = 4.29;
p1.MinimumStock = 100;

p1.Display();
public class Product
{
    private string _name;
    public string Name
    {
        get => _name.ToUpper();
        set => _name = value;
    }

    private double _price;
    public double Price
    {
        get => _price;
        set
        {
            if (value < 5.00)
                _price = 5.00;
            else
                _price = value;
        } 
        
    }

    private double _discount = 0.1;
    public double Discount => _discount;

    public double FinalPrice
    {
        get => (1 - Discount) * Price;
    }
    public int MinimumStock { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Name} \n" +
                          $"{Price.ToString("c")}\n" +
                          $"{Discount}\n" +
                          $"{FinalPrice.ToString("c")}\n" +
                          $"{MinimumStock}");
    }
    
    
}