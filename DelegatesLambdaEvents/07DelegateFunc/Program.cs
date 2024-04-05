
//
// static double SquareRoot(int number)
// {
//     return Math.Sqrt(number);
// }

int number = 8;

Func<int, double> squareRoot = x => Math.Sqrt(x);

Console.WriteLine(squareRoot(number));
