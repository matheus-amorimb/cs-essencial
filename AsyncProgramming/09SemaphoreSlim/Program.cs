SemaphoreSlim semaphoreSlim = new SemaphoreSlim(4);

for (int i = 0; i <= 6; i++)
{
    string threadName = "Thread" + i;
    int waiting = 2 + 2 * i;
    Thread thread = new Thread(() => AccessDataBase(semaphoreSlim, threadName, waiting));
    thread.Start();
}

static void AccessDataBase(SemaphoreSlim semaphoreSlim, 
    string name, int seconds)
{
    Console.WriteLine($"{name}: wait to access the database");
    semaphoreSlim.Wait();
    
    Console.WriteLine($"{name}: was authorized to access the database.");
    Thread.Sleep(TimeSpan.FromSeconds(seconds));
    
    Console.WriteLine($"{name}: has been completed.");
    semaphoreSlim.Release();
}