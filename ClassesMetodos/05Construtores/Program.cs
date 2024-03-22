Console.WriteLine("## Construtores ## \n");


//Aluno aluno1 = new Aluno("matheus", 25, "masculino", "aprovado"); 
//Aluno2 aluno1 = new Aluno2("matheus");
Aluno3 aluno1 = new Aluno3("matheus", 25, "masculino", "aprovado"); 

System.Console.WriteLine(aluno1.nome);
System.Console.WriteLine(aluno1.idade);
System.Console.WriteLine(aluno1.sexo);
System.Console.WriteLine(aluno1.aprovado);


//Construtor
public class Aluno
{	
	public Aluno(string alunoNome)
	{
		nome = alunoNome;
	}
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

//Mais de um construtor
public class Aluno2
{	
	public Aluno2(string alunoNome) => nome = alunoNome;
 
	public Aluno2(string alunoNome, int alunoIdade, string alunoSexo, string alunoAprovado)
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

//Chamando outro construtor
public class Aluno3
{	
	public Aluno3(string alunoNome) => nome = alunoNome;
 
	public Aluno3(string alunoNome, int alunoIdade, string alunoSexo, string alunoAprovado): this(alunoNome)
	{
		idade = alunoIdade;
		sexo = alunoSexo;
		aprovado = alunoAprovado;
    }

	public string? nome;
	public int idade;
	public string? sexo;
	public string? aprovado;
} 
