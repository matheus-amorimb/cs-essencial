int number = 4;
int number2 = 8;
int number3 = 12;

Action<int, int, int> square = 
    (x, y, z) => 
        Console.WriteLine($"x²: {Math.Pow(x, 2)} \ny²: {Math.Pow(y, 2)}, \nz²: {Math.Pow(z, 2)}");

square(number, number2, number3);
