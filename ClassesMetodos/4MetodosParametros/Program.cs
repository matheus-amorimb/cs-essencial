using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("## Métodos - Parâmetros ## \n");

        Aluno aluno = new Aluno();

        Console.WriteLine("Nome: ");
        aluno.nome = Console.ReadLine();

        Console.WriteLine("Idade: ");
        aluno.idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sexo: ");
        aluno.sexo = Console.ReadLine();

        Console.WriteLine("Aprovado (S/N): ");
        aluno.aprovado = Console.ReadLine();

        Curso curso_matematica = new Curso();
        curso_matematica.Resultado(aluno);
    }
}

public class Aluno
{
    public string? nome;
    public int idade;
    public string? sexo;
    public string? aprovado;

}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        System.Console.WriteLine($"O aluno {aluno.nome}, sexo {aluno.sexo}, com {aluno.idade} anos");
        if(aluno.aprovado == "S")
            System.Console.WriteLine("foi aprovado");
        else
            System.Console.WriteLine("foi reprovado");
    }
}