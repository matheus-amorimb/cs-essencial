
await ThrowExceptionAsync();

static async Task ThrowExceptionAsync()
{
    try
    {
        var firstTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new IndexOutOfRangeException("IndexOutOfRangeException");
        });
        await firstTask;
        Console.WriteLine("First task is done.");
    }
    catch (Exception e)
    {
        Console.WriteLine("Block catch executed");
        Console.WriteLine(e.Message);    
    }
}