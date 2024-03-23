SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>()
{
    {50, "Brazil"},
    {30, "China"},
    {40, "USA"},
    {10, "France"},
    {20, "UK"},
};

Console.WriteLine("########## Displaying dictionary ##########");
foreach (var item in sortedDictionary)
{
    Console.WriteLine($"key: {item.Key}; value: {item.Value}");
}