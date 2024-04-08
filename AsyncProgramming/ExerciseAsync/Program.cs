var url = "https://macoratti.net/dados/poesia.txt";
var pathToSave = "/home/matheus/matheus-dev/code/cs/cs-fundamentals/AsyncProgramming/ExerciseAsync/Download/file.txt";
await DownloadFileAsync(url, pathToSave);

static async Task DownloadFileAsync(string url, string pathToSave)
{
    var secTime = 1;
    var miliTime = TimeSpan.FromSeconds(secTime);
    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(miliTime);
    
    HttpClient httpClient = new HttpClient();

    try
    {
        HttpResponseMessage response = await httpClient.GetAsync(url, 
            cancellationTokenSource.Token);
        string content = await response.Content.ReadAsStringAsync();

        await using (StreamWriter streamWriter = new StreamWriter(pathToSave))
        {
            streamWriter.Write(content);
        }
        
        Console.WriteLine("Download completed successfully.");
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