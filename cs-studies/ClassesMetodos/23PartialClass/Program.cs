using _23PartialClass;

MyPartialClass myPartialClass = new MyPartialClass();

var age = myPartialClass.CalculateAge(new DateTime(1998, 6, 18));
Console.WriteLine($"{Math.Round(age.TotalDays/365)} anos");

