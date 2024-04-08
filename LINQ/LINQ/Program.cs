IList<string> fruits = new List<string>(){"Banana", "Apple", "Orange", "Grape"};

var result = from f in fruits
    where f.Contains('e')
    select f;

Console.WriteLine(result);