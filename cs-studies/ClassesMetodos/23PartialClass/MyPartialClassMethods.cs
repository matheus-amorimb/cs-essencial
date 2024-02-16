namespace _23PartialClass;

public partial class MyPartialClass
{
    public TimeSpan CalculateAge(DateTime BirthDate)
    {
        return (DateTime.Now.Date - BirthDate);
    }

    public TimeSpan DifferenceBetweenDates(DateTime date1, DateTime date2)
    {
        var difference = date1.Subtract(date2);
        return difference;
    }
    
}