try
{
    string fileUrl = "https://macoratti.net/dados/poesia.txt";

    HttpClient client = new HttpClient();
    HttpResponseMessage response = await client.GetAsync(fileUrl);

    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("File access successful:\n\n");
        string content = await response.Content.ReadAsStringAsync();
        Console.WriteLine(content);
    }
    else
    {
        throw new HttpRequestException("Error: " + (int)response.StatusCode);
    }

}
catch (HttpRequestException e) when (e.Message.Contains("404"))
{
    Console.WriteLine("Page not found!");
}
catch (HttpRequestException e) when (e.Message.Contains("401"))
{
    Console.WriteLine("Unauthorized access!");
}
catch (HttpRequestException e) when (e.Message.Contains("400"))
{
    Console.WriteLine("Invalid request!");
}
catch (HttpRequestException e) when (e.Message.Contains("500"))
{
    Console.WriteLine("Internal server error!");
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}
finally
{
    Console.WriteLine("\nProcessing completed");
}