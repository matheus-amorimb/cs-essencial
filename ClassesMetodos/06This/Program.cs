Console.WriteLine("This");

//Primeiro uso: diferenciar entre parâmetros dos métodos e campos
// public class Cliente
// {
//     public string? nome;
//     public int idade;
//
//     public Cliente(string? nome, int idade)
//     {
//         this.nome = nome;
//         this.idade = idade;
//     }
// }

//Segundo uso: Passar um objeto da instância atual como parâmetro para outros métodos
// Teste t1 = new Teste();
//
// t1.Num1 = 10;
// t1.Num2 = 20;
// t1.Exibir();
// public class Teste
// {
//     public int Num1;
//     public int Num2;
//
//     public void PassarParametro(Teste t)
//     {
//         Console.WriteLine($"¨\nthis = {this}");
//         Console.WriteLine("Num1: " + t.Num1);
//         Console.WriteLine("Num2: " + t.Num2);
//     }
//
//     public void Exibir()
//     {
//         PassarParametro(this);
//     }
// }

//Terceito uso: Invocar outro construtor da mesma classe

Teste teste1 = new Teste(650);

public class Teste
{
    public Teste (int num1, int num2, int num3): this (1050, 1150)
    {
        Console.WriteLine($"\n Construtor com três parâmetros {num1} e {num2} e {num3}");
    }

    public Teste(int num4, int num5)
    {
        Console.WriteLine($"\n Construtor com dois parâmetros {num4} e {num5}");
    }

    public Teste(int num) : this(750, 850, 950)
    {
        Console.WriteLine("\n Construtor com um parâmetro " + num);
    }
}