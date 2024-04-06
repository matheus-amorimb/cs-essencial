await MethodWithoutReturnAsync();
var result = await MethodReturnValueAsync(100);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Result: {result}");

static async ValueTask MethodWithoutReturnAsync()
{
    Console.WriteLine("Method does not return any value.");
    await Task.Delay(2000);
}

static async ValueTask<int> MethodReturnValueAsync(int value)
{
    Console.WriteLine("Method returns any value.");
    await Task.Delay(2000);
    return value * 2;
}