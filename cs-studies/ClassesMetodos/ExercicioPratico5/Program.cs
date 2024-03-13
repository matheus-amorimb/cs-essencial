Car chevrolet = new Car("Sedan", "Chevrolet", "Onix", 2016, 100);

chevrolet.DisplayInfo(model: chevrolet.Model, automaker: chevrolet.Automaker, brand: chevrolet.Brand,
    power: chevrolet.Power);
chevrolet.DisplayInfo(model: chevrolet.Model, automaker: chevrolet.Automaker, brand: chevrolet.Brand, power: chevrolet.Power, year: chevrolet.Year);
public class Car
{
    public string Model;
    public string Automaker;
    public string Brand;
    public int Year;
    public int Power;

    public Car(string model, string automaker, string brand, int year, int power)
    {
        this.Model = model;
        this.Automaker = automaker;
        this.Brand = brand;
        this.Year = year;
        this.Power = power;
    }

    public void DisplayInfo(string model, string automaker, string brand, int power, int year = 2024)
    {
        Console.WriteLine(model);
        Console.WriteLine(automaker);
        Console.WriteLine(brand);
        Console.WriteLine(power);
        Console.WriteLine(year);
    }

}
