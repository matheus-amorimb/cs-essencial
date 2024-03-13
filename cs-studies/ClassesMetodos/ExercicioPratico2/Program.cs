Car chevrolet = new Car("Sedan", "Chevrolet", "Onix", 2016, 110);
Car ford = new Car("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine($"The maximum speed of chevrolet model {chevrolet.Model} is {chevrolet.MaximumSpeed()}");
Console.WriteLine($"The maximum speed of ford model {ford.Model} is {ford.MaximumSpeed()}");

public class Car
{
    public string Model;
    public string Automaker;
    public string Brand;
    public int Year;
    public int Power;

    public Car(string model, string automaker)
    {
        Model = model;
        Automaker = automaker;
    }
    
    public Car(string model, string automaker, string brand, int ano, int power)
    {
        this.Model = model;
        this.Automaker = automaker;
        this.Brand = brand;
        this.Year = ano;
        this.Power = power;
    }

    public void SpeedUp()
    {
        Console.WriteLine($"Speeding up my {this.Brand}");
    }

    public double MaximumSpeed()
    {
        return this.Power * 1.75;
    }
}