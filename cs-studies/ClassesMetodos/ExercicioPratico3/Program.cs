Car chevrolet = new Car("Sedan", "Chevrolet", "Onix", 2016, 100);

Console.WriteLine($"Chevrolet Power: {chevrolet.Power}");

Console.WriteLine(chevrolet.IncreasePower(chevrolet.Power));
Console.WriteLine($"Chevrolet Power after power increase by value: {chevrolet.Power}");

Console.WriteLine(chevrolet.IncreasePower(ref chevrolet.Power));
Console.WriteLine($"Power chevrolet after power increase by refer: {chevrolet.Power}");

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

    public int IncreasePower(int power)
    {
        power += 3;
        return power;
    }

    public int IncreasePower(ref int power)
    {
        power += 5;
        return power;
    }
}