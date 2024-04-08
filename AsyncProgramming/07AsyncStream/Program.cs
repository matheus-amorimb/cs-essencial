await foreach (var month in GenerateMonths())
{
    Console.WriteLine(month);
} 

static async IAsyncEnumerable<string> GenerateMonths()
{
    yield return "january";
    yield return "february";
    await Task.Delay(2000);
    yield return "march";
    yield return "april";
    yield return "may";
}