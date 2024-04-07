﻿
using System.Diagnostics;

CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

var stopwatch = new Stopwatch();
stopwatch.Start();

try
{
    cancellationTokenSource.Cancel();
    var result = await LongDurationTask(100, 
        cancellationTokenSource.Token);

    Console.WriteLine(result);
}
catch (Exception e)
{
    Console.WriteLine("Task aborted");
    Console.WriteLine($"time expired after {stopwatch.Elapsed}");
}

static Task<int> LongDurationTask(int value,
    CancellationToken cancellationToken = default)
{
    Console.WriteLine("Long duration task executed.");

    Task<int> task = null;

    task = Task.Run(() =>
    {
        int result = 0;
        for (int i = 0; i < value; i++)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                throw new TaskCanceledException(task);
            }
            Thread.Sleep(50);
            result += i;
        }
        return result;
    });
    return task;
}