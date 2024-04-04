int number = 10;

Predicate<int> delegateEven = x => x % 2 == 0;

if (delegateEven(number))
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}