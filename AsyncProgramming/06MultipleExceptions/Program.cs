await ThrowMultipleExceptionsAsync();

static async Task ThrowMultipleExceptionsAsync()
{
    Task? tasks = null;
    try
    {
        var firstTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new IndexOutOfRangeException("firstTask: IndexOutOfRangeException");
        });
        var secondTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new IndexOutOfRangeException("secondTask: IndexOutOfRangeException");
        });

        tasks = Task.WhenAll(firstTask, secondTask);
        await tasks;
    }
    catch
    {
        Console.WriteLine("The following exceptions were raised:");
        AggregateException allExceptions = tasks.Exception;
        foreach (var e in allExceptions.InnerExceptions)
        {
            // Console.WriteLine(e.GetType().ToString());
            Console.WriteLine(e.Message);
        }
    }
}