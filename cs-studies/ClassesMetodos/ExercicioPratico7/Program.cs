Car chevrolet = new Car("Sedan", "Chevrolet", "Onix", 1998, 100);
Car honda = new Car("SUV", "Honda", "HRV", 2024, 100);

chevrolet.DisplayInfo();
Console.WriteLine();
honda.DisplayInfo();
public class Car
{
    public string Model;
    public string Automaker;
    public string Brand;
    private int _year;
    public int Year
    {
        get { return _year;}
        set
        {
            if (value < 2000)
                _year = 2000;
            else if (value > 2022)
                _year = 2022;
            else
                _year = value;
        }
    }
    public int Power;

    public Car(string model, string automaker, string brand, int year, int power)
    {
        this.Model = model;
        this.Automaker = automaker;
        this.Brand = brand;
        this.Year = year;
        this.Power = power;
    }

    public void DisplayInfo()
    {
        Console.WriteLine(this.Model);
        Console.WriteLine(this.Automaker);
        Console.WriteLine(this.Brand);
        Console.WriteLine(this.Power);
        Console.WriteLine(this.Year);
    }

}