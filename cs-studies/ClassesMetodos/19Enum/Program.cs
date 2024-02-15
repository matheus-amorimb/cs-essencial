using _19Enum;

Console.WriteLine((DaysOfWeek.Monday));
Console.WriteLine((DaysOfWeek.Sunday));

int day1 = (int) DaysOfWeek.Monday;
int day7 = (int) DaysOfWeek.Sunday;
    
Console.WriteLine($"Monday: {day1}");
Console.WriteLine($"Sunday: {day7}");

Console.WriteLine("----------");

Console.WriteLine($"Accessing first item of Categories: {(Categories)0}");
Console.WriteLine($"Accessing last item of Categories: {(Categories)5}");
