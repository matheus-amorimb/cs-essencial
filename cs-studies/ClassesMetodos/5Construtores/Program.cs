Console.WriteLine("## Construtores ## \n");


Aluno aluno1 = new Aluno("matheus", 25, "masculino", "aprovado");

System.Console.WriteLine(aluno1.nome);
System.Console.WriteLine(aluno1.idade);
System.Console.WriteLine(aluno1.sexo);
System.Console.WriteLine(aluno1.aprovado);


public class Aluno
{	
	public Aluno(string alunoNome, int alunoIdade, string alunoSexo, string alunoAprovado) //construtor
	{
		nome = alunoNome;
		idade = alunoIdade;
		sexo = alunoSexo;
		aprovado = alunoAprovado;

    }
	
	public string? nome;
	public int idade;
	public string? sexo;
	public string? aprovado;
} 
