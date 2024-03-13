Car.SetVehicleTaxRate();
Console.WriteLine($"Vehicle Tax Rate: {Car.VehicleTaxRate}");

public class Car
{
    public static int VehicleTaxRate;

    public static void SetVehicleTaxRate()
    {
        VehicleTaxRate = 4;
    }
}