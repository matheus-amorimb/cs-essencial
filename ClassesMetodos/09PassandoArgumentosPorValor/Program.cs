
int x = 20;

Console.WriteLine("Valor do argumento x antes de passar por valor " + x);

Calculo calc = new Calculo();
calc.Double(x);

Console.WriteLine("Valor do argumento x depois de passar por valor " + x);
public class Calculo
{
    public void Double(int y)
    {
        y *= 2;
        Console.WriteLine($"Valor do parâmetro y no método Dobrar {y}");
    }
}