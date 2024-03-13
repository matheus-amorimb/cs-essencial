Console.WriteLine("\n### Localizando elemento no array ###");

Console.WriteLine("\n### Insira o número de valores que a array deve possuir: ");
int length = Convert.ToInt32(Console.ReadLine());

int [] numbers = new int[length];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"numbers[{i}] = ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

string input;
do
{ 
    Console.WriteLine("\n### Insira o número que deseja localizar na array (Digite fim para encerrar): ");
    input = Console.ReadLine();

    if (input.ToLower() != "fim")
    {
        bool contains = numbers.Contains(Convert.ToInt32(input));

        if (contains)
        {
            Console.WriteLine($"\nO número {input} existe no array");
        }
        else
        {
            Console.WriteLine($"\nO número {input} não existe no array");
        }
        
    }
    
}
while(input.ToLower() != "fim");