
Car chevrolet = new Car("Sedan", "Chevrolet", "Onix", 2016, 110);
Car ford = new Car("SUV", "Ford", "EcoSport", 2018, 120);

chevrolet.SpeedUp(chevrolet.Brand);
ford.SpeedUp(ford.Brand);

public class Car
{
    public string Model;
    public string Automaker;
    public string Brand;
    public int Year;
    public int Power;
    
    public Car(string model, string automaker, string brand, int ano, int power)
    {
        this.Model = model;
        this.Automaker = automaker;
        this.Brand = brand;
        this.Year = ano;
        this.Power = power;
    }

    public void SpeedUp(string brand)
    {
        Console.WriteLine($"Speeding up my {brand}");
    }
}