using ExerciseDelegates;

List<Person> persons = new List<Person>()
{
    new Person("Alice", 12),
    new Person("Bob", 17),
    new Person("Charlie", 40),
    new Person("Frank", 42),
    new Person("Grace", 33)
};
Console.WriteLine("==================================================");
Console.WriteLine("All Persons");
Console.WriteLine("==================================================");
Action<Person> printPersons =  x => Console.WriteLine($"Name: {x.Name}, Age: {x.Age}");

foreach (Person person in persons)
{
    printPersons(person);
}

Console.WriteLine("\n==================================================");
Console.WriteLine("Persons over 18");
Console.WriteLine("==================================================");

Predicate <Person> overEighteen = person => person.Age >= 18;
List<Person> personsOverEighteen = persons.FindAll(person => overEighteen(person));

foreach (Person person in personsOverEighteen)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}
