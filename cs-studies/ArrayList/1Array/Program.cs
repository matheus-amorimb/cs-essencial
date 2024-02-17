
int [] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var names = new string[5]{"Ana", "Maria", "Marta", "Paulo", "Carlos"};

names[0] = "Matheus";

Console.WriteLine("---------- for ----------");

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("---------- foreach ----------");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}