Semaphore semaphore = new Semaphore(3, 5);

for (int i = 0; i <10; i++)
{
    Thread thread = new Thread(() => ProcessOperation(semaphore));
    thread.Name = "Thread: " + i;
    thread.Start();
}

static void ProcessOperation(Semaphore semaphore)
{
    semaphore.WaitOne();
    Console.WriteLine($"Thread {Thread.CurrentThread.Name} entered the critical section");
    
    Thread.Sleep(6000);
    
    semaphore.Release();
    Console.WriteLine($"Thread {Thread.CurrentThread.Name} was released.");
}