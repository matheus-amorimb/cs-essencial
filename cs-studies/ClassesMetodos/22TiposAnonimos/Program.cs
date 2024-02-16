var aluno = new
{
    Nome = "Maria",
    Idade = 42,
    Endereco = new {Id = 1, Cidade = "Santos", Pais = "Brasil"}
};
Console.WriteLine(aluno.Nome + " - " + aluno.Idade + "anos" + " - " + aluno.Endereco.Cidade);