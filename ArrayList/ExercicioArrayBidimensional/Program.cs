string[,] students;
students = new string[2, 5];

for (int i = 0; i < students.GetLength(0); i++)
{
    for (int j = 0; j < students.GetLength(1); j++)
    {
        Console.Write($"Informe o valor da posição [{i}, {j}]: ");
        students[i, j] = Console.ReadLine();
    }
}

for (int i = 0; i < students.GetLength(0); i++)
{
    for (int j = 0; j < students.GetLength(1); j++)
    {
        Console.Write($"[{i}, {j}]: {students[i, j]}\t");
    }
}