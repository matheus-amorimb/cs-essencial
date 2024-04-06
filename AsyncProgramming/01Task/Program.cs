Console.WriteLine("================================");
Console.WriteLine("Async Breakfast");
Console.WriteLine("================================");

await BreakfastAsync();

static async Task<int> BreakfastAsync()
{
    Console.WriteLine("\n>>Make coffee");
    Task<Coffee> taskCoffee = BrewCoffeeAsync();
    
    Console.WriteLine(">>Make bread");
    Task<Bread> taskBread = MakeBreadAsync();

    var coffee = await taskCoffee;
    var bread = await taskBread;
    
    ServeBreakfast(coffee, bread);

    return 1;
}

static void ServeBreakfast(Coffee coffee, Bread bread){
    Console.WriteLine("\n>>Serving breakfast");
    Thread.Sleep(2000);
    Console.WriteLine(">>Breakfast is ready");
}

static async Task<Coffee> BrewCoffeeAsync()
{
    Console.WriteLine("-Coffee 1");
    await Task.Delay(2000);
    Console.WriteLine("-Coffee 2");
    await Task.Delay(2000);
    Console.WriteLine("-Coffee 3");
    return new Coffee();
}

static async Task<Bread> MakeBreadAsync()
{
    Console.WriteLine("*Bread 1");
    await Task.Delay(2000);
    Console.WriteLine("*Bread 2");
    await Task.Delay(2000);
    Console.WriteLine("*Bread 3");
    return new Bread();
}

public class Coffee() { }
public class Bread() { }