// Random random = new Random();
// Console.WriteLine(random.Next());
// Console.WriteLine(random.Next(20));
// Console.WriteLine(random.Next(10, 20));
// Console.WriteLine(random.NextDouble());

// Byte[] randBytes = new byte[10];
// Random randNum = new Random();
// randNum.NextBytes(randBytes);
//
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(randBytes[i]);
// }

Random random = new Random();

int[] winningNumbers = new int[6];

for (int i = 0; i < 6; i++)
{
    int winningNumber;

    do
    {
        winningNumber = random.Next(1, 61);
    } while (winningNumbers.Contains(winningNumber));
    
    winningNumbers[i] = winningNumber;
}

Array.Sort(winningNumbers);

Console.WriteLine("Winning Numbers");
Console.WriteLine(string.Join(" ", winningNumbers));