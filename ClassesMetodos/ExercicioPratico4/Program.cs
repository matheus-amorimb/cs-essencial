Car chevrolet = new Car("Sedan", "Chevrolet", "Onix", 2016, 100);

var newPower = chevrolet.IncreasePowerSpeed(chevrolet.Power, out double speed);

Console.WriteLine("New power : " + newPower);
Console.WriteLine("New maximum speed : " + speed );
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

    public int IncreasePowerSpeed(int power, out double speed)
    {
        power += 7;
        speed = power * 1.75;
        return power;
    }

}