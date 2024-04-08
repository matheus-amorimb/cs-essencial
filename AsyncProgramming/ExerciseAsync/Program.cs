

static async Task DownloadFile()
{
    var secTime = 10;
    var miliTime = TimeSpan.FromSeconds(secTime);
    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(miliTime);
    
    var url = "";
    HttpClient httpClient = new HttpClient();

    try
    {
        var response = httpClient.GetAsync(url, cancellationTokenSource.Token);
        await response;
    }
    catch (OperationCanceledException e)
    {
        Console.WriteLine("OperationCanceledException");
        Console.WriteLine(e.Message);
    }
    catch (HttpRequestException e)
    {
        Console.WriteLine("HttpRequestException");
        Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine("GeneralException");
        Console.WriteLine(e.Message);
    }
} 