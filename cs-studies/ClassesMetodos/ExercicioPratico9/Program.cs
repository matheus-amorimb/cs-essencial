using ExercicioPratico9;

Console.WriteLine("White: 1");
Console.WriteLine("Red: 2");
Console.WriteLine("Black: 3");
Console.WriteLine("Gray: 4");
Console.WriteLine("Silver: 5");
Console.WriteLine("Blue: 6");

Console.WriteLine("Choose the car colour.");
int carColour = Convert.ToInt32(Console.ReadLine());

Car chevrolet = new Car("Sedan", "Chevrolet", "Onix", 2016, 100, carColour);

chevrolet.DisplayInfo();

public class Car
{
    public string Model;
    public string Automaker;
    public string Brand;
    public int Year;
    public int Power;
    public int Colour;

    public Car(string model, string automaker, string brand, int year, int power, int colour)
    {
        this.Model = model;
        this.Automaker = automaker;
        this.Brand = brand;
        this.Year = year;
        this.Power = power;
        this.Colour = colour;
    }

    public void DisplayInfo()
    {
        Console.WriteLine(this.Model);
        Console.WriteLine(this.Automaker);
        Console.WriteLine(this.Brand);
        Console.WriteLine(this.Year);
        Console.WriteLine(this.Power);
        Console.WriteLine((Colours)this.Colour);
    }

}

